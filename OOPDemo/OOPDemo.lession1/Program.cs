namespace OOPDemo.lession1;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;
        
        Student student = new Student();
        student.FullName = "John Doe";
        student.Age = 20;
        student.AverageGrade = 9.5;
        
        student.ViewInfor();

        Student[] studentList = new Student[10];
        for (int i = 0; i < studentList.Length; i++)
        {
            studentList[i] = new Student();
            student.FullName = "John Doe" + i;
            student.Age = 18;
            student.AverageGrade = i;
            student.ViewInfor();
        }
    }
}