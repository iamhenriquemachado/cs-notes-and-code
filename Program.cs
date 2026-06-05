using cs_notes_and_code.challenges.CsvReader;
using cs_notes_and_code.challenges.CsvReader.Entities;
using cs_notes_and_code.challenges.CsvReader.Interfaces;

ICar c = new CsvBuilder();

List<Car> carList = new List<Car>
{
    new Car { Id = 6, Name = "Mustang GT", Brand = "Ford", Year = 2022, Type = "Coupe" },
    new Car { Id = 7, Name = "Civic Touring", Brand = "Honda", Year = 2021, Type = "Sedan" },
    new Car { Id = 8, Name = "Corolla Cross", Brand = "Toyota", Year = 2023, Type = "SUV" },
    new Car { Id = 9, Name = "Camaro SS", Brand = "Chevrolet", Year = 2020, Type = "Coupe" },
    new Car { Id = 10, Name = "Ranger XLT", Brand = "Ford", Year = 2022, Type = "Truck" },
    new Car { Id = 11, Name = "Compass Limited", Brand = "Jeep", Year = 2021, Type = "SUV" },
    new Car { Id = 12, Name = "HB20 Platinum", Brand = "Hyundai", Year = 2024, Type = "Hatchback" },
    new Car { Id = 13, Name = "Onix Premier", Brand = "Chevrolet", Year = 2023, Type = "Hatchback" },
    new Car { Id = 14, Name = "Tiguan R-Line", Brand = "Volkswagen", Year = 2022, Type = "SUV" },
    new Car { Id = 15, Name = "320i Sport", Brand = "BMW", Year = 2021, Type = "Sedan" },

};

c.Add(carList);