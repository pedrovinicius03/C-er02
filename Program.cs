// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using C__us13.Classes;

PessoaFisica novaPf = new PessoaFisica();

novaPf.nome = "Vinicius";
novaPf.cpf = "1234567890";
novaPf.rendimentos = 7000.5f;
Console.WriteLine($"Pessoa Juridica===========================");
float resultado = novaPf.CalcularImposto(novaPf.rendimentos);
Console.WriteLine(resultado);

// Console.WriteLine(novaPf.nome);
// Console.WriteLine(novaPf.cpf);
// Console.WriteLine($"------------------------------------");

// Console.WriteLine($"nome {novaPf.nome} cpf {novaPf.cpf} ");

// Console.WriteLine("Bem-vindo" + novaPf.nome + ", seu cpf é " + novaPf.cpf + "!!!");

Console.WriteLine($"Pessoa Juridica===========================");
PessoaJuridica novaPj = new PessoaJuridica();

float impostoPagar =novaPj.CalcularImposto(12000.5f);
Console.WriteLine($"R$ {impostoPagar:0.00}");
Console.WriteLine($"R$ {impostoPagar.ToString("C")}");


