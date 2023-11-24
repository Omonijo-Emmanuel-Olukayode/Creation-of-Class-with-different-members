using System;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }

    public Person(string name, int age, string address, string email)
    {
        Name = name;
        Age = age;
        Address = address;
        Email = email;
    }

    public void Greet()
    {
        Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
        Console.WriteLine($"I live at {Address} and my email is {Email}.");
    }

    public void UpdateInformation(string newAddress, string newEmail)
    {
        Address = newAddress;
        Email = newEmail;
        Console.WriteLine("Information updated.");
    }
}

class Program
{
    static void Main()
    {
        // Example usage
        // Creating instances of the Person class
        Person person1 = new Person("Emmanuel", 25, "123 Main St", "Emmanuel14@example.com");
        Person person2 = new Person("Olukayode", 30, "456 Oak St", "Olukayode23@example.com");

        // Greeting
        Console.WriteLine("Initial Information:");
        person1.Greet();
        person2.Greet();

        // Update information for person1
        Console.WriteLine("\nUpdating Information for Person 1:");
        person1.UpdateInformation("789 Pine St", "john.new@example.com");
        person1.Greet();
    }
}
