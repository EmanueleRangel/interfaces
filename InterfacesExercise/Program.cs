using System.Globalization;
using InterfacesExercise.Entities;
using InterfacesExercise.Services;


Console.WriteLine("Enter contract data");
Console.Write("Number: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Date: ");
DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
Console.Write("Contract value: ");
double totalValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("Enter the number of installments: ");
int months = int.Parse(Console.ReadLine());

Contract contract = new Contract(number, date, totalValue);

ContractService contractService = new ContractService(new PaypalService());
contractService.ProcessContract(contract, months);

Console.Write("Installments: ");
foreach (Installment installment in contract.Installments)
{
    Console.WriteLine(installment);
}







