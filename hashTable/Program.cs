using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Cria uma tabela hash com 100 posições
        Dictionary<string, string> tabela = new Dictionary<string, string>(100);

        // Solicita ao usuário os pares de chave/valor
        while (true)
        {
            Console.WriteLine("Insira o CPF:");
            string cpf = Console.ReadLine();

            // Verifica se a chave já foi inserida
            if (tabela.ContainsKey(cpf))
            {
                Console.WriteLine("Chave já inserida.");
                continue;
            }

            // Solicita ao usuário o nome
            Console.WriteLine("Insira o nome:");
            string nome = Console.ReadLine();

            // Insere o par de chave/valor na tabela
            tabela.Add(cpf, nome);

            // Pergunta ao usuário se deseja inserir mais um par de chave/valor
            Console.WriteLine("Deseja inserir mais um par de chave/valor? (S/N)");
            string resposta = Console.ReadLine();

            if (resposta.ToUpper() != "S")
            {
                break;
            }
        }

        // Percorre e exibe todos os dados inseridos pelo usuário na tela
        foreach (var item in tabela)
        {
            Console.WriteLine("CPF: {0}, Nome: {1}", item.Key, item.Value);
        }
    }
}
