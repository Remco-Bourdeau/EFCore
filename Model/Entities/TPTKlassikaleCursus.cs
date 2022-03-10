using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class TPTKlassikaleCursus:TPTCursus
    {
        public DateTime Van { get; set; }
        public DateTime Tot { get; set; }
    }
}
