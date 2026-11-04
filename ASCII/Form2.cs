using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ASCII
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            dataGridView1.Rows.Add("32", " ");
            dataGridView1.Rows.Add("33", "!");
            dataGridView1.Rows.Add("34", "\"");
            dataGridView1.Rows.Add("35", "#");
            dataGridView1.Rows.Add("36", "$");
            dataGridView1.Rows.Add("37", "%");
            dataGridView1.Rows.Add("38", "&");
            dataGridView1.Rows.Add("39", "'");
            dataGridView1.Rows.Add("40", "(");
            dataGridView1.Rows.Add("41", ")");
            dataGridView1.Rows.Add("42", "*");
            dataGridView1.Rows.Add("43", "+");
            dataGridView1.Rows.Add("44", ",");
            dataGridView1.Rows.Add("45", "-");
            dataGridView1.Rows.Add("46", ".");
            dataGridView1.Rows.Add("47", "/");
            dataGridView1.Rows.Add("48", "0");
            dataGridView1.Rows.Add("49", "1");
            dataGridView1.Rows.Add("50", "2");
            dataGridView1.Rows.Add("51", "3");
            dataGridView1.Rows.Add("52", "4");
            dataGridView1.Rows.Add("53", "5");
            dataGridView1.Rows.Add("54", "6");
            dataGridView1.Rows.Add("55", "7");
            dataGridView1.Rows.Add("56", "8");
            dataGridView1.Rows.Add("57", "9");
            dataGridView1.Rows.Add("58", ":");
            dataGridView1.Rows.Add("59", ";");
            dataGridView1.Rows.Add("60", "<");
            dataGridView1.Rows.Add("61", "=");
            dataGridView1.Rows.Add("62", ">");
            dataGridView1.Rows.Add("63", "?");
            dataGridView1.Rows.Add("64", "@");
            dataGridView1.Rows.Add("65", "A");
            dataGridView1.Rows.Add("66", "B");
            dataGridView1.Rows.Add("67", "C");
            dataGridView1.Rows.Add("68", "D");
            dataGridView1.Rows.Add("69", "E");
            dataGridView1.Rows.Add("70", "F");
            dataGridView1.Rows.Add("71", "G");
            dataGridView1.Rows.Add("72", "H");
            dataGridView1.Rows.Add("73", "I");
            dataGridView1.Rows.Add("74", "J");
            dataGridView1.Rows.Add("75", "K");
            dataGridView1.Rows.Add("76", "L");
            dataGridView1.Rows.Add("77", "M");
            dataGridView1.Rows.Add("78", "N");
            dataGridView1.Rows.Add("79", "O");
            dataGridView1.Rows.Add("80", "P");
            dataGridView1.Rows.Add("81", "Q");
            dataGridView1.Rows.Add("82", "R");
            dataGridView1.Rows.Add("83", "S");
            dataGridView1.Rows.Add("84", "T");
            dataGridView1.Rows.Add("85", "U");
            dataGridView1.Rows.Add("86", "V");
            dataGridView1.Rows.Add("87", "W");
            dataGridView1.Rows.Add("88", "X");
            dataGridView1.Rows.Add("89", "Y");
            dataGridView1.Rows.Add("90", "Z");
            dataGridView1.Rows.Add("91", "[");
            dataGridView1.Rows.Add("92", "\\");
            dataGridView1.Rows.Add("93", "]");
            dataGridView1.Rows.Add("94", "^");
            dataGridView1.Rows.Add("95", "_");
            dataGridView1.Rows.Add("96", "`");
            dataGridView1.Rows.Add("97", "a");
            dataGridView1.Rows.Add("98", "b");
            dataGridView1.Rows.Add("99", "c");
            dataGridView1.Rows.Add("100", "d");
            dataGridView1.Rows.Add("101", "e");
            dataGridView1.Rows.Add("102", "f");
            dataGridView1.Rows.Add("103", "g");
            dataGridView1.Rows.Add("104", "h");
            dataGridView1.Rows.Add("105", "i");
            dataGridView1.Rows.Add("106", "j");
            dataGridView1.Rows.Add("107", "k");
            dataGridView1.Rows.Add("108", "l");
            dataGridView1.Rows.Add("109", "m");
            dataGridView1.Rows.Add("110", "n");
            dataGridView1.Rows.Add("111", "o");
            dataGridView1.Rows.Add("112", "p");
            dataGridView1.Rows.Add("113", "q");
            dataGridView1.Rows.Add("114", "r");
            dataGridView1.Rows.Add("115", "s");
            dataGridView1.Rows.Add("116", "t");
            dataGridView1.Rows.Add("117", "u");
            dataGridView1.Rows.Add("118", "v");
            dataGridView1.Rows.Add("119", "w");
            dataGridView1.Rows.Add("120", "x");
            dataGridView1.Rows.Add("121", "y");
            dataGridView1.Rows.Add("122", "z");
            dataGridView1.Rows.Add("123", "{");
            dataGridView1.Rows.Add("124", "|");
            dataGridView1.Rows.Add("125", "}");
            dataGridView1.Rows.Add("126", "~");
            dataGridView1.Rows.Add("127", "DEL");

            dataGridView2.Rows.Add("0", "NUL (Null, nulo)");
            dataGridView2.Rows.Add("1", "SOH (Start of Heading, início do cabeçalho)");
            dataGridView2.Rows.Add("2", "STX (Start of Text, início do texto)");
            dataGridView2.Rows.Add("3", "ETX (End of Text, fim do texto)");
            dataGridView2.Rows.Add("4", "EOT (End of Transmission, fim da transmissão)");
            dataGridView2.Rows.Add("5", "ENQ (Enquiry, consulta)");
            dataGridView2.Rows.Add("6", "ACK (Acknowledge, confirmação)");
            dataGridView2.Rows.Add("7", "BEL (Bell, campainha/sinal sonoro)");
            dataGridView2.Rows.Add("8", "BS (Backspace, retrocesso)");
            dataGridView2.Rows.Add("9", "HT (Horizontal Tab, tabulação horizontal)");
            dataGridView2.Rows.Add("10", "LF (Line Feed, avanço de linha/quebra de linha)");
            dataGridView2.Rows.Add("11", "VT (Vertical Tab, tabulação vertical)");
            dataGridView2.Rows.Add("12", "FF (Form Feed, avanço de página)");
            dataGridView2.Rows.Add("13", "CR (Carriage Return, retorno do cursor ao início da linha)");
            dataGridView2.Rows.Add("14", "SO (Shift Out, desloca para fora)");
            dataGridView2.Rows.Add("15", "SI (Shift In, desloca para dentro)");
            dataGridView2.Rows.Add("16", "DLE (Data Link Escape, escape de enlace de dados)");
            dataGridView2.Rows.Add("17", "DC1 (Device Control 1, controle de dispositivo 1, usado como XON)");
            dataGridView2.Rows.Add("18", "DC2 (Device Control 2, controle de dispositivo 2)");
            dataGridView2.Rows.Add("19", "DC3 (Device Control 3, controle de dispositivo 3, usado como XOFF)");
            dataGridView2.Rows.Add("20", "DC4 (Device Control 4, controle de dispositivo 4)");
            dataGridView2.Rows.Add("21", "NAK (Negative Acknowledge, confirmação negativa)");
            dataGridView2.Rows.Add("22", "SYN (Synchronous Idle, ocioso síncrono)");
            dataGridView2.Rows.Add("23", "ETB (End of Transmission Block, fim do bloco de transmissão)");
            dataGridView2.Rows.Add("24", "CAN (Cancel, cancelar)");
            dataGridView2.Rows.Add("25", "EM (End of Medium, fim do meio de armazenamento)");
            dataGridView2.Rows.Add("26", "SUB (Substitute, substituição)");
            dataGridView2.Rows.Add("27", "ESC (Escape, escape)");
            dataGridView2.Rows.Add("28", "FS (File Separator, separador de arquivo)");
            dataGridView2.Rows.Add("29", "GS (Group Separator, separador de grupo)");
            dataGridView2.Rows.Add("30", "RS (Record Separator, separador de registro)");
            dataGridView2.Rows.Add("31", "US (Unit Separator, separador de unidade)");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
