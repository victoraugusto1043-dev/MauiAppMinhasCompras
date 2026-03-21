using MauiAppMinhasCompras.Models;

namespace MauiAppMinhasCompras.Views;

public partial class EditarProduto : ContentPage
{
	public EditarProduto()
	{
		InitializeComponent();
	}

    private async void ToolbarItem_Clicked(object sender, EventArgs e)
    {
        try
        {
            Produto produto_anexado = (Produto)BindingContext;

            Produto p = new Produto
            {
                Id =  produto_anexado.Id,
                Descricao = txt_descricao.Text,
                Quantidade = double.Parse(txt_quantidade.Text),
                Preco = double.Parse(txt_preco.Text)
            };
            await App.Database.Update(p);
            await DisplayAlert("Sucesso", "Cadastro Atualizado!", "OK");
            await Navigation.PopAsync();
        }
        catch (Exception ex)
        {
            await DisplayAlert("Ops", $"Ocorreu um erro: {ex.Message}", "OK");
        }
    }
}