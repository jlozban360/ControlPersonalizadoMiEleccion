namespace ControlPersonalizadoMiEleccion
{
    public partial class BotonPersonalizado : Button
    {
        public BotonPersonalizado()
        {
            InitializeComponent();
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);

            Random rand = new Random();
            int r = rand.Next(256);
            int g = rand.Next(256);
            int b = rand.Next(256);

            this.BackColor = Color.FromArgb(r, g, b);
        }
    }
}
