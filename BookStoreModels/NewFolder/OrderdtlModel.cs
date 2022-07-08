using BookStoreModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreModels.NewFolder
{
    public class OrderdtlModel
    {
        public OrderdtlModel() { }

        public OrderdtlModel(Orderdtl order)
        {
            Id = order.Id;
            Bookid = order.Bookid;
            Quantity = order.Quantity;
            Ordermstid = order.Ordermstid;
        }

        public int Id { get; set; }
        public int? Bookid { get; set; }
        public int? Quantity { get; set; }
        public decimal? Totalprice { get; set; }
        public int? Ordermstid { get; set; }
        public decimal? Price { get; set; }
    }
}
