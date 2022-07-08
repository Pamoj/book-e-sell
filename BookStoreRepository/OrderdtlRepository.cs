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
    public class OrderdtlRepository : BaseRepository
    {
        public Orderdtl GetOrderdtl(int id)
        {
            return _context.Orderdtls.FirstOrDefault(c => c.Id == id);
        }

        public Orderdtl AddOrderdtl(Orderdtl category)
        {
            try
            {
                var entry = _context.Orderdtls.Add(category);
                _context.SaveChanges();
                return entry.Entity;
            }
            catch (Exception ex)
            {
                return null;
            }
            
        }


        public bool DeleteOrderdtl(int id)
        {
            var category = _context.Orderdtls.FirstOrDefault(c => c.Id == id);
            if (category == null)
                return false;

            _context.Orderdtls.Remove(category);
            _context.SaveChanges();
            return true;
        }
    }
}

