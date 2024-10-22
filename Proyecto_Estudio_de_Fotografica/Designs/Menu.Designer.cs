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
            label2 = new Label();
            lb_citas = new Label();
            lv_CitasCliente = new ListView();
            FechaAgendada = new ColumnHeader();
            HoraAgendada = new ColumnHeader();
            EstadoAgendada = new ColumnHeader();
            btn_ConsultarCita_Consultar = new Button();
            tb_NombreCompleto_Consulta = new TextBox();
            lbl_NombreCompleto_Consulta = new Label();
            tab_citasAgendadas = new TabPage();
            bt_CitasdelDia_VerCitas = new Customs.CustomButtonRound1();
            bt_CitasPendientes_VerCitas = new Customs.CustomButtonRound1();
            bt_CitasVencidas_VerCitas = new Customs.CustomButtonRound1();
            btn_EliminarDato = new Customs.CustomButtonRound1();
            btn_VerTodas_VerCitas = new Customs.CustomButtonRound1();
            lv_VerCitas = new ListView();
            CitaID = new ColumnHeader();
            Clientes = new ColumnHeader();
            Fecha = new ColumnHeader();
            Hora = new ColumnHeader();
            Pago = new ColumnHeader();
            Servicio = new ColumnHeader();
            Estadocita = new ColumnHeader();
            tab_agendarCitas = new TabPage();
            label1 = new Label();
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
            tab_consultarCitas.Controls.Add(label2);
            tab_consultarCitas.Controls.Add(lb_citas);
            tab_consultarCitas.Controls.Add(lv_CitasCliente);
            tab_consultarCitas.Controls.Add(btn_ConsultarCita_Consultar);
            tab_consultarCitas.Controls.Add(tb_NombreCompleto_Consulta);
            tab_consultarCitas.Controls.Add(lbl_NombreCompleto_Consulta);
            tab_consultarCitas.Location = new Point(4, 24);
            tab_consultarCitas.Name = "tab_consultarCitas";
            tab_consultarCitas.Padding = new Padding(3);
            tab_consultarCitas.Size = new Size(752, 309);
            tab_consultarCitas.TabIndex = 2;
            tab_consultarCitas.Text = "Consultar Citas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(194, 40);
            label2.Name = "label2";
            label2.Size = new Size(490, 15);
            label2.TabIndex = 12;
            label2.Text = "Nota:  Si solo se ingreso un apellido entonces poner un espacio despues del primer apellido ";
            // 
            // lb_citas
            // 
            lb_citas.AutoSize = true;
            lb_citas.Location = new Point(121, 53);
            lb_citas.Name = "lb_citas";
            lb_citas.Size = new Size(33, 15);
            lb_citas.TabIndex = 11;
            lb_citas.Text = "Citas";
            // 
            // lv_CitasCliente
            // 
            lv_CitasCliente.Columns.AddRange(new ColumnHeader[] { FechaAgendada, HoraAgendada, EstadoAgendada });
            lv_CitasCliente.Location = new Point(13, 70);
            lv_CitasCliente.Margin = new Padding(3, 2, 3, 2);
            lv_CitasCliente.Name = "lv_CitasCliente";
            lv_CitasCliente.Size = new Size(244, 234);
            lv_CitasCliente.TabIndex = 10;
            lv_CitasCliente.UseCompatibleStateImageBehavior = false;
            lv_CitasCliente.View = View.Details;
            // 
            // FechaAgendada
            // 
            FechaAgendada.Text = "Fecha";
            FechaAgendada.Width = 80;
            // 
            // HoraAgendada
            // 
            HoraAgendada.Text = "Hora";
            HoraAgendada.Width = 80;
            // 
            // EstadoAgendada
            // 
            EstadoAgendada.Text = "Estado";
            EstadoAgendada.Width = 80;
            // 
            // btn_ConsultarCita_Consultar
            // 
            btn_ConsultarCita_Consultar.Location = new Point(558, 14);
            btn_ConsultarCita_Consultar.Name = "btn_ConsultarCita_Consultar";
            btn_ConsultarCita_Consultar.Size = new Size(109, 23);
            btn_ConsultarCita_Consultar.TabIndex = 9;
            btn_ConsultarCita_Consultar.Text = "Consultar";
            btn_ConsultarCita_Consultar.UseVisualStyleBackColor = true;
            btn_ConsultarCita_Consultar.Click += btn_ConsultarCita_Consultar_Click;
            // 
            // tb_NombreCompleto_Consulta
            // 
            tb_NombreCompleto_Consulta.Location = new Point(204, 14);
            tb_NombreCompleto_Consulta.Name = "tb_NombreCompleto_Consulta";
            tb_NombreCompleto_Consulta.Size = new Size(348, 23);
            tb_NombreCompleto_Consulta.TabIndex = 8;
            tb_NombreCompleto_Consulta.TextChanged += tb_NombreCompleto_Consulta_TextChanged;
            // 
            // lbl_NombreCompleto_Consulta
            // 
            lbl_NombreCompleto_Consulta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_NombreCompleto_Consulta.AutoSize = true;
            lbl_NombreCompleto_Consulta.BackColor = Color.LightGray;
            lbl_NombreCompleto_Consulta.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_NombreCompleto_Consulta.Location = new Point(13, 11);
            lbl_NombreCompleto_Consulta.Name = "lbl_NombreCompleto_Consulta";
            lbl_NombreCompleto_Consulta.Size = new Size(165, 24);
            lbl_NombreCompleto_Consulta.TabIndex = 7;
            lbl_NombreCompleto_Consulta.Text = "Nombre Completo";
            lbl_NombreCompleto_Consulta.TextAlign = ContentAlignment.TopCenter;
            // 
            // tab_citasAgendadas
            // 
            tab_citasAgendadas.BackColor = Color.LightGray;
            tab_citasAgendadas.Controls.Add(bt_CitasdelDia_VerCitas);
            tab_citasAgendadas.Controls.Add(bt_CitasPendientes_VerCitas);
            tab_citasAgendadas.Controls.Add(bt_CitasVencidas_VerCitas);
            tab_citasAgendadas.Controls.Add(btn_EliminarDato);
            tab_citasAgendadas.Controls.Add(btn_VerTodas_VerCitas);
            tab_citasAgendadas.Controls.Add(lv_VerCitas);
            tab_citasAgendadas.Location = new Point(4, 24);
            tab_citasAgendadas.Name = "tab_citasAgendadas";
            tab_citasAgendadas.Padding = new Padding(3);
            tab_citasAgendadas.Size = new Size(752, 309);
            tab_citasAgendadas.TabIndex = 1;
            tab_citasAgendadas.Text = "Ver Citas Agendadas";
            // 
            // bt_CitasdelDia_VerCitas
            // 
            bt_CitasdelDia_VerCitas.BackColor = Color.Magenta;
            bt_CitasdelDia_VerCitas.BackGroundColor = Color.Magenta;
            bt_CitasdelDia_VerCitas.BorderColor = Color.PaleVioletRed;
            bt_CitasdelDia_VerCitas.BorderRadius = 34;
            bt_CitasdelDia_VerCitas.BorderSize = 0;
            bt_CitasdelDia_VerCitas.FlatAppearance.BorderSize = 0;
            bt_CitasdelDia_VerCitas.FlatStyle = FlatStyle.Flat;
            bt_CitasdelDia_VerCitas.ForeColor = Color.White;
            bt_CitasdelDia_VerCitas.Location = new Point(147, 273);
            bt_CitasdelDia_VerCitas.Margin = new Padding(3, 2, 3, 2);
            bt_CitasdelDia_VerCitas.Name = "bt_CitasdelDia_VerCitas";
            bt_CitasdelDia_VerCitas.Size = new Size(152, 34);
            bt_CitasdelDia_VerCitas.TabIndex = 6;
            bt_CitasdelDia_VerCitas.Text = "Ver Citas del Día";
            bt_CitasdelDia_VerCitas.TextColor = Color.White;
            bt_CitasdelDia_VerCitas.UseVisualStyleBackColor = false;
            bt_CitasdelDia_VerCitas.Click += bt_CitasdelDia_VerCitas_Click;
            // 
            // bt_CitasPendientes_VerCitas
            // 
            bt_CitasPendientes_VerCitas.BackColor = Color.MediumSlateBlue;
            bt_CitasPendientes_VerCitas.BackGroundColor = Color.MediumSlateBlue;
            bt_CitasPendientes_VerCitas.BorderColor = Color.PaleVioletRed;
            bt_CitasPendientes_VerCitas.BorderRadius = 34;
            bt_CitasPendientes_VerCitas.BorderSize = 0;
            bt_CitasPendientes_VerCitas.FlatAppearance.BorderSize = 0;
            bt_CitasPendientes_VerCitas.FlatStyle = FlatStyle.Flat;
            bt_CitasPendientes_VerCitas.ForeColor = Color.White;
            bt_CitasPendientes_VerCitas.Location = new Point(308, 273);
            bt_CitasPendientes_VerCitas.Margin = new Padding(3, 2, 3, 2);
            bt_CitasPendientes_VerCitas.Name = "bt_CitasPendientes_VerCitas";
            bt_CitasPendientes_VerCitas.Size = new Size(152, 34);
            bt_CitasPendientes_VerCitas.TabIndex = 5;
            bt_CitasPendientes_VerCitas.Text = "Ver Citas Pendientes";
            bt_CitasPendientes_VerCitas.TextColor = Color.White;
            bt_CitasPendientes_VerCitas.UseVisualStyleBackColor = false;
            bt_CitasPendientes_VerCitas.Click += bt_CitasPendientes_VerCitas_Click;
            // 
            // bt_CitasVencidas_VerCitas
            // 
            bt_CitasVencidas_VerCitas.BackColor = Color.MediumSlateBlue;
            bt_CitasVencidas_VerCitas.BackGroundColor = Color.MediumSlateBlue;
            bt_CitasVencidas_VerCitas.BorderColor = Color.PaleVioletRed;
            bt_CitasVencidas_VerCitas.BorderRadius = 34;
            bt_CitasVencidas_VerCitas.BorderSize = 0;
            bt_CitasVencidas_VerCitas.FlatAppearance.BorderSize = 0;
            bt_CitasVencidas_VerCitas.FlatStyle = FlatStyle.Flat;
            bt_CitasVencidas_VerCitas.ForeColor = Color.White;
            bt_CitasVencidas_VerCitas.Location = new Point(473, 273);
            bt_CitasVencidas_VerCitas.Margin = new Padding(3, 2, 3, 2);
            bt_CitasVencidas_VerCitas.Name = "bt_CitasVencidas_VerCitas";
            bt_CitasVencidas_VerCitas.Size = new Size(152, 34);
            bt_CitasVencidas_VerCitas.TabIndex = 4;
            bt_CitasVencidas_VerCitas.Text = "Ver Citas Vencidas";
            bt_CitasVencidas_VerCitas.TextColor = Color.White;
            bt_CitasVencidas_VerCitas.UseVisualStyleBackColor = false;
            bt_CitasVencidas_VerCitas.Click += bt_CitasVencidas_VerCitas_Click;
            // 
            // btn_EliminarDato
            // 
            btn_EliminarDato.BackColor = Color.MediumSlateBlue;
            btn_EliminarDato.BackGroundColor = Color.MediumSlateBlue;
            btn_EliminarDato.BorderColor = Color.PaleVioletRed;
            btn_EliminarDato.BorderRadius = 34;
            btn_EliminarDato.BorderSize = 0;
            btn_EliminarDato.FlatAppearance.BorderSize = 0;
            btn_EliminarDato.FlatStyle = FlatStyle.Flat;
            btn_EliminarDato.ForeColor = Color.White;
            btn_EliminarDato.Location = new Point(642, 273);
            btn_EliminarDato.Margin = new Padding(3, 2, 3, 2);
            btn_EliminarDato.Name = "btn_EliminarDato";
            btn_EliminarDato.Size = new Size(100, 34);
            btn_EliminarDato.TabIndex = 3;
            btn_EliminarDato.Text = "Eliminar";
            btn_EliminarDato.TextColor = Color.White;
            btn_EliminarDato.UseVisualStyleBackColor = false;
            btn_EliminarDato.Click += btn_EliminarDato_Click;
            // 
            // btn_VerTodas_VerCitas
            // 
            btn_VerTodas_VerCitas.BackColor = Color.MediumSlateBlue;
            btn_VerTodas_VerCitas.BackGroundColor = Color.MediumSlateBlue;
            btn_VerTodas_VerCitas.BorderColor = Color.PaleVioletRed;
            btn_VerTodas_VerCitas.BorderRadius = 34;
            btn_VerTodas_VerCitas.BorderSize = 0;
            btn_VerTodas_VerCitas.FlatAppearance.BorderSize = 0;
            btn_VerTodas_VerCitas.FlatStyle = FlatStyle.Flat;
            btn_VerTodas_VerCitas.ForeColor = Color.White;
            btn_VerTodas_VerCitas.Location = new Point(6, 273);
            btn_VerTodas_VerCitas.Margin = new Padding(3, 2, 3, 2);
            btn_VerTodas_VerCitas.Name = "btn_VerTodas_VerCitas";
            btn_VerTodas_VerCitas.Size = new Size(135, 34);
            btn_VerTodas_VerCitas.TabIndex = 2;
            btn_VerTodas_VerCitas.Text = "Ver Todas las Citas";
            btn_VerTodas_VerCitas.TextColor = Color.White;
            btn_VerTodas_VerCitas.UseVisualStyleBackColor = false;
            btn_VerTodas_VerCitas.Click += btn_VerTodas_VerCitas_Click;
            // 
            // lv_VerCitas
            // 
            lv_VerCitas.AllowColumnReorder = true;
            lv_VerCitas.Columns.AddRange(new ColumnHeader[] { CitaID, Clientes, Fecha, Hora, Pago, Servicio, Estadocita });
            lv_VerCitas.FullRowSelect = true;
            lv_VerCitas.GridLines = true;
            lv_VerCitas.Location = new Point(4, 3);
            lv_VerCitas.Name = "lv_VerCitas";
            lv_VerCitas.ShowItemToolTips = true;
            lv_VerCitas.Size = new Size(745, 267);
            lv_VerCitas.TabIndex = 0;
            lv_VerCitas.UseCompatibleStateImageBehavior = false;
            lv_VerCitas.View = View.Details;
            lv_VerCitas.ColumnClick += lv_VerCitas_ColumnClick;
            lv_VerCitas.SelectedIndexChanged += lv_VerCitas_SelectedIndexChanged;
            // 
            // CitaID
            // 
            CitaID.Text = "ID";
            CitaID.Width = 30;
            // 
            // Clientes
            // 
            Clientes.Text = "Clientes";
            Clientes.TextAlign = HorizontalAlignment.Center;
            Clientes.Width = 250;
            // 
            // Fecha
            // 
            Fecha.Text = "Fecha";
            Fecha.TextAlign = HorizontalAlignment.Center;
            Fecha.Width = 100;
            // 
            // Hora
            // 
            Hora.Text = "Hora";
            Hora.TextAlign = HorizontalAlignment.Center;
            Hora.Width = 100;
            // 
            // Pago
            // 
            Pago.Text = "Pago";
            Pago.TextAlign = HorizontalAlignment.Center;
            Pago.Width = 80;
            // 
            // Servicio
            // 
            Servicio.Text = "Servicio";
            Servicio.TextAlign = HorizontalAlignment.Center;
            Servicio.Width = 157;
            // 
            // Estadocita
            // 
            Estadocita.Tag = "";
            Estadocita.Text = "Estado";
            Estadocita.TextAlign = HorizontalAlignment.Center;
            Estadocita.Width = 130;
            // 
            // tab_agendarCitas
            // 
            tab_agendarCitas.Controls.Add(label1);
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
            tab_agendarCitas.Location = new Point(4, 24);
            tab_agendarCitas.Name = "tab_agendarCitas";
            tab_agendarCitas.Padding = new Padding(3);
            tab_agendarCitas.Size = new Size(752, 309);
            tab_agendarCitas.TabIndex = 0;
            tab_agendarCitas.Text = "Agendar Citas";
            tab_agendarCitas.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.LightGray;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(619, 124);
            label1.Name = "label1";
            label1.Size = new Size(51, 24);
            label1.TabIndex = 16;
            label1.Text = "Hora";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // date_Hora_Agendar
            // 
            date_Hora_Agendar.CustomFormat = "HH:mm";
            date_Hora_Agendar.Font = new Font("Microsoft Sans Serif", 12F);
            date_Hora_Agendar.Format = DateTimePickerFormat.Custom;
            date_Hora_Agendar.Location = new Point(608, 151);
            date_Hora_Agendar.Margin = new Padding(3, 2, 3, 2);
            date_Hora_Agendar.Name = "date_Hora_Agendar";
            date_Hora_Agendar.ShowUpDown = true;
            date_Hora_Agendar.Size = new Size(77, 26);
            date_Hora_Agendar.TabIndex = 8;
            date_Hora_Agendar.Value = new DateTime(2024, 8, 28, 19, 43, 0, 0);
            // 
            // tb_anticipo
            // 
            tb_anticipo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_anticipo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_anticipo.Location = new Point(104, 213);
            tb_anticipo.Name = "tb_anticipo";
            tb_anticipo.Size = new Size(247, 26);
            tb_anticipo.TabIndex = 6;
            tb_anticipo.KeyPress += tb_anticipo_KeyPress;
            // 
            // lb_Anticipo
            // 
            lb_Anticipo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lb_Anticipo.AutoSize = true;
            lb_Anticipo.BackColor = Color.LightGray;
            lb_Anticipo.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_Anticipo.Location = new Point(8, 213);
            lb_Anticipo.Name = "lb_Anticipo";
            lb_Anticipo.Size = new Size(78, 24);
            lb_Anticipo.TabIndex = 15;
            lb_Anticipo.Text = "Anticipo";
            lb_Anticipo.TextAlign = ContentAlignment.TopCenter;
            // 
            // tb_Altura_Agendar
            // 
            tb_Altura_Agendar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_Altura_Agendar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_Altura_Agendar.Location = new Point(500, 69);
            tb_Altura_Agendar.Name = "tb_Altura_Agendar";
            tb_Altura_Agendar.Size = new Size(94, 26);
            tb_Altura_Agendar.TabIndex = 4;
            tb_Altura_Agendar.KeyPress += tb_Altura_Agendar_KeyPress;
            // 
            // lbl_Altura_Agendar
            // 
            lbl_Altura_Agendar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_Altura_Agendar.AutoSize = true;
            lbl_Altura_Agendar.BackColor = Color.LightGray;
            lbl_Altura_Agendar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Altura_Agendar.Location = new Point(393, 69);
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
            cb_Paquete_Agendar.Location = new Point(101, 124);
            cb_Paquete_Agendar.Name = "cb_Paquete_Agendar";
            cb_Paquete_Agendar.Size = new Size(249, 28);
            cb_Paquete_Agendar.TabIndex = 5;
            // 
            // lbl_fecha_Agendar
            // 
            lbl_fecha_Agendar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_fecha_Agendar.AutoSize = true;
            lbl_fecha_Agendar.BackColor = Color.LightGray;
            lbl_fecha_Agendar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_fecha_Agendar.Location = new Point(453, 124);
            lbl_fecha_Agendar.Name = "lbl_fecha_Agendar";
            lbl_fecha_Agendar.Size = new Size(64, 24);
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
            date_Fecha_Agendar.Location = new Point(434, 151);
            date_Fecha_Agendar.Name = "date_Fecha_Agendar";
            date_Fecha_Agendar.Size = new Size(113, 26);
            date_Fecha_Agendar.TabIndex = 7;
            // 
            // lbl_numeroDeTelefono_Agendar
            // 
            lbl_numeroDeTelefono_Agendar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_numeroDeTelefono_Agendar.AutoSize = true;
            lbl_numeroDeTelefono_Agendar.BackColor = Color.LightGray;
            lbl_numeroDeTelefono_Agendar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_numeroDeTelefono_Agendar.Location = new Point(7, 70);
            lbl_numeroDeTelefono_Agendar.Name = "lbl_numeroDeTelefono_Agendar";
            lbl_numeroDeTelefono_Agendar.Size = new Size(69, 24);
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
            lbl_paquete_Agendar.Location = new Point(6, 124);
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
            lbl_apellidos_Agendar.Location = new Point(393, 22);
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
            lbl_nombre_Agendar.Location = new Point(7, 25);
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
            tb_NumeroDeTelefono_Agendar.Location = new Point(101, 68);
            tb_NumeroDeTelefono_Agendar.Name = "tb_NumeroDeTelefono_Agendar";
            tb_NumeroDeTelefono_Agendar.Size = new Size(249, 26);
            tb_NumeroDeTelefono_Agendar.TabIndex = 3;
            tb_NumeroDeTelefono_Agendar.KeyPress += tb_NumeroDeTelefono_Agendar_KeyPress;
            // 
            // tb_Apellidos_Agendar
            // 
            tb_Apellidos_Agendar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_Apellidos_Agendar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_Apellidos_Agendar.Location = new Point(500, 22);
            tb_Apellidos_Agendar.Name = "tb_Apellidos_Agendar";
            tb_Apellidos_Agendar.Size = new Size(231, 26);
            tb_Apellidos_Agendar.TabIndex = 2;
            tb_Apellidos_Agendar.TextChanged += tb_Apellidos_Agendar_TextChanged;
            // 
            // tb_Nombre_Agendar
            // 
            tb_Nombre_Agendar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_Nombre_Agendar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_Nombre_Agendar.Location = new Point(101, 24);
            tb_Nombre_Agendar.Name = "tb_Nombre_Agendar";
            tb_Nombre_Agendar.Size = new Size(250, 26);
            tb_Nombre_Agendar.TabIndex = 1;
            tb_Nombre_Agendar.TextChanged += tb_Nombre_Agendar_TextChanged;
            // 
            // btn_AgendarCita_Agendar
            // 
            btn_AgendarCita_Agendar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_AgendarCita_Agendar.Location = new Point(608, 252);
            btn_AgendarCita_Agendar.Name = "btn_AgendarCita_Agendar";
            btn_AgendarCita_Agendar.Size = new Size(113, 33);
            btn_AgendarCita_Agendar.TabIndex = 9;
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
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
        internal TabPage tab_consultarCitas;
        internal TabPage tab_citasAgendadas;
        internal TabPage tab_agendarCitas;
        internal TabControl tab_menu;
        internal Label lbl_fondo;
        internal System.ComponentModel.BackgroundWorker backgroundWorker1;
        internal Button btn_AgendarCita_Agendar;
        internal Label lbl_paquete_Agendar;
        internal Label lbl_apellidos_Agendar;
        internal Label lbl_nombre_Agendar;
        internal TextBox tb_NumeroDeTelefono_Agendar;
        internal TextBox tb_Apellidos_Agendar;
        internal TextBox tb_Nombre_Agendar;
        internal Label lbl_numeroDeTelefono_Agendar;
        internal ComboBox cb_Paquete_Agendar;
        internal Label lbl_fecha_Agendar;
        internal DateTimePicker date_Fecha_Agendar;
        internal TextBox tb_NombreCompleto_Consulta;
        internal Label lbl_NombreCompleto_Consulta;
        internal Button btn_ConsultarCita_Consultar;
        internal Label lbl_Altura_Agendar;
        internal TextBox tb_Altura_Agendar;
        internal TextBox tb_anticipo;
        internal Label lb_Anticipo;
        public ListView lv_VerCitas;
        internal DateTimePicker date_Hora_Agendar;
        internal Customs.CustomButtonRound1 btn_VerTodas_VerCitas;
        internal Customs.CustomButtonRound1 btn_EliminarDato;
        internal Customs.CustomButtonRound1 bt_CitasVencidas_VerCitas;
        internal Customs.CustomButtonRound1 bt_CitasdelDia_VerCitas;
        internal Customs.CustomButtonRound1 bt_CitasPendientes_VerCitas;
        internal Label label1;
        private ColumnHeader Clientes;
        private ColumnHeader Fecha;
        private ColumnHeader Hora;
        private ColumnHeader Pago;
        private ColumnHeader Servicio;
        private ColumnHeader Estadocita;
        private ColumnHeader CitaID;
        private Label lb_citas;
        internal ListView lv_CitasCliente;
        private ColumnHeader FechaAgendada;
        private ColumnHeader HoraAgendada;
        private ColumnHeader EstadoAgendada;
        private Label label2;
    }
}