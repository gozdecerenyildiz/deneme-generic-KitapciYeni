using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.POCO
{
    public class KitapTur
    {
        public int Id { get; set; }
        public int KitapId { get; set; }
        public int TurId { get; set; }

        public virtual Kitap Kitap { get; set; }
        public virtual Tur Tur { get; set; }
    }
}
