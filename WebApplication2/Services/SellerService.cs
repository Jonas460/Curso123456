using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Services {
    public class SellerService {
        private readonly WebApplication2Context _context;

        public SellerService(WebApplication2Context context) {
            _context = context;
        }
        public List<Saller> FindAll() {
            return _context.Saller.ToList();
        }
        public void Insert(Saller obj) {
            _context.Add(obj);
            _context.SaveChanges();
        }
        public Saller FindById(int id) {
            return _context.Saller.FirstOrDefault(obj => obj.Id == id);
        }
        public void Remove(int id) {
            var obj = _context.Saller.Find(id);
            _context.Saller.Remove(obj);
            _context.SaveChanges();
        }
    }
}
