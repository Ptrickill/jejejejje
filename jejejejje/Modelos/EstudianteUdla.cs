using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jejejejje.Modelos
{
    [Table("EstudianteUdla")]
    public class EstudianteUdla
    {
        [PrimaryKey]
        public int Id { get; set; }
        [MaxLength(200)]
        public string Nombre { get; set; }
        [MaxLength(200)]
        public string Carrera { get; set; }

    }
}
