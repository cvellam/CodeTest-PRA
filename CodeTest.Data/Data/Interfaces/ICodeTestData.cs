using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest.Data
{
   public interface ICodeTestData
    {
        IEnumerable<Product> GetAllProducts();
        IEnumerable<State> GetAllStates();
        State GetState(string Id);
        Product GetProduct(int Id);
    }
}
