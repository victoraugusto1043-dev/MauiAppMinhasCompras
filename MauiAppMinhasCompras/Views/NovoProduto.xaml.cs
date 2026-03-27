using System;
using Microsoft.Maui.Controls;
using MauiAppMinhasCompras.Models;
using MauiAppMinhasCompras.Helpers;
using MauiAppMinhasCompras.Views;
using System.Threading.Tasks;

namespace MauiAppMinhasCompras.Views
{
    public partial class NovoProduto : ContentPage
    {
        public NovoProduto()
        {
            InitializeComponent();
        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            try
            {
                Produto p = new Produto
                {
                    Descricao = txt_descricao.Text,
                    Quantidade = double.Parse(txt_quantidade.Text),
                    Preco = double.Parse(txt_preco.Text),
                    DataCadastro = dtp_dataCadastro.Date
                };
                await App.Database.Insert(p);
                await DisplayAlert("Sucesso", "Produto cadastrado com sucesso!", "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", $"Ocorreu um erro: {ex.Message}", "OK");
            }
        }
    }
}