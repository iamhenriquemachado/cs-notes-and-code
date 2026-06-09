using System.Threading.Tasks;

namespace cs_notes_and_code.challenges.Day_23_25.Interface
{
    internal interface IDataEngine
    {
        Task<string> FetchRawJsonFromWebAsync(string cep);
        ViaCepResponse ConvertJsonToClass(string rawJson);
        void AddAddress(ViaCepResponse viaCepResponse);
        IEnumerable<ViaCepResponse> PrintJsonData();

    }
}
