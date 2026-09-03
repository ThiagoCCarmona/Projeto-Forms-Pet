namespace Projeto_forms_Vet.Views;

public partial class FormEsqueceuSenha : ContentPage
{
    public FormEsqueceuSenha()
    {
        InitializeComponent();
    }

    private async void OnRedefinirSenhaClicked(object sender, EventArgs e)
    {
        await MensagemEnvio.FadeToAsync(1, 500);
        await PreencherVerificacao.FadeToAsync(1, 500);
        await txtCodigo.FadeToAsync(1, 500);
        await btnVerificarCodigo.FadeToAsync(1, 500);
    }

    private async void OnVerificarCodigoClicked(object sender, EventArgs e)
    {
        if (txtCodigo.Text == "123")
        {
            await lbNovaSenha.FadeToAsync(1, 500);
            await txtNovaSenha.FadeToAsync(1, 500);
            await lbConfirmarSenha.FadeToAsync(1, 500);
            await txtConfirmarSenha.FadeToAsync(1, 500);
            await btnRedefinirSenha.FadeToAsync(1, 500);
        }
        else
        {
            await DisplayAlertAsync("Código incorreto", "O código digitado está incorreto. Por favor, tente novamente.", "OK");
        }

    }

    private void OnRedefinirSenhaFinalClicked(object sender, EventArgs e)
    {
        if (txtNovaSenha.Text == txtConfirmarSenha.Text)
        {
            DisplayAlert("Sucesso", "Senha redefinida com sucesso!", "OK");
            Navigation.PopAsync();
        }
        else
        {
            DisplayAlert("Erro", "As senhas não coincidem. Por favor, tente novamente.", "OK");
        }
    }

    private async void OnVoltarClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}