
/* Calculadora de hipostenusas
 Console.WriteLine("Introduce el valor del primer cateto");
double primerCateto = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Introduce el valor del segundo cateto");
double segundoCateto = Convert.ToDouble(Console.ReadLine());

double resultado = Math.Sqrt((primerCateto * primerCateto) + (segundoCateto * segundoCateto));


Console.WriteLine(resultado);
*/


/*Number guessing
 Random rd = new Random();


int number =  rd.Next(100);
int answer = -1;
int counter = 0;

while (true)
{
    Console.WriteLine("Insert a new number please");
    answer = Convert.ToInt32(Console.ReadLine());
    counter++;

    if (answer == number)
    {
        Console.WriteLine($"Your number: {answer} is correct");
        break;
    }else if(number > answer)
    {
        Console.WriteLine($"Your number:{answer} is lower");
    }else if (number < answer)
    {
        Console.WriteLine($"Your number: {answer} is greater");
    }
    Console.WriteLine("");
}
Console.WriteLine($"Your attempts are {counter}");
 */

/* Rock Paper Scissors
 Console.WriteLine("Enter the following numbers to pick one option:");
Console.WriteLine("1.Rock");
Console.WriteLine("2.Paper");
Console.WriteLine("3.Scissors");

int player = Convert.ToInt32(Console.ReadLine());

Random random = new Random();
int computer = random.Next(1, 3);

string result = "";

switch (player)
{
    case 1:
        switch (computer)
        {
            case 1:
                result = "Draw with rocks";
                break;

            case 2:
                result = "Computers Wins with Paper";
                break;

            case 3:
                result = "Player Wins with Rock";
                break;
        }
        break;

    case 2:
        switch (computer)
        {
            case 1:
                result = "Computer Wins with Rock";
                break;

            case 2:
                result = "Draw with Paper";
                break;

            case 3:
                result = "Computer Wins with Scissors";
                break;
        }
        break;

    case 3:
        switch (computer)
        {
            case 1:
                result = "Computer Wins with Rock";
                break;

            case 2:
                result = "Player wins with Scissors";
                break;

            case 3:
                result = "Draw with Scissors";
                break;
        }
        break;
    default:
        Console.WriteLine("Please enter a valid option.(1/2/3)");
        break;
}

Console.WriteLine(result);

 */

/*Calculator
 
try
{

    Console.WriteLine("Enter the first value: ");
    double firstValue = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter the second value: ");
    double secondValue = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter the option that you want to complete: ");
    Console.WriteLine("* / + - %");
    string operation = Console.ReadLine();

    double result = 0;
    switch (operation)
    {
        case "*":
            result = firstValue * secondValue;
            break;
        case "/":
            result = firstValue / secondValue;
            break;
        case "+":
            result = firstValue + secondValue;
            break;
        case "-":
            result = firstValue - secondValue;
            break;
        case "%":
            result = firstValue % secondValue;
            break;
        default:
            Console.WriteLine("Please enter a valid operation (* / + - %)");
            break;
    }
    Console.WriteLine($"Your result is: {result}");
}
catch (Exception ex)
{
    Console.WriteLine("Please enter a valid number");
}
 */


