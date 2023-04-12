// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using C__us13.Classes;

PessoaFisica novaPf = new PessoaFisica();

novaPf.nome = "Vinicius";
novaPf.cpf = "1234567890";

Console.WriteLine(novaPf.nome);
Console.WriteLine(novaPf.cpf);
Console.WriteLine($"------------------------------------");

Console.WriteLine($"nome {novaPf.nome} cpf {novaPf.cpf} ");

Console.WriteLine("Bem-vindo" + novaPf.nome + ", seu cpf é " + novaPf.cpf + "!!!");