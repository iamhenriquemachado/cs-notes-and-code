using cs_notes_and_code.challenges.Day_23_25;
using cs_notes_and_code.challenges.Day_23_25.Interface;

IDataEngine engine = new DataEngine();

bool correctZipAddress = false;

do
{
    Console.WriteLine("Type a ZIP Address to fetch the data...");
    string cep = Console.ReadLine();

    if (!int.TryParse(cep, out int result))
    {
        Console.WriteLine("ZIP Address Incorret. Please, try again with a valid one.");
        correctZipAddress = false;
    }
    else
    {
        correctZipAddress = true;
    }
}
while (!correctZipAddress);

Console.WriteLine("Loop finished;");




//int userMenu = 0;

//while (userMenu == 0)
//{
//    string rawJsonResult = await engine.FetchRawJsonFromWebAsync(result);
//    ViaCepResponse structuredAddress = await engine.ConvertJsonToClass(rawJsonResult);
//    engine.AddAddress(structuredAddress);

//    var response = engine.PrintJsonData();

//    foreach (var item in response)
//    {
//        Console.WriteLine();
//        Console.WriteLine("========== ADDRESS INFORMATION ==========");
//        Console.WriteLine($"CEP         : {item.Cep}");
//        Console.WriteLine($"Street      : {item.Logradouro}");
//        Console.WriteLine($"Complement  : {item.Complemento}");
//        Console.WriteLine($"Unit        : {item.Unidade}");
//        Console.WriteLine($"District    : {item.Bairro}");
//        Console.WriteLine($"City        : {item.Localidade}");
//        Console.WriteLine($"State (UF)  : {item.Uf}");
//        Console.WriteLine($"State       : {item.Estado}");
//        Console.WriteLine($"Region      : {item.Regiao}");
//        Console.WriteLine($"IBGE        : {item.Ibge}");
//        Console.WriteLine($"GIA         : {item.Gia}");
//        Console.WriteLine($"DDD         : {item.DDD}");
//        Console.WriteLine($"SIAFI       : {item.Siafi}");
//        Console.WriteLine("=========================================");
//    }

//    Console.WriteLine("Do you want to search for another CEP?");
//    int exitOption = int.Parse(Console.ReadLine());

//    userMenu = exitOption;
//}





