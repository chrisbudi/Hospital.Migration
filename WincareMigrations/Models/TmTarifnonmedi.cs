﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace WincareMigrations.Models;

public partial class TmTarifnonmedi
{
    public decimal IdNonmedis { get; set; }

    public string VKdtarif { get; set; }

    public string VNmtarif { get; set; }

    public decimal? IdGroupnonmedis { get; set; }

    public bool? IsAktif { get; set; }

    public virtual TmTarifnonmedisGroup IdGroupnonmedisNavigation { get; set; }

    public virtual ICollection<TmTarifnonmedisHarga> TmTarifnonmedisHargas { get; set; } = new List<TmTarifnonmedisHarga>();

    public virtual ICollection<TmTarifnonmedisMatrix> TmTarifnonmedisMatrices { get; set; } = new List<TmTarifnonmedisMatrix>();

    public virtual ICollection<TmTarifnonmedisRekanan> TmTarifnonmedisRekanans { get; set; } = new List<TmTarifnonmedisRekanan>();
}