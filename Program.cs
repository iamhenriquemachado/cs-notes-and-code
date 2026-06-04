using cs_notes_and_code.challenges.CsvReader;
using cs_notes_and_code.challenges.CsvReader.Entities;
using cs_notes_and_code.challenges.CsvReader.Interfaces;

ICar c = new CsvBuilder();

List<Car> carList = new List<Car>
{
    new Car { Id = 51, Name = "Mustang GT", Brand = "Ford", Year = 2022, Type = "Coupe" },
    new Car { Id = 52, Name = "Civic Touring", Brand = "Honda", Year = 2021, Type = "Sedan" },
    new Car { Id = 53, Name = "Corolla Cross", Brand = "Toyota", Year = 2023, Type = "SUV" },
    new Car { Id = 54, Name = "Camaro SS", Brand = "Chevrolet", Year = 2020, Type = "Coupe" },
    new Car { Id = 55, Name = "Ranger XLT", Brand = "Ford", Year = 2022, Type = "Truck" },
    new Car { Id = 56, Name = "Compass Limited", Brand = "Jeep", Year = 2021, Type = "SUV" },
    new Car { Id = 57, Name = "HB20 Platinum", Brand = "Hyundai", Year = 2024, Type = "Hatchback" },
    new Car { Id = 58, Name = "Onix Premier", Brand = "Chevrolet", Year = 2023, Type = "Hatchback" },
    new Car { Id = 59, Name = "Tiguan R-Line", Brand = "Volkswagen", Year = 2022, Type = "SUV" },
    new Car { Id = 60, Name = "320i Sport", Brand = "BMW", Year = 2021, Type = "Sedan" },

};

c.Add(carList);