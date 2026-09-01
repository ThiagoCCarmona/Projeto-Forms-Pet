namespace Projeto_forms_Vet.Views;

using Microsoft.Maui.Controls;
using System;

public partial class FormCadastroPet : ContentPage
{
    public FormCadastroPet()
    {
        InitializeComponent();
    }

    private async void OnVoltarClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private void OnDataNascimentoSelected(object sender, DateChangedEventArgs e)
    {
        DateTime dataNascimento = e.NewDate ?? DateTime.Today;

        DateTime hoje = DateTime.Today;

        int idade = hoje.Year - dataNascimento.Year;

        if (dataNascimento.Date > hoje.AddYears(-idade))
        {
            idade--;
        }

        if (idade < 0)
        {
            idade = 0;
        }

        lblIdade.Text = $"Idade: {idade} ano(s)";
    }
}