using DataAccess.DbContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EntityFramework
{
    public class EntityFrameworkRepository<T>
    {
        KitapciDbContext dbContext = new KitapciDbContext();
        //T = Type
        public bool Ekle(T entity)
        {
           dbContext.Add(entity);
           int sonuc = dbContext.SaveChanges();
            if (sonuc>0)
            {
                return true;
            }
            else
            {
                return false;
            }
    
        }
        
    }
}
