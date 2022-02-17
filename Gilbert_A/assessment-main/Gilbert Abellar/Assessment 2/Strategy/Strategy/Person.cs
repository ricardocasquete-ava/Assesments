namespace Strategy;

[ClassInterface(ClassInterfaceType.None)]
public class Person : IPerson
{
    public Person(string name, int age, Gender gender)
    {
        Name = name;
        Age = age;
        Gender = gender;
    }

    public string Name { get; set; } = string.Empty;

    public int Age { get; set; } = 0;

    public Gender Gender { get; set; } = Gender.Male;
}