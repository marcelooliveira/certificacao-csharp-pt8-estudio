using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Listings
{
    class Item_25 //Json
    {
        static async Task XMain(string[] args)
        {
            string cep = "04101300";
            string url = $"http://viacep.com.br/ws/{cep}/json/";

            var endereco = await GetEndereco(url);
            Console.WriteLine($"{endereco.logradouro} - {endereco.bairro} - {endereco.localidade} - {endereco.uf}");
            Console.ReadKey();
        }

        static async Task<Endereco> GetEndereco(string url)
        {
            string json = await LerPaginaWeb(url);
            return JsonConvert.DeserializeObject<Endereco>(json);
        }

        static async Task<string> LerPaginaWeb(string uri)
        {
            HttpClient cliente = new HttpClient();
            return await cliente.GetStringAsync(uri);
        }

        //gerado por: http://json2csharp.com/

        //public class RootObject
        public class Endereco
        {
            public string cep { get; set; }
            public string logradouro { get; set; }
            public string complemento { get; set; }
            public string bairro { get; set; }
            public string localidade { get; set; }
            public string uf { get; set; }
            public string unidade { get; set; }
            public string ibge { get; set; }
            public string gia { get; set; }
        }
    }
}
