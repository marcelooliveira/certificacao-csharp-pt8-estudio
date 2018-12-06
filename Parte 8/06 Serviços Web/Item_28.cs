using ServiceReference1;
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Listings
{
    class Item_28 //Web Service
    {
        static async Task Main(string[] args)
        {
            using (MeuServicoClient servicoClient = new MeuServicoClient())
            {
                var nomeCurso = await servicoClient.GetValorAsync(1);
                Console.WriteLine(nomeCurso);
            }
            Console.ReadKey();
        }
    }
}
