﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace WincareMigrations.Models;

public partial class TmDokter
{
    public decimal IdDokter { get; set; }

    public string VKddokter { get; set; }

    public string VNmdokter { get; set; }

    public string VSpesialisasidokter { get; set; }

    public string VAlamatdokter { get; set; }

    public string VTelpdokter { get; set; }

    public string VAlamatpraktek { get; set; }

    public string VTelppraktek { get; set; }

    public bool? CAktif { get; set; }

    public string ImFotodokter { get; set; }

    public string VKodetarif { get; set; }

    public string VKdakun { get; set; }

    public string VBy { get; set; }

    public string IsTtd { get; set; }

    public decimal? Pin { get; set; }

    public string VNosip { get; set; }

    public virtual ICollection<TmJadwaldokter> TmJadwaldokters { get; set; } = new List<TmJadwaldokter>();

    public virtual ICollection<TmUser> TmUsers { get; set; } = new List<TmUser>();

    public virtual TmCoa VKdakunNavigation { get; set; }
}