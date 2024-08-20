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
        private void InitializeComponent()
        {
            btn_Login = new Button();
            tb_User = new TextBox();
            tb_Password = new TextBox();
            pb_UserIcon = new PictureBox();
            pb_LockIcon = new PictureBox();
            lbl_Password = new Label();
            lbl_User = new Label();
            ((System.ComponentModel.ISupportInitialize)pb_UserIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_LockIcon).BeginInit();
            SuspendLayout();
            // 
            // btn_Login
            // 
            btn_Login.Location = new Point(83, 184);
            btn_Login.Margin = new Padding(3, 2, 3, 2);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(158, 34);
            btn_Login.TabIndex = 0;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // tb_User
            // 
            tb_User.Location = new Point(111, 75);
            tb_User.Name = "tb_User";
            tb_User.Size = new Size(121, 23);
            tb_User.TabIndex = 1;
            // 
            // tb_Password
            // 
            tb_Password.Location = new Point(111, 133);
            tb_Password.Name = "tb_Password";
            tb_Password.Size = new Size(121, 23);
            tb_Password.TabIndex = 2;
            // 
            // pb_UserIcon
            // 
            pb_UserIcon.Image = Properties.Resources.user_icon;
            pb_UserIcon.Location = new Point(55, 69);
            pb_UserIcon.Name = "pb_UserIcon";
            pb_UserIcon.Size = new Size(50, 35);
            pb_UserIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pb_UserIcon.TabIndex = 3;
            pb_UserIcon.TabStop = false;
            // 
            // pb_LockIcon
            // 
            pb_LockIcon.Image = Properties.Resources.lock_icon;
            pb_LockIcon.Location = new Point(55, 119);
            pb_LockIcon.Name = "pb_LockIcon";
            pb_LockIcon.Size = new Size(50, 37);
            pb_LockIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pb_LockIcon.TabIndex = 4;
            pb_LockIcon.TabStop = false;
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Location = new Point(111, 115);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(67, 15);
            lbl_Password.TabIndex = 5;
            lbl_Password.Text = "Contraseña";
            // 
            // lbl_User
            // 
            lbl_User.AutoSize = true;
            lbl_User.Location = new Point(111, 57);
            lbl_User.Name = "lbl_User";
            lbl_User.Size = new Size(47, 15);
            lbl_User.TabIndex = 6;
            lbl_User.Text = "Usuario";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(316, 316);
            Controls.Add(lbl_User);
            Controls.Add(lbl_Password);
            Controls.Add(pb_LockIcon);
            Controls.Add(pb_UserIcon);
            Controls.Add(tb_Password);
            Controls.Add(tb_User);
            Controls.Add(btn_Login);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pb_UserIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_LockIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Login;
        private TextBox tb_User;
        private TextBox tb_Password;
        private PictureBox pb_UserIcon;
        private PictureBox pb_LockIcon;
        private Label lbl_Password;
        private Label lbl_User;
    }
}
