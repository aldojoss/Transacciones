using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Transacciones_en_.net.Models
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Identificacion { get; set; }
        public List<Cuentas> Cuentas { get; set; } = new List<Cuentas>();
    }
}
