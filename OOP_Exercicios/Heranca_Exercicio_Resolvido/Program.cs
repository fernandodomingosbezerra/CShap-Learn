﻿using Heranca_Exercicio_Resolvido;

Console.WriteLine("\n####  Conta Corrente :  Numero: 111 Titular: Dbezerra   ###");
Conta conta = new();
conta.Numero = 111;
conta.Titular = "Dbezerra";

Console.WriteLine("Depositando R$ 1.000,00");
conta.Depositar(1000);
Console.WriteLine("Sacando R$ 100,00");
conta.Sacar(100);
Console.WriteLine($"Saldo da conta: " + conta.Saldo.ToString("c"));
Console.WriteLine("\nSacando R$ 2.000,00");
conta.Sacar(2000);
Console.WriteLine($"Saldo da conta: " + conta.Saldo.ToString("c"));

Console.WriteLine("\n####  Conta Poupança :  Numero: 222 Titular: Dbezerra2   ###");
ContaPoupanca contapoupanca = new();
contapoupanca.Numero = 222;
contapoupanca.Titular = "Dbezerra2";

Console.WriteLine("Depositando R$ 1.000,00");
contapoupanca.Depositar(1000);
Console.WriteLine($"Saldo da conta poupança: " + contapoupanca.Saldo.ToString("c"));
Console.WriteLine("Sacando R$ 100,00");
contapoupanca.Sacar(100);
Console.WriteLine($"Saldo da conta poupança: " + contapoupanca.Saldo.ToString("c"));

Console.WriteLine("\nSacando R$ 2.000,00");
contapoupanca.Sacar(2000);
Console.WriteLine($"Saldo da conta poupança: " + contapoupanca.Saldo.ToString("c"));

Console.WriteLine("\n###   Conta Investimento :  Numero: 333 Titular: Dbezerra3   ###");
ContaInvestimento containvestimento = new();
containvestimento.Numero = 333;
containvestimento.Titular = "Dbezerra3";

Console.WriteLine("Depositando R$ 1.000,00");
containvestimento.Depositar(1000);
Console.WriteLine($"Saldo da conta investimento: " + containvestimento.Saldo.ToString("c"));
Console.WriteLine("Sacando R$ 100,00");
containvestimento.Sacar(100);
Console.WriteLine($"Saldo da conta investimento: " + containvestimento.Saldo.ToString("c"));

Console.WriteLine("\nSacando R$ 2.000,00");
containvestimento.Sacar(2000);
Console.WriteLine($"Saldo da conta investimento: " + containvestimento.Saldo.ToString("c"));

