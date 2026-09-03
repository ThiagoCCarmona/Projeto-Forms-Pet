namespace Projeto_forms_Vet.Views;

public partial class FormCadastro : ContentPage
{
	public FormCadastro()
	{
		InitializeComponent();
	}

	private async void onClickedProcurarEndereco(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new viewEndereco());
    }

	private void onClickedSalvaCadastro (object sender, EventArgs e)
	{
        Navigation.PopAsync();
    }

    private async void OnVoltarClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}