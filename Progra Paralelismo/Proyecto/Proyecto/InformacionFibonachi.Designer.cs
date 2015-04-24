namespace Proyecto
{
    partial class InformacionFibonachi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformacionFibonachi));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxCantProcesadoresSelect = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxConsumoProcesador = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelProcesador = new System.Windows.Forms.Label();
            this.textBoxCore = new System.Windows.Forms.TextBox();
            this.textBoxRAM = new System.Windows.Forms.TextBox();
            this.textBoxProcesador = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TBtiempoParalelo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBtiempoSecuencial = new System.Windows.Forms.TextBox();
            this.TBCantValores = new System.Windows.Forms.TextBox();
            this.buttonEjecutar = new System.Windows.Forms.Button();
            this.comboBoxTipoEjecucion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(25, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 59);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(504, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 47;
            this.button2.Text = "Seleccionar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxCantProcesadoresSelect
            // 
            this.comboBoxCantProcesadoresSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCantProcesadoresSelect.FormattingEnabled = true;
            this.comboBoxCantProcesadoresSelect.Location = new System.Drawing.Point(377, 90);
            this.comboBoxCantProcesadoresSelect.Name = "comboBoxCantProcesadoresSelect";
            this.comboBoxCantProcesadoresSelect.Size = new System.Drawing.Size(105, 21);
            this.comboBoxCantProcesadoresSelect.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Consumo del procesador";
            // 
            // textBoxConsumoProcesador
            // 
            this.textBoxConsumoProcesador.Location = new System.Drawing.Point(163, 127);
            this.textBoxConsumoProcesador.Name = "textBoxConsumoProcesador";
            this.textBoxConsumoProcesador.ReadOnly = true;
            this.textBoxConsumoProcesador.Size = new System.Drawing.Size(194, 20);
            this.textBoxConsumoProcesador.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Cantidad de nucleos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Memoria RAM";
            // 
            // labelProcesador
            // 
            this.labelProcesador.AutoSize = true;
            this.labelProcesador.Location = new System.Drawing.Point(22, 16);
            this.labelProcesador.Name = "labelProcesador";
            this.labelProcesador.Size = new System.Drawing.Size(61, 13);
            this.labelProcesador.TabIndex = 41;
            this.labelProcesador.Text = "Procesador";
            // 
            // textBoxCore
            // 
            this.textBoxCore.Location = new System.Drawing.Point(163, 91);
            this.textBoxCore.Name = "textBoxCore";
            this.textBoxCore.ReadOnly = true;
            this.textBoxCore.Size = new System.Drawing.Size(194, 20);
            this.textBoxCore.TabIndex = 40;
            // 
            // textBoxRAM
            // 
            this.textBoxRAM.Location = new System.Drawing.Point(163, 51);
            this.textBoxRAM.Name = "textBoxRAM";
            this.textBoxRAM.ReadOnly = true;
            this.textBoxRAM.Size = new System.Drawing.Size(194, 20);
            this.textBoxRAM.TabIndex = 39;
            // 
            // textBoxProcesador
            // 
            this.textBoxProcesador.Location = new System.Drawing.Point(163, 16);
            this.textBoxProcesador.Name = "textBoxProcesador";
            this.textBoxProcesador.ReadOnly = true;
            this.textBoxProcesador.Size = new System.Drawing.Size(352, 20);
            this.textBoxProcesador.TabIndex = 38;
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(495, 234);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(408, 249);
            this.chart1.TabIndex = 37;
            this.chart1.Text = "chart1";
            // 
            // TBtiempoParalelo
            // 
            this.TBtiempoParalelo.Location = new System.Drawing.Point(219, 329);
            this.TBtiempoParalelo.Name = "TBtiempoParalelo";
            this.TBtiempoParalelo.ReadOnly = true;
            this.TBtiempoParalelo.Size = new System.Drawing.Size(121, 20);
            this.TBtiempoParalelo.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Tiempo de Duración Paralela";
            // 
            // TBtiempoSecuencial
            // 
            this.TBtiempoSecuencial.Location = new System.Drawing.Point(219, 298);
            this.TBtiempoSecuencial.Name = "TBtiempoSecuencial";
            this.TBtiempoSecuencial.ReadOnly = true;
            this.TBtiempoSecuencial.Size = new System.Drawing.Size(121, 20);
            this.TBtiempoSecuencial.TabIndex = 34;
            // 
            // TBCantValores
            // 
            this.TBCantValores.Location = new System.Drawing.Point(219, 267);
            this.TBCantValores.Name = "TBCantValores";
            this.TBCantValores.Size = new System.Drawing.Size(121, 20);
            this.TBCantValores.TabIndex = 33;
            // 
            // buttonEjecutar
            // 
            this.buttonEjecutar.Location = new System.Drawing.Point(367, 264);
            this.buttonEjecutar.Name = "buttonEjecutar";
            this.buttonEjecutar.Size = new System.Drawing.Size(75, 23);
            this.buttonEjecutar.TabIndex = 32;
            this.buttonEjecutar.Text = "Ejecutar";
            this.buttonEjecutar.UseVisualStyleBackColor = true;
            this.buttonEjecutar.Click += new System.EventHandler(this.buttonEjecutar_Click_1);
            // 
            // comboBoxTipoEjecucion
            // 
            this.comboBoxTipoEjecucion.AccessibleDescription = "Fibonachi";
            this.comboBoxTipoEjecucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoEjecucion.FormattingEnabled = true;
            this.comboBoxTipoEjecucion.Items.AddRange(new object[] {
            "Secuencial",
            "Paralelo"});
            this.comboBoxTipoEjecucion.Location = new System.Drawing.Point(219, 234);
            this.comboBoxTipoEjecucion.Name = "comboBoxTipoEjecucion";
            this.comboBoxTipoEjecucion.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoEjecucion.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Tiempo de Duracion Secuencial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Insertar Cantidad de Valores";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Tipo de ejecución";
            // 
            // InformacionFibonachi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 499);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBoxCantProcesadoresSelect);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxConsumoProcesador);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelProcesador);
            this.Controls.Add(this.textBoxCore);
            this.Controls.Add(this.textBoxRAM);
            this.Controls.Add(this.textBoxProcesador);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.TBtiempoParalelo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBtiempoSecuencial);
            this.Controls.Add(this.TBCantValores);
            this.Controls.Add(this.buttonEjecutar);
            this.Controls.Add(this.comboBoxTipoEjecucion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "InformacionFibonachi";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxCantProcesadoresSelect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxConsumoProcesador;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelProcesador;
        private System.Windows.Forms.TextBox textBoxCore;
        private System.Windows.Forms.TextBox textBoxRAM;
        private System.Windows.Forms.TextBox textBoxProcesador;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox TBtiempoParalelo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBtiempoSecuencial;
        private System.Windows.Forms.TextBox TBCantValores;
        private System.Windows.Forms.Button buttonEjecutar;
        private System.Windows.Forms.ComboBox comboBoxTipoEjecucion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}