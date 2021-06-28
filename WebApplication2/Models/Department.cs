using System;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication2.Models {
    public class Department {

        public int id { get; set; }
        public string Name { get; set; }
        public ICollection<Saller> Sallers { get; set; } = new List<Saller>();

        public Department() {
        }

        public Department(int id, string name) {
            this.id = id;
            Name = name;
        }
        public void AddSaller(Saller saller) {
            Sallers.Add(saller);
        }
        public double TotalSales(DateTime initial, DateTime final) {
            return Sallers.Sum(saller => saller.TotalSales(initial, final));
        }
    }
}
