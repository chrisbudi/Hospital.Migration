﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace WincareMigrations.Models;

public partial class TmTarifdetail
{
    public decimal IdTarifdetail { get; set; }

    public string VKodetariflayan { get; set; }

    public string VKdtarifdetail { get; set; }

    public string VNmtarifdetail { get; set; }

    public bool? IsAktif { get; set; }

    public decimal? IdGrouptarif { get; set; }

    public virtual TmTarifGroup IdGrouptarifNavigation { get; set; }

    public virtual TmTarifPelayanan VKodetariflayanNavigation { get; set; }
}