namespace StaticExercise
{
    public class Program
    {
       public static void Main(string[] args)
        { Console.WriteLine("Tell me a temprature Farenheit");
            var x = double.Parse(Console.ReadLine());
            var z =TempConverter.FarenheitToCelcius(x);
            Console.WriteLine($"converted {x}farenheit to{z}celcius ");

            Console.WriteLine("Tell me a temprature Celcius");
            var y = double.Parse(Console.ReadLine());
            var v = TempConverter.CelciusToFarenheit(y);
            Console.WriteLine($"converted {y}celcius to{v}farenheit");
        }
    }
}
