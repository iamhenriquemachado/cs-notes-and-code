using cs_notes_and_code.challenges.CsvReader;
using cs_notes_and_code.challenges.CsvReader.Entities;
using cs_notes_and_code.challenges.CsvReader.Interfaces;

ICar c = new CsvBuilder();

List<Car> carList = new List<Car>
{
    new Car { Id = 15, Name = "Ferrari Purosangue", Brand = "Ferrari", Year = 2026, Type = "Sport" },
    new Car { Id = 16, Name = "911 Turbo S", Brand = "Porsche", Year = 2025, Type = "Sport" },
    new Car { Id = 17, Name = "Mustang GT", Brand = "Ford", Year = 2024, Type = "Muscle" },
    new Car { Id = 18, Name = "Camaro SS", Brand = "Chevrolet", Year = 2024, Type = "Muscle" },
    new Car { Id = 19, Name = "Civic Type R", Brand = "Honda", Year = 2025, Type = "Hatchback" },
    new Car { Id = 20, Name = "Corolla Cross", Brand = "Toyota", Year = 2025, Type = "SUV" },
    new Car { Id = 21, Name = "Model 3 Performance", Brand = "Tesla", Year = 2025, Type = "Electric" },
    new Car { Id = 22, Name = "X5 M Competition", Brand = "BMW", Year = 2026, Type = "SUV" },
    new Car { Id = 23, Name = "A45 S AMG", Brand = "Mercedes-Benz", Year = 2025, Type = "Hatchback" },
    new Car { Id = 24, Name = "RS6 Avant", Brand = "Audi", Year = 2025, Type = "Wagon" },
    new Car { Id = 25, Name = "Range Rover Sport", Brand = "Land Rover", Year = 2026, Type = "SUV" },
    new Car { Id = 26, Name = "Wrangler Rubicon", Brand = "Jeep", Year = 2025, Type = "Off-Road" },
    new Car { Id = 27, Name = "Golf GTI", Brand = "Volkswagen", Year = 2024, Type = "Hatchback" },
    new Car { Id = 28, Name = "CX-5", Brand = "Mazda", Year = 2025, Type = "SUV" },
    new Car { Id = 29, Name = "Altima SR", Brand = "Nissan", Year = 2025, Type = "Sedan" },
    new Car { Id = 30, Name = "Charger Scat Pack", Brand = "Dodge", Year = 2023, Type = "Muscle" }
};

c.SearchById(19);