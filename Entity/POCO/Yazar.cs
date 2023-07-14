using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.POCO
{
    public class Yazar
    {
        public int Id { get; set; }
        public string YazarIsim { get; set; }

        //Navigation Propertyler
        //Bire (Yazar) - Çok (KitapYazar)
        public virtual ICollection<KitapYazar> KitapYazar { get; set; }
    }
}
