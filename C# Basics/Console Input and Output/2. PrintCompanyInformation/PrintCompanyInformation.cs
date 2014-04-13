using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Company address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Phone number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Fax number: ");
        string faxNumber = Console.ReadLine();
        Console.Write("Web site: ");
        string webSite = Console.ReadLine();
        Console.Write("Manager first name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Manager last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Manager age: ");
        uint managerAge = uint.Parse(Console.ReadLine());
        Console.Write("Manager phone: ");
        string managerPhone = Console.ReadLine();

        Console.WriteLine("{0}\r\nAddress: {1}", companyName, companyAddress);
        Console.WriteLine("Tel.: {0}", string.IsNullOrWhiteSpace(phoneNumber) ? "(no phone)" : phoneNumber);
        Console.WriteLine("Fax: {0}", string.IsNullOrWhiteSpace(faxNumber) ? "(no fax)" : faxNumber);
        Console.WriteLine("Web site: {0}", string.IsNullOrWhiteSpace(webSite) ? "(no web site)" : webSite);
        Console.WriteLine("Manager: {0}(age: {1}, tel. {2})", managerFirstName + " " + managerLastName, managerAge, managerPhone);

    }
}