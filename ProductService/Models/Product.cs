﻿namespace ProductService.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string? Nombre { get; set; }

        public string? Descripcion { get; set; }

        public decimal Precio { get; set; }

        public int CategoryId { get; set; }

        public int stock { get; set; }

    }
}
