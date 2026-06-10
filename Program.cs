using cs_notes_and_code.challenges.Day_23_25;
using cs_notes_and_code.challenges.Day_23_25.Interface;

IDataEngine engine = new DataEngine();
string cep = "14702020";

string rawJsonResult = await engine.FetchRawJsonFromWebAsync(cep);
ViaCepResponse structuredAddress = await engine.ConvertJsonToClass(rawJsonResult);
engine.AddAddress(structuredAddress);


var response = engine.PrintJsonData();

foreach (var item in response)
{
    Console.WriteLine();
    Console.WriteLine("========== ADDRESS INFORMATION ==========");
    Console.WriteLine($"CEP         : {item.Cep}");
    Console.WriteLine($"Street      : {item.Logradouro}");
    Console.WriteLine($"Complement  : {item.Complemento}");
    Console.WriteLine($"Unit        : {item.Unidade}");
    Console.WriteLine($"District    : {item.Bairro}");
    Console.WriteLine($"City        : {item.Localidade}");
    Console.WriteLine($"State (UF)  : {item.Uf}");
    Console.WriteLine($"State       : {item.Estado}");
    Console.WriteLine($"Region      : {item.Regiao}");
    Console.WriteLine($"IBGE        : {item.Ibge}");
    Console.WriteLine($"GIA         : {item.Gia}");
    Console.WriteLine($"DDD         : {item.DDD}");
    Console.WriteLine($"SIAFI       : {item.Siafi}");
    Console.WriteLine("=========================================");
}