using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTrabajoFinal2021.Models
{
    public class Auto
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Marca { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Modelo { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Color { get; set; }

        [Column(TypeName = "money")]
        public decimal Precio { get; set; }

       
    }
}
