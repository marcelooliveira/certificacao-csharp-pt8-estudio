﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Listings
{
    class Item_06 //Stream exceptions
    {
        static void Main(string[] args)
        {
            try
            {
                string conteudo = File.ReadAllText(path: "Arquivo.txt");
                Console.WriteLine(conteudo);
            }
            catch (FileNotFoundException ex)
            {
                // Arquivo não encontrado
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                // Outras exceções
                Console.WriteLine(ex.Message);
            }
        }
    }
}
