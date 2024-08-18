namespace Proyecto_Estudio_de_Fotografica
{
    partial class Login
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
        private void InitializeComponent() {
            btn_login = new Button();
            tb_user = new TextBox();
            tb_password = new TextBox();
            pb_userIcon = new PictureBox();
            pb_lockIcon = new PictureBox();
            lbl_password = new Label();
            lbl_user = new Label();
            ((System.ComponentModel.ISupportInitialize)pb_userIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_lockIcon).BeginInit();
            SuspendLayout();
            // 
            // btn_login
            // 
            btn_login.Location = new Point(83, 184);
            btn_login.Margin = new Padding(3, 2, 3, 2);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(158, 34);
            btn_login.TabIndex = 0;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            // 
            // tb_user
            // 
            tb_user.Location = new Point(111, 75);
            tb_user.Name = "tb_user";
            tb_user.Size = new Size(121, 23);
            tb_user.TabIndex = 1;
            // 
            // tb_password
            // 
            tb_password.Location = new Point(111, 133);
            tb_password.Name = "tb_password";
            tb_password.Size = new Size(121, 23);
            tb_password.TabIndex = 2;
            // 
            // pb_userIcon
            // 
            pb_userIcon.Image = Properties.Resources.user_icon;
            pb_userIcon.Location = new Point(55, 69);
            pb_userIcon.Name = "pb_userIcon";
            pb_userIcon.Size = new Size(50, 35);
            pb_userIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pb_userIcon.TabIndex = 3;
            pb_userIcon.TabStop = false;
            // 
            // pb_lockIcon
            // 
            pb_lockIcon.Image = Properties.Resources.lock_icon;
            pb_lockIcon.Location = new Point(55, 119);
            pb_lockIcon.Name = "pb_lockIcon";
            pb_lockIcon.Size = new Size(50, 37);
            pb_lockIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pb_lockIcon.TabIndex = 4;
            pb_lockIcon.TabStop = false;
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Location = new Point(111, 115);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(67, 15);
            lbl_password.TabIndex = 5;
            lbl_password.Text = "Contraseña";
            // 
            // lbl_user
            // 
            lbl_user.AutoSize = true;
            lbl_user.Location = new Point(111, 57);
            lbl_user.Name = "lbl_user";
            lbl_user.Size = new Size(47, 15);
            lbl_user.TabIndex = 6;
            lbl_user.Text = "Usuario";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(316, 316);
            Controls.Add(lbl_user);
            Controls.Add(lbl_password);
            Controls.Add(pb_lockIcon);
            Controls.Add(pb_userIcon);
            Controls.Add(tb_password);
            Controls.Add(tb_user);
            Controls.Add(btn_login);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pb_userIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_lockIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_login;
        private TextBox tb_user;
        private TextBox tb_password;
        private PictureBox pb_userIcon;
        private PictureBox pb_lockIcon;
        private Label lbl_password;
        private Label lbl_user;
    }
}
