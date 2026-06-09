using cs_notes_and_code.challenges.Day_23_25;
using cs_notes_and_code.challenges.Day_23_25.Interface;

IEngine engine = new DataEngine();


string cep = "14702020";

string rawJsonResult = await engine.FetchRawJsonFromWebAsync(cep);
ViaCepResponse structuredAddress = engine.ConvertJsonToClass(rawJsonResult);