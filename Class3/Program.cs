namespace Class3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student student1 = new Student("Ayxan", "Mustafayev", "P");
            Student student2 = new Student("Fikret", "Huseynov", "P");
            Student student3 = new Student("Huseyn", "Ahadzade", "P");

            Student[] studentarr = { student1, student2, student3 };

            Group group1 = new Group(327, 3, studentarr);

            Student student4 = new Student("Shahin", "Sharifzade", "P");

            group1.AddStudent(student4);
            group1.GetStudents();

        }
    }
}