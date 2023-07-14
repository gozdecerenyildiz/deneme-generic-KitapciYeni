using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.POCO
{
    public class Tur
    {
        public int Id { get; set; }
        public string TurIsmi { get; set; }
        public virtual ICollection<KitapTur> KitapTur { get; set; }
    }
}
