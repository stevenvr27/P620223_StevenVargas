namespace P620223_StevenVargas.Formularios
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnVerPassword = new System.Windows.Forms.Button();
            this.LblRecuperarContrasennia = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtContrasennia = new System.Windows.Forms.TextBox();
            this.TxtNombreUsuario = new System.Windows.Forms.TextBox();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.BtnVerPassword);
            this.panel1.Controls.Add(this.LblRecuperarContrasennia);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TxtContrasennia);
            this.panel1.Controls.Add(this.TxtNombreUsuario);
            this.panel1.Controls.Add(this.BtnIngresar);
            this.panel1.Controls.Add(this.BtnCancelar);
            this.panel1.Location = new System.Drawing.Point(29, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 266);
            this.panel1.TabIndex = 0;
            // 
            // BtnVerPassword
            // 
            this.BtnVerPassword.Location = new System.Drawing.Point(286, 129);
            this.BtnVerPassword.Name = "BtnVerPassword";
            this.BtnVerPassword.Size = new System.Drawing.Size(41, 26);
            this.BtnVerPassword.TabIndex = 7;
            this.BtnVerPassword.Text = "Ver";
            this.BtnVerPassword.UseVisualStyleBackColor = true;
            this.BtnVerPassword.Click += new System.EventHandler(this.BtnVerPassword_Click);
            this.BtnVerPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnVerPassword_MouseDown);
            this.BtnVerPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnVerPassword_MouseUp);
            // 
            // LblRecuperarContrasennia
            // 
            this.LblRecuperarContrasennia.AutoSize = true;
            this.LblRecuperarContrasennia.LinkColor = System.Drawing.Color.Red;
            this.LblRecuperarContrasennia.Location = new System.Drawing.Point(176, 158);
            this.LblRecuperarContrasennia.Name = "LblRecuperarContrasennia";
            this.LblRecuperarContrasennia.Size = new System.Drawing.Size(106, 13);
            this.LblRecuperarContrasennia.TabIndex = 6;
            this.LblRecuperarContrasennia.TabStop = true;
            this.LblRecuperarContrasennia.Text = "Olvidé mi contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(55, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre Usuario";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TxtContrasennia
            // 
            this.TxtContrasennia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContrasennia.Location = new System.Drawing.Point(21, 129);
            this.TxtContrasennia.Name = "TxtContrasennia";
            this.TxtContrasennia.Size = new System.Drawing.Size(306, 26);
            this.TxtContrasennia.TabIndex = 3;
            this.TxtContrasennia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtContrasennia.UseSystemPasswordChar = true;
            // 
            // TxtNombreUsuario
            // 
            this.TxtNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreUsuario.ForeColor = System.Drawing.Color.LightGreen;
            this.TxtNombreUsuario.Location = new System.Drawing.Point(21, 53);
            this.TxtNombreUsuario.Name = "TxtNombreUsuario";
            this.TxtNombreUsuario.Size = new System.Drawing.Size(306, 26);
            this.TxtNombreUsuario.TabIndex = 2;
            this.TxtNombreUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.BackColor = System.Drawing.Color.GreenYellow;
            this.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnIngresar.Location = new System.Drawing.Point(21, 201);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(115, 42);
            this.BtnIngresar.TabIndex = 1;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.LightCoral;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnCancelar.Location = new System.Drawing.Point(197, 201);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(116, 42);
            this.BtnCancelar.TabIndex = 0;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(441, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 199);
            this.panel2.TabIndex = 1;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(671, 306);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnVerPassword;
        private System.Windows.Forms.LinkLabel LblRecuperarContrasennia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtContrasennia;
        private System.Windows.Forms.TextBox TxtNombreUsuario;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Panel panel2;
    }
}