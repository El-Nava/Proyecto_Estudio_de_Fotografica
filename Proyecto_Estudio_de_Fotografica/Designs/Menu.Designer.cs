namespace Proyecto_Estudio_de_Fotografica
{
    partial class Menu
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
        private void InitializeComponent() {
            tab_consultarCitas = new TabPage();
            btn_ConsultarCita_Consultar = new Button();
            tb_NombreCompleto_Consulta = new TextBox();
            lbl_NombreCompleto_Consulta = new Label();
            tab_citasAgendadas = new TabPage();
            tab_agendarCitas = new TabPage();
            tb_Altura_Agendar = new TextBox();
            lbl_Altura_Agendar = new Label();
            cb_Paquete_Agendar = new ComboBox();
            lbl_fecha_Agendar = new Label();
            date_Fecha_Agendar = new DateTimePicker();
            lbl_numeroDeTelefono_Agendar = new Label();
            lbl_paquete_Agendar = new Label();
            lbl_apellidos_Agendar = new Label();
            lbl_nombre_Agendar = new Label();
            tb_NumeroDeTelefono_Agendar = new TextBox();
            tb_Apellidos_Agendar = new TextBox();
            tb_Nombre_Agendar = new TextBox();
            btn_AgendarCita_Agendar = new Button();
            lbl_fondo = new Label();
            tab_menu = new TabControl();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tab_consultarCitas.SuspendLayout();
            tab_agendarCitas.SuspendLayout();
            tab_menu.SuspendLayout();
            SuspendLayout();
            // 
            // tab_consultarCitas
            // 
            tab_consultarCitas.BackColor = Color.LightGray;
            tab_consultarCitas.Controls.Add(btn_ConsultarCita_Consultar);
            tab_consultarCitas.Controls.Add(tb_NombreCompleto_Consulta);
            tab_consultarCitas.Controls.Add(lbl_NombreCompleto_Consulta);
            tab_consultarCitas.Location = new Point(4, 24);
            tab_consultarCitas.Name = "tab_consultarCitas";
            tab_consultarCitas.Padding = new Padding(3);
            tab_consultarCitas.Size = new Size(752, 309);
            tab_consultarCitas.TabIndex = 2;
            tab_consultarCitas.Text = "Consultar citas";
            // 
            // btn_ConsultarCita_Consultar
            // 
            btn_ConsultarCita_Consultar.Location = new Point(558, 14);
            btn_ConsultarCita_Consultar.Name = "btn_ConsultarCita_Consultar";
            btn_ConsultarCita_Consultar.Size = new Size(109, 23);
            btn_ConsultarCita_Consultar.TabIndex = 9;
            btn_ConsultarCita_Consultar.Text = "Consultar";
            btn_ConsultarCita_Consultar.UseVisualStyleBackColor = true;
            // 
            // tb_NombreCompleto_Consulta
            // 
            tb_NombreCompleto_Consulta.Location = new Point(204, 14);
            tb_NombreCompleto_Consulta.Name = "tb_NombreCompleto_Consulta";
            tb_NombreCompleto_Consulta.Size = new Size(348, 23);
            tb_NombreCompleto_Consulta.TabIndex = 8;
            // 
            // lbl_NombreCompleto_Consulta
            // 
            lbl_NombreCompleto_Consulta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_NombreCompleto_Consulta.AutoSize = true;
            lbl_NombreCompleto_Consulta.BackColor = Color.LightGray;
            lbl_NombreCompleto_Consulta.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_NombreCompleto_Consulta.Location = new Point(37, 12);
            lbl_NombreCompleto_Consulta.Name = "lbl_NombreCompleto_Consulta";
            lbl_NombreCompleto_Consulta.Size = new Size(165, 24);
            lbl_NombreCompleto_Consulta.TabIndex = 7;
            lbl_NombreCompleto_Consulta.Text = "Nombre Completo";
            lbl_NombreCompleto_Consulta.TextAlign = ContentAlignment.TopCenter;
            // 
            // tab_citasAgendadas
            // 
            tab_citasAgendadas.BackColor = Color.LightGray;
            tab_citasAgendadas.Location = new Point(4, 24);
            tab_citasAgendadas.Name = "tab_citasAgendadas";
            tab_citasAgendadas.Padding = new Padding(3);
            tab_citasAgendadas.Size = new Size(752, 309);
            tab_citasAgendadas.TabIndex = 1;
            tab_citasAgendadas.Text = "Ver citas agendadas";
            // 
            // tab_agendarCitas
            // 
            tab_agendarCitas.Controls.Add(tb_Altura_Agendar);
            tab_agendarCitas.Controls.Add(lbl_Altura_Agendar);
            tab_agendarCitas.Controls.Add(cb_Paquete_Agendar);
            tab_agendarCitas.Controls.Add(lbl_fecha_Agendar);
            tab_agendarCitas.Controls.Add(date_Fecha_Agendar);
            tab_agendarCitas.Controls.Add(lbl_numeroDeTelefono_Agendar);
            tab_agendarCitas.Controls.Add(lbl_paquete_Agendar);
            tab_agendarCitas.Controls.Add(lbl_apellidos_Agendar);
            tab_agendarCitas.Controls.Add(lbl_nombre_Agendar);
            tab_agendarCitas.Controls.Add(tb_NumeroDeTelefono_Agendar);
            tab_agendarCitas.Controls.Add(tb_Apellidos_Agendar);
            tab_agendarCitas.Controls.Add(tb_Nombre_Agendar);
            tab_agendarCitas.Controls.Add(btn_AgendarCita_Agendar);
            tab_agendarCitas.Controls.Add(lbl_fondo);
            tab_agendarCitas.Location = new Point(4, 24);
            tab_agendarCitas.Name = "tab_agendarCitas";
            tab_agendarCitas.Padding = new Padding(3);
            tab_agendarCitas.Size = new Size(752, 309);
            tab_agendarCitas.TabIndex = 0;
            tab_agendarCitas.Text = "Agendar citas";
            tab_agendarCitas.UseVisualStyleBackColor = true;
            // 
            // tb_Altura_Agendar
            // 
            tb_Altura_Agendar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_Altura_Agendar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_Altura_Agendar.Location = new Point(346, 141);
            tb_Altura_Agendar.Name = "tb_Altura_Agendar";
            tb_Altura_Agendar.Size = new Size(289, 26);
            tb_Altura_Agendar.TabIndex = 14;
            // 
            // lbl_Altura_Agendar
            // 
            lbl_Altura_Agendar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_Altura_Agendar.AutoSize = true;
            lbl_Altura_Agendar.BackColor = Color.LightGray;
            lbl_Altura_Agendar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Altura_Agendar.Location = new Point(249, 141);
            lbl_Altura_Agendar.Name = "lbl_Altura_Agendar";
            lbl_Altura_Agendar.Size = new Size(91, 24);
            lbl_Altura_Agendar.TabIndex = 13;
            lbl_Altura_Agendar.Text = "Altura (m)";
            lbl_Altura_Agendar.TextAlign = ContentAlignment.TopCenter;
            // 
            // cb_Paquete_Agendar
            // 
            cb_Paquete_Agendar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cb_Paquete_Agendar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_Paquete_Agendar.FormattingEnabled = true;
            cb_Paquete_Agendar.Items.AddRange(new object[] { "Paquete 1", "Paquete 2", "Paquete 3" });
            cb_Paquete_Agendar.Location = new Point(346, 173);
            cb_Paquete_Agendar.Name = "cb_Paquete_Agendar";
            cb_Paquete_Agendar.Size = new Size(289, 28);
            cb_Paquete_Agendar.TabIndex = 12;
            cb_Paquete_Agendar.SelectedIndexChanged += cb_Paquete_Agendar_SelectedIndexChanged;
            // 
            // lbl_fecha_Agendar
            // 
            lbl_fecha_Agendar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_fecha_Agendar.AutoSize = true;
            lbl_fecha_Agendar.BackColor = Color.LightGray;
            lbl_fecha_Agendar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_fecha_Agendar.Location = new Point(276, 203);
            lbl_fecha_Agendar.Name = "lbl_fecha_Agendar";
            lbl_fecha_Agendar.Size = new Size(64, 24);
            lbl_fecha_Agendar.TabIndex = 11;
            lbl_fecha_Agendar.Text = "Fecha";
            lbl_fecha_Agendar.TextAlign = ContentAlignment.TopCenter;
            // 
            // date_Fecha_Agendar
            // 
            date_Fecha_Agendar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            date_Fecha_Agendar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            date_Fecha_Agendar.Location = new Point(346, 207);
            date_Fecha_Agendar.Name = "date_Fecha_Agendar";
            date_Fecha_Agendar.Size = new Size(289, 26);
            date_Fecha_Agendar.TabIndex = 10;
            // 
            // lbl_numeroDeTelefono_Agendar
            // 
            lbl_numeroDeTelefono_Agendar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_numeroDeTelefono_Agendar.AutoSize = true;
            lbl_numeroDeTelefono_Agendar.BackColor = Color.LightGray;
            lbl_numeroDeTelefono_Agendar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_numeroDeTelefono_Agendar.Location = new Point(162, 109);
            lbl_numeroDeTelefono_Agendar.Name = "lbl_numeroDeTelefono_Agendar";
            lbl_numeroDeTelefono_Agendar.Size = new Size(178, 24);
            lbl_numeroDeTelefono_Agendar.TabIndex = 8;
            lbl_numeroDeTelefono_Agendar.Text = "Numero de telefono";
            lbl_numeroDeTelefono_Agendar.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl_paquete_Agendar
            // 
            lbl_paquete_Agendar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_paquete_Agendar.AutoSize = true;
            lbl_paquete_Agendar.BackColor = Color.LightGray;
            lbl_paquete_Agendar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_paquete_Agendar.Location = new Point(260, 170);
            lbl_paquete_Agendar.Name = "lbl_paquete_Agendar";
            lbl_paquete_Agendar.Size = new Size(80, 24);
            lbl_paquete_Agendar.TabIndex = 7;
            lbl_paquete_Agendar.Text = "Paquete";
            lbl_paquete_Agendar.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl_apellidos_Agendar
            // 
            lbl_apellidos_Agendar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_apellidos_Agendar.AutoSize = true;
            lbl_apellidos_Agendar.BackColor = Color.LightGray;
            lbl_apellidos_Agendar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_apellidos_Agendar.Location = new Point(252, 77);
            lbl_apellidos_Agendar.Name = "lbl_apellidos_Agendar";
            lbl_apellidos_Agendar.Size = new Size(88, 24);
            lbl_apellidos_Agendar.TabIndex = 6;
            lbl_apellidos_Agendar.Text = "Apellidos";
            lbl_apellidos_Agendar.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl_nombre_Agendar
            // 
            lbl_nombre_Agendar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_nombre_Agendar.AutoSize = true;
            lbl_nombre_Agendar.BackColor = Color.LightGray;
            lbl_nombre_Agendar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_nombre_Agendar.Location = new Point(261, 45);
            lbl_nombre_Agendar.Name = "lbl_nombre_Agendar";
            lbl_nombre_Agendar.Size = new Size(79, 24);
            lbl_nombre_Agendar.TabIndex = 5;
            lbl_nombre_Agendar.Text = "Nombre";
            lbl_nombre_Agendar.TextAlign = ContentAlignment.TopCenter;
            // 
            // tb_NumeroDeTelefono_Agendar
            // 
            tb_NumeroDeTelefono_Agendar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_NumeroDeTelefono_Agendar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_NumeroDeTelefono_Agendar.Location = new Point(346, 109);
            tb_NumeroDeTelefono_Agendar.Name = "tb_NumeroDeTelefono_Agendar";
            tb_NumeroDeTelefono_Agendar.Size = new Size(289, 26);
            tb_NumeroDeTelefono_Agendar.TabIndex = 3;
            // 
            // tb_Apellidos_Agendar
            // 
            tb_Apellidos_Agendar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_Apellidos_Agendar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_Apellidos_Agendar.Location = new Point(346, 77);
            tb_Apellidos_Agendar.Name = "tb_Apellidos_Agendar";
            tb_Apellidos_Agendar.Size = new Size(289, 26);
            tb_Apellidos_Agendar.TabIndex = 2;
            // 
            // tb_Nombre_Agendar
            // 
            tb_Nombre_Agendar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_Nombre_Agendar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_Nombre_Agendar.Location = new Point(346, 45);
            tb_Nombre_Agendar.Name = "tb_Nombre_Agendar";
            tb_Nombre_Agendar.Size = new Size(289, 26);
            tb_Nombre_Agendar.TabIndex = 1;
            // 
            // btn_AgendarCita_Agendar
            // 
            btn_AgendarCita_Agendar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_AgendarCita_Agendar.Location = new Point(418, 256);
            btn_AgendarCita_Agendar.Name = "btn_AgendarCita_Agendar";
            btn_AgendarCita_Agendar.Size = new Size(113, 33);
            btn_AgendarCita_Agendar.TabIndex = 1;
            btn_AgendarCita_Agendar.Text = "Agendar cita";
            btn_AgendarCita_Agendar.UseVisualStyleBackColor = true;
            btn_AgendarCita_Agendar.Click += btn_AgendarCita_Agendar_Click;
            // 
            // lbl_fondo
            // 
            lbl_fondo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_fondo.BackColor = Color.LightGray;
            lbl_fondo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_fondo.Location = new Point(5, 3);
            lbl_fondo.MaximumSize = new Size(2000, 900);
            lbl_fondo.Name = "lbl_fondo";
            lbl_fondo.Size = new Size(744, 303);
            lbl_fondo.TabIndex = 0;
            // 
            // tab_menu
            // 
            tab_menu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tab_menu.Controls.Add(tab_agendarCitas);
            tab_menu.Controls.Add(tab_citasAgendadas);
            tab_menu.Controls.Add(tab_consultarCitas);
            tab_menu.Location = new Point(12, 12);
            tab_menu.Name = "tab_menu";
            tab_menu.SelectedIndex = 0;
            tab_menu.Size = new Size(760, 337);
            tab_menu.TabIndex = 0;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 361);
            Controls.Add(tab_menu);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            tab_consultarCitas.ResumeLayout(false);
            tab_consultarCitas.PerformLayout();
            tab_agendarCitas.ResumeLayout(false);
            tab_agendarCitas.PerformLayout();
            tab_menu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabPage tab_consultarCitas;
        private TabPage tab_citasAgendadas;
        private TabPage tab_agendarCitas;
        private TabControl tab_menu;
        private Label lbl_fondo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btn_AgendarCita_Agendar;
        private Label lbl_paquete_Agendar;
        private Label lbl_apellidos_Agendar;
        private Label lbl_nombre_Agendar;
        private TextBox tb_NumeroDeTelefono_Agendar;
        private TextBox tb_Apellidos_Agendar;
        private TextBox tb_Nombre_Agendar;
        private Label lbl_numeroDeTelefono_Agendar;
        private ComboBox cb_Paquete_Agendar;
        private Label lbl_fecha_Agendar;
        private DateTimePicker date_Fecha_Agendar;
        private TextBox tb_NombreCompleto_Consulta;
        private Label lbl_NombreCompleto_Consulta;
        private Button btn_ConsultarCita_Consultar;
        private Label lbl_Altura_Agendar;
        private TextBox tb_Altura_Agendar;
    }
}