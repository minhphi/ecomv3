using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using DataObjects.EntityFramework.Model;
using Product = BusinessObject.Product;

namespace DataObjects.EntityFramework.Implement
{
    public class EntityProductDao : EntityDaoBase, IProductDao
    {
        public IList<Product> FindAll()
        {
            using (Context)
            {
                return Context.Products.Select(c => Mapper.Map(c)).ToList();
            }
        }

        public Product FindById(int id)
        {
            using (Context)
            {
                return Mapper.Map(Context.Products.Find(id));
            }
        }

        public IList<Product> FindBy(int[] ids)
        {
            throw new NotImplementedException();
        }

        public Product Insert(Product obj)
        {
            using (Context)
            {
                var entity = Mapper.Map(obj);
                Context.Products.Add(entity);
                Context.SaveChanges();
                return obj;
            }
        }

        public IList<Product> Insert(List<Product> objs)
        {
            throw new NotImplementedException();
        }

        public Product Update(Product obj)
        {
            using (Context)
            {
                var entity = Context.Products.Find(obj.Id);
                if (entity == null) throw new NullReferenceException(string.Format("UpdateProduct: Product with Id {0} is not found", obj.Id));
                Mapper.MapNewValue(entity, obj);
                Context.Entry(entity).State = EntityState.Modified;
                Context.SaveChanges();
                return Mapper.Map(entity);
            }
        }

        public List<Product> Update(List<Product> objs)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(List<Product> obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int[] ids)
        {
            throw new NotImplementedException();
        }
    }
}
