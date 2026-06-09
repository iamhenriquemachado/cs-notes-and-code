using System.Threading.Tasks;

namespace cs_notes_and_code.challenges.Day_23_25.Interface
{
    internal interface IEngine
    {
        Task<string> FetchRawJsonFromWebAsync(string cep);
        ViaCepResponse ConvertJsonToClass(string rawJson);
        IEnumerable<ViaCepResponse> PrintJsonData();
    }
}
