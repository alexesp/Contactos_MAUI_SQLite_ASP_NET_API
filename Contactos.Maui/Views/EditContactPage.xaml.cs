namespace Contactos.Maui.Views;

public partial class EditContactPage : ContentPage
{
	public EditContactPage()
	{
		InitializeComponent();
	}

    private void btnCancel_Clicked(object sender, EventArgs e)
    {
        //Shell.Current.GoToAsync("..");
        Shell.Current.GoToAsync($"//{nameof(ContactsPage)}");
    }

    public string ContactId
    {
        set
        {

        }
    }
}