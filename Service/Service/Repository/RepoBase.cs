    using Microsoft.Data.SqlClient;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Internal;
    using Service.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Service.Repository
    {
        public class RepoBase<T> where T : class
        {
            ConvenienceStoreContext ConvenienceStorecontext;
            DbSet<T> Dbset;   

            public RepoBase()
             {
                 ConvenienceStorecontext = new ConvenienceStoreContext();
                 Dbset = ConvenienceStorecontext.Set<T>();
            }
        
            public List<T> GetAll()
            {
                return Dbset.ToList();
            }

            public void Create(T entity)
            {
                Dbset.Add(entity);
                ConvenienceStorecontext.SaveChanges();
            }

            public bool Delete(T entity)
            {
                Dbset.Remove(entity);
                ConvenienceStorecontext.SaveChanges();
                return true;
            }
            public void Update(T entity)
            {
                var tracker = ConvenienceStorecontext.Attach(entity);
                tracker.State = EntityState.Modified;
                ConvenienceStorecontext.SaveChanges();

            }

        /*public List<ImportBill> GetMyModelsByRawQuery()
        {
            string query = "select *\r\nfrom ImportBill ib join Provider p  \r\non ib.proId = p.proId\r\njoin Merchandise m \r\non m.merId = ib.merId \r\n";


            List<ImportBill> models = ConvenienceStorecontext.ImportBills.FromSqlRaw(query).ToList();

            return models;
        }*/

        public List<T> GetByRawQuery(string query, params SqlParameter[] parameters)
        {
            return ConvenienceStorecontext.Set<T>().FromSqlRaw(query, parameters).ToList();
        }
         public T GetById(int id)
        {
            return Dbset.Find(id);
        }



    }
}
