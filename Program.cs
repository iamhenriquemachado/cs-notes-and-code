using cs_notes_and_code.challenges.CsvReader;
using cs_notes_and_code.challenges.CsvReader.Entities;
using cs_notes_and_code.challenges.CsvReader.Interfaces;

ICar c = new CsvBuilder();

List<Car> carList = new List<Car>
{
    new Car { Id = 15, Name = "Ferrari Pure Blood", Brand = "Ferrari", Year = 2026, Type = "Sport" },

};

c.DeleteById(15);