using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Lista1PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //exercicio 1

            //double m, cm, mm;

            //Console.WriteLine("Digite o valor em metros: ");
            //m = double.Parse(Console.ReadLine());
            //cm = m * 100;
            //mm = m * 1000;
            //Console.WriteLine("O valor em centímetros é: " + cm + " e o valor em milímetros é: " + mm); 

            //exercicio 2, a

            //float c, f;

            //Console.WriteLine("Digite o valor em Fahrenheit: ");
            //f = float.Parse(Console.ReadLine());
            //c = (float)((f - 32.0) * (5.0 / 9.0));
            //Console.WriteLine("O valor em celcius é: " + c); 

            //exercicio 2, b

            //int c, f;

            //Console.WriteLine("Digite o valor em Fahrenheit: ");
            //f = int.Parse(Console.ReadLine());
            //c = (f - 32) * (5 / 9);
            //Console.WriteLine("O valor em celcius é: " + c); 

            //o valor resulta em 0 pois, ao dividir 5 por 9 em numero inteiro, os numeros após a virgula não serao considerados, ao multiplicar um numero por 0, resulta em 0. 

            //exercicio 3

            //double alt, kg, imc;

            //Console.WriteLine("Digite sua altura em metros: ");
            //alt = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite seu peso em kg: ");
            //kg = double.Parse(Console.ReadLine());

            //imc = kg / (alt * alt);

            //Console.WriteLine("O valor de seu imc é: " + imc);

            //exercicio 4

            //double n1, n2, n3, p1, p2, p3, mp;

            //Console.WriteLine("Digite a nota 1: ");
            //n1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite a peso 1: ");
            //p1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite a nota 2: ");
            //n2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite a peso 2: ");
            //p2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite a nota 3: ");
            //n3 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite a peso 3: ");
            //p3 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite a nota 2: ");

            //mp = (n1 * p1 + n2 * p2 + n3 * p3) / (p1 + p2 + p3);

            //Console.WriteLine("O valor da média ponderada é: " + mp);

            //exercicio 5

            //double d, t, v;

            //Console.WriteLine("Digite a distancia em metros: ");
            //d = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o tempo em segundos: ");
            //t = double.Parse(Console.ReadLine());
            //v = d / t;

            //Console.WriteLine("O valor da velocidade é: " + v + "m/s");

            //exercicio 6

            //double s, a;

            //Console.WriteLine("Digite seu salário: ");
            //s = double.Parse(Console.ReadLine());
            //a = s * 0.25 + s;

            //Console.WriteLine("O valor do salário com aumento é: " + a);

            //exercicio 7

            //double d, c, r;

            //Console.WriteLine("Digite o valor em dolares: ");
            //d = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite a cotação do dolar para real: ");
            //c = double.Parse(Console.ReadLine());
            //r = c / d;

            //Console.WriteLine("O valor em reais é: R$" + r);

            //exercicio 8

            //int n, tn, dn, rn;

            //Console.WriteLine("Digite o valor: ");
            //n = int.Parse(Console.ReadLine());
            //rn = (n * 3 + 1) + (n * 2 - 1);

            //Console.WriteLine("O valor é: " + rn);

            //exercicio 9

            //int num, mil, cem, dez, uni;

            //Console.WriteLine("Digite um valor de quatro digitos: ");
            //num = int.Parse(Console.ReadLine());

            //mil = num / 1000;
            //cem = num / 100 - 10 * mil;
            //dez = num / 10 - 100 * mil - 10 * cem;
            //uni = num/ 1 - 1000 * mil - 100 * cem - 10 * dez;

            //Console.WriteLine(mil);
            //Console.WriteLine(cem);
            //Console.WriteLine(dez);
            //Console.WriteLine(uni);

            //double inv, d1, d2, d3, d4, total;

            //inv = 1000;

            //d1 = inv - inv * 0.034;
            //d2 = d1 + d1 * 0.028; 
            //d3 = d2 + d2 * 0.14; 
            //d4 = d3 - d3 * 0.085;

            //total = d4;

            //Console.WriteLine("O valor em reais é: R$" + total);

            //exercicio 11

            //int n, q, c;

            //Console.WriteLine("Digite um numero: ");
            //n = int.Parse(Console.ReadLine());
            //q = n * n;
            //c = q * n;

            //Console.WriteLine("O numero ao quadrado é: " + q + " e o valor ao cubo é: " + c);

            //exercicio 12

            //double h, pih, pim;

            //Console.WriteLine("Digite sua altura: ");
            //h = double.Parse(Console.ReadLine());

            //pih = (72.7 * h) - 58;
            //pim = (62.1 * h) - 44.7;

            //Console.WriteLine("O peso ideal para pessoas do sexo masculino é: " + pih + " e para pessoas do sexo feminino é: " + pim);

            //exercicio 13

            //O Git é um sistema de controle de versões distribuído, usado no desenvolvimento de software e  para registrar o histórico de edições de qualquer tipo de arquivo.
            //O GitHub é uma plataforma de hospedagem de código fonte e arquivos com controle de versão usando o Git.

            //1- Git Clone: Git clone é uma comando para baixar o código-fonte existente de um repositório remoto.
            //2- Git Branch: Usando as branches, vários desenvolvedores conseguem trabalhar em paralelo no mesmo projeto simultaneamente.
            //3- Git Checkout: Usamos git checkout, na maioria dos casos, para trocar de uma branch para outra.
            //4- Git Status: O comando git status nos dá todas as informações necessárias sobre a branch atual.
            //5- Git Add: Precisamos usar o comando git add para incluir as alterações de um ou vários arquivos em nosso próximo commit.
            //6- Git Commit: Este comando é utilizado para definir um ponto de verificação no processo de desenvolvimento.
            //7- Git Push: Git Push faz o upload dos seus commits no repositório remoto.
            //8- Git Pull: O comando git pull é usado para obter as atualizações de um repositório remoto.
            //9- Git Revert: O git revert é utilizado para desfazer as commits.
            //10- Git Merge: Este comando integra sua branch com o recurso e todos os seus commits na branch de desenvolvimento ou na branch principal.


        }
    }
}
