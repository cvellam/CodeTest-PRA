using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest.Data
{

    public class Product
    {
        [Required]
        public int ProductId { get; set; }

        [MaxLength(100)]
        public string ProductName { get; set; }

        public decimal Price { get; set; }

        public bool IsDiscount { get; set; }
    }
}
