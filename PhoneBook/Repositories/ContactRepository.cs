public class ContactRepository
{
    private readonly List<Contact> _contacts = new();
    // не разбирам много new() без тип - учителят каза че компилаторът сам го разбира от List<Contact>
    // а readonly значи че списъкът не може да се замени с друг, но може да му се добавят неща

    public void Add(Contact contact)
    {
        _contacts.Add(contact);
    }

    public List<Contact> Search(string text)
    {
        List<Contact> result = new();
        foreach (Contact contact in _contacts)
        {
            // това е сложното: StringComparison.OrdinalIgnoreCase не го разбирам напълно
            // но е за да не пречат главни и малки букви (иван и Иван да са едно и също)
            if (contact.Name.Contains(text, StringComparison.OrdinalIgnoreCase))
            {
                result.Add(contact);
            }
        }
        return result;
    }
}
