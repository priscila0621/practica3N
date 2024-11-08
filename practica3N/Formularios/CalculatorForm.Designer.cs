namespace practica3N.Formularios
{
    partial class CalculatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tbNum1 = new MetroFramework.Controls.MetroTextBox();
            this.tbNum2 = new MetroFramework.Controls.MetroTextBox();
            this.btnSuma = new MetroFramework.Controls.MetroButton();
            this.btnResta = new MetroFramework.Controls.MetroButton();
            this.btnMultiplicacion = new MetroFramework.Controls.MetroButton();
            this.btnDivision = new MetroFramework.Controls.MetroButton();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(49, 104);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(154, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Ingresa los dos números:";
            // 
            // tbNum1
            // 
            // 
            // 
            // 
            this.tbNum1.CustomButton.Image = null;
            this.tbNum1.CustomButton.Location = new System.Drawing.Point(58, 1);
            this.tbNum1.CustomButton.Name = "";
            this.tbNum1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbNum1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbNum1.CustomButton.TabIndex = 1;
            this.tbNum1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbNum1.CustomButton.UseSelectable = true;
            this.tbNum1.CustomButton.Visible = false;
            this.tbNum1.Lines = new string[0];
            this.tbNum1.Location = new System.Drawing.Point(209, 104);
            this.tbNum1.MaxLength = 32767;
            this.tbNum1.Name = "tbNum1";
            this.tbNum1.PasswordChar = '\0';
            this.tbNum1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNum1.SelectedText = "";
            this.tbNum1.SelectionLength = 0;
            this.tbNum1.SelectionStart = 0;
            this.tbNum1.ShortcutsEnabled = true;
            this.tbNum1.Size = new System.Drawing.Size(80, 23);
            this.tbNum1.TabIndex = 1;
            this.tbNum1.UseSelectable = true;
            this.tbNum1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbNum1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbNum2
            // 
            // 
            // 
            // 
            this.tbNum2.CustomButton.Image = null;
            this.tbNum2.CustomButton.Location = new System.Drawing.Point(58, 1);
            this.tbNum2.CustomButton.Name = "";
            this.tbNum2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbNum2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbNum2.CustomButton.TabIndex = 1;
            this.tbNum2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbNum2.CustomButton.UseSelectable = true;
            this.tbNum2.CustomButton.Visible = false;
            this.tbNum2.Lines = new string[0];
            this.tbNum2.Location = new System.Drawing.Point(334, 104);
            this.tbNum2.MaxLength = 32767;
            this.tbNum2.Name = "tbNum2";
            this.tbNum2.PasswordChar = '\0';
            this.tbNum2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNum2.SelectedText = "";
            this.tbNum2.SelectionLength = 0;
            this.tbNum2.SelectionStart = 0;
            this.tbNum2.ShortcutsEnabled = true;
            this.tbNum2.Size = new System.Drawing.Size(80, 23);
            this.tbNum2.TabIndex = 2;
            this.tbNum2.UseSelectable = true;
            this.tbNum2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbNum2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSuma
            // 
            this.btnSuma.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSuma.BackgroundImage")));
            this.btnSuma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSuma.Location = new System.Drawing.Point(49, 158);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(66, 60);
            this.btnSuma.TabIndex = 4;
            this.btnSuma.UseSelectable = true;
            // 
            // btnResta
            // 
            this.btnResta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnResta.BackgroundImage")));
            this.btnResta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnResta.Location = new System.Drawing.Point(164, 158);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(66, 60);
            this.btnResta.TabIndex = 5;
            this.btnResta.UseSelectable = true;
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMultiplicacion.BackgroundImage")));
            this.btnMultiplicacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMultiplicacion.Location = new System.Drawing.Point(284, 158);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(66, 60);
            this.btnMultiplicacion.TabIndex = 6;
            this.btnMultiplicacion.UseSelectable = true;
            // 
            // btnDivision
            // 
            this.btnDivision.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDivision.BackgroundImage")));
            this.btnDivision.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDivision.Location = new System.Drawing.Point(396, 158);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(66, 60);
            this.btnDivision.TabIndex = 7;
            this.btnDivision.UseSelectable = true;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(214, 248);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 28);
            this.lblResultado.TabIndex = 8;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 354);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMultiplicacion);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.tbNum2);
            this.Controls.Add(this.tbNum1);
            this.Controls.Add(this.metroLabel1);
            this.Name = "CalculatorForm";
            this.Text = "Calculadora Básica";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tbNum1;
        private MetroFramework.Controls.MetroTextBox tbNum2;
        private MetroFramework.Controls.MetroButton btnSuma;
        private MetroFramework.Controls.MetroButton btnResta;
        private MetroFramework.Controls.MetroButton btnMultiplicacion;
        private MetroFramework.Controls.MetroButton btnDivision;
        private System.Windows.Forms.Label lblResultado;
    }
}