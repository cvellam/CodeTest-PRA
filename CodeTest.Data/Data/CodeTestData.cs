using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest.Data
{
   public class CodeTestData:ICodeTestData
    {
        private List<Product> _products = new List<Product>();
        private List<State> _states = new List<State>();
     
        public CodeTestData()
        {

            _products.Add(new Product { ProductId = 1, ProductName = "Computer", Price = 500.12M, IsDiscount = true });
            _products.Add(new Product { ProductId = 2, ProductName = "Surface Pro", Price =799.99M, IsDiscount = false });
            _products.Add(new Product { ProductId = 3, ProductName = "iPhone7", Price = 899.99M, IsDiscount = false });
            _products.Add(new Product { ProductId = 4, ProductName = "Galaxy7" , Price = 599.99M, IsDiscount = true });


            _states.Add(new State { StateId = "AL", StateName = "Alabama", Tax = 5 });
            _states.Add(new State { StateId = "AK", StateName = "Alaska", Tax = 5 });
            _states.Add(new State { StateId = "AZ", StateName = "Arizona", Tax = 5 });
            _states.Add(new State { StateId = "AR", StateName = "Arkansas", Tax = 5 });
            _states.Add(new State { StateId = "CA", StateName = "California", Tax = 5 });
            _states.Add(new State { StateId = "CO", StateName = "Colorado", Tax = 5 });
            _states.Add(new State { StateId = "CT", StateName = "Connecticut", Tax = 5 });
            _states.Add(new State { StateId = "DE", StateName = "Delaware", Tax = 5 });
            _states.Add(new State { StateId = "DC", StateName = "District of Columbia", Tax = 5 });
            _states.Add(new State { StateId = "FL", StateName = "Florida", Tax = 0 });
            _states.Add(new State { StateId = "GA", StateName = "Georgia", Tax = 5 });
            _states.Add(new State { StateId = "HI", StateName = "Hawaii", Tax = 5 });
            _states.Add(new State { StateId = "ID", StateName = "StateIdaho", Tax = 5 });
            _states.Add(new State { StateId = "IL", StateName = "Illinois", Tax = 5 });
            _states.Add(new State { StateId = "IN", StateName = "Indiana", Tax = 5 });
            _states.Add(new State { StateId = "IA", StateName = "Iowa", Tax = 5 });
            _states.Add(new State { StateId = "KS", StateName = "Kansas", Tax = 5 });
            _states.Add(new State { StateId = "KY", StateName = "Kentucky", Tax = 5 });
            _states.Add(new State { StateId = "LA", StateName = "Louisiana", Tax = 5 });
            _states.Add(new State { StateId = "ME", StateName = "Maine", Tax = 5 });
            _states.Add(new State { StateId = "MD", StateName = "Maryland", Tax = 5 });
            _states.Add(new State { StateId = "MA", StateName = "Massachusetts", Tax = 5 });
            _states.Add(new State { StateId = "MI", StateName = "Michigan", Tax = 5 });
            _states.Add(new State { StateId = "MN", StateName = "Minnesota", Tax = 5 });
            _states.Add(new State { StateId = "MS", StateName = "Mississippi", Tax = 5 });
            _states.Add(new State { StateId = "MO", StateName = "Missouri", Tax = 5 });
            _states.Add(new State { StateId = "MT", StateName = "Montana", Tax = 5 });
            _states.Add(new State { StateId = "NE", StateName = "Nebraska", Tax = 5 });
            _states.Add(new State { StateId = "NV", StateName = "Nevada", Tax = 5 });
            _states.Add(new State { StateId = "NH", StateName = "New Hampshire", Tax = 5 });
            _states.Add(new State { StateId = "NJ", StateName = "New Jersey", Tax = 5 });
            _states.Add(new State { StateId = "NM", StateName = "New Mexico", Tax = 5 });
            _states.Add(new State { StateId = "NY", StateName = "New York", Tax = 5 });
            _states.Add(new State { StateId = "NC", StateName = "North Carolina", Tax = 5 });
            _states.Add(new State { StateId = "ND", StateName = "North Dakota", Tax = 5 });
            _states.Add(new State { StateId = "OH", StateName = "Ohio", Tax = 5 });
            _states.Add(new State { StateId = "OK", StateName = "Oklahoma", Tax = 5 });
            _states.Add(new State { StateId = "OR", StateName = "Oregon", Tax = 5 });
            _states.Add(new State { StateId = "PA", StateName = "Pennsylvania", Tax = 5 });
            _states.Add(new State { StateId = "RI", StateName = "Rhode Island", Tax = 5 });
            _states.Add(new State { StateId = "SC", StateName = "South Carolina", Tax = 5 });
            _states.Add(new State { StateId = "SD", StateName = "South Dakota", Tax = 5 });
            _states.Add(new State { StateId = "TN", StateName = "Tennessee", Tax = 5 });
            _states.Add(new State { StateId = "TX", StateName = "Texas", Tax = 0 });
            _states.Add(new State { StateId = "UT", StateName = "Utah", Tax = 5 });
            _states.Add(new State { StateId = "VT", StateName = "Vermont", Tax = 5 });
            _states.Add(new State { StateId = "VA", StateName = "Virginia", Tax = 5 });
            _states.Add(new State { StateId = "WA", StateName = "Washington", Tax = 5 });
            _states.Add(new State { StateId = "WV", StateName = "West Virginia", Tax = 5 });
            _states.Add(new State { StateId = "WI", StateName = "Wisconsin", Tax = 5 });
            _states.Add(new State { StateId = "WY", StateName = "Wyoming", Tax = 5 });
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _products;
        }

        public IEnumerable<State> GetAllStates()
        {
            return _states;
        }

        public Product GetProduct(int Id)
        {
            return _products.Find(w => w.ProductId == Id);
        }

        public State GetState(string Id)
        {
            return _states.Find(s => s.StateId == Id);
        }      

    }
}

