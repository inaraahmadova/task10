namespace task10
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Student student1 = new Student("inara", "ahmadova", "ab106", 85);
            student1.GetInfo();
            student1.CheckGraduated();
            student1.GetDiplomDegree();
        }
    }
}
