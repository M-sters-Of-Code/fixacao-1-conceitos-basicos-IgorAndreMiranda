﻿
/*
 * As classes a serem dsenvolvidas devem atender aos seguintes requisitos:
 * - Devem estar na pasta Model
 * - Para a classe SomaDoisNumeros, deve-se criar um método estático chamado Somar que recebe dois inteiros e retorna a soma deles
 * - Para a classe MetrosMilimetros, deve-se criar um método estático chamado Converter que recebe um double e retorna o valor em milímetros
 * - A  classe CalculaAumento deve ter um método estático chamado Calcular que recebe um double salario e um double aumento e retorna o valor do salário com o aumento aplicado
 * A classe CalculaDesconto deve ter um método estático chamado Calcular que recebe um double valor e um double desconto e retorna o valor com o desconto aplicado
 * - A classe CalculaAluguelCarro deve ter um método estático chamado Calcular que recebe um int dias, um int quilometragemInicial, um int quilometragemFinal e retorna o valor total do aluguel
 */

//PRIMEIRA  TABELA REALIZADA
using FixacaoConceitosBasicos1.Model;

int resultadoSoma = SomaDoisNumeros.Somar(5, 10);
Console.WriteLine($"Soma: {resultadoSoma}");

double milimetros = MetroMilimetros.Converter(2.5);
Console.WriteLine($"Milímetros: {milimetros}");

double novoSalario = CalculaAumento.Calcular(2000, 500);
Console.WriteLine($"Salário com aumento: {novoSalario}");

double valorComDesconto = CalculaDesconto.Calcular(1000, 150);
Console.WriteLine($"Valor com desconto: {valorComDesconto}");

double custoAluguel = CalculaAluguelCarro.Calcular(3, 100, 300);
Console.WriteLine($"Custo total do aluguel: {custoAluguel}");