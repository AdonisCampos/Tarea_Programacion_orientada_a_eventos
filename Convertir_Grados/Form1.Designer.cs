namespace Convertir_Grados
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
            label1 = new Label();
            sidebarMenuPanel = new Panel();
            celsiusakelvinboton = new Button();
            farenheitacelsiusboton = new Button();
            CelsiusaFathrenheitboton = new Button();
            logopicture = new PictureBox();
            panel1 = new Panel();
            cerraraplicacion = new Button();
            contentpanel = new Panel();
            sidebarMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logopicture).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LavenderBlush;
            label1.Location = new Point(21, 62);
            label1.Name = "label1";
            label1.Size = new Size(486, 23);
            label1.TabIndex = 3;
            label1.Text = "Programa para convertir la temperatura";
            label1.Click += label1_Click;
            // 
            // sidebarMenuPanel
            // 
            sidebarMenuPanel.BackColor = Color.MediumOrchid;
            sidebarMenuPanel.Controls.Add(celsiusakelvinboton);
            sidebarMenuPanel.Controls.Add(farenheitacelsiusboton);
            sidebarMenuPanel.Controls.Add(CelsiusaFathrenheitboton);
            sidebarMenuPanel.Controls.Add(logopicture);
            sidebarMenuPanel.Dock = DockStyle.Left;
            sidebarMenuPanel.Location = new Point(0, 0);
            sidebarMenuPanel.Name = "sidebarMenuPanel";
            sidebarMenuPanel.Size = new Size(200, 338);
            sidebarMenuPanel.TabIndex = 4;
            // 
            // celsiusakelvinboton
            // 
            celsiusakelvinboton.Dock = DockStyle.Top;
            celsiusakelvinboton.FlatAppearance.BorderSize = 0;
            celsiusakelvinboton.FlatStyle = FlatStyle.Flat;
            celsiusakelvinboton.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            celsiusakelvinboton.ForeColor = Color.White;
            celsiusakelvinboton.Location = new Point(0, 180);
            celsiusakelvinboton.Name = "celsiusakelvinboton";
            celsiusakelvinboton.Padding = new Padding(10, 0, 0, 0);
            celsiusakelvinboton.Size = new Size(200, 40);
            celsiusakelvinboton.TabIndex = 3;
            celsiusakelvinboton.Text = "Celsius a kelvin";
            celsiusakelvinboton.TextAlign = ContentAlignment.MiddleLeft;
            celsiusakelvinboton.UseVisualStyleBackColor = true;
            // 
            // farenheitacelsiusboton
            // 
            farenheitacelsiusboton.Dock = DockStyle.Top;
            farenheitacelsiusboton.FlatAppearance.BorderSize = 0;
            farenheitacelsiusboton.FlatStyle = FlatStyle.Flat;
            farenheitacelsiusboton.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            farenheitacelsiusboton.ForeColor = Color.White;
            farenheitacelsiusboton.Location = new Point(0, 140);
            farenheitacelsiusboton.Name = "farenheitacelsiusboton";
            farenheitacelsiusboton.Padding = new Padding(10, 0, 0, 0);
            farenheitacelsiusboton.Size = new Size(200, 40);
            farenheitacelsiusboton.TabIndex = 2;
            farenheitacelsiusboton.Text = " Fahrenheit a Celsius ";
            farenheitacelsiusboton.TextAlign = ContentAlignment.MiddleLeft;
            farenheitacelsiusboton.UseVisualStyleBackColor = true;
            farenheitacelsiusboton.Click += farenheitacelsiusboton_Click;
            // 
            // CelsiusaFathrenheitboton
            // 
            CelsiusaFathrenheitboton.Dock = DockStyle.Top;
            CelsiusaFathrenheitboton.FlatAppearance.BorderSize = 0;
            CelsiusaFathrenheitboton.FlatStyle = FlatStyle.Flat;
            CelsiusaFathrenheitboton.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            CelsiusaFathrenheitboton.ForeColor = Color.White;
            CelsiusaFathrenheitboton.Location = new Point(0, 100);
            CelsiusaFathrenheitboton.Name = "CelsiusaFathrenheitboton";
            CelsiusaFathrenheitboton.Padding = new Padding(10, 0, 0, 0);
            CelsiusaFathrenheitboton.Size = new Size(200, 40);
            CelsiusaFathrenheitboton.TabIndex = 1;
            CelsiusaFathrenheitboton.Text = "Celsius a Fahrenheit";
            CelsiusaFathrenheitboton.TextAlign = ContentAlignment.MiddleLeft;
            CelsiusaFathrenheitboton.UseVisualStyleBackColor = true;
            CelsiusaFathrenheitboton.Click += CelsiusaFathrenheitboton_Click;
            // 
            // logopicture
            // 
            logopicture.Dock = DockStyle.Top;
            logopicture.Image = Properties.Resources.pngwing_com;
            logopicture.Location = new Point(0, 0);
            logopicture.Name = "logopicture";
            logopicture.Size = new Size(200, 100);
            logopicture.SizeMode = PictureBoxSizeMode.StretchImage;
            logopicture.TabIndex = 0;
            logopicture.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumOrchid;
            panel1.Controls.Add(cerraraplicacion);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(200, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(510, 100);
            panel1.TabIndex = 5;
            // 
            // cerraraplicacion
            // 
            cerraraplicacion.BackgroundImage = Properties.Resources.boton_cerrar;
            cerraraplicacion.BackgroundImageLayout = ImageLayout.Stretch;
            cerraraplicacion.FlatAppearance.BorderSize = 0;
            cerraraplicacion.FlatStyle = FlatStyle.Flat;
            cerraraplicacion.ImageAlign = ContentAlignment.TopLeft;
            cerraraplicacion.Location = new Point(437, 12);
            cerraraplicacion.Name = "cerraraplicacion";
            cerraraplicacion.Size = new Size(61, 32);
            cerraraplicacion.TabIndex = 4;
            cerraraplicacion.UseVisualStyleBackColor = true;
            cerraraplicacion.Click += cerraraplicacion_Click;
            // 
            // contentpanel
            // 
            contentpanel.Dock = DockStyle.Fill;
            contentpanel.Location = new Point(200, 100);
            contentpanel.Name = "contentpanel";
            contentpanel.Size = new Size(510, 238);
            contentpanel.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 338);
            Controls.Add(contentpanel);
            Controls.Add(panel1);
            Controls.Add(sidebarMenuPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            sidebarMenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logopicture).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Panel sidebarMenuPanel;
        private Panel panel1;
        private PictureBox logopicture;
        private Button cerraraplicacion;
        private Button CelsiusaFathrenheitboton;
        private Button celsiusakelvinboton;
        private Button farenheitacelsiusboton;
        private Panel contentpanel;
    }
}