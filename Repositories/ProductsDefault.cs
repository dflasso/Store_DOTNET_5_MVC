using System;
using System.Collections.Generic;
using G10COMERCIALIZADORA_DOTNET.Models;
using Microsoft.EntityFrameworkCore;

namespace G10COMERCIALIZADORA_DOTNET.Repositories
{
    public class ProductsDefault
    {
        public static void CreateDefaulProducts(ModelBuilder modelBuilder)
        {
            List<Category> categories = new List<Category>();
            categories.Add(new Category(1,"Ropa", "Prendas de Vestir"));
            categories.Add(new Category(2,"Bazar Escolar", "Utilies escolares"));
            categories.Add(new Category(3,"Vajilla", "Vajilla de Procelana"));

            modelBuilder.Entity<Category>().HasData(categories);

            List<Brand> brands = new List<Brand>();
            brands.Add(new Brand(1, "Adolfo Domínguez", "Pepito S.A.", "Marca de Ropa"));
            brands.Add(new Brand(2, "Massimo Dutti", "Pepito S.A.", "Marca de Ropa"));
            brands.Add(new Brand(3, "Cortefiel", "Pepito S.A.", "Marca de Ropa"));
            brands.Add(new Brand(4, "Mango", "Pepito S.A.", "Marca de Ropa"));
            modelBuilder.Entity<Brand>().HasData(brands);

            //Productos
            List<Product> products = new List<Product>();
            products.Add(new Product(1, "Blusa", "Blusa para Dama", "r001", "small", "casual", "", 25.89, 30.00, 25, 1, 1, 3));
            products.Add(new Product(2, "Camisa", "Camisa para Niño", "r002", "small", "casual", "", 15.00, 20.00, 13, 1, 2, 3));
            products.Add(new Product(3, "Bufanda", "Bufanda impermiable", "r003", "small", "casual", "", 3.80, 5.00, 30, 1, 3, 3));
            modelBuilder.Entity<Product>().HasData(products);

            //impuestos
            List<Tax> taxes = new List<Tax>();
            taxes.Add(new Tax(1, "IVA", 12, "12%", "IVA 12%"));
            taxes.Add(new Tax(2, "IVA", 14, "14%", "IVA 14%"));
            taxes.Add(new Tax(3, "IVA", 0, "0%", "IVA 0%"));
            taxes.Add(new Tax(4, "IVA", 0, "12%", "No objeto de impuesto"));
            taxes.Add(new Tax(5, "ICE", 150, "3023", "ICE 3023 - Productos del tabaco sucedáneos del tabaco"));
            taxes.Add(new Tax(6, "ICE", 10, "3023", "ICE 3023 - Productos del tabaco sucedáneos del tabaco"));
            taxes.Add(new Tax(7, "ICE", 20, "3051", "ICE 3051 - Perfumes y aguas de tocador"));
            taxes.Add(new Tax(8, "ICE", 35, "3023", "ICE 3620 - Videojuegos"));
            taxes.Add(new Tax(9, "ICE", 300, "3630", "ICE 3630 - Armas de fuego, armas deportivas y municiones excepto aquellas adquiridas por la fuerza pública"));
            modelBuilder.Entity<Tax>().HasData(taxes);

            //Compañia
            List<Company> companies = new List<Company>();
            companies.Add(new Company(1,"0990017514001", "Los Chinitos", "Pepito Pérez", "6 de Diciembre", "022 588 003", "", "info@chinitos.com") );
            modelBuilder.Entity<Company>().HasData(companies);

            //Secuencial - Establecimiento
            List<Sequential> sequentials = new List<Sequential>();
            sequentials.Add(new Sequential(1, "Matriz", "001", "Secuencial de la Matriz"));
            sequentials.Add(new Sequential(2, "Sucursal Sur", "002", "Secuencial de la Sucursal Sur - La Magdalena"));
            modelBuilder.Entity<Sequential>().HasData(sequentials);

            //Secuencial Vendedor
            List<SequentialSeller> sequentialSellers = new List<SequentialSeller>();
            sequentialSellers.Add(new SequentialSeller(1, "001", null, 1,1) ); 
            modelBuilder.Entity<SequentialSeller>().HasData(sequentialSellers);

            //Formas de Pago
            List<Payment> payments = new List<Payment>();
            payments.Add(new Payment(1, "Efectivo", "Pagar en Efectivo"));
            payments.Add(new Payment(2, "Tarjeta de Débito", "Pagar con Tarjeta de Débito"));
            payments.Add(new Payment(3, "Tarjeta de Crédito", "Pagar con Tarjeta de Crédito"));
            modelBuilder.Entity<Payment>().HasData(payments);

            Invoice invoice = new Invoice(1, "0804202101179190121500110010040000009853912397917",  "000000001", 0, 0, DateTime.Now, 1, 2, 1,1);
            modelBuilder.Entity<Invoice>().HasData(invoice);
        }
    }
}