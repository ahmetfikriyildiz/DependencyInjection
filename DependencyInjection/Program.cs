public interface ITeacher
{
    string FirstName { get; set; }
    string LastName { get; set; }
    string GetInfo();

}
public class Teacher(string firstName, string lastName) : ITeacher
{
    public string FirstName { get; set; } = firstName;
    public string LastName { get; set; } = lastName;

    public string GetInfo()
    {
        return $"{FirstName} {LastName}";
    }
}
public class ClassRoom(ITeacher teacher)
{
    private readonly ITeacher _teacher = teacher;

    public string GetTeacherInfo()
    {
        return _teacher.GetInfo();
    }
}

class Program
{
    static void Main(string[] args)
    {
        ITeacher teacher = new Teacher("Ahmet Fikri", "Yıldız");

        ClassRoom classRoom = new ClassRoom(teacher);

        Console.WriteLine("Öğretmen Bilgileri " + classRoom.GetTeacherInfo());
    }
}
