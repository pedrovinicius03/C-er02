
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using C__us13.Classes;

PessoaFisica novaPf = new PessoaFisica();
PessoaJuridica novaPj = new PessoaJuridica();
Endereco novoEndPf = new Endereco();

novaPf.nome = "Vinicius";
novaPf.cpf = "1234567890";
novaPf.rendimentos = 7000.5f;
Console.WriteLine($"Pessoa Juridica===========================");
float resultado = novaPf.CalcularImposto(novaPf.rendimentos);
Console.WriteLine(resultado);
Console.WriteLine($"Validacao de datas=====================");
DateTime temp = new DateTime (2000,01,01);
// Console.WriteLine(novaPf.validarDataNasc(temp));
Console.WriteLine(novaPf.validarDataNasc("01/01/2000"));

novoEndPf.logradouro = "Rua Niteroi";
novoEndPf.numero = 180;
novoEndPf.complemento = "predio";
novoEndPf.endComercial = true;

novaPf.endereço = novoEndPf;

Console.WriteLine(@$"
Nome: {novaPf.nome}
endereço :{novaPf.endereço.logradouro}, Num: {novaPf.endereço.numero} 
Maior de idade : {novaPf.ValidardataNasc(novaPf.dataNasc)}

");



// Console.WriteLine(novaPf.nome);
// Console.WriteLine(novaPf.cpf);
// Console.WriteLine($"------------------------------------");

// Console.WriteLine($"nome {novaPf.nome} cpf {novaPf.cpf} ");

// Console.WriteLine("Bem-vindo" + novaPf.nome + ", seu cpf é " + novaPf.cpf + "!!!");

Console.WriteLine($"Pessoa Juridica===========================");


float impostoPagar =novaPj.CalcularImposto(12000.5f);
Console.WriteLine($"R$ {impostoPagar:0.00}");
Console.WriteLine($"R$ {impostoPagar.ToString("C")}");


