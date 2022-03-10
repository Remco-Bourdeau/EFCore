using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Model.Entities
{
    public class Land
    {
        public Land()
        {
            Docenten = new List<Docent>();
        }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string LandCode { get; set; }
        public string Naam { get; set; }
        public ICollection<Docent> Docenten { get; set; }
        //private readonly ILazyLoader lazyLoader;
        //public Land (ILazyLoader lazyLoader)
        //{
        //    this.lazyLoader = lazyLoader;
        //}
        //public Land()
        //{
        //    Docenten = new List<Docent>();
        //}
        //private ICollection<Docent> docenten;
        //public ICollection<Docent> Docenten
        //{
        //    get => lazyLoader.Load(this, ref docenten);
        //    set => docenten = value;
        //}

        //[Key, DatabaseGenerated(DatabaseGeneratedOption.None)] //no auto incrmenet
        //public string LandCode { get; set; }
        //public string Naam { get; set; }
        ////public virtual ICollection<Docent> Docenten { get; set; }
    }
}
