using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roupas_aluguel
{
    class program
    {
        static void Main(string[] args)
        {
            string opçao;
            Menu menu = new Menu();
            Cliente cliente = new Cliente();
            do
            {
                opçao = menu.menu();
                switch (opçao)
                {
                    case "1":
                        Console.WriteLine("Cadastrar Cliente");
                        cliente.cadastrarCliente();
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.WriteLine("Cadastrar Roupa");
                        Roupas roupas = new Roupas
                        roupas.cadastrarRoupas();
                        Console.Readkey();
                        break;

                    case "3":
                        cliente.mostrarCadastro();
                        Console.ReadKey();
                        break;
                    case "Q":
                        Console.WriteLine("Encerrando o programa");
                        break;
                    default:
                        Console.WriteLine("Opcao invalida!");
                        break;
                }
            } while (opçao != "Q");
            //Environment.Exit(0);
        }





    }
}