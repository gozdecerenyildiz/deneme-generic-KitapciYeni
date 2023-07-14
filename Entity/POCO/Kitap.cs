using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text;

namespace Entity.POCO
{
    public class Kitap
    {
        
        public int Id { get; set; }
        public string KitapIsmi { get; set; }

        public virtual ICollection<KitapTur> KitapTur { get; set; }
        public virtual ICollection<KitapYazar> KitapYazar { get; set; }
    }
}
