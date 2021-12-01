using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roupas_aluguel

{
    class Aluguel

    {
        public double valorTotal;
        public DateTime duracao;
        public string descricao;
        public DateTime datainicial;
        public DateTime datafinal;
        public double acidente;
        public string nomeCliente;

        public void cadastrarAluguel()
        {

            datainicial = DateTime.Now;
            Console.WriteLine(datainicial.Date);
            Console.WriteLine("Digite o motivo da aluguel");
            descricao = Console.ReadLine();
        }

        public void cadastrarMulta()
        {
            Console.WriteLine("Informe o valor do acidente");
            acidente = double.Parse(Console.ReadLine());
            if (acidente > 0)
            {

            }
            else
            {
                acidente = 0;
            }
        }

        public void mostrarMulta()
        {
            Console.WriteLine("Total do acidente R${0}, total a pagar{1}", acidente, valorTotal);
        }

        public void mostrarTotal()
        {
            Console.WriteLine("Valor Total, aluguel + acidente : {0}", acidente + valorTotal);
        }

        public void registrarDevolucao()
        {
            datafinal = DateTime.Now;
            Console.WriteLine(" Devolvido em{0}", datafinal.Date);
        }
    }
}
