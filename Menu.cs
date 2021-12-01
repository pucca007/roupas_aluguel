using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roupas_aluguel

{
    class Menu
    {

        public string menu()
        {
            Console.Clear();
            Console.WriteLine("1 -Cadastrar Cliente");
            Console.WriteLine("2 -Cadastrar Roupas");
            Console.WriteLine("3 -Fazer Aluguel");
            Console.WriteLine("4 -Listar Cliente");
            Console.WriteLine("Q -Sair");
            Console.WriteLine("Escolha uma opcao:");
            string opcao;
            opcao = Console.ReadLine();
            return opcao.ToUpper();

        }

    }
}