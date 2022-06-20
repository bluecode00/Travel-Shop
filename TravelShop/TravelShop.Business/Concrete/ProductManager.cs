using TravelShop.Business.Abstract;
using TravelShop.Data.Abstract;
using TravelShop.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelShop.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductRepository _productRepository;

        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            _productRepository.Delete(entity);
        }

        public List<Product> GetAll()
        {
            return _productRepository.GetAll();
        }

        public Product GeyById(int id)
        {
            return _productRepository.GetById(id);
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
