﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace WincareMigrations.Models;

public partial class TmPemeriksaanpenunjangdetail
{
    public decimal IdPenunjangdetail { get; set; }

    public decimal? IdMasterpemeriksaanpenunjang { get; set; }

    public string VKdpemeriksaan { get; set; }

    public string VKddetail { get; set; }

    public string VNmdetail { get; set; }

    public string VGroup { get; set; }

    public string VTipe { get; set; }

    public decimal? DJumlah { get; set; }

    public decimal? DHarga { get; set; }

    public decimal? DBeapasien { get; set; }

    public decimal? DBearekanan { get; set; }

    public string VKodetarif { get; set; }

    public bool? IsAktif { get; set; }

    public virtual TmPemeriksaanpenunjang IdMasterpemeriksaanpenunjangNavigation { get; set; }
}