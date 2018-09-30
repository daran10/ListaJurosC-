using System;

namespace ListaJuros2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ContaPoupanca saldoPoupanca = new ContaPoupanca();
            ContaPoupanca.saldoPoupanca = 5000;

            ContaPoupanca poupador1 = new ContaPoupanca();
            ContaPoupanca.poupador1 = 2000;

            ContaPoupanca poupador2= new ContaPoupanca();
            ContaPoupanca.poupador2 = 3000;

            ContaPoupanca taxaDeJurosAnual = new ContaPoupanca();
            ContaPoupanca.taxaDeJurosAnual = 0.04;

            ContaPoupanca AlterarTaxaDeJuros = new ContaPoupanca();
            ContaPoupanca.AlterarTaxaDeJuros = 0.05;

            ContaPoupanca CalcularJurosMensal = new ContaPoupanca();
            ContaPoupanca CalcularJurosAnual = new ContaPoupanca();



            Console.WriteLine("O Saldo Atual é: " + ContaPoupanca.saldoPoupanca);
            Console.ReadLine();
            Console.WriteLine("A taxa de juros mensal em 4% é : " + CalcularJurosMensal.CalcularJurosmensal());
            Console.ReadLine();
            Console.WriteLine("A taxa de jurtos anual em 5% é : " + CalcularJurosAnual.CalcularJurosAnual());
            Console.ReadLine();

            double valor1 = 2000;
            double valor2 = 3000;
            double percentual1 = 0.04 / 100.0;
            double percentual2 = 0.05 / 100.0;
            double resultado1 = valor1 + (percentual1 * valor1);
            double resultado2 = valor1 + (percentual2 * valor1);
            double resultado3 = valor1 + (percentual1 * valor2);
            double resultado4 = valor1 + (percentual2 * valor2);

            Console.WriteLine("O Saldo do poupador 1 acrescidos de juros em 4% é: "
                              + resultado1);

            Console.ReadLine();
            Console.WriteLine("O saldo do poupador 2 acrescidos de juros em 4% é: " + resultado2);
            Console.ReadLine();
            Console.WriteLine("O saldo do poupador 1 acrescidos de juros em 5% é: " + resultado3);
            Console.ReadLine();
            Console.WriteLine("O saldo do poupador 2 acrescidos de juros em 5% é: " + resultado4);
            Console.ReadLine();

        }
    }
}
