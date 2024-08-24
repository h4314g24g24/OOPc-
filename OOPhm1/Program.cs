using System;


namespace OOPhm1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Використання класу Address
            Address address = new Address(20222, "Ukraine", "Kyiv", "Yordanska Street", 15, 32);
            address.DisplayAddress();

            // Використання класу Converter
            Converter converter = new Converter(41.15, 46.86, 53.77);
            Console.WriteLine($"10000 UAH to USD: {converter.ConvertFromUAH(10000, "usd")}");
            Console.WriteLine($"500 USD to UAH: {converter.ConvertToUAH(500, "usd")}");

            // Використання класу Employee
            Employee employee = new Employee("Oleg ", "Kyshnir ", "developer", 7);
            employee.DisplayEmployeeInfo();

            // Використання класу User
            User user = new User("Oleg333", "Kyshnir", "Ivanov", 30);
            user.DisplayUserInfo();







        }
    }
}
