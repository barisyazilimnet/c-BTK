using Northwind.Business.Abstract;
using Northwind.DataAccess.Abstract;
using Northwind.Entites.Concrete;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System;
using Northwind.Business.ValidationRules.FluentValidation;
using FluentValidation;

namespace Northwind.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            ProductValidatior productvalidatior = new ProductValidatior();
            var result = productvalidatior.Validate(product);
            if(result.Errors.Count>0)
                throw new ValidationException(result.Errors);
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            try
            {
                _productDal.Delete(product);
            }
            catch
            {
                throw new Exception("Ürün Silinemedi.");
            }
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetProductsByCategory(int categoryId)
        {
            return _productDal.GetAll(p => p.CategoryId == categoryId);
        }

        public List<Product> GetProductsByProductName(string productName)
        {
            return _productDal.GetAll(p => p.ProductName.ToLower().Contains(productName.ToLower()));
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
