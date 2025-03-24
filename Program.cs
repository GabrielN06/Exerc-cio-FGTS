double salario, fgts;
Console.Write("Digite o salário para calcular o FGTS: (R$)..:");

salario = Convert.ToDouble(Console.ReadLine());
fgts = salario * 0.08;

Console.WriteLine($"\nFGTS: R${fgts:F2} ");



