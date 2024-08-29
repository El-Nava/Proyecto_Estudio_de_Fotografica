﻿namespace Proyecto_Estudio_de_Fotografica
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
            btn_ConsultarCita_Consultar = new Button();
            tb_NombreCompleto_Consulta = new TextBox();
            lbl_NombreCompleto_Consulta = new Label();
            tab_citasAgendadas = new TabPage();
            customButtonRound11 = new Customs.CustomButtonRound1();
            lv_VerCitas = new ListView();
            tab_agendarCitas = new TabPage();
            date_Hora_Agendar = new DateTimePicker();
            tb_anticipo = new TextBox();
            lb_Anticipo = new Label();
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
            tab_citasAgendadas.SuspendLayout();
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
            tab_consultarCitas.Location = new Point(4, 29);
            tab_consultarCitas.Margin = new Padding(3, 4, 3, 4);
            tab_consultarCitas.Name = "tab_consultarCitas";
            tab_consultarCitas.Padding = new Padding(3, 4, 3, 4);
            tab_consultarCitas.Size = new Size(861, 416);
            tab_consultarCitas.TabIndex = 2;
            tab_consultarCitas.Text = "Consultar citas";
            // 
            // btn_ConsultarCita_Consultar
            // 
            btn_ConsultarCita_Consultar.Location = new Point(638, 19);
            btn_ConsultarCita_Consultar.Margin = new Padding(3, 4, 3, 4);
            btn_ConsultarCita_Consultar.Name = "btn_ConsultarCita_Consultar";
            btn_ConsultarCita_Consultar.Size = new Size(125, 31);
            btn_ConsultarCita_Consultar.TabIndex = 9;
            btn_ConsultarCita_Consultar.Text = "Consultar";
            btn_ConsultarCita_Consultar.UseVisualStyleBackColor = true;
            // 
            // tb_NombreCompleto_Consulta
            // 
            tb_NombreCompleto_Consulta.Location = new Point(233, 19);
            tb_NombreCompleto_Consulta.Margin = new Padding(3, 4, 3, 4);
            tb_NombreCompleto_Consulta.Name = "tb_NombreCompleto_Consulta";
            tb_NombreCompleto_Consulta.Size = new Size(397, 27);
            tb_NombreCompleto_Consulta.TabIndex = 8;
            // 
            // lbl_NombreCompleto_Consulta
            // 
            lbl_NombreCompleto_Consulta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_NombreCompleto_Consulta.AutoSize = true;
            lbl_NombreCompleto_Consulta.BackColor = Color.LightGray;
            lbl_NombreCompleto_Consulta.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_NombreCompleto_Consulta.Location = new Point(42, 16);
            lbl_NombreCompleto_Consulta.Name = "lbl_NombreCompleto_Consulta";
            lbl_NombreCompleto_Consulta.Size = new Size(212, 29);
            lbl_NombreCompleto_Consulta.TabIndex = 7;
            lbl_NombreCompleto_Consulta.Text = "Nombre Completo";
            lbl_NombreCompleto_Consulta.TextAlign = ContentAlignment.TopCenter;
            // 
            // tab_citasAgendadas
            // 
            tab_citasAgendadas.BackColor = Color.LightGray;
            tab_citasAgendadas.Controls.Add(customButtonRound11);
            tab_citasAgendadas.Controls.Add(lv_VerCitas);
            tab_citasAgendadas.Location = new Point(4, 29);
            tab_citasAgendadas.Margin = new Padding(3, 4, 3, 4);
            tab_citasAgendadas.Name = "tab_citasAgendadas";
            tab_citasAgendadas.Padding = new Padding(3, 4, 3, 4);
            tab_citasAgendadas.Size = new Size(861, 416);
            tab_citasAgendadas.TabIndex = 1;
            tab_citasAgendadas.Text = "Ver citas agendadas";
            // 
            // customButtonRound11
            // 
            customButtonRound11.BackColor = Color.MediumSlateBlue;
            customButtonRound11.BackGroundColor = Color.MediumSlateBlue;
            customButtonRound11.BorderColor = Color.PaleVioletRed;
            customButtonRound11.BorderRadius = 39;
            customButtonRound11.BorderSize = 0;
            customButtonRound11.FlatAppearance.BorderSize = 0;
            customButtonRound11.FlatStyle = FlatStyle.Flat;
            customButtonRound11.ForeColor = Color.White;
            customButtonRound11.Location = new Point(659, 370);
            customButtonRound11.Name = "customButtonRound11";
            customButtonRound11.Size = new Size(174, 46);
            customButtonRound11.TabIndex = 1;
            customButtonRound11.Text = "Actualizar";
            customButtonRound11.TextColor = Color.White;
            customButtonRound11.UseVisualStyleBackColor = false;
            customButtonRound11.Click += customButtonRound11_Click;
            // 
            // lv_VerCitas
            // 
            lv_VerCitas.Location = new Point(3, 8);
            lv_VerCitas.Margin = new Padding(3, 4, 3, 4);
            lv_VerCitas.Name = "lv_VerCitas";
            lv_VerCitas.Size = new Size(851, 355);
            lv_VerCitas.TabIndex = 0;
            lv_VerCitas.UseCompatibleStateImageBehavior = false;
            // 
            // tab_agendarCitas
            // 
            tab_agendarCitas.Controls.Add(date_Hora_Agendar);
            tab_agendarCitas.Controls.Add(tb_anticipo);
            tab_agendarCitas.Controls.Add(lb_Anticipo);
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
            tab_agendarCitas.Location = new Point(4, 29);
            tab_agendarCitas.Margin = new Padding(3, 4, 3, 4);
            tab_agendarCitas.Name = "tab_agendarCitas";
            tab_agendarCitas.Padding = new Padding(3, 4, 3, 4);
            tab_agendarCitas.Size = new Size(861, 416);
            tab_agendarCitas.TabIndex = 0;
            tab_agendarCitas.Text = "Agendar citas";
            tab_agendarCitas.UseVisualStyleBackColor = true;
            // 
            // date_Hora_Agendar
            // 
            date_Hora_Agendar.CustomFormat = "HH:mm";
            date_Hora_Agendar.Format = DateTimePickerFormat.Custom;
            date_Hora_Agendar.Location = new Point(682, 145);
            date_Hora_Agendar.Name = "date_Hora_Agendar";
            date_Hora_Agendar.ShowUpDown = true;
            date_Hora_Agendar.Size = new Size(87, 27);
            date_Hora_Agendar.TabIndex = 1;
            date_Hora_Agendar.Value = new DateTime(2024, 8, 28, 19, 43, 0, 0);
            // 
            // tb_anticipo
            // 
            tb_anticipo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_anticipo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_anticipo.Location = new Point(151, 147);
            tb_anticipo.Margin = new Padding(3, 4, 3, 4);
            tb_anticipo.Name = "tb_anticipo";
            tb_anticipo.Size = new Size(202, 30);
            tb_anticipo.TabIndex = 16;
            // 
            // lb_Anticipo
            // 
            lb_Anticipo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lb_Anticipo.AutoSize = true;
            lb_Anticipo.BackColor = Color.LightGray;
            lb_Anticipo.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_Anticipo.Location = new Point(19, 147);
            lb_Anticipo.Name = "lb_Anticipo";
            lb_Anticipo.Size = new Size(105, 29);
            lb_Anticipo.TabIndex = 15;
            lb_Anticipo.Text = "Anticipo:";
            lb_Anticipo.TextAlign = ContentAlignment.TopCenter;
            // 
            // tb_Altura_Agendar
            // 
            tb_Altura_Agendar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_Altura_Agendar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_Altura_Agendar.Location = new Point(549, 57);
            tb_Altura_Agendar.Margin = new Padding(3, 4, 3, 4);
            tb_Altura_Agendar.Name = "tb_Altura_Agendar";
            tb_Altura_Agendar.Size = new Size(263, 30);
            tb_Altura_Agendar.TabIndex = 14;
            // 
            // lbl_Altura_Agendar
            // 
            lbl_Altura_Agendar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_Altura_Agendar.AutoSize = true;
            lbl_Altura_Agendar.BackColor = Color.LightGray;
            lbl_Altura_Agendar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Altura_Agendar.Location = new Point(405, 56);
            lbl_Altura_Agendar.Name = "lbl_Altura_Agendar";
            lbl_Altura_Agendar.Size = new Size(116, 29);
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
            cb_Paquete_Agendar.Location = new Point(113, 99);
            cb_Paquete_Agendar.Margin = new Padding(3, 4, 3, 4);
            cb_Paquete_Agendar.Name = "cb_Paquete_Agendar";
            cb_Paquete_Agendar.Size = new Size(317, 33);
            cb_Paquete_Agendar.TabIndex = 12;
            // 
            // lbl_fecha_Agendar
            // 
            lbl_fecha_Agendar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_fecha_Agendar.AutoSize = true;
            lbl_fecha_Agendar.BackColor = Color.LightGray;
            lbl_fecha_Agendar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_fecha_Agendar.Location = new Point(549, 104);
            lbl_fecha_Agendar.Name = "lbl_fecha_Agendar";
            lbl_fecha_Agendar.Size = new Size(80, 29);
            lbl_fecha_Agendar.TabIndex = 11;
            lbl_fecha_Agendar.Text = "Fecha";
            lbl_fecha_Agendar.TextAlign = ContentAlignment.TopCenter;
            // 
            // date_Fecha_Agendar
            // 
            date_Fecha_Agendar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            date_Fecha_Agendar.CustomFormat = "dd/MM/yyyy";
            date_Fecha_Agendar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            date_Fecha_Agendar.Format = DateTimePickerFormat.Custom;
            date_Fecha_Agendar.Location = new Point(532, 145);
            date_Fecha_Agendar.Margin = new Padding(3, 4, 3, 4);
            date_Fecha_Agendar.Name = "date_Fecha_Agendar";
            date_Fecha_Agendar.Size = new Size(129, 30);
            date_Fecha_Agendar.TabIndex = 10;
            // 
            // lbl_numeroDeTelefono_Agendar
            // 
            lbl_numeroDeTelefono_Agendar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_numeroDeTelefono_Agendar.AutoSize = true;
            lbl_numeroDeTelefono_Agendar.BackColor = Color.LightGray;
            lbl_numeroDeTelefono_Agendar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_numeroDeTelefono_Agendar.Location = new Point(27, 56);
            lbl_numeroDeTelefono_Agendar.Name = "lbl_numeroDeTelefono_Agendar";
            lbl_numeroDeTelefono_Agendar.Size = new Size(90, 29);
            lbl_numeroDeTelefono_Agendar.TabIndex = 8;
            lbl_numeroDeTelefono_Agendar.Text = "Celular";
            lbl_numeroDeTelefono_Agendar.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl_paquete_Agendar
            // 
            lbl_paquete_Agendar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_paquete_Agendar.AutoSize = true;
            lbl_paquete_Agendar.BackColor = Color.LightGray;
            lbl_paquete_Agendar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_paquete_Agendar.Location = new Point(21, 111);
            lbl_paquete_Agendar.Name = "lbl_paquete_Agendar";
            lbl_paquete_Agendar.Size = new Size(103, 29);
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
            lbl_apellidos_Agendar.Location = new Point(405, 11);
            lbl_apellidos_Agendar.Name = "lbl_apellidos_Agendar";
            lbl_apellidos_Agendar.Size = new Size(114, 29);
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
            lbl_nombre_Agendar.Location = new Point(19, 13);
            lbl_nombre_Agendar.Name = "lbl_nombre_Agendar";
            lbl_nombre_Agendar.Size = new Size(101, 29);
            lbl_nombre_Agendar.TabIndex = 5;
            lbl_nombre_Agendar.Text = "Nombre";
            lbl_nombre_Agendar.TextAlign = ContentAlignment.TopCenter;
            // 
            // tb_NumeroDeTelefono_Agendar
            // 
            tb_NumeroDeTelefono_Agendar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_NumeroDeTelefono_Agendar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_NumeroDeTelefono_Agendar.Location = new Point(113, 56);
            tb_NumeroDeTelefono_Agendar.Margin = new Padding(3, 4, 3, 4);
            tb_NumeroDeTelefono_Agendar.Name = "tb_NumeroDeTelefono_Agendar";
            tb_NumeroDeTelefono_Agendar.Size = new Size(202, 30);
            tb_NumeroDeTelefono_Agendar.TabIndex = 3;
            // 
            // tb_Apellidos_Agendar
            // 
            tb_Apellidos_Agendar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_Apellidos_Agendar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_Apellidos_Agendar.Location = new Point(549, 11);
            tb_Apellidos_Agendar.Margin = new Padding(3, 4, 3, 4);
            tb_Apellidos_Agendar.Name = "tb_Apellidos_Agendar";
            tb_Apellidos_Agendar.Size = new Size(263, 30);
            tb_Apellidos_Agendar.TabIndex = 2;
            // 
            // tb_Nombre_Agendar
            // 
            tb_Nombre_Agendar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_Nombre_Agendar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_Nombre_Agendar.Location = new Point(113, 11);
            tb_Nombre_Agendar.Margin = new Padding(3, 4, 3, 4);
            tb_Nombre_Agendar.Name = "tb_Nombre_Agendar";
            tb_Nombre_Agendar.Size = new Size(267, 30);
            tb_Nombre_Agendar.TabIndex = 1;
            // 
            // btn_AgendarCita_Agendar
            // 
            btn_AgendarCita_Agendar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_AgendarCita_Agendar.Location = new Point(713, 364);
            btn_AgendarCita_Agendar.Margin = new Padding(3, 4, 3, 4);
            btn_AgendarCita_Agendar.Name = "btn_AgendarCita_Agendar";
            btn_AgendarCita_Agendar.Size = new Size(129, 44);
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
            lbl_fondo.Location = new Point(6, 4);
            lbl_fondo.MaximumSize = new Size(2286, 1200);
            lbl_fondo.Name = "lbl_fondo";
            lbl_fondo.Size = new Size(850, 404);
            lbl_fondo.TabIndex = 0;
            // 
            // tab_menu
            // 
            tab_menu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tab_menu.Controls.Add(tab_agendarCitas);
            tab_menu.Controls.Add(tab_citasAgendadas);
            tab_menu.Controls.Add(tab_consultarCitas);
            tab_menu.Location = new Point(14, 16);
            tab_menu.Margin = new Padding(3, 4, 3, 4);
            tab_menu.Name = "tab_menu";
            tab_menu.SelectedIndex = 0;
            tab_menu.Size = new Size(869, 449);
            tab_menu.TabIndex = 0;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 481);
            Controls.Add(tab_menu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            tab_consultarCitas.ResumeLayout(false);
            tab_consultarCitas.PerformLayout();
            tab_citasAgendadas.ResumeLayout(false);
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
        private TextBox tb_anticipo;
        private Label lb_Anticipo;
        private ListView lv_VerCitas;
        private Customs.CustomButtonRound1 customButtonRound11;
        private DateTimePicker date_Hora_Agendar;
    }
}