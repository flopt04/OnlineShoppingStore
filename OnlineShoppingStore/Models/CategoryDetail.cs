using OnlineShoppingStore.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShoppingStore.Models
{
    public class CategoryDetail
    {
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Este campo é obigatório!")]
        [StringLength(100, ErrorMessage = "Minimo 3 caractéres e máximo 100", MinimumLength = 3)]
        public string CategoryName { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDelete { get; set; }
    }
    public class ProductDetail
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Este campo é obigatório!")]
        [StringLength(100, ErrorMessage = "Minimo 3 caractéres e máximo 100", MinimumLength = 3)]
        public string ProductName { get; set; }

        [Required]
        [Range(1, 50)]
        public Nullable<int> CategoryId { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }

        [Required(ErrorMessage = "Este campo é obigatório!")]
        public string Description { get; set; }
        public string ProductImage { get; set; }
        public Nullable<bool> IsFeatured { get; set; }

        [Required]
        [Range(typeof(int), "1", "500", ErrorMessage = "Quantidade inválida!")]
        public Nullable<int> Quantity { get; set; }

        [Range(typeof(decimal), "1", "200000", ErrorMessage = "Preço inválido!")]
        public Nullable<decimal> Price { get; set; }
        public SelectList Categories { get; set; }

    }
}