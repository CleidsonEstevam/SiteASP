using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //associação do departamento com os vendedores 
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department()
        {

        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTime final)
            //Pego cada vendedor, chamo o total de vendas dele dentro de uma data inicial e final e somo com todos os vendedores do departamento
        {
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }
    }
}
