namespace LoginProjectForm {
    partial class Form1 {
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_IniciarSesion = new System.Windows.Forms.Button();
            this.btn_CrearCuenta = new System.Windows.Forms.Button();
            this.btn_RecuperarContrasena = new System.Windows.Forms.Button();
            this.lbl_ErrorUsuario = new System.Windows.Forms.Label();
            this.lbl_ErrorContraseña = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contaseña";
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(72, 119);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(210, 20);
            this.txt_Usuario.TabIndex = 3;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(72, 190);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(210, 20);
            this.txt_Password.TabIndex = 4;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // btn_IniciarSesion
            // 
            this.btn_IniciarSesion.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_IniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_IniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_IniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btn_IniciarSesion.Location = new System.Drawing.Point(72, 236);
            this.btn_IniciarSesion.Name = "btn_IniciarSesion";
            this.btn_IniciarSesion.Size = new System.Drawing.Size(210, 36);
            this.btn_IniciarSesion.TabIndex = 5;
            this.btn_IniciarSesion.Text = "Iniciar sesion";
            this.btn_IniciarSesion.UseVisualStyleBackColor = false;
            this.btn_IniciarSesion.Click += new System.EventHandler(this.btn_IniciarSesion_Click);
            // 
            // btn_CrearCuenta
            // 
            this.btn_CrearCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CrearCuenta.Location = new System.Drawing.Point(202, 292);
            this.btn_CrearCuenta.Name = "btn_CrearCuenta";
            this.btn_CrearCuenta.Size = new System.Drawing.Size(80, 23);
            this.btn_CrearCuenta.TabIndex = 6;
            this.btn_CrearCuenta.Text = "Crear Cuenta";
            this.btn_CrearCuenta.UseVisualStyleBackColor = true;
            // 
            // btn_RecuperarContrasena
            // 
            this.btn_RecuperarContrasena.BackColor = System.Drawing.Color.Transparent;
            this.btn_RecuperarContrasena.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RecuperarContrasena.ForeColor = System.Drawing.Color.Black;
            this.btn_RecuperarContrasena.Location = new System.Drawing.Point(72, 292);
            this.btn_RecuperarContrasena.Name = "btn_RecuperarContrasena";
            this.btn_RecuperarContrasena.Size = new System.Drawing.Size(116, 23);
            this.btn_RecuperarContrasena.TabIndex = 7;
            this.btn_RecuperarContrasena.Text = "¿Olvido Contraseña?";
            this.btn_RecuperarContrasena.UseVisualStyleBackColor = false;
            // 
            // lbl_ErrorUsuario
            // 
            this.lbl_ErrorUsuario.AutoSize = true;
            this.lbl_ErrorUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorUsuario.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorUsuario.Location = new System.Drawing.Point(69, 142);
            this.lbl_ErrorUsuario.Name = "lbl_ErrorUsuario";
            this.lbl_ErrorUsuario.Size = new System.Drawing.Size(0, 15);
            this.lbl_ErrorUsuario.TabIndex = 8;
            // 
            // lbl_ErrorContraseña
            // 
            this.lbl_ErrorContraseña.AutoSize = true;
            this.lbl_ErrorContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorContraseña.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorContraseña.Location = new System.Drawing.Point(69, 213);
            this.lbl_ErrorContraseña.Name = "lbl_ErrorContraseña";
            this.lbl_ErrorContraseña.Size = new System.Drawing.Size(0, 15);
            this.lbl_ErrorContraseña.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 356);
            this.Controls.Add(this.lbl_ErrorContraseña);
            this.Controls.Add(this.lbl_ErrorUsuario);
            this.Controls.Add(this.btn_RecuperarContrasena);
            this.Controls.Add(this.btn_CrearCuenta);
            this.Controls.Add(this.btn_IniciarSesion);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button btn_IniciarSesion;
        private System.Windows.Forms.Button btn_CrearCuenta;
        private System.Windows.Forms.Button btn_RecuperarContrasena;
        private System.Windows.Forms.Label lbl_ErrorUsuario;
        private System.Windows.Forms.Label lbl_ErrorContraseña;
    }
}

