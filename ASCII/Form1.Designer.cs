namespace ASCII
{
    partial class CONVERTERASCII
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CONVERTERASCII));
            label1 = new Label();
            ConvertidoASCII = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            EntradaASCI = new TextBox();
            Converter = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(83, 148);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 0;
            label1.Text = "Informe ";
            // 
            // ConvertidoASCII
            // 
            ConvertidoASCII.Enabled = false;
            ConvertidoASCII.Location = new Point(83, 275);
            ConvertidoASCII.Name = "ConvertidoASCII";
            ConvertidoASCII.Size = new Size(442, 23);
            ConvertidoASCII.TabIndex = 2;
            ConvertidoASCII.TextChanged += ConvertidoASCII_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(83, 257);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 3;
            label2.Text = "Resultado";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(EntradaASCI);
            panel1.Controls.Add(Converter);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(ConvertidoASCII);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(624, 460);
            panel1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(528, 14);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Codigos ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // EntradaASCI
            // 
            EntradaASCI.Location = new Point(83, 166);
            EntradaASCI.Name = "EntradaASCI";
            EntradaASCI.Size = new Size(442, 23);
            EntradaASCI.TabIndex = 7;
            // 
            // Converter
            // 
            Converter.Location = new Point(234, 219);
            Converter.Name = "Converter";
            Converter.Size = new Size(156, 23);
            Converter.TabIndex = 6;
            Converter.Text = "Converter para texto";
            Converter.UseVisualStyleBackColor = true;
            Converter.Click += Converter_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 434);
            label3.Name = "label3";
            label3.Size = new Size(188, 13);
            label3.TabIndex = 5;
            label3.Text = "Developed byº Matheus Soares 1º ADS";
            label3.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(16, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // CONVERTERASCII
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(648, 484);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "CONVERTERASCII";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CONVERTERASCII";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;

        public TextBox EntradaASCII { get; private set; }

        private TextBox textBox1;
        private TextBox ConvertidoASCII;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private PictureBox pictureBox1;
        private Button Converter;
        private TextBox EntradaASCI;
        private Button button1;
    }
}
