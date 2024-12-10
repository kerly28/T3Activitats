public class Animal
{
    private string name;
    private int age;

    public string GetName() { return name; }
    public int GetAge() { return age; }

    public void SetName(string name) { this.name = name; }
    public void SetAge(int age) { this.age = age; }

    // Constructor
    public Animal(string name, int age)
    {
        SetName(name);
        SetAge(age);
    }
}