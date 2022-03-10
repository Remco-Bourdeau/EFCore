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
    public class Campus
    {
        public Campus()
        {
            Docenten = new List<Docent>();
        }
        public int CampusId { get; set; }
        [Required]
        [Column("CampusNaam")]
        public string Naam { get; set; }
        public Adres Adres { get; set; }
        [NotMapped]
        public string Commentaar { get; set; }
        public ICollection<Docent> Docenten { get; set; }
        // private readonly ILazyLoader lazyLoader;
        // public Campus(ILazyLoader lazyLoader){
        //     this.lazyLoader = lazyLoader;
        // }
        // public Campus()
        // {
        //     Docenten = new List<Docent>();
        // }
        // private ICollection<Docent> docenten;
        // public ICollection<Docent> Docenten
        // {
        //     get => lazyLoader.Load(this, ref docenten);
        //     set => docenten = value;
        // }
        // //[NotMapped]
        //// public string NietOpnemen { get; set; }
        // public int CampusId { get; set; }
        // [Required]
        // [Column("CampusNaam")]
        // public string Naam { get; set; }
        // public string Straat { get; set; }
        // public string Huisnummer { get; set; }
        // public string Postcode { get; set; }
        // [StringLength(50)]
        // public string Gemeente { get; set; }
        // [NotMapped]
        // public string Commentaar { get; set; }
        // //public virtual ICollection<Docent> Docenten { get; set; }
    }
}
