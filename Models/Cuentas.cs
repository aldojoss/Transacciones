using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Transacciones_en_.net.Models
{
    public class Cuentas
    {
        [Key]
        public int CuentaId { get; set; }
        public string NumeroCuenta { get; set; }
        public decimal Saldo { get; set; }
        public bool Estado { get; set; } = true;
        public int ClienteId { get; set; }
        public Clientes Cliente { get; set; } //relacion?
    }
}
