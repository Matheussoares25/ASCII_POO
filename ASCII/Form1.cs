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
                var (palavra, letras) = codigo.Converter();

                ConvertidoASCII.Text = palavra;

                MessageBox.Show(this, $"A palavra convertida é: {palavra}\n\nAs letras correspondentes aos códigos ASCII fornecidos são:\n{string.Join(", ", letras)}", "Resultado da Conversão", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
