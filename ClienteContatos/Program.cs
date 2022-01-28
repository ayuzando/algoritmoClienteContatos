using System;

namespace ClienteContatos
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Cliente cliente = new Cliente();
                cliente.NomeCliente = "Mingau";
                Contato contato1 = new Contato()
                {
                    CodigoContato = 1,
                    NomeContato = "Cinza",
                    Telefone = "444444",
                    TipoRelacao = "Avó"

                };
                Contato contato2 = new Contato()
                {
                    CodigoContato = 630,
                    NomeContato = "Contato2",
                    Telefone = "555555",
                    TipoRelacao = "Mãe"

                };
                Contato contato3 = new Contato()
                {
                    CodigoContato = 9430,
                    NomeContato = "Contato3",
                    Telefone = "666666",
                    TipoRelacao = "Outros"

                };
                Contato contato4 = new Contato()
                {
                    CodigoContato = 3,
                    NomeContato = "Contato4",
                    Telefone = "666666",
                    TipoRelacao = "Outros"

                };
                cliente.AdicionaContato(contato3);
                cliente.AdicionaContato(contato2);
                cliente.AdicionaContato(contato1);
                cliente.AdicionaContato(contato4);
                Console.WriteLine(cliente.NomeCliente);
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
