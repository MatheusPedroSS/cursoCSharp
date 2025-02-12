﻿using System;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            // Area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            //PI = 3.1415;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é " + area);

            // Tipos internos

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo? " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade: " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo Gols: " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário: " + salario);

            int menorValorInt = int.MinValue;
            Console.WriteLine("Menor valor Inteiro: " + menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População Brasileira: " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor Long: " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População Mundial: " + populacaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine("Preço do Computador: " + precoComputador);

            double valorDeMercadoApple = 1_000_000_000_000.00;
            Console.WriteLine("Valor de mercado Apple: " + valorDeMercadoApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distancia entre as Estrelas: " + distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra: " + letra);

            string texto = "Seja bem vindo ao curso de C#!";
            Console.WriteLine(texto);
        }
    }
}