using blazor_car_configurator.Models;
// using System.Collections.Generic;
// using System.Linq;


namespace blazor_car_configurator.Services
{
    public class CarDataService
    {
        private readonly List<Brand> _brands;
        private readonly List<CarModel> _models;
        private readonly List<Engine> _engines;
        private readonly List<Package> _packages;
        private readonly List<Tire> _tires;

        public CarDataService()
        {
            _brands = new List<Brand>
            {
                new Brand { Id = 1, Name = "Toyota", Price = 20000 },
                new Brand { Id = 2, Name = "Ford", Price = 30000 },
                new Brand { Id = 3, Name = "Honda", Price = 25000 }
            };

            _models = new List<CarModel>
            {
                new CarModel { Id = 1, BrandId = 1, Name = "Corolla", Price = 1500 },
                new CarModel { Id = 2, BrandId = 1, Name = "Camry", Price = 2000 },
                new CarModel { Id = 3, BrandId = 1, Name = "RAV4", Price = 2500 },
                new CarModel { Id = 4, BrandId = 2, Name = "Focus", Price = 1500 },
                new CarModel { Id = 5, BrandId = 2, Name = "Mustang", Price = 3500 },
                new CarModel { Id = 6, BrandId = 2, Name = "Explorer", Price = 3000 },
                new CarModel { Id = 7, BrandId = 3, Name = "Civic", Price = 1500 },
                new CarModel { Id = 8, BrandId = 3, Name = "Accord", Price = 2000 },
                new CarModel { Id = 9, BrandId = 3, Name = "CR-V", Price = 2500 }


            };

            _engines = new List<Engine>
            {
                new Engine { Id = 1, BrandId = 1, Name = "1.6L", Price = 1000 },
                new Engine { Id = 2, BrandId = 1, Name = "2.0L", Price = 1500 },
                new Engine { Id = 3, BrandId = 1, Name = "2.5L", Price = 2000 },
                new Engine { Id = 4, BrandId = 2, Name = "1.5L EcoBoost", Price = 1200 },
                new Engine { Id = 5, BrandId = 2, Name = "2.3L EcoBoost", Price = 1800 },
                new Engine { Id = 6, BrandId = 2, Name = "5.0L V8", Price = 3000 },
                new Engine { Id = 7, BrandId = 3, Name = "1.5L Turbo", Price = 1300 },
                new Engine { Id = 8, BrandId = 3, Name = "2.0L Turbo", Price = 1600 },
                new Engine { Id = 9, BrandId = 3, Name = "2.4L", Price = 1800 }

            };

            _packages = new List<Package>
            {
                new Package { Id = 1, BrandId = 1, Name = "Standard", Price = 800 },
                new Package { Id = 2, BrandId = 1, Name = "Luxury", Price = 1500 },
                new Package { Id = 3, BrandId = 1, Name = "Off-Road", Price = 1200 },
                new Package { Id = 4, BrandId = 2, Name = "Standard", Price = 900 },
                new Package { Id = 5, BrandId = 2, Name = "Sport", Price = 1600 },
                new Package { Id = 6, BrandId = 2, Name = "Technology", Price = 1400 },
                new Package { Id = 7, BrandId = 3, Name = "Comfort", Price = 1000 },
                new Package { Id = 8, BrandId = 3, Name = "Safety", Price = 1200 },
                new Package { Id = 9, BrandId = 3, Name = "Premium", Price = 1600 }
            };

            _tires = new List<Tire>
            {
                new Tire { Id = 1, BrandId = 1, Name = "Standard Tires", Price = 500 },
                new Tire { Id = 2, BrandId = 1, Name = "Premium Tires", Price = 1000 },
                new Tire { Id = 3, BrandId = 1, Name = "All-Terrain Tires", Price = 1200 },
                new Tire { Id = 4, BrandId = 2, Name = "Standard Tires", Price = 600 },
                new Tire { Id = 5, BrandId = 2, Name = "Winter Tires", Price = 900 },
                new Tire { Id = 6, BrandId = 2, Name = "Performance Tires", Price = 1300 },
                new Tire { Id = 7, BrandId = 3, Name = "Standard Tires", Price = 550 },
                new Tire { Id = 8, BrandId = 3, Name = "All-Season Tires", Price = 1100 },
                new Tire { Id = 9, BrandId = 3, Name = "Sport Tires", Price = 1400 }
            };
        }

        public List<Brand> GetBrands() => _brands;

        public List<CarModel> GetModelsByBrandId(int brandId) =>
            _models.Where(m => m.BrandId == brandId).ToList();

        public List<Engine> GetEnginesByBrandId(int brandId) =>
            _engines.Where(e => e.BrandId == brandId).ToList();

        public List<Package> GetPackagesByBrandId(int brandId) =>
            _packages.Where(p => p.BrandId == brandId).ToList();

        public List<Tire> GetTiresByBrandId(int brandId) =>
            _tires.Where(t => t.BrandId == brandId).ToList();
    }
}
