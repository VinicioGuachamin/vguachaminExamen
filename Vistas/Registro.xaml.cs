namespace vguachaminExamen.Vistas;

public partial class Registro : ContentPage
{
	public Registro(string nombreUsuario)
	{
		InitializeComponent();
        lblUsuario.Text = nombreUsuario;
    }

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        double total = 1500;
        double inicial = Convert.ToDouble(txtMontoInicial.Text);
        double cuota = ((total - inicial) / 4) + (0.04 * total);
        txtMensual.Text = cuota.ToString();
    }

    private void btnResumen_Clicked(object sender, EventArgs e)
    {
        string resumen = "Nombre: " + txtNombre.Text + "\n" +
            "Apellido: " + txtApellido.Text + "\n"
            + "Edad: " + txtEdad.Text + "\n"
            + "Fecha: " + fecha.Date + "\n"
            + "Monto Inicial: " + txtMontoInicial.Text + "\n"
            + "Pago Mensual: " + txtMensual.Text + "\n";
        DisplayAlert("Alert", resumen, "OK");
    }
}