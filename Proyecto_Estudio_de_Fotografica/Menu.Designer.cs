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
        private void InitializeComponent()
        {
            tab_consultarCitas = new TabPage();
            tab_citasAgendadas = new TabPage();
            tab_agendarCitas = new TabPage();
            cb_Paquete_Agendar = new ComboBox();
            lbl_fecha_1 = new Label();
            date_fechaAgendar = new DateTimePicker();
            lbl_numeroDeTelefono_1 = new Label();
            lbl_paquete_1 = new Label();
            lbl_apellidos_1 = new Label();
            lbl_nombre_1 = new Label();
            tb_NumeroDeTelefono_Agendar = new TextBox();
            tb_Apellidos_Agendar = new TextBox();
            tx_Nombre_Agendar = new TextBox();
            btn_AgendarCita_1 = new Button();
            lbl_fondo = new Label();
            tab_menu = new TabControl();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lbl_NombreCompleto_Consulta = new Label();
            tx_NombreCompleto_Consulta = new TextBox();
            btn_ConsultarCita_Consultar = new Button();
            tab_consultarCitas.SuspendLayout();
            tab_agendarCitas.SuspendLayout();
            tab_menu.SuspendLayout();
            SuspendLayout();
            // 
            // tab_consultarCitas
            // 
            tab_consultarCitas.BackColor = Color.LightGray;
            tab_consultarCitas.Controls.Add(btn_ConsultarCita_Consultar);
            tab_consultarCitas.Controls.Add(tx_NombreCompleto_Consulta);
            tab_consultarCitas.Controls.Add(lbl_NombreCompleto_Consulta);
            tab_consultarCitas.Location = new Point(4, 24);
            tab_consultarCitas.Name = "tab_consultarCitas";
            tab_consultarCitas.Padding = new Padding(3);
            tab_consultarCitas.Size = new Size(752, 309);
            tab_consultarCitas.TabIndex = 2;
            tab_consultarCitas.Text = "Consultar citas";
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
            tab_agendarCitas.Controls.Add(cb_Paquete_Agendar);
            tab_agendarCitas.Controls.Add(lbl_fecha_1);
            tab_agendarCitas.Controls.Add(date_fechaAgendar);
            tab_agendarCitas.Controls.Add(lbl_numeroDeTelefono_1);
            tab_agendarCitas.Controls.Add(lbl_paquete_1);
            tab_agendarCitas.Controls.Add(lbl_apellidos_1);
            tab_agendarCitas.Controls.Add(lbl_nombre_1);
            tab_agendarCitas.Controls.Add(tb_NumeroDeTelefono_Agendar);
            tab_agendarCitas.Controls.Add(tb_Apellidos_Agendar);
            tab_agendarCitas.Controls.Add(tx_Nombre_Agendar);
            tab_agendarCitas.Controls.Add(btn_AgendarCita_1);
            tab_agendarCitas.Controls.Add(lbl_fondo);
            tab_agendarCitas.Location = new Point(4, 24);
            tab_agendarCitas.Name = "tab_agendarCitas";
            tab_agendarCitas.Padding = new Padding(3);
            tab_agendarCitas.Size = new Size(752, 309);
            tab_agendarCitas.TabIndex = 0;
            tab_agendarCitas.Text = "Agendar citas";
            tab_agendarCitas.UseVisualStyleBackColor = true;
            // 
            // cb_Paquete_Agendar
            // 
            cb_Paquete_Agendar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cb_Paquete_Agendar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_Paquete_Agendar.FormattingEnabled = true;
            cb_Paquete_Agendar.Items.AddRange(new object[] { "Paquete 1", "Paquete 2", "Paquete 3" });
            cb_Paquete_Agendar.Location = new Point(342, 168);
            cb_Paquete_Agendar.Name = "cb_Paquete_Agendar";
            cb_Paquete_Agendar.Size = new Size(256, 28);
            cb_Paquete_Agendar.TabIndex = 12;
            // 
            // lbl_fecha_1
            // 
            lbl_fecha_1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_fecha_1.AutoSize = true;
            lbl_fecha_1.BackColor = Color.LightGray;
            lbl_fecha_1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_fecha_1.Location = new Point(253, 203);
            lbl_fecha_1.Name = "lbl_fecha_1";
            lbl_fecha_1.Size = new Size(64, 24);
            lbl_fecha_1.TabIndex = 11;
            lbl_fecha_1.Text = "Fecha";
            lbl_fecha_1.TextAlign = ContentAlignment.TopCenter;
            // 
            // date_fechaAgendar
            // 
            date_fechaAgendar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            date_fechaAgendar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            date_fechaAgendar.Location = new Point(342, 202);
            date_fechaAgendar.Name = "date_fechaAgendar";
            date_fechaAgendar.Size = new Size(256, 26);
            date_fechaAgendar.TabIndex = 10;
            // 
            // lbl_numeroDeTelefono_1
            // 
            lbl_numeroDeTelefono_1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_numeroDeTelefono_1.AutoSize = true;
            lbl_numeroDeTelefono_1.BackColor = Color.LightGray;
            lbl_numeroDeTelefono_1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_numeroDeTelefono_1.Location = new Point(131, 138);
            lbl_numeroDeTelefono_1.Name = "lbl_numeroDeTelefono_1";
            lbl_numeroDeTelefono_1.Size = new Size(178, 24);
            lbl_numeroDeTelefono_1.TabIndex = 8;
            lbl_numeroDeTelefono_1.Text = "Numero de telefono";
            lbl_numeroDeTelefono_1.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl_paquete_1
            // 
            lbl_paquete_1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_paquete_1.AutoSize = true;
            lbl_paquete_1.BackColor = Color.LightGray;
            lbl_paquete_1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_paquete_1.Location = new Point(232, 171);
            lbl_paquete_1.Name = "lbl_paquete_1";
            lbl_paquete_1.Size = new Size(80, 24);
            lbl_paquete_1.TabIndex = 7;
            lbl_paquete_1.Text = "Paquete";
            lbl_paquete_1.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl_apellidos_1
            // 
            lbl_apellidos_1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_apellidos_1.AutoSize = true;
            lbl_apellidos_1.BackColor = Color.LightGray;
            lbl_apellidos_1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_apellidos_1.Location = new Point(222, 105);
            lbl_apellidos_1.Name = "lbl_apellidos_1";
            lbl_apellidos_1.Size = new Size(88, 24);
            lbl_apellidos_1.TabIndex = 6;
            lbl_apellidos_1.Text = "Apellidos";
            lbl_apellidos_1.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl_nombre_1
            // 
            lbl_nombre_1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_nombre_1.AutoSize = true;
            lbl_nombre_1.BackColor = Color.LightGray;
            lbl_nombre_1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_nombre_1.Location = new Point(234, 74);
            lbl_nombre_1.Name = "lbl_nombre_1";
            lbl_nombre_1.Size = new Size(79, 24);
            lbl_nombre_1.TabIndex = 5;
            lbl_nombre_1.Text = "Nombre";
            lbl_nombre_1.TextAlign = ContentAlignment.TopCenter;
            // 
            // tb_NumeroDeTelefono_Agendar
            // 
            tb_NumeroDeTelefono_Agendar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_NumeroDeTelefono_Agendar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_NumeroDeTelefono_Agendar.Location = new Point(342, 134);
            tb_NumeroDeTelefono_Agendar.Name = "tb_NumeroDeTelefono_Agendar";
            tb_NumeroDeTelefono_Agendar.Size = new Size(256, 29);
            tb_NumeroDeTelefono_Agendar.TabIndex = 3;
            // 
            // tb_Apellidos_Agendar
            // 
            tb_Apellidos_Agendar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_Apellidos_Agendar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_Apellidos_Agendar.Location = new Point(342, 104);
            tb_Apellidos_Agendar.Name = "tb_Apellidos_Agendar";
            tb_Apellidos_Agendar.Size = new Size(256, 26);
            tb_Apellidos_Agendar.TabIndex = 2;
            // 
            // tx_Nombre_Agendar
            // 
            tx_Nombre_Agendar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tx_Nombre_Agendar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tx_Nombre_Agendar.Location = new Point(342, 70);
            tx_Nombre_Agendar.Name = "tx_Nombre_Agendar";
            tx_Nombre_Agendar.Size = new Size(256, 29);
            tx_Nombre_Agendar.TabIndex = 1;
            // 
            // btn_AgendarCita_1
            // 
            btn_AgendarCita_1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_AgendarCita_1.Location = new Point(485, 250);
            btn_AgendarCita_1.Name = "btn_AgendarCita_1";
            btn_AgendarCita_1.Size = new Size(113, 33);
            btn_AgendarCita_1.TabIndex = 1;
            btn_AgendarCita_1.Text = "Agendar cita";
            btn_AgendarCita_1.UseVisualStyleBackColor = true;
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
            // lbl_NombreCompleto_Consulta
            // 
            lbl_NombreCompleto_Consulta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_NombreCompleto_Consulta.AutoSize = true;
            lbl_NombreCompleto_Consulta.BackColor = Color.LightGray;
            lbl_NombreCompleto_Consulta.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_NombreCompleto_Consulta.Location = new Point(15, 13);
            lbl_NombreCompleto_Consulta.Name = "lbl_NombreCompleto_Consulta";
            lbl_NombreCompleto_Consulta.Size = new Size(165, 24);
            lbl_NombreCompleto_Consulta.TabIndex = 7;
            lbl_NombreCompleto_Consulta.Text = "Nombre Completo";
            lbl_NombreCompleto_Consulta.TextAlign = ContentAlignment.TopCenter;
            // 
            // tx_NombreCompleto_Consulta
            // 
            tx_NombreCompleto_Consulta.Location = new Point(203, 14);
            tx_NombreCompleto_Consulta.Name = "tx_NombreCompleto_Consulta";
            tx_NombreCompleto_Consulta.Size = new Size(348, 23);
            tx_NombreCompleto_Consulta.TabIndex = 8;
            // 
            // btn_ConsultarCita_Consultar
            // 
            btn_ConsultarCita_Consultar.Location = new Point(576, 13);
            btn_ConsultarCita_Consultar.Name = "btn_ConsultarCita_Consultar";
            btn_ConsultarCita_Consultar.Size = new Size(109, 23);
            btn_ConsultarCita_Consultar.TabIndex = 9;
            btn_ConsultarCita_Consultar.Text = "Consultar";
            btn_ConsultarCita_Consultar.UseVisualStyleBackColor = true;
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
        private Button btn_AgendarCita_1;
        private Label lbl_paquete_1;
        private Label lbl_apellidos_1;
        private Label lbl_nombre_1;
        private TextBox tb_NumeroDeTelefono_Agendar;
        private TextBox tb_Apellidos_Agendar;
        private TextBox tx_Nombre_Agendar;
        private Label lbl_numeroDeTelefono_1;
        private ComboBox cb_Paquete_Agendar;
        private Label lbl_fecha_1;
        private DateTimePicker date_fechaAgendar;
        private TextBox tx_NombreCompleto_Consulta;
        private Label lbl_NombreCompleto_Consulta;
        private Button btn_ConsultarCita_Consultar;
    }
}