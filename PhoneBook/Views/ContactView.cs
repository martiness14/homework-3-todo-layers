public class ContactView
{
    public void ShowMenu()
    {
        Console.WriteLine("1. добави контакт");
        Console.WriteLine("2. търси контакт");
        Console.WriteLine("0. изход");
        Console.Write("избор: ");
    }

    public string ReadChoice()
    {
        // не разбирам ?? "" - значи че ако ReadLine върне null (нищо), да се върне празен текст
        return Console.ReadLine() ?? "";
    }

    public string Ask(string prompt)
    {
        Console.Write(prompt + ": ");
        return Console.ReadLine() ?? "";
    }

    // не разбирам защо контролерът вика View а не печата сам - казаха че View само показва и въвежда
    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }

    public void ShowContacts(List<Contact> contacts)
    {
        if (contacts.Count == 0)
        {
            Console.WriteLine("Няма намерени контакти.");
            return;
        }
        foreach (Contact contact in contacts)
        {
            Console.WriteLine(contact.Name + " - " + contact.Phone);
        }
    }
}
