namespace TablasHash
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_direccionInicial = new System.Windows.Forms.TextBox();
            this.textBox_tamañoRegistro = new System.Windows.Forms.TextBox();
            this.textBox_numeroRanuras = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_numeroRegistrosPorCubeta = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_Eliminar = new System.Windows.Forms.Button();
            this.button_Insertar = new System.Windows.Forms.Button();
            this.textBox_insertar = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.richTextBox_escribir_leer_archivo = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button_LeerArchivo = new System.Windows.Forms.Button();
            this.button_LeerEstructuraHash = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(5, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(644, 324);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox_direccionInicial);
            this.tabPage1.Controls.Add(this.textBox_tamañoRegistro);
            this.tabPage1.Controls.Add(this.textBox_numeroRanuras);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBox_numeroRegistrosPorCubeta);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(636, 298);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Crear";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(458, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Dirección inicial:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tamaño de registro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Numero de ranuras:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Registros por cubeta:";
            // 
            // textBox_direccionInicial
            // 
            this.textBox_direccionInicial.Location = new System.Drawing.Point(461, 117);
            this.textBox_direccionInicial.Name = "textBox_direccionInicial";
            this.textBox_direccionInicial.Size = new System.Drawing.Size(100, 20);
            this.textBox_direccionInicial.TabIndex = 13;
            // 
            // textBox_tamañoRegistro
            // 
            this.textBox_tamañoRegistro.Location = new System.Drawing.Point(342, 117);
            this.textBox_tamañoRegistro.Name = "textBox_tamañoRegistro";
            this.textBox_tamañoRegistro.Size = new System.Drawing.Size(100, 20);
            this.textBox_tamañoRegistro.TabIndex = 12;
            // 
            // textBox_numeroRanuras
            // 
            this.textBox_numeroRanuras.Location = new System.Drawing.Point(213, 117);
            this.textBox_numeroRanuras.Name = "textBox_numeroRanuras";
            this.textBox_numeroRanuras.Size = new System.Drawing.Size(100, 20);
            this.textBox_numeroRanuras.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Crear tabla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox_numeroRegistrosPorCubeta
            // 
            this.textBox_numeroRegistrosPorCubeta.Location = new System.Drawing.Point(79, 117);
            this.textBox_numeroRegistrosPorCubeta.Name = "textBox_numeroRegistrosPorCubeta";
            this.textBox_numeroRegistrosPorCubeta.Size = new System.Drawing.Size(100, 20);
            this.textBox_numeroRegistrosPorCubeta.TabIndex = 9;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button_Eliminar);
            this.tabPage2.Controls.Add(this.button_Insertar);
            this.tabPage2.Controls.Add(this.textBox_insertar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(636, 298);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Insertar/Eliminar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_Eliminar
            // 
            this.button_Eliminar.Location = new System.Drawing.Point(247, 206);
            this.button_Eliminar.Name = "button_Eliminar";
            this.button_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.button_Eliminar.TabIndex = 2;
            this.button_Eliminar.Text = "Eliminar";
            this.button_Eliminar.UseVisualStyleBackColor = true;
            this.button_Eliminar.Click += new System.EventHandler(this.button_Eliminar_Click);
            // 
            // button_Insertar
            // 
            this.button_Insertar.Location = new System.Drawing.Point(247, 148);
            this.button_Insertar.Name = "button_Insertar";
            this.button_Insertar.Size = new System.Drawing.Size(75, 23);
            this.button_Insertar.TabIndex = 1;
            this.button_Insertar.Text = "Insertar";
            this.button_Insertar.UseVisualStyleBackColor = true;
            this.button_Insertar.Click += new System.EventHandler(this.button_Insertar_Click);
            // 
            // textBox_insertar
            // 
            this.textBox_insertar.Location = new System.Drawing.Point(232, 80);
            this.textBox_insertar.Name = "textBox_insertar";
            this.textBox_insertar.Size = new System.Drawing.Size(100, 20);
            this.textBox_insertar.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.richTextBox_escribir_leer_archivo);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(636, 298);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Escribir";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // richTextBox_escribir_leer_archivo
            // 
            this.richTextBox_escribir_leer_archivo.Location = new System.Drawing.Point(0, 0);
            this.richTextBox_escribir_leer_archivo.Name = "richTextBox_escribir_leer_archivo";
            this.richTextBox_escribir_leer_archivo.Size = new System.Drawing.Size(636, 208);
            this.richTextBox_escribir_leer_archivo.TabIndex = 1;
            this.richTextBox_escribir_leer_archivo.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(252, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Escrbir en archivo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button_LeerEstructuraHash);
            this.tabPage4.Controls.Add(this.richTextBox1);
            this.tabPage4.Controls.Add(this.button_LeerArchivo);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(636, 298);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Leer archivo";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(636, 208);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // button_LeerArchivo
            // 
            this.button_LeerArchivo.Location = new System.Drawing.Point(252, 263);
            this.button_LeerArchivo.Name = "button_LeerArchivo";
            this.button_LeerArchivo.Size = new System.Drawing.Size(105, 23);
            this.button_LeerArchivo.TabIndex = 2;
            this.button_LeerArchivo.Text = "Leer archivo";
            this.button_LeerArchivo.UseVisualStyleBackColor = true;
            this.button_LeerArchivo.Click += new System.EventHandler(this.button_LeerArchivo_Click);
            // 
            // button_LeerEstructuraHash
            // 
            this.button_LeerEstructuraHash.Location = new System.Drawing.Point(409, 263);
            this.button_LeerEstructuraHash.Name = "button_LeerEstructuraHash";
            this.button_LeerEstructuraHash.Size = new System.Drawing.Size(150, 23);
            this.button_LeerEstructuraHash.TabIndex = 4;
            this.button_LeerEstructuraHash.Text = "Leer estructura hash";
            this.button_LeerEstructuraHash.UseVisualStyleBackColor = true;
            this.button_LeerEstructuraHash.Click += new System.EventHandler(this.button_LeerEstructuraHash_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 339);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_direccionInicial;
        private System.Windows.Forms.TextBox textBox_tamañoRegistro;
        private System.Windows.Forms.TextBox textBox_numeroRanuras;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_numeroRegistrosPorCubeta;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button_Insertar;
        private System.Windows.Forms.TextBox textBox_insertar;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox richTextBox_escribir_leer_archivo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_Eliminar;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button_LeerArchivo;
        private System.Windows.Forms.Button button_LeerEstructuraHash;
    }
}

