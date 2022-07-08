using BookStore.Repository;
using BookStoreModels.NewFolder;
using BookStoreModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreRepository
{
    public class OrdermstRepository : BaseRepository
    {
        public Ordermst GetOrderMst(int id)
        {
            return _context.Ordermsts.FirstOrDefault(c => c.Id == id);
        }

        public Ordermst AddOrderMsts(Ordermst category)
        {
            var entry = _context.Ordermsts.Add(category);
            _context.SaveChanges();
            return entry.Entity;
        }

        public bool DeleteOrderMst(int id)
        {
            var category = _context.Ordermsts.FirstOrDefault(c => c.Id == id);
            if (category == null)
                return false;

            _context.Ordermsts.Remove(category);
            _context.SaveChanges();
            return true;
        }
    }
}
