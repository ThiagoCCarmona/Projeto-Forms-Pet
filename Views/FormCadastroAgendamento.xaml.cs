namespace Projeto_forms_Vet.Views;

public partial class FormCadastroAgendamento : ContentPage
{
	public FormCadastroAgendamento()
	{
		InitializeComponent();
	}

	private async void onVerPets(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new FormViewPet());
    }

	private void onSalvarAgendamento(object sender, EventArgs e)
	{
		Navigation.PopAsync();
    }

    private async void OnVoltarClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}