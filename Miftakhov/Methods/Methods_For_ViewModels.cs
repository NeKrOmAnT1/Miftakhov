using Miftakhov.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Miftakhov.Methods
{
    internal class Methods_For_ViewModels
    {
        private readonly AppDbContext _context = new();
        public ObservableCollection<Material> LoadMaterail()
        {
            _context.Database.EnsureCreated();
            return new ObservableCollection<Material>(_context.Materials.ToList());
        } 
        public ObservableCollection<Products> LoadProduct()
        {
            _context.Database.EnsureCreated();
            return new ObservableCollection<Products>(_context.Products.ToList());
        }

        public void DeleteProduct(ObservableCollection<Products> products, Products selected)
        {
            if (selected == null) return;

            _context.Products.Remove(selected);
            _context.SaveChanges();

            products.Remove(selected);
            MessageBox.Show("Продукт успешно удален!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        public void AddProduct(Products product)
        {
            if (product == null) return;

            using var context = new AppDbContext();
            context.Products.Add(product);
            context.SaveChanges();

            MessageBox.Show("Продукт успешно добавлен!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        public void UpdateProduct(Products updatedProduct)
        {
            if (updatedProduct == null) return;

            using var context = new AppDbContext();
            var existing = context.Products.FirstOrDefault(p => p.ProductId == updatedProduct.ProductId);

            if (existing != null)
            {
                existing.ProductTypeId = updatedProduct.ProductTypeId;
                existing.ProductName = updatedProduct.ProductName;
                existing.Article = updatedProduct.Article;
                existing.MinPartnerPrice = updatedProduct.MinPartnerPrice;
                existing.RollWidthMeters = updatedProduct.RollWidthMeters;

                context.SaveChanges();

                MessageBox.Show("Продукт успешно обновлён!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Продукт не найден в базе данных.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
