using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeTest.Data;

namespace CodeTest.Repository
{
    public class CodeTestRepository : ICodeTestRepository
    {
        // This Can be changed to EF or otherData Persisent layer after the fact.
        private readonly ICodeTestData _dbContext;

       
        public CodeTestRepository(ICodeTestData dbContext)
        {
            _dbContext = dbContext;
        }


        //public CodeTestRepository()
        //{
        //    _dbContext = new CodeTestData();
        //}

        public IEnumerable<Product> GetAllProducts()
        {
            return _dbContext.GetAllProducts();
        }

        public IEnumerable<State> GetAllStates()
        {
            return _dbContext.GetAllStates();
        }

        public Product GetProduct(int id)
        {
            return _dbContext.GetProduct(id);
        }

        public State GetState(string id)
        {
            return _dbContext.GetState(id);
        }        
    }
}
