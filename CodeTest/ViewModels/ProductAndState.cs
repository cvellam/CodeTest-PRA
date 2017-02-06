using CodeTest.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeTest.ViewModels
{
    public class ProductAndState
    {

        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<State> States { get; set; }
    }
}