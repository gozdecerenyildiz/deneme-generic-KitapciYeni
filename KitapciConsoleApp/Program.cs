using DataAccess.EntityFramework;
using Entity.POCO;
using System;

namespace KitapciConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {


            //Proje Geliştirme Yöntemleri
            //---------------------------
            // 1) DB FİRST   : Önce database sonra kod (Varolan bir veritabanına göre uygulama geliştirip o uygulamayı o veritabanına bağlamak)

            // 2) CODE FİRST : Önce kod sonra database (Olmayan bir veritabanına sanki varmış gibi, uygulamamızı geliştirmek)
            //---------------------------

            //DBCONTEXT: Veritabanı bağlamı (bağlantısı), proejemizin veritabanına bağlandığımız ve veritabanı ile ilgili işlemleri gerçekleştirebildiğimiz class.

            //Migration: Bizim olmayan veritabanımızın daha doğrusu code first t ekniği ile geliştirilen bir projede tabloların, kolonların özelliklerinin kaydını tutan yapıdır.
            //

            //Generic Yapılar: Tip bağımsız yapılardır. Yani classlar, methodlar, propertyler vb. Belirli bir tipe göre çalışmayan, bizim içerisine vermiş olduğumuz tipe göre çalışan yapılardır.

            //EntityFramework: Veri tabanı işlemlerimizi kolaylıkla gerçekleştirebileceğimiz kütüphanedir.

            //Repository Design Pattern (Repository Tasarım Kalıbı): Veritabanı işlemlerimiz için oluşturduğumuz generic classımızın ismi.
            
            Console.WriteLine("Hello World!");
        }

        static void Test(int sayı)
        {
            
        }
        //entity-sağ tık-poco (new folder)-add-class:Veri tabanımızdaki tutacağımız tablolarımızın klasörü.bunun içine class oluştururz ve tablolar yer alır.claslar içindeki propertiler bizim tablolarımızın kolonları olucak

        //navigation propertiler: public virtual icollection<kitaplar> kitap {get;set;}(yalnızca bir kere kullanılırsın-şey gibi sql de diyagramdaki ilişkilendirme gibi)

        //data access-sağ tık-new folder-DB Context+ Entity Framework oluşturulur.veri tabanına bağlamamızı sağlar dbcontext.içine class oluşturulur.class isimine db context yazılır diğerlerinden ayrımı yapabilelim diye.daha clas içinde kalıtım yapılır microsoft.entityframeworkcore.dbcontextten
     
        //override edeceğmiz onconfiguring metdu oluşturulur.(otomatik kendi yazar).ve altında connection string oluşturulur:sql ile visual stidio arasındaki bağlantı kodu.
       
        //dataacses-sağ tık-set as startup project.daha sonra view-other windows-package manager console seçilir.
       
        //ilk migrationa a intit veya initilaize

        //package manager console ekrenından dataacsses seçilir ve migration oluşturulur.
        //entityframeworkcore\add-migrations init yazılır
        //magament programını aç ve visial studio da package manager console kısımında entityframeworkcore\update-database yaz

        //generic yapı için entity frameworke gelip -sağ tık-add-class-isime entityframeworkrepostory
    }
}
}
