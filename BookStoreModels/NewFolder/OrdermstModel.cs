using BookStoreModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreModels.NewFolder
{
    public class OrdermstModel
    {
        public OrdermstModel() { }

        public OrdermstModel(Ordermst order)
        {
            Id = order.Id;
            Userid = order.Userid;
            Orderdate = order.Orderdate;
            Totalprice = order.Totalprice;
        }
        public int Id { get; set; }
        public int? Userid { get; set; }
        public DateTime? Orderdate { get; set; }
        public decimal? Totalprice { get; set; }
    }
}
