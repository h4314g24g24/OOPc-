using System;


namespace OOPhm1
{
    public class User
    {

        public string Login { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public int Age { get; set; }
        public DateTime RegistrationDate { get; }

        public User(string login, string firstName, string lastName, int age)
        {
            Login = login;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            RegistrationDate = DateTime.Now;
        }

        public void DisplayUserInfo()
        {
            Console.WriteLine($"User: {Login}, Name: {FirstName} {LastName}, Age: {Age}, Registration Date: {RegistrationDate}");
        }




              


    }
}
