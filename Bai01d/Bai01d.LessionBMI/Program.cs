namespace Bai01d.LessionBMI;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        double weight = 0;
        double height = 0;
        
        Console.Write("Input weight(kg): ");
        weight = double.Parse(Console.ReadLine());
        
        Console.Write("Input height(cm): ");
        height = double.Parse(Console.ReadLine());
        
        double bmi = weight / (height * height);
        
        Console.WriteLine("BMI = {0}", bmi);
        
        Console.WriteLine("Input random key to exit");
        Console.ReadKey();
    }
}