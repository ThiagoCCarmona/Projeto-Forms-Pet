using Microsoft.Maui.Controls;
using System;
using Projeto_forms_Vet.Views;

namespace Projeto_forms_Vet.Views;

public partial class FrmPrincipal : ContentPage
{
	public FrmPrincipal()
	{
		InitializeComponent();
	}

	private async void OnPetsClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new FormCadastroPet());
	}

	private async void OnEsqueceuSenhaClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FormEsqueceuSenha());
    }

	private async void OnCadastroClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FormCadastro());
    }

	private async void OnEntrarClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new FormAgendamento());
	}

}