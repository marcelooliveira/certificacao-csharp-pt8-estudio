using System;
using System.IO;
using System.Text;

namespace Listings
{
    class Item_01 //Usando o FileStream
    {
        static void Main(string[] args)
        {
            // GRAVANDO UM ARQUIVO

            FileStream fluxoSaida
                = new FileStream("ArquivoSaida.txt", FileMode.Create, FileAccess.Write);

            string mensagemSaida = "Olá, Alura!";

            byte[] array = Encoding.UTF8.GetBytes(mensagemSaida);
            int posicao = 0;
            int tamanho = mensagemSaida.Length;
            fluxoSaida.Write(array, posicao, tamanho);
            fluxoSaida.Close();
        }
    }
}