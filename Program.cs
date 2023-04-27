using Sistema_Pagamento;

SistemaPagamento Pagamento = new SistemaPagamento();


double valorCompra;
int opcao;

do
{
    Console.Write("\nDigite o valor da compra: ");
    valorCompra = double.Parse(Console.ReadLine());

    Console.WriteLine("\nDigite a opção de pagamento: ");
    Console.WriteLine("1 - Boleto");
    Console.WriteLine("2 - Cartão de crédito");
    Console.WriteLine("3 - Cartão de débito");
    Console.WriteLine("4 - Cancelar operação");
    Console.WriteLine("5 - Sair do sistema");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Pagamento.PagamentoBoleto(valorCompra);
            break;
        case 2:
            Pagamento.PagamentoCartaoCredito(valorCompra);
            break;
        case 3:
            Pagamento.PagamentoCartaoDebito(valorCompra);
            break;
        case 4:
            Console.WriteLine("Operação cancelada!");
            break;
        case 5:
            Console.WriteLine("Saindo do sistema...");
            break;
        default:
            Console.WriteLine("Opção inválida! Tente novamente.");
            break;
    }
} while (opcao != 5);

