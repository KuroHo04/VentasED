namespace VentasED
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producto cocacola600 = new Producto();
            cocacola600.Descripcion = "Coca cola 600";
            cocacola600.ValorUnitario = 20.00m;

            Producto sabritas = new Producto();
            sabritas.Descripcion = "Chetos Flaming hot";
            sabritas.ValorUnitario = 18.00m;



            MessageBox.Show(cocacola600.ToString());
            MessageBox.Show(sabritas.ToString());
        }

        private void btnProductosArreglo_Click(object sender, EventArgs e)
        {
            Producto cocacola600 = new Producto();
            cocacola600.Descripcion = "Coca cola 600";
            cocacola600.ValorUnitario = 20.00m;

            Producto sabritas = new Producto();
            sabritas.Descripcion = "Chetos Flaming hot";
            sabritas.ValorUnitario = 18.00m;

            Producto[] productos = new Producto[] { cocacola600, sabritas };
            foreach(Producto producto in productos) 
            {
                MessageBox.Show(producto.ToString());
            }
        }
    }
}
