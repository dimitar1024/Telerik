using System;
class PrintCompanyInformation
{
    static void Main()
    {
        string companyName = Console.ReadLine();
        string companyAddress = Console.ReadLine();
        ulong phoneNumber = ulong.Parse(Console.ReadLine());
        ulong? faxNumber = ulong.Parse(Console.ReadLine());

        string website = Console.ReadLine();
        string managerFirstName = Console.ReadLine();
        string managerLastName = Console.ReadLine();
        byte managerAge = byte.Parse(Console.ReadLine());
        ulong managerPhone = uint.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine(companyName);
        Console.WriteLine("Address: {0}", companyAddress);
        Console.WriteLine("Tel: +{0:### ### ## ## ##}", phoneNumber);
        Console.WriteLine("Fax: +{0:### ### ## ## ##}", faxNumber);
        Console.WriteLine("          Web site: {0}", website);
        Console.Write("Manager: {0} {1} ( age: {2} tel. +{3:### ### ## ## ##})", managerFirstName, managerLastName, managerAge, managerPhone);

    }
}
