namespace UI;

public class Principal:Form
{
    private Label lblNombre = new();
    private TextBox txtNombre = new ();  // private TextBox txtNombre;
    private Label lblDireccion = new();
    private TextBox txtDireccion = new();
    private Button btnNuevo = new();
    private Button btnGuardar = new();
    private Button btnAnulaar = new(); 
    public Principal()
    {
        this.Size = new System.Drawing.Size (800,400);
        this.Text = "Registro de Cliente";


        lblNombre.Text = "Nombre";
        lblNombre.Location = new System.Drawing.Point (110,60);

        // txtNombre = new() { Location = new System.Drawing.Point(110, 60), width = 150 };


        this.Controls.Add (lblNombre); // pinta el control en la UI
        this.Controls.Add (txtNombre); // pinta el control en la UI


       // Application.EnableVisualStyles();
       // Application.Run(new Principal());
    }
    // [STAThread] // Decoradores, es una clase 
}