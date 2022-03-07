using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Model.Entities
{
    class Land
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)] //no auto incrmenet
        public string LandCode { get; set; }
        public string Naam { get; set; }
        public ICollection<Docent> Docenten { get; set; }
    }
}
