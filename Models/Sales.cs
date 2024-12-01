﻿using NuGet.Protocol.Plugins;
using System.ComponentModel.DataAnnotations;

namespace Bookstore.Models
{
    public class Sales
    {
        public int Id { get; set; }

        [Display(Name = "Data")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; } = DateTime.Now;

        [Display(Name = "Valor")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public double Amount => CalculateTotalAmount();

        [Display(Name = "Vendedor")]
        public Sellers Seller { get; set; }

        [Display(Name = "Livros")]
        public ICollection<Book> Books { get; set; } = new List<Book>();


        public Sales()
        {

        }
        public Sales(int id)
        {
            Id = id;
        }

        private double CalculateTotalAmount()
        {
            return Books.Sum(book => book.Price);
        }
    }
}