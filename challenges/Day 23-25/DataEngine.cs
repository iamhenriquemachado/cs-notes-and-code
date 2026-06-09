using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using cs_notes_and_code.challenges.Day_23_25;
using cs_notes_and_code.challenges.Day_23_25.Interface;

namespace cs_notes_and_code.challenges.Day_23_25
{
    internal class DataEngine : IDataEngine
    {
        private static readonly HttpClient _httpClient = new HttpClient();
        private readonly List<ViaCepResponse> _viaCepResponseList = new List<ViaCepResponse>();
        public async Task<string> FetchRawJsonFromWebAsync(string cep)
        {

            string url = $"https://viacep.com.br/ws/{cep}/json/";
            string responseBody = await _httpClient.GetStringAsync(url);

            return responseBody;
        }
        public ViaCepResponse ConvertJsonToClass(string rawJson)
        {
            ViaCepResponse addressObject = JsonSerializer.Deserialize<ViaCepResponse>(rawJson);

            return new ViaCepResponse
            {
                Cep = addressObject.Cep,
                Logradouro = addressObject.Logradouro,
                Complemento = addressObject.Complemento,
                Unidade = addressObject.Unidade, 
                Bairro = addressObject.Bairro, 
                Localidade = addressObject.Localidade, 
                Uf = addressObject.Uf, 
                Estado = addressObject.Estado, 
                Regiao = addressObject.Regiao, 
                Ibge = addressObject.Ibge, 
                Gia = addressObject.Gia, 
                DDD = addressObject.DDD, 
                Siafi = addressObject.Siafi

            };

        }

        public void AddAddress(ViaCepResponse viaCepResponse)
        {
            _viaCepResponseList.Add(viaCepResponse);
        }

        public IEnumerable<ViaCepResponse> PrintJsonData()
        {
            return _viaCepResponseList.AsReadOnly();
        }
    }
}
