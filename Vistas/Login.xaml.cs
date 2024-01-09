namespace vguachaminExamen.Vistas;

public partial class Login : ContentPage
{
    List<Usuarios> us = new List<Usuarios>();
    Usuarios usu1 = new Usuarios();
    Usuarios usu2 = new Usuarios();
    Usuarios usu3 = new Usuarios();
    public Login()
	{
		InitializeComponent();

		
		usu1.name = "estudiante2024";
		usu1.pass = "uisrael2024";
		us.Add(usu1);
        usu2.name = "examen1";
        usu2.pass = "parcial1";
        us.Add(usu2);	
        usu3.name = "vinicio";
        usu3.pass = "2024";
        us.Add(usu3);
    }

    private void btnLogin_Clicked(object sender, EventArgs e)
	{
        string usuario = txtUsuario.Text;
        string pass = txContrasena.Text;
        var login = us.Where(x => x.name == usuario && x.pass == pass).ToList();
        if (login.Count > 0)
        {
            Navigation.PushAsync(new Vistas.Registro(login.FirstOrDefault().name));
        }else
        {
            DisplayAlert("Alert", "Usuario/Contraseña Incorrecta", "OK");
        }
    }

    private void btnAcerca_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Alert", "Proyecto construido por Vinicio Guachamin", "OK");
    }

	public class Usuarios
	{
		public string name { get; set;}
        public string pass { get; set; }
    }
}