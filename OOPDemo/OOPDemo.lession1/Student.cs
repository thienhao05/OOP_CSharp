namespace OOPDemo.lession1;

public class Student
{
    public string FullName;
    public int Age;
    public double AverageGrade;

    public void ViewInfor()
    {
        Console.WriteLine($"Full name: {FullName}\n" + 
                          $"Age: {Age}\n" + 
                          $"Distinction Student:  {DisStu()}\n" +
                          $"Average: {AverageGrade}");
    }

    public string DisStu()
    {
        if (AverageGrade >= 8) return "Excellent / Very good";
        else if(AverageGrade >= 7) return "Good";
        else if (AverageGrade >= 5) return "Average";
        return "Weak";
    }
    
}