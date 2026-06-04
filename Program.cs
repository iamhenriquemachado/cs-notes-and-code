using cs_notes_and_code.challenges.CsvReader;
using cs_notes_and_code.challenges.CsvReader.Interfaces;

ICar c = new CsvBuilder();

var carList = c.List();

foreach(var car in carList)
{
    Console.WriteLine($"{car.Name} {car.Id}");
}