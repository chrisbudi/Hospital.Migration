using Microsoft.EntityFrameworkCore;

namespace Wincare.Core.DatabaseConfig
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public List<SequenceInfo> GetAllSequences()
        {
            return this.Sequences.FromSqlRaw(@"
                select *
                from ( select n.nspname as sequence_schema, 
                        c.relname as sequence_name
                    from pg_class c 
                    join pg_namespace n on n.oid = c.relnamespace
                    join pg_user u on u.usesysid = c.relowner
                    where c.relkind = 'S'
                ) tb 
            ").ToList();
        }

        public string GetPrimaryKeyColumnForTable(string tableName)
        {
            var sql =
                $$"""
                SELECT 
                    kcu.column_name 
                FROM 
                    information_schema.table_constraints tc 
                    JOIN information_schema.key_column_usage kcu ON tc.constraint_name = kcu.constraint_name 
                        AND tc.table_schema = kcu.table_schema
                WHERE 
                    tc.constraint_type = 'PRIMARY KEY' 
                    AND tc.table_name = '{{tableName}}'
                """;
            return this.Set<PrimaryKeyInfo>().FromSqlRaw(sql, tableName).FirstOrDefault()?.column_name;
        }

        public long GetMaxIdForTable(string tableName, string columnName)
        {
            var sql = $"SELECT COALESCE(MAX(\"{columnName}\"), 0) \"MaxId\" FROM \"{tableName}\"";
            return this.Set<MaxIdResult>().FromSqlRaw(sql).FirstOrDefault()?.MaxId ?? 0;
        }

        public void AlterSequence(string sequenceName, long restartWith)
        {
            var sql = $"ALTER SEQUENCE \"{sequenceName}\" RESTART WITH {restartWith}";
            this.Database.ExecuteSqlRaw(sql);
        }

        public DbSet<SequenceInfo> Sequences { get; set; }
        public DbSet<PrimaryKeyInfo> PrimaryKeyInfos { get; set; }
        public DbSet<MaxIdResult> MaxIdResults { get; set; }
    }
}

[Keyless]
public class SequenceInfo
{
    public string sequence_schema { get; set; }
    public string sequence_name { get; set; }
    //public string table_name { get; set; }
}

[Keyless]
public class PrimaryKeyInfo
{
    public string column_name { get; set; }
}

[Keyless]
public class MaxIdResult
{
    public long MaxId { get; set; }
}
