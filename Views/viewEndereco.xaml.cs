namespace Projeto_forms_Vet.Views;

public partial class viewEndereco : ContentPage
{
	public viewEndereco()
	{
		InitializeComponent();
	}

	private async void onClickedAdicionarEndereco(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new formCadastroEndereco());
    }

    private async void OnVoltarClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}