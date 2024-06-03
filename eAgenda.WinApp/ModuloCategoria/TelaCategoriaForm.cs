namespace eAgenda.WinApp.ModuloCategoria
{
    public partial class TelaCategoriaForm : Form
    {
        private Categoria categoria;

        public Categoria Categoria
        {
            set
            {
                txtId.Text = value.Id.ToString();
                txtTitulo.Text = value.Titulo;
            }
            get
            {
                return categoria;
            }
        }

        public TelaCategoriaForm()
        {
            InitializeComponent();
        }
    }
}
