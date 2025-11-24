using AddressBook.Application.Services;
using AddressBook.Core.Models;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To AddressBook!");


            var service = new AddressBookService();

            Console.WriteLine("**************\n \t Add a Contact \n*************");

            var contact = new Contact();

            Console.Write("First Name: ");
            contact.FirstName = Console.ReadLine();

            Console.Write("Last Name: ");
            contact.LastName = Console.ReadLine();

            Console.Write("Address: ");
            contact.Address = Console.ReadLine();

            Console.Write("City: ");
            contact.City = Console.ReadLine();

            Console.Write("State: ");
            contact.State = Console.ReadLine();

            Console.Write("Zip: ");
            contact.Zip = Console.ReadLine();

            Console.Write("Phone Number: ");
            contact.PhoneNumber = Console.ReadLine();

            Console.Write("Email: ");
            contact.Email = Console.ReadLine();

            service.AddContact(contact);

            Console.WriteLine("\nContact Added Successfully!");
        }
    }
}
