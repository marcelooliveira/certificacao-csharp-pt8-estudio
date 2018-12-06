using System;
using System.IO;
using System.IO.Pipes;
using System.Net.Sockets;
using System.Text;

namespace Listings
{
    class Item_00 //Streams
    {
        static void XMain(string[] args)
        {
            FileStream fluxoArquivo = 
                new FileStream("Diretores.txt", FileMode.Open, FileAccess.Read);

            byte[] bytes = new byte[10];
            int posicao = 0;
            int tamanho = 10;
            fluxoArquivo.Read(bytes, posicao, tamanho);

            fluxoArquivo.Seek(5, SeekOrigin.Current);
            fluxoArquivo.Read(bytes, posicao, tamanho);

            foreach (var caractere in bytes)
            {
                //Console.Write(caractere);
                Console.Write((char)caractere);
            }

            Console.ReadKey();
        }
    }
}