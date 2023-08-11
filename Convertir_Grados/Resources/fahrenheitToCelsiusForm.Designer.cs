namespace Convertir_Grados.Resources
{
    partial class fahrenheitToCelsiusForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titlelabel = new Label();
            txtFahrenheit = new TextBox();
            lblResultado = new Label();
            btnConvertir = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // titlelabel
            // 
            titlelabel.AutoSize = true;
            titlelabel.BackColor = Color.Transparent;
            titlelabel.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            titlelabel.ForeColor = Color.Fuchsia;
            titlelabel.Location = new Point(48, 9);
            titlelabel.Name = "titlelabel";
            titlelabel.Size = new Size(420, 30);
            titlelabel.TabIndex = 1;
            titlelabel.Text = "Convertir  Fahrenheit a Celsius ";
            titlelabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtFahrenheit
            // 
            txtFahrenheit.BorderStyle = BorderStyle.FixedSingle;
            txtFahrenheit.Location = new Point(141, 78);
            txtFahrenheit.Name = "txtFahrenheit";
            txtFahrenheit.Size = new Size(173, 23);
            txtFahrenheit.TabIndex = 2;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.ForeColor = Color.FromArgb(192, 0, 192);
            lblResultado.Location = new Point(141, 116);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(59, 15);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "Resultado";
            // 
            // btnConvertir
            // 
            btnConvertir.BackColor = Color.FromArgb(192, 0, 192);
            btnConvertir.Font = new Font("Segoe UI Variable Display", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnConvertir.ForeColor = Color.White;
            btnConvertir.Location = new Point(141, 144);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(173, 28);
            btnConvertir.TabIndex = 4;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = false;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(192, 0, 192);
            label1.Location = new Point(141, 50);
            label1.Name = "label1";
            label1.Size = new Size(180, 15);
            label1.TabIndex = 5;
            label1.Text = "Ingrese los grados en Fahrenheit:";
            // 
            // fahrenheitToCelsiusForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 461);
            Controls.Add(label1);
            Controls.Add(btnConvertir);
            Controls.Add(lblResultado);
            Controls.Add(txtFahrenheit);
            Controls.Add(titlelabel);
            Name = "fahrenheitToCelsiusForm";
            Text = "fahrenheitToCelsiusForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titlelabel;
        private TextBox txtFahrenheit;
        private Label lblResultado;
        private Button btnConvertir;
        private Label label1;
    }
}