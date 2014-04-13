using System;

class BankAccountData
{
    static void Main()
    {
        string firstName = "John";
        string middleName = "Jones";
        string lastName = "Smith";
        decimal balance = 1000.0M;
        string bankName = "Bank of UK";

        // The IBAN and credit card numbers are taken from online examples
        string iban = "GB29 RBOS 6016 1331 9268 19";
        string creditCard1 = "5482 8548 4580 1667";
        string creditCard2 = "5103 7461 5547 4060";
        string creditCard3 = "5555 6820 0808 9834";

        Console.WriteLine(
            "First name: {0}\r\nMiddle name: {1}\r\nLast name: {2}\r\nBalance: {3}\r\nBank name: {4}\r\nIBAN: {5}\r\nCredit card 1: {6}\r\nCredit card 2: {7}\r\nCredit card 3: {8}",
            firstName, middleName, lastName, balance, bankName, iban, creditCard1, creditCard2, creditCard3);
    }
}