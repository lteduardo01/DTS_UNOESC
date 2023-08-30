
namespace vetorOrdenado
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];

            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = i;
            }

            Random random = new Random();
            for (int i = vetor.Length - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                int temp = vetor[i];
                vetor[i] = vetor[j];
                vetor[j] = temp;
            }

            Array.Sort(vetor);

            Console.WriteLine("Valores ordenados:");
            foreach (int valor in vetor)
            {
                Console.Write(valor + " ");
            }

            Console.WriteLine(); 
        }
    }
}
