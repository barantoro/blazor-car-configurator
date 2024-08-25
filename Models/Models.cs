namespace blazor_car_configurator.Models
{
    public class Brand
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
    }

    public class CarModel
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
    }

    public class Engine
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
    }

    public class Package
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
    }

    public class Tire
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
    }
}
