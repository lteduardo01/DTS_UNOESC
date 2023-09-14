using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> filaDeStrings = new Queue<string>();

        filaDeStrings.Enqueue("fila");
        filaDeStrings.Enqueue("de");
        filaDeStrings.Enqueue("strings");

        string proximoElemento = filaDeStrings.Peek();
        Console.WriteLine($"Próximo elemento na fila: {proximoElemento}");

        Console.WriteLine("Itens na fila de strings:");
        foreach (var item in filaDeStrings)
        {
            Console.WriteLine(item);
        }
    }
}
