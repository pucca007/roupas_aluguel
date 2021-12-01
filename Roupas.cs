using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace roupas_aluguel
{
    class Roupas
    {
        private string tipo;
        private double tamanho;
        private string cor;
        private string tecido;
        

        public void cadastrarCliente()
        {
            Console.WriteLine("Digite o tipo da Roupa");
            tipo = Console.ReadLine();

            Console.WriteLine("Digite o tamanho");
            tamanho = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a cor da Roupa");
            cor = Console.ReadLine();

            Console.WriteLine("Digite o tecido da Roupa");
            tecido = Console.ReadLine();

         }

        public void mostrarCadastro()
        {
            Console.WriteLine("--- Cadastro ---");

            Console.WriteLine("Tipo:{0}", tipo);

            Console.WriteLine("Tamanho:{0}", tamanho);

            Console.WriteLine("Cor:{0}", cor);

            Console.WriteLine("Tecido:{0}", tecido);

         
        }

        


    }
}

