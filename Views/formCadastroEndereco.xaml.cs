namespace Projeto_forms_Vet.Views;

public partial class formCadastroEndereco : ContentPage
{
	public formCadastroEndereco()
	{
		InitializeComponent();
	}

	private async void onClickedSalvaEndereco (object sender, EventArgs e)
	{
		Navigation.PopAsync();
    }

    private async void OnVoltarClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}