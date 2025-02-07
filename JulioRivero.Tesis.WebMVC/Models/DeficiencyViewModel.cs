﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JulioRivero.Tesis.WebMVC.Models
{
    public class DeficiencyViewModel
    {
        public int Id { get; set; }
        public int ImpairmentId { get; set; }
        [Display(Name = "Tipo")]
        public string Kind { get; set; }
        [Display(Name = "Nombre")]
        public string Name { get; set; }
        [DataType(DataType.MultilineText)]
        [Display(Name = "Introducción")]
        public string Introduction { get; set; }
        [DataType(DataType.MultilineText)]
        [Display(Name = "Sintomas")]
        public string Symptom { get; set; }
        [DataType(DataType.MultilineText)]
        [Display(Name = "Prevencion")]
        public string Prevention { get; set; }
    }
}