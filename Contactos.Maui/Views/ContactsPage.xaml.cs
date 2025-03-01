using Contactos.Maui.Models;
using Contact = Contactos.Maui.Models.Contact;

namespace Contactos.Maui.Views;

public partial class ContactsPage : ContentPage
{
	public ContactsPage()
	{




		List<Contact> contacts = ContactRepository.GetContacts();
		
        InitializeComponent();
        listContacts.ItemsSource = contacts;

       
    }

	

    private async void listContacts_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
		if (listContacts.SelectedItem != null)
		{
			//DisplayAlert("test", "test", "OK");

			await Shell.Current.GoToAsync(
                $"{nameof(EditContactPage)}?Id={((Contact)listContacts.SelectedItem).ContactId}");
		}
		
    }

    private void listContacts_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        listContacts.SelectedItem = null;
    }
}