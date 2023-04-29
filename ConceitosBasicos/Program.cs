// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Xml.Serialization;

inicio:

int escolha;



    Console.WriteLine("\n ===== Menu Principal ===== \n");
    Console.WriteLine("0 - encerrar o programa");
    Console.WriteLine("1 - Somar 2 números");
    Console.WriteLine("2 - transformar metros em milimetros");
    Console.WriteLine("3 - calcular o aumento");
    Console.WriteLine("4 - calcular o desconto");
    Console.WriteLine("5 - calcular o aluguel do carro");
    Console.WriteLine("6 - calcular o IMC");
    Console.WriteLine("7 - calcular o tabuada");
    Console.WriteLine("8 - Multiplos de 3");
    Console.WriteLine("9 - Calcular Fatorial");
    Console.WriteLine("10 - Calcular o imposto de renda");
    Console.WriteLine("11 - Adivinhar um numero ");
    Console.WriteLine("12 - Financiamento");
    Console.WriteLine("13 - Aposentadoria");
    Console.WriteLine("Digite o numero da sua opção: ");
    string res = Console.ReadLine();
    escolha = int.Parse(res);


    switch (escolha)
    {
      case 0:
        Console.Clear();
        Console.WriteLine("Fim do programa");
        return;
      case 1:
        int num1, num2, soma;
        Console.WriteLine("Digite um numero: ");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite outro numero: ");
        num2 = int.Parse(Console.ReadLine());

        soma = num1 + num2;

        Console.WriteLine("O resultado da soma foi {0}",soma);

        break;

      case 2:
        

        Console.WriteLine("Informe o valor em metro ");
        float metro = float.Parse(Console.ReadLine());
        Console.WriteLine("O valor informado em  metro foi : " + metro);
        double milimetros = metro * 1000;
        Console.WriteLine($"Valor informado em milimetros foi " + milimetros);
        break;

      case 3:
        Console.WriteLine("Informe o salario ");
        double recebido = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe percentual de aumento");
        double porceaumento = double.Parse(Console.ReadLine()) / 100;
        double perceaumento = (double)(recebido * porceaumento);
        Console.WriteLine("Percentual de aumento é " + perceaumento);
        double novosalario = (double)(recebido + perceaumento);
        Console.WriteLine("Valor do novo salario é " + novosalario);
        Console.WriteLine("Salario inicial é " + recebido);

        break;
      case 4:
        Console.WriteLine("Informe o valor ");
        float dindin = float.Parse(Console.ReadLine());
        Console.WriteLine("Informe a porcentagem do desconto");
        float desconto = float.Parse(Console.ReadLine());
        float Vdesconto = dindin - (dindin * desconto) / 100;
        Console.WriteLine("Valor com desconto igual a " + Vdesconto);
        Console.WriteLine("Valor sem desconto " + dindin);
        Console.WriteLine("Desconto foi de " + desconto + "%");
        break;

      case 5:
        Console.WriteLine("Informe o numero de dias ");
        byte ndias = byte.Parse(Console.ReadLine());
        Console.WriteLine("Informe Quilometro inicial");
        byte kminicial = byte.Parse(Console.ReadLine());
        Console.WriteLine("Informe Quilometro Final");
        byte quilometrofinal = byte.Parse(Console.ReadLine());

        int valperdia = (int)(ndias * 95);
        double valorporquilometro = (double)(quilometrofinal - kminicial) * 0.35;
        double valortotal = (double)(valorporquilometro + valperdia);
        Console.WriteLine("Valor a ser pago é :" + valortotal);
        break;

      case 6:
        Console.WriteLine("Informe a altura em metros : ");
        float altura = float.Parse(Console.ReadLine());
        Console.WriteLine("Informe o peso em kg : ");
        float peso = float.Parse(Console.ReadLine());
        float imc = peso / (altura * altura);
        Console.WriteLine("Imc igual:" + imc);
        if (imc < 18.5)
        {
            Console.WriteLine("Abaixo do peso");
        }
        else if (imc <= 24.9)
        {
            Console.WriteLine("Peso ideal");
        }
        else if (imc <= 29.9)
        {
            Console.WriteLine("Um pouco acima do peso");
        }
        else if (imc <= 34.9)
        {
            Console.WriteLine("Obesidade grau 1");
        }
        else if (imc <= 39.9)
        {
            Console.WriteLine("Obesidade grau 2");
        }
        else if (imc >= 40)
        {
            Console.WriteLine("Obesidade grau 3, bora perder essa barriga.");
        }
        break;

       
      case 7:
        int forma, contas, numer;

        Console.Write("Digite o Numero para executar a tabuada dele : ");
        numer = int.Parse(Console.ReadLine());

        for (contas = 1; contas <= 10; ++contas)
        {
            forma = numer * contas;
            Console.WriteLine(numer + " X " + contas + " = " + forma);
        }
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
        break;

      case 8:
        float[] multi3 = new float[101];
        multi3[0] = 3;
        int contador = 0;

        for (int i = 1; i < multi3.Length; i++)
        {
            multi3[i] = i * 3;
            if (multi3[i] % 3 == 0)
            {
                Console.WriteLine("É múltiplo de 3: " + multi3[i]);
                contador++;
            }
        }

        Console.WriteLine("Total de múltiplos de 3: " + contador);
        Console.WriteLine("Esses são os múltiplos de 3");
        break;

      case 9:
        float[] fatorar = new float[11];
        fatorar[0] = 1;

        for (int i = 1; i < fatorar.Length; i++)
        {
            fatorar[i] = fatorar[i - 1] * i;
            Console.WriteLine($"O fatorial de {i} é {fatorar[i]}");
        }
        break;

      case 10:
        Console.WriteLine("Informe um salario");
        double salBruto = double.Parse(Console.ReadLine());
        if (salBruto < 1903.93)
        {
            Console.WriteLine("Não recebe desconto");
        }
        else if (salBruto <= 2826.65)
        {
            double perdes = 7.5 / 100;
            double Salariocomdesconto = salBruto - (salBruto * perdes);
            Console.WriteLine("Salario com desconto igual a " + Salariocomdesconto);
        }
        else if (salBruto <= 3751.05)
        {
            double porcentagemdedesconto = 15.0 / 100;
            double salariocomdesconto = salBruto - (salBruto * porcentagemdedesconto);
            Console.WriteLine("Salario com desconto igual a " + salariocomdesconto);
            var valordaporcentagem = (salBruto * porcentagemdedesconto);
            double valorapagar = valordaporcentagem - 142.80;
            Console.WriteLine("Valor a pagar = " + valorapagar);
        }
        else if (salBruto <= 4664.68)
        {
            double porcentagemdedesconto = 22.5 / 100;
            double salariocomdesconto = salBruto - (salBruto * porcentagemdedesconto);
            Console.WriteLine("Salario com desconto igual a " + salariocomdesconto);
            var valordaporcentagem = (salBruto * porcentagemdedesconto);
            double valorapagar = valordaporcentagem - 142.80;
            Console.WriteLine("Valor a pagar = " + valorapagar);

        }
        else if (salBruto > 4664.68)
        {
            double porcentagemdedesconto = 27.5 / 100;
            double salariocomdesconto = salBruto - (salBruto * porcentagemdedesconto);
            Console.WriteLine("Salario com desconto igual a " + salariocomdesconto);
            var valordaporcentagem = (salBruto * porcentagemdedesconto);
            double valorapagar = valordaporcentagem - 142.80;
            Console.WriteLine("Valor a pagar = " + valorapagar);
        }
        break;

      case 11:
        int tentando = 0;
        int num = 0;
        Random r = new Random();
        int a = r.Next(0, 100);
        while (true)
        {
            tentando++;
            Console.WriteLine("Adivinhe o número!");
            try
            {
                num = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Por favor, digite um número inteiro.");
                continue; // isso volta pra o início do loop
            }
            if (num < a) { Console.WriteLine("Maior..."); }
            else if (num > a) { Console.WriteLine("Menor..."); }
            if (tentando >= 10)
            {
                Console.WriteLine("Você errou!");
                Console.WriteLine("O número era " + a);
                break;
            }
            if (num == a)
            {
                Console.WriteLine("Acertou!");
                Console.WriteLine("\nDepois de {0} tentativas.", tentando);
                break;
            }
        }
        break;

      case 12:
        Console.WriteLine("Informe o valor do veiculo");
        double valVeiculo = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe o numero de parcelas");
        double NumParcelas = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe taxa mensal ");
        double taxamensal = double.Parse(Console.ReadLine()) / 100;

        double jurosSimples = valVeiculo * taxamensal * NumParcelas;
        double jurosCompostos = valVeiculo * Math.Pow(1 + taxamensal, NumParcelas) - valVeiculo;

        double valorTotalJurosSimples = valVeiculo + jurosSimples;
        double valorTotalJurosCompostos = valVeiculo + jurosCompostos;

        Console.WriteLine("Valor do Veiculo Total com juros simples: " + valorTotalJurosSimples);
        Console.WriteLine("Valor do Veiculo Total com juros compostos: " + valorTotalJurosCompostos);


        break;

       case 13:
        Console.WriteLine("Informe a sua idade");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe a idade que quer se aposentar");
        int finalage = int.Parse(Console.ReadLine());
        Console.WriteLine("Valor para aposentadoria");
        float valaposenta = float.Parse(Console.ReadLine());
        Console.WriteLine("Qual sua taxa de rendimento");
        float taxarendimento = float.Parse(Console.ReadLine()) / 100;
        float anosrendimento = (finalage - age) * 12;
        for (int i = 0; i < anosrendimento; i++)
        {
            valaposenta *= 1 + taxarendimento;
        }
        float dinheiro = valaposenta;
        float juros = dinheiro - valaposenta;
        float juroscompostos = valaposenta + juros;

        Console.WriteLine("Juros compostos igual a " + juroscompostos);
        Console.WriteLine("Juros igual a " + (juros / 12));
        Console.WriteLine("valor mais juros " + (dinheiro / 12));
        break;

        
}
decisao:
char cont;

Console.WriteLine("Quer continuar? [s/n]");
cont = char.Parse(Console.ReadLine()); 

if(cont == 'n')
{
    Console.WriteLine("Fim do programa");
}
else if (cont == 's')
 {
    goto inicio;

}
else if (cont != 's')
{
    Console.WriteLine("Tente novamente.");
    goto decisao;
}


