using System.Runtime.CompilerServices;

namespace CotizadorDesktop
{
    partial class Form1
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
            button_Candado = new Button();
            button_Euro = new Button();
            button_Dolar = new Button();
            button_Peso = new Button();
            label_Cotizacion = new Label();
            label_Euro = new Label();
            label_Dolar = new Label();
            label_Peso = new Label();
            tb_EuroCantidad = new RichTextBox();
            tb_PesoCantidad = new RichTextBox();
            tb_DolarCantidad = new RichTextBox();
            tb_euroCotizacion = new RichTextBox();
            tb_dolarCotizacion = new RichTextBox();
            tb_PesoCotizacion = new RichTextBox();
            label_Euro2 = new Label();
            label_Dolar2 = new Label();
            label_Peso2 = new Label();
            tb_EuroAEuro = new TextBox();
            TB_EuroADolar = new TextBox();
            tb_EuroAPeso = new TextBox();
            tb_DolarAEuro = new TextBox();
            tb_DolarADolar = new TextBox();
            tb_DolarAPeso = new TextBox();
            tb_PesoAEuro = new TextBox();
            tb_PesoADolar = new TextBox();
            tb_PesoAPeso = new TextBox();
            SuspendLayout();
            // 
            // button_Candado
            // 
            button_Candado.Image = Properties.Resources.icons8_desbloquear_30;
            button_Candado.Location = new Point(218, 34);
            button_Candado.Name = "button_Candado";
            button_Candado.Size = new Size(87, 36);
            button_Candado.TabIndex = 0;
            button_Candado.UseVisualStyleBackColor = true;
            button_Candado.Click += button_Candado_Click;
            // 
            // button_Euro
            // 
            button_Euro.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button_Euro.Location = new Point(230, 133);
            button_Euro.Name = "button_Euro";
            button_Euro.Size = new Size(75, 29);
            button_Euro.TabIndex = 1;
            button_Euro.Text = "->";
            button_Euro.UseVisualStyleBackColor = true;
            button_Euro.Click += button_Euro_Click;
            // 
            // button_Dolar
            // 
            button_Dolar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button_Dolar.Location = new Point(230, 192);
            button_Dolar.Name = "button_Dolar";
            button_Dolar.Size = new Size(75, 23);
            button_Dolar.TabIndex = 2;
            button_Dolar.Text = "->";
            button_Dolar.UseVisualStyleBackColor = true;
            // 
            // button_Peso
            // 
            button_Peso.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button_Peso.Location = new Point(230, 250);
            button_Peso.Name = "button_Peso";
            button_Peso.Size = new Size(75, 23);
            button_Peso.TabIndex = 3;
            button_Peso.Text = "->";
            button_Peso.UseVisualStyleBackColor = true;
            // 
            // label_Cotizacion
            // 
            label_Cotizacion.AutoSize = true;
            label_Cotizacion.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label_Cotizacion.Location = new Point(67, 42);
            label_Cotizacion.Name = "label_Cotizacion";
            label_Cotizacion.Size = new Size(105, 25);
            label_Cotizacion.TabIndex = 4;
            label_Cotizacion.Text = "Cotizacion";
            // 
            // label_Euro
            // 
            label_Euro.AutoSize = true;
            label_Euro.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label_Euro.Location = new Point(12, 133);
            label_Euro.Name = "label_Euro";
            label_Euro.Size = new Size(41, 20);
            label_Euro.TabIndex = 5;
            label_Euro.Text = "Euro";
            // 
            // label_Dolar
            // 
            label_Dolar.AutoSize = true;
            label_Dolar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label_Dolar.Location = new Point(10, 195);
            label_Dolar.Name = "label_Dolar";
            label_Dolar.Size = new Size(47, 20);
            label_Dolar.TabIndex = 6;
            label_Dolar.Text = "Dolar";
            // 
            // label_Peso
            // 
            label_Peso.AutoSize = true;
            label_Peso.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label_Peso.Location = new Point(10, 253);
            label_Peso.Name = "label_Peso";
            label_Peso.Size = new Size(42, 20);
            label_Peso.TabIndex = 7;
            label_Peso.Text = "Peso";
            // 
            // tb_EuroCantidad
            // 
            tb_EuroCantidad.Location = new Point(67, 135);
            tb_EuroCantidad.Name = "tb_EuroCantidad";
            tb_EuroCantidad.Size = new Size(145, 27);
            tb_EuroCantidad.TabIndex = 8;
            tb_EuroCantidad.Text = "";
            tb_EuroCantidad.TextChanged += tb_EuroCantidad_TextChanged;
            tb_EuroCantidad.Validating += tb_EuroCantidad_Validating;
            // 
            // tb_PesoCantidad
            // 
            tb_PesoCantidad.Location = new Point(67, 253);
            tb_PesoCantidad.Name = "tb_PesoCantidad";
            tb_PesoCantidad.Size = new Size(145, 23);
            tb_PesoCantidad.TabIndex = 9;
            tb_PesoCantidad.Text = "";
            tb_PesoCantidad.Validating += tb_PesoCantidad_Validating;
            // 
            // tb_DolarCantidad
            // 
            tb_DolarCantidad.Location = new Point(67, 193);
            tb_DolarCantidad.Name = "tb_DolarCantidad";
            tb_DolarCantidad.Size = new Size(145, 22);
            tb_DolarCantidad.TabIndex = 10;
            tb_DolarCantidad.Text = "";
            tb_DolarCantidad.TextChanged += tb_DolarCantidad_TextChanged;
            tb_DolarCantidad.Validating += tb_DolarCantidad_Validating;
            // 
            // tb_euroCotizacion
            // 
            tb_euroCotizacion.Location = new Point(385, 42);
            tb_euroCotizacion.Name = "tb_euroCotizacion";
            tb_euroCotizacion.Size = new Size(143, 26);
            tb_euroCotizacion.TabIndex = 11;
            tb_euroCotizacion.Text = "";
            tb_euroCotizacion.TextChanged += tb_euroCotizacion_TextChanged;
            // 
            // tb_dolarCotizacion
            // 
            tb_dolarCotizacion.Location = new Point(566, 42);
            tb_dolarCotizacion.Name = "tb_dolarCotizacion";
            tb_dolarCotizacion.Size = new Size(156, 26);
            tb_dolarCotizacion.TabIndex = 12;
            tb_dolarCotizacion.Text = "";
            tb_dolarCotizacion.TextChanged += tb_dolarCotizacion_TextChanged;
            // 
            // tb_PesoCotizacion
            // 
            tb_PesoCotizacion.Location = new Point(778, 42);
            tb_PesoCotizacion.Name = "tb_PesoCotizacion";
            tb_PesoCotizacion.Size = new Size(135, 26);
            tb_PesoCotizacion.TabIndex = 13;
            tb_PesoCotizacion.Text = "";
            tb_PesoCotizacion.TextChanged += tb_PesoCotizacion_TextChanged;
            // 
            // label_Euro2
            // 
            label_Euro2.AutoSize = true;
            label_Euro2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label_Euro2.Location = new Point(427, 102);
            label_Euro2.Name = "label_Euro2";
            label_Euro2.Size = new Size(41, 20);
            label_Euro2.TabIndex = 14;
            label_Euro2.Text = "Euro";
            // 
            // label_Dolar2
            // 
            label_Dolar2.AutoSize = true;
            label_Dolar2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label_Dolar2.Location = new Point(615, 102);
            label_Dolar2.Name = "label_Dolar2";
            label_Dolar2.Size = new Size(47, 20);
            label_Dolar2.TabIndex = 15;
            label_Dolar2.Text = "Dolar";
            // 
            // label_Peso2
            // 
            label_Peso2.AutoSize = true;
            label_Peso2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label_Peso2.Location = new Point(821, 102);
            label_Peso2.Name = "label_Peso2";
            label_Peso2.Size = new Size(42, 20);
            label_Peso2.TabIndex = 16;
            label_Peso2.Text = "Peso";
            // 
            // tb_EuroAEuro
            // 
            tb_EuroAEuro.Location = new Point(399, 135);
            tb_EuroAEuro.Name = "tb_EuroAEuro";
            tb_EuroAEuro.Size = new Size(100, 23);
            tb_EuroAEuro.TabIndex = 17;
            // 
            // TB_EuroADolar
            // 
            TB_EuroADolar.Location = new Point(588, 138);
            TB_EuroADolar.Name = "TB_EuroADolar";
            TB_EuroADolar.Size = new Size(100, 23);
            TB_EuroADolar.TabIndex = 18;
            // 
            // tb_EuroAPeso
            // 
            tb_EuroAPeso.Location = new Point(787, 139);
            tb_EuroAPeso.Name = "tb_EuroAPeso";
            tb_EuroAPeso.Size = new Size(100, 23);
            tb_EuroAPeso.TabIndex = 19;
            // 
            // tb_DolarAEuro
            // 
            tb_DolarAEuro.Location = new Point(399, 192);
            tb_DolarAEuro.Name = "tb_DolarAEuro";
            tb_DolarAEuro.Size = new Size(100, 23);
            tb_DolarAEuro.TabIndex = 20;
            // 
            // tb_DolarADolar
            // 
            tb_DolarADolar.Location = new Point(588, 194);
            tb_DolarADolar.Name = "tb_DolarADolar";
            tb_DolarADolar.Size = new Size(100, 23);
            tb_DolarADolar.TabIndex = 21;
            // 
            // tb_DolarAPeso
            // 
            tb_DolarAPeso.Location = new Point(787, 196);
            tb_DolarAPeso.Name = "tb_DolarAPeso";
            tb_DolarAPeso.Size = new Size(100, 23);
            tb_DolarAPeso.TabIndex = 22;
            // 
            // tb_PesoAEuro
            // 
            tb_PesoAEuro.Location = new Point(399, 250);
            tb_PesoAEuro.Name = "tb_PesoAEuro";
            tb_PesoAEuro.Size = new Size(100, 23);
            tb_PesoAEuro.TabIndex = 23;
            // 
            // tb_PesoADolar
            // 
            tb_PesoADolar.Location = new Point(588, 250);
            tb_PesoADolar.Name = "tb_PesoADolar";
            tb_PesoADolar.Size = new Size(100, 23);
            tb_PesoADolar.TabIndex = 24;
            // 
            // tb_PesoAPeso
            // 
            tb_PesoAPeso.Location = new Point(787, 254);
            tb_PesoAPeso.Name = "tb_PesoAPeso";
            tb_PesoAPeso.Size = new Size(100, 23);
            tb_PesoAPeso.TabIndex = 25;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 490);
            Controls.Add(tb_PesoAPeso);
            Controls.Add(tb_PesoADolar);
            Controls.Add(tb_PesoAEuro);
            Controls.Add(tb_DolarAPeso);
            Controls.Add(tb_DolarADolar);
            Controls.Add(tb_DolarAEuro);
            Controls.Add(tb_EuroAPeso);
            Controls.Add(TB_EuroADolar);
            Controls.Add(tb_EuroAEuro);
            Controls.Add(label_Peso2);
            Controls.Add(label_Dolar2);
            Controls.Add(label_Euro2);
            Controls.Add(tb_PesoCotizacion);
            Controls.Add(tb_dolarCotizacion);
            Controls.Add(tb_euroCotizacion);
            Controls.Add(tb_DolarCantidad);
            Controls.Add(tb_PesoCantidad);
            Controls.Add(tb_EuroCantidad);
            Controls.Add(label_Peso);
            Controls.Add(label_Dolar);
            Controls.Add(label_Euro);
            Controls.Add(label_Cotizacion);
            Controls.Add(button_Peso);
            Controls.Add(button_Dolar);
            Controls.Add(button_Euro);
            Controls.Add(button_Candado);
            Name = "Form1";
            Text = "Conversor";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion



        private Button button_Candado;

        private Button button_Euro;
        private Button button_Dolar;
        private Button button_Peso;
        private Label label_Cotizacion;
        private Label label_Euro;
        private Label label_Dolar;
        private Label label_Peso;
        private RichTextBox tb_EuroCantidad;
        private RichTextBox tb_PesoCantidad;
        private RichTextBox tb_DolarCantidad;
        private RichTextBox tb_euroCotizacion;
        private RichTextBox tb_dolarCotizacion;
        private RichTextBox tb_PesoCotizacion;
        private Label label_Euro2;
        private Label label_Dolar2;
        private Label label_Peso2;
        private TextBox tb_EuroAEuro;
        private TextBox TB_EuroADolar;
        private TextBox tb_EuroAPeso;
        private TextBox tb_DolarAEuro;
        private TextBox tb_DolarADolar;
        private TextBox tb_DolarAPeso;
        private TextBox tb_PesoAEuro;
        private TextBox tb_PesoADolar;
        private TextBox tb_PesoAPeso;
    }
}