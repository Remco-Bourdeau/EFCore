using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Model.Entities
{
    public partial class Docent
    {
        public Docent() { }
        public int DocentId { get; set; }
        [Required]
        [MaxLength(20)]
        public string Voornaam { get; set; }
        [Required]
        [MaxLength(30)]
        public string Familienaam { get; set; }
        [Column("Maandwedde", TypeName = "decimal(18,4)")]
        public decimal Wedde { get; set; }
        [Column(TypeName = "date")]
        public DateTime InDienst { get; set; }
        public bool? HeeftRijbewijs { get; set; }
        public Geslacht Geslacht { get; set; }
        [ForeignKey("Land")]
        public string LandCode { get; set; }
        public int CampusId { get; set; }
        public Land Land { get; set; }
        public Campus Campus { get; set; }
        public Adres ThuisAdres { get; set; }
        public Adres VerblijfAdres { get; set; }

        public void Opslag(decimal bedrag)
        {
            Wedde += bedrag;
        }

        //private readonly ILazyLoader lazyLoader;
        //public Docent() { }
        //public Docent(ILazyLoader lazyLoader)
        //{
        //    this.lazyLoader = lazyLoader;
        //}
        //private Campus campus;
        //public Campus Campus
        //{
        //    get => lazyLoader.Load(this, ref campus);
        //    set => campus = value;
        //}

        //private Land land;
        //public Land Land
        //{
        //    get => lazyLoader.Load(this, ref land);
        //    set => land = value;
        //}

        //public int DocentId { get; set; }
        //public Geslacht Geslacht { get; set; }
        //[Required]
        //[MaxLength(20)]
        //public string Voornaam { get; set; }//verplicht
        //public bool? HeeftRijbewijs { get; set; }//niet verplicht
        //[Required]
        //[MaxLength(30)]
        //public string Familienaam { get; set; }
        //[Column("Maandwedde", TypeName ="decimal(18,4)")]
        //public decimal Wedde { get; set; }
        //[Column(TypeName ="date")]
        //public DateTime InDienst { get; set; }
        //[ForeignKey("Land")]
        //public string LandCode { get; set; }
        //public int CampusId { get; set; }
        ////public virtual Campus Campus { get; set; }
        ////public virtual Land Land { get; set; }
    }
}
