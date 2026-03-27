namespace MauiAppMinhasCompras.Views;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
            DateTime inicio = dtInicio.Date;
            DateTime fim = dtFim.Date;

            var lista = await App.Database.GetAll();

            var filtrados = lista
                .Where(p => p.DataCadastro.Date >= inicio.Date &&
                            p.DataCadastro.Date <= fim.Date)
                .ToList();

            listaProdutos.ItemsSource = filtrados;

        } catch (Exception ex)
		{
			DisplayAlert("Ops", $"Ocorreu um erro: {ex.Message}", "OK");
        }

    }
}