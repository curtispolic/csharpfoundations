namespace csharpfoundations
{
	public class BasicNumberOperations
	{
		public static void Run()
		{
			// Int operations
			int firstNumber = 18;
			int secondNumber = 6;

			Console.WriteLine(firstNumber + secondNumber);

			// Implication of string conversion during concatenation
			Console.WriteLine("Bob has " + firstNumber + " widgets.");
			Console.WriteLine("Bob has " + firstNumber + 7 + " widgets");
            Console.WriteLine("Bob has " + (firstNumber + 7) + " widgets");

            // Casting to use decimal division
            int first = 7;
            int second = 5;
            decimal quotient = (decimal)first / (decimal)second;
            Console.WriteLine(quotient);
            // Technically only first OR second needs to be cast, the compiler will do some lifting

            // Modulus operand
            Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
            Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

            // This is the part where it teaches me BODMAS (PEMDAS in the tutorial)
            int firstExpression = 3 + 4 * 5;
            int secondExpression = (3 + 4) * 5;
            Console.WriteLine(firstExpression);
            Console.WriteLine(secondExpression);

            // Teaches increments and decrements
            int value = 12;
            value++;
            Console.WriteLine(value);
            value--;
            Console.WriteLine(value);

            // Doing them before or after
            // This will print then increment
            Console.WriteLine(value++);
            // This will increment then print
            Console.WriteLine(++value);


            // Below is the challenge code:
            // Challenge is to convert degrees F to C
            // I'll also convert another value back
            int fahrenheit = 94;
            decimal fahrenheitToCelsius = ((decimal)fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"{fahrenheit} degrees F is {Math.Round(fahrenheitToCelsius, 1)} degrees C");

            int celsius = 12;
            decimal celsiusToFahrenheit = (decimal)celsius * 9 / 5 + 32;
            Console.WriteLine($"{celsius} degrees C is {Math.Round(celsiusToFahrenheit, 1)} degrees F");


        }
	}
}

