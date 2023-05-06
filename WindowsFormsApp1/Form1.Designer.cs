namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTrabajadorNombre = new System.Windows.Forms.TextBox();
            this.txtCocheMatricula = new System.Windows.Forms.TextBox();
            this.txtCocheMarca = new System.Windows.Forms.TextBox();
            this.txtReparacionCosto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbCocheTipo = new System.Windows.Forms.ComboBox();
            this.cbReparacionTipo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtReparacionDescripcion = new System.Windows.Forms.TextBox();
            this.rbCamion = new System.Windows.Forms.RadioButton();
            this.rbAutoPersonal = new System.Windows.Forms.RadioButton();
            this.rbReparacionEspecializada = new System.Windows.Forms.RadioButton();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dTañocompra = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCedulaTrabajdor = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTrabajadorNombre
            // 
            this.txtTrabajadorNombre.Location = new System.Drawing.Point(726, 116);
            this.txtTrabajadorNombre.Name = "txtTrabajadorNombre";
            this.txtTrabajadorNombre.Size = new System.Drawing.Size(139, 20);
            this.txtTrabajadorNombre.TabIndex = 0;
            // 
            // txtCocheMatricula
            // 
            this.txtCocheMatricula.Location = new System.Drawing.Point(467, 205);
            this.txtCocheMatricula.Name = "txtCocheMatricula";
            this.txtCocheMatricula.Size = new System.Drawing.Size(122, 20);
            this.txtCocheMatricula.TabIndex = 2;
            // 
            // txtCocheMarca
            // 
            this.txtCocheMarca.Location = new System.Drawing.Point(466, 62);
            this.txtCocheMarca.Name = "txtCocheMarca";
            this.txtCocheMarca.Size = new System.Drawing.Size(121, 20);
            this.txtCocheMarca.TabIndex = 3;
            // 
            // txtReparacionCosto
            // 
            this.txtReparacionCosto.Location = new System.Drawing.Point(162, 63);
            this.txtReparacionCosto.Name = "txtReparacionCosto";
            this.txtReparacionCosto.Size = new System.Drawing.Size(138, 20);
            this.txtReparacionCosto.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(733, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Trabajador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(494, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Coche";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(157, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Reparacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(662, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(389, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Matricula";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(407, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Marca";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(371, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Año Compra";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(107, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "Costo";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // cbCocheTipo
            // 
            this.cbCocheTipo.FormattingEnabled = true;
            this.cbCocheTipo.Items.AddRange(new object[] {
            "Camiones",
            "Coche Personal"});
            this.cbCocheTipo.Location = new System.Drawing.Point(466, 159);
            this.cbCocheTipo.Name = "cbCocheTipo";
            this.cbCocheTipo.Size = new System.Drawing.Size(121, 21);
            this.cbCocheTipo.TabIndex = 17;
            // 
            // cbReparacionTipo
            // 
            this.cbReparacionTipo.FormattingEnabled = true;
            this.cbReparacionTipo.Items.AddRange(new object[] {
            "Llenar llantas desinfladas",
            "Reparar motor",
            "Pintar auto",
            "Cambio de aceite",
            "Cambio de llantas"});
            this.cbReparacionTipo.Location = new System.Drawing.Point(161, 106);
            this.cbReparacionTipo.Name = "cbReparacionTipo";
            this.cbReparacionTipo.Size = new System.Drawing.Size(139, 21);
            this.cbReparacionTipo.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(353, 161);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "Tipo De Coche";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(19, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 17);
            this.label12.TabIndex = 20;
            this.label12.Text = "Tipo De Reparacion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(69, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Descripcion";
            // 
            // txtReparacionDescripcion
            // 
            this.txtReparacionDescripcion.Location = new System.Drawing.Point(161, 150);
            this.txtReparacionDescripcion.Multiline = true;
            this.txtReparacionDescripcion.Name = "txtReparacionDescripcion";
            this.txtReparacionDescripcion.Size = new System.Drawing.Size(139, 61);
            this.txtReparacionDescripcion.TabIndex = 21;
            // 
            // rbCamion
            // 
            this.rbCamion.AutoSize = true;
            this.rbCamion.Location = new System.Drawing.Point(39, 235);
            this.rbCamion.Name = "rbCamion";
            this.rbCamion.Size = new System.Drawing.Size(60, 17);
            this.rbCamion.TabIndex = 23;
            this.rbCamion.TabStop = true;
            this.rbCamion.Text = "Camion";
            this.rbCamion.UseVisualStyleBackColor = true;
            // 
            // rbAutoPersonal
            // 
            this.rbAutoPersonal.AutoSize = true;
            this.rbAutoPersonal.Location = new System.Drawing.Point(107, 235);
            this.rbAutoPersonal.Name = "rbAutoPersonal";
            this.rbAutoPersonal.Size = new System.Drawing.Size(115, 17);
            this.rbAutoPersonal.TabIndex = 24;
            this.rbAutoPersonal.TabStop = true;
            this.rbAutoPersonal.Text = "Automovil Personal";
            this.rbAutoPersonal.UseVisualStyleBackColor = true;
            // 
            // rbReparacionEspecializada
            // 
            this.rbReparacionEspecializada.AutoSize = true;
            this.rbReparacionEspecializada.Location = new System.Drawing.Point(228, 235);
            this.rbReparacionEspecializada.Name = "rbReparacionEspecializada";
            this.rbReparacionEspecializada.Size = new System.Drawing.Size(142, 17);
            this.rbReparacionEspecializada.TabIndex = 25;
            this.rbReparacionEspecializada.TabStop = true;
            this.rbReparacionEspecializada.Text = "Reparacion Especializad";
            this.rbReparacionEspecializada.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(356, 285);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(117, 57);
            this.btnGuardar.TabIndex = 26;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dTañocompra
            // 
            this.dTañocompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTañocompra.Location = new System.Drawing.Point(470, 108);
            this.dTañocompra.Name = "dTañocompra";
            this.dTañocompra.Size = new System.Drawing.Size(117, 20);
            this.dTañocompra.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(662, 85);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 17);
            this.label15.TabIndex = 33;
            this.label15.Text = "Cedula";
            // 
            // txtCedulaTrabajdor
            // 
            this.txtCedulaTrabajdor.Location = new System.Drawing.Point(726, 81);
            this.txtCedulaTrabajdor.Name = "txtCedulaTrabajdor";
            this.txtCedulaTrabajdor.Size = new System.Drawing.Size(139, 20);
            this.txtCedulaTrabajdor.TabIndex = 32;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(204, 285);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(117, 20);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(75, 287);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(123, 17);
            this.label16.TabIndex = 31;
            this.label16.Text = "Fecha de Registro";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(778, 161);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(117, 20);
            this.dateTimePicker2.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(614, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Fecha de Nacimiento";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 469);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtCedulaTrabajdor);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dTañocompra);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.rbReparacionEspecializada);
            this.Controls.Add(this.rbAutoPersonal);
            this.Controls.Add(this.rbCamion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtReparacionDescripcion);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbReparacionTipo);
            this.Controls.Add(this.cbCocheTipo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtReparacionCosto);
            this.Controls.Add(this.txtCocheMarca);
            this.Controls.Add(this.txtCocheMatricula);
            this.Controls.Add(this.txtTrabajadorNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTrabajadorNombre;
        private System.Windows.Forms.TextBox txtCocheMatricula;
        private System.Windows.Forms.TextBox txtCocheMarca;
        private System.Windows.Forms.TextBox txtReparacionCosto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbCocheTipo;
        private System.Windows.Forms.ComboBox cbReparacionTipo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtReparacionDescripcion;
        private System.Windows.Forms.RadioButton rbCamion;
        private System.Windows.Forms.RadioButton rbAutoPersonal;
        private System.Windows.Forms.RadioButton rbReparacionEspecializada;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DateTimePicker dTañocompra;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCedulaTrabajdor;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label5;
    }
}

