namespace ASCII
{
    public partial class CONVERTERASCII : Form
    {
        public CONVERTERASCII()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Converter_Click(object sender, EventArgs e)
        {
            CodigoASCII codigo = new CodigoASCII
            {
                Codigo = EntradaASCI.Text
            };

            try
            {
                var palavra = codigo.Converter();

                ConvertidoASCII.Text = palavra;
           
            }
            catch (FormatException exception)
            {
                MessageBox.Show(this, exception.Message, "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
