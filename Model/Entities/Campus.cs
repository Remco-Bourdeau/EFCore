using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    class Campus
    {
        //[NotMapped]
       // public string NietOpnemen { get; set; }
        public int CampusId { get; set; }
        [Required]
        [Column("CampusNaam")]
        public string Naam { get; set; }
        public string Straat { get; set; }
        public string Huisnummer { get; set; }
        [StringLength(50)]
        public string Gemeente { get; set; }
        [NotMapped]
        public string Commentaar { get; set; }
        public ICollection<Docent> Docenten { get; set; }
    }
}
