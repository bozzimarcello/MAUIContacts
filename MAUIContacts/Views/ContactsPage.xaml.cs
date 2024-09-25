namespace MAUIContacts.Views;

public partial class ContactsPage : ContentPage
{
    public ContactsPage()
    {
        InitializeComponent();
        List<Contact> contacts = new List<Contact>()
        {
            new Contact { Name = "Pino", Email = "pino@email.com" },
            new Contact { Name = "Gino", Email = "gino@email.com" },
            new Contact { Name = "Lino", Email = "lino@email.com" },
        };
        LstContacts.ItemsSource = contacts;
    }

}

public class Contact
{
    public string Name { get; set; }
    public string Email { get; set; }
}