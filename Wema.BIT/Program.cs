using System;

// Think of a namespace like a folder or a category that helps organize things. Here, we put our blueprints for people
// (User class) and payments (Payment class) into a namespace called Wema.BIT.User

namespace Wema.BIT.User
{
    public class User
    {
        // Properties (Here, we're defining a blueprint (a class) for a person. This person has properties like ID,
        // first name, last name, and email. )
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        // Constructor (This part is like a special set of instructions that say, "When we create a new person, we
        // need to give them an ID, first name, last name, and email.")
        public User(int id, string firstName, string lastName, string email)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        // Method to display user information (This is a set of instructions for our person to introduce themselves. It's
        // like saying, "When a person is asked to show their information, they should say their ID, name, and email.")
        public void DisplayUserInfo()
        {
            Console.WriteLine($"User ID: {ID}");
            Console.WriteLine($"Name: {FirstName} {LastName}");
            Console.WriteLine($"Email: {Email}");
        }
    }

    public class Payment
    {
        // Properties ( Similar to the person, this is a blueprint for a payment. Payments have
        // properties like ID and Amount.)
        public int ID { get; set; }
        public decimal Amount { get; set; }

        // Constructor (This is the set of instructions for creating a payment. It says,
        // "When we create a new payment, we need to give it an ID and an amount.")
        public Payment(int id, decimal amount)
        {
            ID = id;
            Amount = amount;
        }

        // Method to display payment information (Like the person, this is a set of instructions
        // for a payment to show its details. It's like saying, "When a payment is asked to show
        // its information, it should say its ID and amount.")
        public void DisplayPaymentInfo()
        {
            Console.WriteLine($"Payment ID: {ID}");
            Console.WriteLine($"Amount: ${Amount}");
        }
    }

    // (Here we're starting the main part of our program. It's like the beginning of our story.)
    class Program 
    {
        static void Main()
        //( Here we're creating a list of people (using our person blueprint). It's like saying,
        //"Let's make a list of five people with different names and emails.")
        {
            List<User> users = new List<User>
            {
                new User(1, "John", "Doe", "john.doe@example.com"),
                new User(2, "Jane", "Smith", "jane.smith@example.com"),
                new User(3, "Bob", "Johnson", "bob.johnson@example.com"),
                new User(4, "Alice", "Williams", "alice.williams@example.com"),
                new User(5, "Charlie", "Brown", "charlie.brown@example.com"),
            };

            // Display user information (This is a loop that goes through each person
            // in the list and asks them to show their information. It's like saying,
            // "Let's go through the list of people and have each one introduce themselves.")

            foreach (User user in users)
            {
                user.DisplayUserInfo();
                Console.WriteLine();
            }

            // This prints an empty line, just for a bit of separation in our output.

            Console.WriteLine();

            // Example usage with a list of payments ( Similar to people, here we're creating a list of payments.
            // It's like saying, "Now, let's make a list of five payments with different amounts.")

            List<Payment> payments = new List<Payment>
            {
                new Payment(101, 500.75m),
                new Payment(102, 300.50m),
                new Payment(103, 750.25m),
                new Payment(104, 100.00m),
                new Payment(105, 1200.00m),
            };

            // Display payment information ( This is another loop that goes through each payment in the list and
            // asks them to show their information. It's like saying "Now, let's go through the list of payments and
            // see how much money each one represents.")

            foreach (Payment payment in payments)
            {
                payment.DisplayPaymentInfo();
                Console.WriteLine();
            }
        }
    }
}

