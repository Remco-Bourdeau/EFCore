using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public partial class Docent
    {
        public string Naam
        {
            get { return Voornaam + " " + Familienaam; }
        }
        [Column(TypeName ="date")]
        public DateTime Geboortedatum { get; set; }
    }
}
