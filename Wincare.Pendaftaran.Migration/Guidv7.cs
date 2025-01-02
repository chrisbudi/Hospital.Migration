using System.Security.Cryptography;

namespace Wincare.Pendaftaran.Migration
{
    public static class GuidV7
    {
        public static Guid NewGuidV7()
        {
            var timestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            var randomBytes = new byte[10];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomBytes);
            }

            var timestampBytes = BitConverter.GetBytes(timestamp);
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(timestampBytes);
            }

            var guidBytes = new byte[16];

            // Timestamp first 6 bytes (48 bits)
            Array.Copy(timestampBytes, 2, guidBytes, 0, 6);

            // Random bytes
            Array.Copy(randomBytes, 0, guidBytes, 6, 10);

            // Set the version to 7
            guidBytes[6] = (byte)((guidBytes[6] & 0x0F) | 0x70);

            // Set the variant to RFC 4122 (10xx)
            guidBytes[8] = (byte)((guidBytes[8] & 0x3F) | 0x80);

            return new Guid(guidBytes);
        }

        static void Main(string[] args)
        {
            var guid = NewGuidV7();
            Console.WriteLine(guid);
        }
    }
}
