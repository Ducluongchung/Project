using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemWeb.Data.Infastructure;
using SystemWeb.Data.Repository;
using SystemWeb.Model.Models;

namespace System.Service
{
    public interface IProductService
    {
        void Add(Product product);

        void Update(Product product);

        void Delete(int id);

        IEnumerable<Product> GetAll();

        IEnumerable<Product> GetAllPaging(int page, int pageSize, out int totalRow);

        IEnumerable<Product> GetAllByCategoryPaging(int categoryId, int page, int pageSize, out int totalRow);

        Product GetById(int id);

        IEnumerable<Product> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow);

        void SaveChanges();
        void MutiDetele();

    }
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        private readonly IUnitOfWork unitOfWork;

        public ProductService(IProductRepository  productRepository, IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            this.productRepository = productRepository;
        }
        public void Add(Product product)
        {
            productRepository.Add(product);
        }

        public void Delete(int id)
        {
            productRepository.Delete(id);
        }

        public IEnumerable<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAllByCategoryPaging(int categoryId, int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void MutiDetele()
        {
           productRepository.DeleteMulti()
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
