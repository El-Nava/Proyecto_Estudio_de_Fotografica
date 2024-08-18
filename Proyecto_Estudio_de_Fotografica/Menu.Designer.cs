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
            cb_paqueteAgendar = new ComboBox();
            lbl_fecha = new Label();
            date_fechaAgendar = new DateTimePicker();
            lbl_numeroDeTelefono = new Label();
            lbl_paquete = new Label();
            lbl_apellidos = new Label();
            lbl_nombre = new Label();
            tb_numeroDeTelefonoAgendar = new TextBox();
            tb_apellidosAgendar = new TextBox();
            tx_nombreAgendar = new TextBox();
            btn_agendarCita = new Button();
            lbl_fondo = new Label();
            tab_menu = new TabControl();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tab_agendarCitas.SuspendLayout();
            tab_menu.SuspendLayout();
            SuspendLayout();
            // 
            // tab_consultarCitas
            // 
            tab_consultarCitas.Location = new Point(4, 24);
            tab_consultarCitas.Name = "tab_consultarCitas";
            tab_consultarCitas.Padding = new Padding(3);
            tab_consultarCitas.Size = new Size(752, 309);
            tab_consultarCitas.TabIndex = 2;
            tab_consultarCitas.Text = "Consultar citas";
            tab_consultarCitas.UseVisualStyleBackColor = true;
            // 
            // tab_citasAgendadas
            // 
            tab_citasAgendadas.Location = new Point(4, 24);
            tab_citasAgendadas.Name = "tab_citasAgendadas";
            tab_citasAgendadas.Padding = new Padding(3);
            tab_citasAgendadas.Size = new Size(752, 309);
            tab_citasAgendadas.TabIndex = 1;
            tab_citasAgendadas.Text = "Ver citas agendadas";
            tab_citasAgendadas.UseVisualStyleBackColor = true;
            // 
            // tab_agendarCitas
            // 
            tab_agendarCitas.Controls.Add(cb_paqueteAgendar);
            tab_agendarCitas.Controls.Add(lbl_fecha);
            tab_agendarCitas.Controls.Add(date_fechaAgendar);
            tab_agendarCitas.Controls.Add(lbl_numeroDeTelefono);
            tab_agendarCitas.Controls.Add(lbl_paquete);
            tab_agendarCitas.Controls.Add(lbl_apellidos);
            tab_agendarCitas.Controls.Add(lbl_nombre);
            tab_agendarCitas.Controls.Add(tb_numeroDeTelefonoAgendar);
            tab_agendarCitas.Controls.Add(tb_apellidosAgendar);
            tab_agendarCitas.Controls.Add(tx_nombreAgendar);
            tab_agendarCitas.Controls.Add(btn_agendarCita);
            tab_agendarCitas.Controls.Add(lbl_fondo);
            tab_agendarCitas.Location = new Point(4, 24);
            tab_agendarCitas.Name = "tab_agendarCitas";
            tab_agendarCitas.Padding = new Padding(3);
            tab_agendarCitas.Size = new Size(752, 309);
            tab_agendarCitas.TabIndex = 0;
            tab_agendarCitas.Text = "Agendar citas";
            tab_agendarCitas.UseVisualStyleBackColor = true;
            // 
            // cb_paqueteAgendar
            // 
            cb_paqueteAgendar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cb_paqueteAgendar.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_paqueteAgendar.FormattingEnabled = true;
            cb_paqueteAgendar.Items.AddRange(new object[] { "Paquete 1", "Paquete 2", "Paquete 3" });
            cb_paqueteAgendar.Location = new Point(342, 168);
            cb_paqueteAgendar.Name = "cb_paqueteAgendar";
            cb_paqueteAgendar.Size = new Size(256, 28);
            cb_paqueteAgendar.TabIndex = 12;
            // 
            // lbl_fecha
            // 
            lbl_fecha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_fecha.AutoSize = true;
            lbl_fecha.BackColor = Color.LightGray;
            lbl_fecha.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_fecha.Location = new Point(253, 203);
            lbl_fecha.Name = "lbl_fecha";
            lbl_fecha.Size = new Size(65, 22);
            lbl_fecha.TabIndex = 11;
            lbl_fecha.Text = "Fecha";
            lbl_fecha.TextAlign = ContentAlignment.TopCenter;
            // 
            // date_fechaAgendar
            // 
            date_fechaAgendar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            date_fechaAgendar.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            date_fechaAgendar.Location = new Point(342, 202);
            date_fechaAgendar.Name = "date_fechaAgendar";
            date_fechaAgendar.Size = new Size(256, 26);
            date_fechaAgendar.TabIndex = 10;
            // 
            // lbl_numeroDeTelefono
            // 
            lbl_numeroDeTelefono.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_numeroDeTelefono.AutoSize = true;
            lbl_numeroDeTelefono.BackColor = Color.LightGray;
            lbl_numeroDeTelefono.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_numeroDeTelefono.Location = new Point(131, 138);
            lbl_numeroDeTelefono.Name = "lbl_numeroDeTelefono";
            lbl_numeroDeTelefono.Size = new Size(188, 22);
            lbl_numeroDeTelefono.TabIndex = 8;
            lbl_numeroDeTelefono.Text = "Numero de telefono";
            lbl_numeroDeTelefono.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl_paquete
            // 
            lbl_paquete.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_paquete.AutoSize = true;
            lbl_paquete.BackColor = Color.LightGray;
            lbl_paquete.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_paquete.Location = new Point(232, 171);
            lbl_paquete.Name = "lbl_paquete";
            lbl_paquete.Size = new Size(86, 22);
            lbl_paquete.TabIndex = 7;
            lbl_paquete.Text = "Paquete";
            lbl_paquete.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl_apellidos
            // 
            lbl_apellidos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_apellidos.AutoSize = true;
            lbl_apellidos.BackColor = Color.LightGray;
            lbl_apellidos.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_apellidos.Location = new Point(222, 105);
            lbl_apellidos.Name = "lbl_apellidos";
            lbl_apellidos.Size = new Size(95, 22);
            lbl_apellidos.TabIndex = 6;
            lbl_apellidos.Text = "Apellidos";
            lbl_apellidos.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl_nombre
            // 
            lbl_nombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_nombre.AutoSize = true;
            lbl_nombre.BackColor = Color.LightGray;
            lbl_nombre.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_nombre.Location = new Point(234, 74);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(83, 22);
            lbl_nombre.TabIndex = 5;
            lbl_nombre.Text = "Nombre";
            lbl_nombre.TextAlign = ContentAlignment.TopCenter;
            // 
            // tb_numeroDeTelefonoAgendar
            // 
            tb_numeroDeTelefonoAgendar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_numeroDeTelefonoAgendar.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_numeroDeTelefonoAgendar.Location = new Point(342, 134);
            tb_numeroDeTelefonoAgendar.Name = "tb_numeroDeTelefonoAgendar";
            tb_numeroDeTelefonoAgendar.Size = new Size(256, 29);
            tb_numeroDeTelefonoAgendar.TabIndex = 3;
            // 
            // tb_apellidosAgendar
            // 
            tb_apellidosAgendar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_apellidosAgendar.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_apellidosAgendar.Location = new Point(342, 104);
            tb_apellidosAgendar.Name = "tb_apellidosAgendar";
            tb_apellidosAgendar.Size = new Size(256, 26);
            tb_apellidosAgendar.TabIndex = 2;
            // 
            // tx_nombreAgendar
            // 
            tx_nombreAgendar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tx_nombreAgendar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tx_nombreAgendar.Location = new Point(342, 70);
            tx_nombreAgendar.Name = "tx_nombreAgendar";
            tx_nombreAgendar.Size = new Size(256, 29);
            tx_nombreAgendar.TabIndex = 1;
            // 
            // btn_agendarCita
            // 
            btn_agendarCita.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_agendarCita.Location = new Point(485, 250);
            btn_agendarCita.Name = "btn_agendarCita";
            btn_agendarCita.Size = new Size(113, 33);
            btn_agendarCita.TabIndex = 1;
            btn_agendarCita.Text = "Agendar cita";
            btn_agendarCita.UseVisualStyleBackColor = true;
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
        private Button btn_agendarCita;
        private Label lbl_paquete;
        private Label lbl_apellidos;
        private Label lbl_nombre;
        private TextBox tb_numeroDeTelefonoAgendar;
        private TextBox tb_apellidosAgendar;
        private TextBox tx_nombreAgendar;
        private Label lbl_numeroDeTelefono;
        private ComboBox cb_paqueteAgendar;
        private Label lbl_fecha;
        private DateTimePicker date_fechaAgendar;
    }
}