using System;

class EmployeeData
{
    static void Main()
    {
        string firstName = "John";
        string lastName = "Smith";
        byte age = 34;
        char gender = 'm';

        // Best practice: These numbers should be stored as strings because there is danger of overflowing
        // (also, we don't add or multiply these numbers, so it's useless to have them as integers in a real application)
        ulong idNumber = 8306112507L;
        uint employeeNumber = 27569999;

        Console.WriteLine(
            "First name: {0}\r\nLast name: {1}\r\nAge: {2}\r\nGender: {3}\r\nID number: {4}\r\nEmployee number: {5}",
            firstName, lastName, age, gender, idNumber, employeeNumber);
    }
}