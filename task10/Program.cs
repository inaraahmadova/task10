namespace task10
{
    class Program
    {
        class Student
        {
            public string Name;
            public string Surname;
            public string Group;
            public int Point;
            public bool isGraduated;

            public Student(string name, string surname, string group, int point)
            {
                Name = name;
                Surname = surname;
                Group = group;
                Point = point;
                isGraduated = point >= 65;
            }
            public void GetInfo()
            {
                Console.WriteLine($"{Name} {Surname} {Group} {Point}bal");
            }
            public void CheckGraduated()
            {
                if (isGraduated)
                {
                    Console.WriteLine($"{Name} mezun olub.");
                }
                else
                {
                    Console.WriteLine($"{Name} mezun olmuyub.");
                }
            }
            public void GetDiplomDegree()
            {
                if (Point < 65)
                {
                    Console.WriteLine("diplom yoxdur.");
                }
                else if (Point >= 65 && Point < 80)
                {
                    Console.WriteLine("adi diplom.");
                }
                else if (Point >= 80 && Point < 90)
                {
                    Console.WriteLine("sheref diplomu.");
                }
                else
                {
                    Console.WriteLine("yuksek sheref diplomu.");
                }
            }
        }
        static void Main(string[] args)
        {
            Student student1 = new Student("inara", "ahmadova", "ab106", 85);
            student1.GetInfo();
            student1.CheckGraduated();
            student1.GetDiplomDegree();
        }
    }
}
