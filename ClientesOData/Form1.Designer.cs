
namespace ClientesOData
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxFechaNac = new System.Windows.Forms.TextBox();
            this.textBoxFuerza = new System.Windows.Forms.TextBox();
            this.textBoxUbicacion = new System.Windows.Forms.TextBox();
            this.textBoxUbicacionAdd = new System.Windows.Forms.TextBox();
            this.textBoxFuerzaAdd = new System.Windows.Forms.TextBox();
            this.textBoxNombreAdd = new System.Windows.Forms.TextBox();
            this.textBoxIdAdd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btAnadir = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxNumEjercitos = new System.Windows.Forms.TextBox();
            this.textBoxFuerzaTotal = new System.Windows.Forms.TextBox();
            this.textBoxFuerzaMedia = new System.Windows.Forms.TextBox();
            this.textBoxAnosTotales = new System.Windows.Forms.TextBox();
            this.textBoxAnosMedia = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(69, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(928, 521);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(289, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "LISTADO DE EJERCITOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1237, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(420, 54);
            this.label2.TabIndex = 2;
            this.label2.Text = "EJERCITO MAS FUERTE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1142, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1142, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1142, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fecha de Nacimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1142, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fuerza de Combate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1142, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ubicacion";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(1346, 161);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(401, 31);
            this.textBoxId.TabIndex = 8;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(1346, 209);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.ReadOnly = true;
            this.textBoxNombre.Size = new System.Drawing.Size(401, 31);
            this.textBoxNombre.TabIndex = 9;
            // 
            // textBoxFechaNac
            // 
            this.textBoxFechaNac.Location = new System.Drawing.Point(1346, 257);
            this.textBoxFechaNac.Name = "textBoxFechaNac";
            this.textBoxFechaNac.ReadOnly = true;
            this.textBoxFechaNac.Size = new System.Drawing.Size(401, 31);
            this.textBoxFechaNac.TabIndex = 10;
            // 
            // textBoxFuerza
            // 
            this.textBoxFuerza.Location = new System.Drawing.Point(1346, 316);
            this.textBoxFuerza.Name = "textBoxFuerza";
            this.textBoxFuerza.ReadOnly = true;
            this.textBoxFuerza.Size = new System.Drawing.Size(401, 31);
            this.textBoxFuerza.TabIndex = 11;
            // 
            // textBoxUbicacion
            // 
            this.textBoxUbicacion.Location = new System.Drawing.Point(1346, 371);
            this.textBoxUbicacion.Name = "textBoxUbicacion";
            this.textBoxUbicacion.ReadOnly = true;
            this.textBoxUbicacion.Size = new System.Drawing.Size(401, 31);
            this.textBoxUbicacion.TabIndex = 12;
            // 
            // textBoxUbicacionAdd
            // 
            this.textBoxUbicacionAdd.Location = new System.Drawing.Point(1346, 715);
            this.textBoxUbicacionAdd.Name = "textBoxUbicacionAdd";
            this.textBoxUbicacionAdd.Size = new System.Drawing.Size(401, 31);
            this.textBoxUbicacionAdd.TabIndex = 23;
            // 
            // textBoxFuerzaAdd
            // 
            this.textBoxFuerzaAdd.Location = new System.Drawing.Point(1346, 660);
            this.textBoxFuerzaAdd.Name = "textBoxFuerzaAdd";
            this.textBoxFuerzaAdd.Size = new System.Drawing.Size(401, 31);
            this.textBoxFuerzaAdd.TabIndex = 22;
            // 
            // textBoxNombreAdd
            // 
            this.textBoxNombreAdd.Location = new System.Drawing.Point(1346, 553);
            this.textBoxNombreAdd.Name = "textBoxNombreAdd";
            this.textBoxNombreAdd.Size = new System.Drawing.Size(401, 31);
            this.textBoxNombreAdd.TabIndex = 20;
            // 
            // textBoxIdAdd
            // 
            this.textBoxIdAdd.Location = new System.Drawing.Point(1346, 505);
            this.textBoxIdAdd.Name = "textBoxIdAdd";
            this.textBoxIdAdd.Size = new System.Drawing.Size(401, 31);
            this.textBoxIdAdd.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1142, 715);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Ubicacion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1142, 660);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Fuerza de Combate";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1142, 607);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(177, 25);
            this.label10.TabIndex = 16;
            this.label10.Text = "Fecha de Nacimiento";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1142, 559);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 25);
            this.label11.TabIndex = 15;
            this.label11.Text = "Nombre";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1142, 511);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 25);
            this.label12.TabIndex = 14;
            this.label12.Text = "Id";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(1318, 423);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(327, 54);
            this.label13.TabIndex = 13;
            this.label13.Text = "NUEVO EJERCITO";
            // 
            // btAnadir
            // 
            this.btAnadir.Location = new System.Drawing.Point(1440, 778);
            this.btAnadir.Name = "btAnadir";
            this.btAnadir.Size = new System.Drawing.Size(112, 34);
            this.btAnadir.TabIndex = 24;
            this.btAnadir.Text = "Añadir";
            this.btAnadir.UseVisualStyleBackColor = true;
            this.btAnadir.Click += new System.EventHandler(this.AnadirEjercitoAsync);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(413, 686);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(201, 54);
            this.label14.TabIndex = 25;
            this.label14.Text = "RESUMEN";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1374, 602);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(362, 31);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(69, 756);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(176, 25);
            this.label15.TabIndex = 27;
            this.label15.Text = "Número de ejércitos:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(69, 806);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(211, 25);
            this.label16.TabIndex = 28;
            this.label16.Text = "Fuerza de Combate total:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(69, 849);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(249, 25);
            this.label17.TabIndex = 29;
            this.label17.Text = "Media de Fuerza de Combate:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(631, 778);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(232, 25);
            this.label18.TabIndex = 30;
            this.label18.Text = "Años totales de experiencia:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(631, 828);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(250, 25);
            this.label19.TabIndex = 31;
            this.label19.Text = "Media de años de experiencia:";
            // 
            // textBoxNumEjercitos
            // 
            this.textBoxNumEjercitos.Location = new System.Drawing.Point(351, 756);
            this.textBoxNumEjercitos.Name = "textBoxNumEjercitos";
            this.textBoxNumEjercitos.ReadOnly = true;
            this.textBoxNumEjercitos.Size = new System.Drawing.Size(247, 31);
            this.textBoxNumEjercitos.TabIndex = 32;
            // 
            // textBoxFuerzaTotal
            // 
            this.textBoxFuerzaTotal.Location = new System.Drawing.Point(351, 800);
            this.textBoxFuerzaTotal.Name = "textBoxFuerzaTotal";
            this.textBoxFuerzaTotal.ReadOnly = true;
            this.textBoxFuerzaTotal.Size = new System.Drawing.Size(247, 31);
            this.textBoxFuerzaTotal.TabIndex = 33;
            // 
            // textBoxFuerzaMedia
            // 
            this.textBoxFuerzaMedia.Location = new System.Drawing.Point(351, 849);
            this.textBoxFuerzaMedia.Name = "textBoxFuerzaMedia";
            this.textBoxFuerzaMedia.ReadOnly = true;
            this.textBoxFuerzaMedia.Size = new System.Drawing.Size(247, 31);
            this.textBoxFuerzaMedia.TabIndex = 34;
            // 
            // textBoxAnosTotales
            // 
            this.textBoxAnosTotales.Location = new System.Drawing.Point(902, 772);
            this.textBoxAnosTotales.Name = "textBoxAnosTotales";
            this.textBoxAnosTotales.ReadOnly = true;
            this.textBoxAnosTotales.Size = new System.Drawing.Size(247, 31);
            this.textBoxAnosTotales.TabIndex = 35;
            // 
            // textBoxAnosMedia
            // 
            this.textBoxAnosMedia.Location = new System.Drawing.Point(902, 828);
            this.textBoxAnosMedia.Name = "textBoxAnosMedia";
            this.textBoxAnosMedia.ReadOnly = true;
            this.textBoxAnosMedia.Size = new System.Drawing.Size(247, 31);
            this.textBoxAnosMedia.TabIndex = 36;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1860, 911);
            this.Controls.Add(this.textBoxAnosMedia);
            this.Controls.Add(this.textBoxAnosTotales);
            this.Controls.Add(this.textBoxFuerzaMedia);
            this.Controls.Add(this.textBoxFuerzaTotal);
            this.Controls.Add(this.textBoxNumEjercitos);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btAnadir);
            this.Controls.Add(this.textBoxUbicacionAdd);
            this.Controls.Add(this.textBoxFuerzaAdd);
            this.Controls.Add(this.textBoxNombreAdd);
            this.Controls.Add(this.textBoxIdAdd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxUbicacion);
            this.Controls.Add(this.textBoxFuerza);
            this.Controls.Add(this.textBoxFechaNac);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Id";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxFechaNac;
        private System.Windows.Forms.TextBox textBoxFuerza;
        private System.Windows.Forms.TextBox textBoxUbicacion;
        private System.Windows.Forms.TextBox textBoxUbicacionAdd;
        private System.Windows.Forms.TextBox textBoxFuerzaAdd;
        private System.Windows.Forms.TextBox textBoxNombreAdd;
        private System.Windows.Forms.TextBox textBoxIdAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btAnadir;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBoxNumEjercitos;
        private System.Windows.Forms.TextBox textBoxFuerzaTotal;
        private System.Windows.Forms.TextBox textBoxFuerzaMedia;
        private System.Windows.Forms.TextBox textBoxAnosTotales;
        private System.Windows.Forms.TextBox textBoxAnosMedia;
    }
}

