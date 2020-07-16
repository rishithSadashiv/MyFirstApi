using MyFirstApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstApi.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public ProductDBContext db;
        public ProductRepository()
        {
            db = new ProductDBContext();
        }
        public void Add(Product p)
        {
            db.Product.Add(p);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            Product p = db.Product.Find(id);
            db.Product.Remove(p);
            db.SaveChanges();
        }

        public Product Get(int id)
        {
            return db.Product.SingleOrDefault<Product>(p=>p.Pid==id);
        }

        public List<Product> GetAll()
        {
            return db.Product.ToList();
        }

        public void Update(Product p)
        {
            db.Product.Update(p);
            db.SaveChanges();
        }
    }
}
