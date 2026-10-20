using Demo_ASPMVC_03.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo_ASPMVC_03.Controllers
{
    public class ProductController : Controller
    {
        private static List<Product> _products = [
            new Product() { Id = 1, Name = "Demo", Desc = null, Price = 3.14, Gtin = "1234567891234", Quantity = 42 },
            new Product() { Id = 2, Name = "Café Arabica 250g", Desc = "Café moulu pur arabica", Price = 5.99, Gtin = "3250390001234", Quantity = 150 },
            new Product() { Id = 3, Name = "Chocolat Noir 70%", Desc = "Tablette de chocolat noir bio", Price = 2.45, Gtin = "3250390005678", Quantity = 85 },
            new Product() { Id = 4, Name = "Bouteille d'eau 1.5L", Desc = "Eau minérale naturelle", Price = 0.65, Gtin = "3250390009012", Quantity = 500 },
            new Product() { Id = 5, Name = "Pâtes Spaghetti 500g", Desc = "Pâtes au blé complet", Price = 1.20, Gtin = "3250390003456", Quantity = 240 },
            new Product() { Id = 6, Name = "Riz Basmati 1kg", Desc = "Riz basmati extra long", Price = 2.89, Gtin = "3250390007890", Quantity = 110 },
            new Product() { Id = 7, Name = "Huile d'Olive 75cl", Desc = "Huile d'olive vierge extra", Price = 8.50, Gtin = "3250390002345", Quantity = 65 },
            new Product() { Id = 8, Name = "Lait Demi-Écrémé 1L", Desc = "Lait UHT d'origine France", Price = 1.05, Gtin = "3250390006789", Quantity = 300 },
            new Product() { Id = 9, Name = "Biscuits Sablés", Desc = "Sablés pur beurre pur sucre", Price = 1.95, Gtin = "3250390001122", Quantity = 95 },
            new Product() { Id = 10, Name = "Jus d'Orange 1L", Desc = "Pur jus d'orange sans pulpe", Price = 2.15, Gtin = "3250390003344", Quantity = 140 },
            new Product() { Id = 11, Name = "Sachet de Thé Vert", Desc = "Thé vert bio - Boîte de 20 sachets", Price = 3.10, Gtin = "3250390005566", Quantity = 75 }
        ];


        public IActionResult Index()
        {
            return View(_products);
        }
        public IActionResult Details(int id)
        {
            Product product = _products.Single(p => p.Id == id);
            return View(product);
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Delete(int id)
        {
            Product product = _products.Single(p => p.Id == id);
            return View(product);
        }
    }
}
