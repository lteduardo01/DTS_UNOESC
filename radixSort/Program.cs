using System;

class RadixSort
{
    public static void Main()
    {
        // Cria um array de números
        int[] arr = { 170, 45, 75, 90, 802, 24, 2, 66 };

        // Ordena o array usando radix sort
        radixSort(arr);

        // Ordena o array usando Array.Sort()
        Array.Sort(arr);

        // Imprime o array ordenado
        foreach (int num in arr)
        {
            Console.WriteLine(num);
        }
    }

    public static void radixSort(int[] arr)
    {
        // Encontra o maior número no array
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }

        // Ordena o array pelo dígito mais significativo
        int exp = 1;
        while (max / exp > 0)
        {
            // Ordena o array pelo dígito atual
            int[] sortedArr = countSort(arr, exp);
            arr = sortedArr;
            exp *= 10;
        }
    }

    public static int[] countSort(int[] arr, int exp)
    {
        // Cria um array de contadores
        int[] count = new int[10];

        // Inicializa os contadores com 0
        for (int i = 0; i < 10; i++)
        {
            count[i] = 0;
        }

        // Conta o número de ocorrências de cada dígito
        for (int i = 0; i < arr.Length; i++)
        {
            count[(arr[i] / exp) % 10]++;
        }

        // Constrói o array ordenado
        int[] sortedArr = new int[arr.Length];
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            // Coloca o elemento na posição correta
            sortedArr[count[(arr[i] / exp) % 10] - 1] = arr[i];
            // Decrementa o contador para a próxima iteração
            count[(arr[i] / exp) % 10]--;
        }

        return sortedArr;
    }
}
