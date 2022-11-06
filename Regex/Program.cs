using System.Text.RegularExpressions;

object[] users = new object[0];

Console.WriteLine("\t\t\tRegister\n");
tryagain:
string username, name, surname, age, phoneNumber, email, password;
Console.Write("Enter Username: ");
username = Console.ReadLine();
Console.Write("Enter Name: ");
name = Console.ReadLine();
Console.Write("Enter Surname: ");
surname = Console.ReadLine();
Console.Write("Enter Age: ");
age = Console.ReadLine();
Console.Write("Enter Phonenumber: ");
phoneNumber = Console.ReadLine();
Console.Write("Enter Email: ");
email = Console.ReadLine();
Console.Write("Enter Password: ");
password = Console.ReadLine();
var Register = new { username, name, surname, age, phoneNumber, email, password };

Regex regexNames = new Regex(@"^[A-Z][a-z]{1,20}");
Regex regexUsername = new Regex(@"[a-z]+\S");
Regex regexEmail = new Regex(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$");
Regex regexPhoneNumber = new Regex(@"^(\+994)\-\d{2}\-\d{3}\-\d{2}\-\d{2}");
Regex regexAge = new Regex(@"\d{1,200}");
Match match1 = regexNames.Match(surname);
Match match2 = regexNames.Match(name);
Match match3 = regexUsername.Match(username);
Match match4 = regexEmail.Match(email);
Match match5 = regexPhoneNumber.Match(phoneNumber);
Match match6 = regexAge.Match(age);



int count = 0;

for (int i = 0; i < users.Length; i++)
{
    if (users[i] == Register.username)
    {
        count = +1;
    }
}

if (match1.Success && match2.Success && match3.Success && match4.Success && match5.Success && match6.Success && count == 0)
{

    Console.WriteLine("Success");


    Array.Resize(ref users, users.Length + 1);
    users[users.Length - 1] = Register;
    Console.WriteLine($"Username : {users}");

}
else
{
    Console.WriteLine("Incorrect!");
    goto tryagain;
}