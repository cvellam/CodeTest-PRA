using CodeTest.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest.Repository
{
   public interface ICodeTestRepository
    {
        IEnumerable<Product> GetAllProducts();

        IEnumerable<State> GetAllStates();

        Product GetProduct(int id);

        State GetState(string id);

    }
}
