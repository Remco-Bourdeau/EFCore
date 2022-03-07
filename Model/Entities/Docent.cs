using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    class Docent
    {
        public int DocentId { get; set; }
        [Required]
        [MaxLength(20)]
        public string Voornaam { get; set; }//verplicht
        public bool? HeeftRijbewijs { get; set; }//niet verplicht
        [Required]
        [MaxLength(30)]
        public string Familienaam { get; set; }
        [Column("Maandwedde", TypeName ="decimal(18,4)")]
        public decimal Wedde { get; set; }
        [Column(TypeName ="date")]
        public DateTime InDienst { get; set; }
        [ForeignKey("Land")]
        public string LandCode { get; set; }
        public int CampusId { get; set; }
        public Campus Campus { get; set; }
    }
}
