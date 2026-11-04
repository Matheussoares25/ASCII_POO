using System.Text;

namespace ASCII
{
    //objeto CodigoASCII armazena o código ASCII a ser convertido.
    internal class CodigoASCII
    {
        public string Codigo { get; set; } = string.Empty;


        //Metodo converter
        public string Converter()
        {
            string[] partes = Codigo.Split((char[]?)null, StringSplitOptions.RemoveEmptyEntries);
            if (partes.Length == 0)
            {
                throw new FormatException("Informe um ou mais códigos ASCII separados por espaços.");
            }

            byte[] bytes = new byte[partes.Length];
            for (int i = 0; i < partes.Length; i++)
            {
                if (!byte.TryParse(partes[i], out bytes[i]) || bytes[i] > 127)
                {
                    throw new FormatException($"'{partes[i]}' não é um código ASCII válido. Use valores entre 0 e 127.");
                }
            }

            string palavra = Encoding.ASCII.GetString(bytes);


            //retorna a palavra convertida.
            return palavra;
        }
    }
}