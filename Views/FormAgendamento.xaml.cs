namespace Projeto_forms_Vet.Views;

public partial class FormAgendamento : ContentPage
{
	public FormAgendamento()
	{
		InitializeComponent();
	}

	private async void onCadastroAgendamento(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new FormCadastroAgendamento());
    }

    private async void OnVoltarClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}