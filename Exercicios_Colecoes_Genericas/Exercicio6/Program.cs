﻿/* Implementar um programa que simula uma fila de impressão seguindo o seguinte roteiro:
• Crie uma variável do tipo Queue<string> para representar a fila de impressão.
• Crie um loop que irá executar até que a fila de impressão esteja vazia.
• Dentro do loop, verifique se a fila de impressão não está vazia. Se não estiver vazia, remova o primeiro
elemento da fila usando o método Dequeue() e imprima na tela que o arquivo "X" está sendo impresso.
• Simule o tempo de impressão com um Thread.Sleep() por um período aleatório de tempo entre 1 e 5
segundos.
• Após simular a impressão do arquivo, imprima na tela que o arquivo "X" foi impresso com sucesso.
• Repita os passos 3 a 5 até que a fila de impressão esteja vazia.
 */

Queue<string> printQueue = new Queue<string>();
printQueue.Enqueue("Arquivo1.pdf");
printQueue.Enqueue("Arquivo2.docx");
printQueue.Enqueue("Arquivo3.ppt");
while (printQueue.Count > 0)
{
    string file = printQueue.Dequeue();
    Console.WriteLine($"\nO arquivo \"{file}\" está sendo impresso...");
    Thread.Sleep(new Random().Next(1000, 5000));
    Console.WriteLine($"O arquivo \"{file}\" foi impresso com sucesso.");
}
Console.ReadKey();
