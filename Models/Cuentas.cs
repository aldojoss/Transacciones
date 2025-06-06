﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Transacciones_en_.net.Models
{
    public class Cuentas
    {
        [Key]
        public int CuentaId { get; set; }
        public string NumeroCuenta { get; set; }
        public decimal Saldo { get; set; }
        public bool Activa { get; set; } = true;
        public int ClienteId { get; set; }

        [ForeignKey("ClienteId")]
        public Clientes Cliente { get; set; } 
    }
}
