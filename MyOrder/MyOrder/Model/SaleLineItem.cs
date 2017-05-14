using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOrder.Model
{
    public class SaleLineItem
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
    }
}

