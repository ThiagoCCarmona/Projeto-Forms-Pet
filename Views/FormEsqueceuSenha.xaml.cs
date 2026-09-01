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
            await Navigation.PopAsync();
        }
        else
        {
            await DisplayAlertAsync("Código incorreto", "O código digitado está incorreto. Por favor, tente novamente.", "OK");
        }

    }
}