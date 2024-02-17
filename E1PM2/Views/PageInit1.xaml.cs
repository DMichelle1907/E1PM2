namespace E1PM2.Views;
public partial class PageInit : ContentPage
{
    Controllers.RegistroController registro;

    public PageInit()
    {
        registro = new Controllers.RegistroController();
        InitializeComponent();
    }

    public PageInit(Controllers.RegistroController dbpath)
    {
        InitializeComponent();
        registro = dbpath;
    }

    private async void btnAgregar_Clicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(Longitud.Text))
        {
            await DisplayAlert("Error", "Por favor, ingrese longitud.", "OK");
            return;
        }


        if (string.IsNullOrWhiteSpace(Latitud.Text))
        {
            await DisplayAlert("Error", "Por favor, ingrese Latitud.", "OK");
            return;
        }

        if (string.IsNullOrWhiteSpace(Descripcion.Text))
        {
            await DisplayAlert("Error", "Por favor, ingrese Descripcion.", "OK");
            return;
        }
        var Registro = new Models.Registro
        {
            Longitud = Longitud.Text,
            Latitud = Latitud.Text,
            Descripcion = Descripcion.Text

        };

        if(await registro.AgregarRegistro(Registro) > 0)
        {
            await DisplayAlert("Éxito", "Registro guardado exitosamente.", "OK");
            Longitud.Text = string.Empty;
            Latitud.Text = string.Empty;
            Descripcion.Text = string.Empty;
        }

    }


    private void btnLista_Clicked(object sender, EventArgs e)
    {

    }

    private void btnSalir_Clicked(object sender, EventArgs e)
    {

    }


}
