﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Denuncia
    {
        public int Id { get; set; }
        public DateTime? Fecha { get; set; }
        public string Calle { get; set; }
        public int Numero { get; set; }
        public string EntreCalles1 { get; set; }
        public string EntreCalles2 { get; set; }
        public string Descripcion { get; set; }
        [Required]
        public int TipoDenunciaId { get; set; }
        public virtual TipoDenuncia TipoDenuncia{get; set;}
        public int? EstadoDenunciaId { get; set; }
        public virtual EstadoDenuncia EstadoDenuncia { get; set; }
        public string Legajo { get; set; }
        public string IpDenunciante { get; set; }
    }
}