using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace roupas_aluguel

{
    class Cliente
    {
        private string nome;
        private double cpf;
        private double cep;
        private double telefone;
        private string email;

        public void cadastrarCliente()
        {
            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o CPF");
            cpf = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o CEP");
            cep = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Telefone");
            telefone = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o email");
            email = Console.ReadLine();

        }

        public void mostrarCadastro()
        {
            Console.WriteLine("--- Cadastro ---");

            Console.WriteLine("Nome:{0}", nome);

            Console.WriteLine("CPF:{0}", cpf);

            Console.WriteLine("CEP:{0}", cep);

            Console.WriteLine("telefone:{0}", telefone);

            Console.WriteLine("email:{0}", email);
        }

        

    }
}


