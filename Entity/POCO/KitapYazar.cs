using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.POCO
{
    public class KitapYazar
    {
        public int Id { get; set; }
        public int KitapId { get; set; }
        public int YazarId { get; set; }

        public virtual Kitap Kitaplar { get; set; }
        public virtual Yazar Yazarlar { get; set; }
    }
}
