namespace Variable;

class Program
{
    static void Main(string[] args)
    {
        int radius = 4; //index 0
        const double PI = 3.14159; //index 1
        double circum, area;
        
        area = PI * radius * radius; //index 0
        circum = 2 * PI * radius; //index 0
        
        //in kết quả
        Console.WriteLine("Ban Kinh = {0}, PI = {1}", radius, PI);
        Console.WriteLine("Dien tich {0}", area);
        Console.WriteLine("Chu vi {0}", circum);
    }
}