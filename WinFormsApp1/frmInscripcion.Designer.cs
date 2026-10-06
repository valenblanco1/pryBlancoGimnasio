namespace WinFormsApp1
{
    partial class frmInscripcion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInscripcion));
            groupBox1 = new GroupBox();
            chkEstudiante = new CheckBox();
            txtEdad = new TextBox();
            txtNombre = new TextBox();
            lblEdad = new Label();
            lblNombre = new Label();
            groupBox2 = new GroupBox();
            chkCasillero = new CheckBox();
            txtMeses = new TextBox();
            cboTurno = new ComboBox();
            cboPlan = new ComboBox();
            lblPlan = new Label();
            lblTurno = new Label();
            lblMeses = new Label();
            groupBox3 = new GroupBox();
            cboCuotas = new ComboBox();
            lblCuotas = new Label();
            rbtTarjeta = new RadioButton();
            rbtEfectivo = new RadioButton();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkEstudiante);
            groupBox1.Controls.Add(txtEdad);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(lblEdad);
            groupBox1.Controls.Add(lblNombre);
            groupBox1.Location = new Point(25, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(236, 134);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Personales";
            // 
            // chkEstudiante
            // 
            chkEstudiante.AutoSize = true;
            chkEstudiante.Location = new Point(125, 82);
            chkEstudiante.Name = "chkEstudiante";
            chkEstudiante.Size = new Size(81, 19);
            chkEstudiante.TabIndex = 4;
            chkEstudiante.Text = "Estudiante";
            chkEstudiante.UseVisualStyleBackColor = true;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(66, 47);
            txtEdad.MaxLength = 3;
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(55, 23);
            txtEdad.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(66, 19);
            txtNombre.MaxLength = 30;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(126, 23);
            txtNombre.TabIndex = 2;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(3, 50);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 1;
            lblEdad.Text = "Edad";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(3, 19);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            lblNombre.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chkCasillero);
            groupBox2.Controls.Add(txtMeses);
            groupBox2.Controls.Add(cboTurno);
            groupBox2.Controls.Add(cboPlan);
            groupBox2.Controls.Add(lblPlan);
            groupBox2.Controls.Add(lblTurno);
            groupBox2.Controls.Add(lblMeses);
            groupBox2.Location = new Point(25, 180);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(236, 134);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Plan";
            // 
            // chkCasillero
            // 
            chkCasillero.AutoSize = true;
            chkCasillero.Location = new Point(73, 106);
            chkCasillero.Name = "chkCasillero";
            chkCasillero.Size = new Size(145, 19);
            chkCasillero.TabIndex = 8;
            chkCasillero.Text = "Casillero ($ 3.000/mes)";
            chkCasillero.UseVisualStyleBackColor = true;
            // 
            // txtMeses
            // 
            txtMeses.Location = new Point(64, 77);
            txtMeses.MaxLength = 2;
            txtMeses.Name = "txtMeses";
            txtMeses.Size = new Size(32, 23);
            txtMeses.TabIndex = 7;
            // 
            // cboTurno
            // 
            cboTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTurno.FormattingEnabled = true;
            cboTurno.Items.AddRange(new object[] { "Mañana", "Tarde", "Noche" });
            cboTurno.Location = new Point(64, 48);
            cboTurno.Name = "cboTurno";
            cboTurno.Size = new Size(93, 23);
            cboTurno.TabIndex = 6;
            // 
            // cboPlan
            // 
            cboPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPlan.FormattingEnabled = true;
            cboPlan.Items.AddRange(new object[] { "Musculación", "Funcional", "Natación" });
            cboPlan.Location = new Point(64, 17);
            cboPlan.Name = "cboPlan";
            cboPlan.Size = new Size(116, 23);
            cboPlan.TabIndex = 5;
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Location = new Point(6, 19);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(30, 15);
            lblPlan.TabIndex = 2;
            lblPlan.Text = "Plan";
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Location = new Point(6, 50);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(39, 15);
            lblTurno.TabIndex = 3;
            lblTurno.Text = "Turno";
            // 
            // lblMeses
            // 
            lblMeses.AutoSize = true;
            lblMeses.Location = new Point(6, 80);
            lblMeses.Name = "lblMeses";
            lblMeses.Size = new Size(40, 15);
            lblMeses.TabIndex = 4;
            lblMeses.Text = "Meses";
            lblMeses.Click += lblMeses_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cboCuotas);
            groupBox3.Controls.Add(lblCuotas);
            groupBox3.Controls.Add(rbtTarjeta);
            groupBox3.Controls.Add(rbtEfectivo);
            groupBox3.Location = new Point(315, 29);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(136, 136);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Forma de pago";
            // 
            // cboCuotas
            // 
            cboCuotas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCuotas.FormattingEnabled = true;
            cboCuotas.Items.AddRange(new object[] { "1", "3", "6" });
            cboCuotas.Location = new Point(76, 85);
            cboCuotas.Name = "cboCuotas";
            cboCuotas.Size = new Size(34, 23);
            cboCuotas.TabIndex = 3;
            // 
            // lblCuotas
            // 
            lblCuotas.AutoSize = true;
            lblCuotas.Location = new Point(26, 88);
            lblCuotas.Name = "lblCuotas";
            lblCuotas.Size = new Size(44, 15);
            lblCuotas.TabIndex = 2;
            lblCuotas.Text = "Cuotas";
            lblCuotas.Click += lblCuotas_Click;
            // 
            // rbtTarjeta
            // 
            rbtTarjeta.AutoSize = true;
            rbtTarjeta.Location = new Point(26, 52);
            rbtTarjeta.Name = "rbtTarjeta";
            rbtTarjeta.Size = new Size(60, 19);
            rbtTarjeta.TabIndex = 1;
            rbtTarjeta.TabStop = true;
            rbtTarjeta.Text = "Tarjeta";
            rbtTarjeta.UseVisualStyleBackColor = true;
            rbtTarjeta.CheckedChanged += rbtTarjeta_CheckedChanged;
            // 
            // rbtEfectivo
            // 
            rbtEfectivo.AutoSize = true;
            rbtEfectivo.Location = new Point(26, 27);
            rbtEfectivo.Name = "rbtEfectivo";
            rbtEfectivo.Size = new Size(67, 19);
            rbtEfectivo.TabIndex = 0;
            rbtEfectivo.TabStop = true;
            rbtEfectivo.Text = "Efectivo";
            rbtEfectivo.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(324, 197);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(114, 43);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "&Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(324, 257);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(114, 43);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "&Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // frmInscripcion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 432);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "frmInscripcion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gimnasio Siglo 21 Inscripción";
            Load += frmInscripcion_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblEdad;
        private Label lblNombre;
        private TextBox txtEdad;
        private TextBox txtNombre;
        private CheckBox chkEstudiante;
        private GroupBox groupBox2;
        private ComboBox cboTurno;
        private ComboBox cboPlan;
        private Label lblPlan;
        private Label lblTurno;
        private Label lblMeses;
        private TextBox txtMeses;
        private CheckBox chkCasillero;
        private GroupBox groupBox3;
        private ComboBox cboCuotas;
        private Label lblCuotas;
        private RadioButton rbtTarjeta;
        private RadioButton rbtEfectivo;
        private Button btnCalcular;
        private Button btnLimpiar;
    }
}