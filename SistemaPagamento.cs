using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Pagamento
{
    public class SistemaPagamento
    {
        public void PagamentoBoleto(double valorCompra)
        {
            double valorBoleto = valorCompra * 0.88;
            string codigoBarras = GerarCodigoBarras();
            Console.WriteLine("Valor a ser pago: R$ " + valorBoleto.ToString("F2"));
            Console.WriteLine("Código de barras: " + codigoBarras);
        }


        public string GerarCodigoBarras()
        {
            Random rnd = new Random();
            string codigoBarras = "";

            for (int i = 0; i < 48; i++)
            {
                codigoBarras += rnd.Next(0, 10);
            }

            return codigoBarras;
        }

        //  public string GerarCodigoBarras()
        // {
        //     Random rnd = new Random();

        //     string codigoBarras = rnd.Next(3000000000000000000);            

        //     return codigoBarras;
        // }


        public void PagamentoCartaoCredito(double valorCompra)
        {
            double valorParcela;
            int numParcelas;

            do
            {
                Console.WriteLine("Digite o número de parcelas (1 a 12):");
                numParcelas = int.Parse(Console.ReadLine());

                if (numParcelas < 1 || numParcelas > 12)
                {
                    Console.WriteLine("Número de parcelas inválido! Tente novamente.");
                }
            } while (numParcelas < 1 || numParcelas > 12);

            if (numParcelas <= 6)
            {
                valorParcela = valorCompra * 1.05 / numParcelas;
            }
            else
            {
                valorParcela = valorCompra * 1.08 / numParcelas;
            }

            double valorTotal = valorCompra * (numParcelas <= 6 ? 1.05 : 1.08);
            Console.WriteLine("Valor total a ser pago: R$ " + valorTotal.ToString("F2"));
            Console.WriteLine("Valor da parcela: R$ " + valorParcela.ToString("F2"));
        }


        public void PagamentoCartaoDebito(double valorCompra)
        {
            double saldo = 1000.0; // saldo em conta pré-definido
            if (valorCompra > saldo)
            {
                Console.WriteLine("Saldo insuficiente para realizar a compra!");
            }
            else
            {
                Console.WriteLine("Valor a ser pago: R$ " + valorCompra.ToString("F2"));
            }
        }

    }
}

