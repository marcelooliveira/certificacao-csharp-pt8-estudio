﻿using System;
using System.IO;

namespace Listings
{
    class Item_00 //Streams
    {
        static void Main(string[] args)
        {
            //TAREFAS:
            //1. ABRIR O ARQUIVO Diretores.txt
            //2. LER 10 BYTES DO ARQUIVO
            //3. IMPRIMIR ESSES BYTES NO CONSOLE

            FileStream fluxoDeArquivo
                = new FileStream("Diretores.txt", FileMode.Open, FileAccess.Read);

        }
    }
}