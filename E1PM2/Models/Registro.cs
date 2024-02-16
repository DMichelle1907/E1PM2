using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace E1PM2.Models
{
    [Table("Registro")]
    public class Registro
    {

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Latitud { get; set; }

        [MaxLength(100)]
        public string Longitud { get; set; }

        [MaxLength(100)]
        public string Descripcion { get; set; }
    }
}
