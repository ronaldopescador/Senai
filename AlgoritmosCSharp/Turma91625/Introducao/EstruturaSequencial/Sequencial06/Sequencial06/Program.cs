// Leitura do peso do prato montado 
Console.Write("Digite o peso do prato montado (sem o peso do prato): ");
double pesoPrato = Convert.ToDouble(Console.ReadLine());

// Cálculo do valor total a pagar
double totalPagar = pesoPrato * 12.00;

// Exibição do valor total a pagar
Console.WriteLine($"O valor a pagar é de {totalPagar:F2}.");
