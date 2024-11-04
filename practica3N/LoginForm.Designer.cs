namespace practica3N
{
    partial class LoginForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.BtnLogin = new MetroFramework.Controls.MetroButton();
            this.tbUsuario = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tbPw = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(254, 102);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Usuario:";
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(316, 194);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(98, 37);
            this.BtnLogin.TabIndex = 6;
            this.BtnLogin.Text = "Iniciar Sesión";
            this.BtnLogin.UseSelectable = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // tbUsuario
            // 
            // 
            // 
            // 
            this.tbUsuario.CustomButton.Image = null;
            this.tbUsuario.CustomButton.Location = new System.Drawing.Point(139, 1);
            this.tbUsuario.CustomButton.Name = "";
            this.tbUsuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbUsuario.CustomButton.TabIndex = 1;
            this.tbUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbUsuario.CustomButton.UseSelectable = true;
            this.tbUsuario.CustomButton.Visible = false;
            this.tbUsuario.Lines = new string[0];
            this.tbUsuario.Location = new System.Drawing.Point(316, 98);
            this.tbUsuario.MaxLength = 32767;
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.PasswordChar = '\0';
            this.tbUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbUsuario.SelectedText = "";
            this.tbUsuario.SelectionLength = 0;
            this.tbUsuario.SelectionStart = 0;
            this.tbUsuario.ShortcutsEnabled = true;
            this.tbUsuario.Size = new System.Drawing.Size(161, 23);
            this.tbUsuario.TabIndex = 7;
            this.tbUsuario.UseSelectable = true;
            this.tbUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroPanel1
            // 
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(34, 98);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(178, 133);
            this.metroPanel1.TabIndex = 8;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(232, 143);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(78, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Contraseña:";
            // 
            // tbPw
            // 
            // 
            // 
            // 
            this.tbPw.CustomButton.Image = null;
            this.tbPw.CustomButton.Location = new System.Drawing.Point(139, 1);
            this.tbPw.CustomButton.Name = "";
            this.tbPw.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbPw.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPw.CustomButton.TabIndex = 1;
            this.tbPw.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPw.CustomButton.UseSelectable = true;
            this.tbPw.CustomButton.Visible = false;
            this.tbPw.Lines = new string[0];
            this.tbPw.Location = new System.Drawing.Point(316, 139);
            this.tbPw.MaxLength = 32767;
            this.tbPw.Name = "tbPw";
            this.tbPw.PasswordChar = '*';
            this.tbPw.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPw.SelectedText = "";
            this.tbPw.SelectionLength = 0;
            this.tbPw.SelectionStart = 0;
            this.tbPw.ShortcutsEnabled = true;
            this.tbPw.Size = new System.Drawing.Size(161, 23);
            this.tbPw.TabIndex = 10;
            this.tbPw.UseSelectable = true;
            this.tbPw.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPw.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 290);
            this.Controls.Add(this.tbPw);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.metroLabel1);
            this.Name = "LoginForm";
            this.Text = "Inicio de Sesión";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton BtnLogin;
        private MetroFramework.Controls.MetroTextBox tbUsuario;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox tbPw;
    }
}

