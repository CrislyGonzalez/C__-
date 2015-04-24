namespace Proyecto
{
    partial class InformacionBurbuja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformacionBurbuja));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxTipoEjecucion = new System.Windows.Forms.ComboBox();
            this.buttonEjecutar = new System.Windows.Forms.Button();
            this.TBCantValores = new System.Windows.Forms.TextBox();
            this.TBtiempoSecuencial = new System.Windows.Forms.TextBox();
            this.TBtiempoParalelo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxProcesador = new System.Windows.Forms.TextBox();
            this.textBoxRAM = new System.Windows.Forms.TextBox();
            this.textBoxCore = new System.Windows.Forms.TextBox();
            this.labelProcesador = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxConsumoProcesador = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxCantProcesadoresSelect = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 59);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tipo de ejecución";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Insertar Cantidad de Valores";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tiempo de Duracion Secuencial";
            // 
            // comboBoxTipoEjecucion
            // 
            this.comboBoxTipoEjecucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoEjecucion.FormattingEnabled = true;
            this.comboBoxTipoEjecucion.Items.AddRange(new object[] {
            "Secuencial",
            "Paralelo"});
            this.comboBoxTipoEjecucion.Location = new System.Drawing.Point(219, 208);
            this.comboBoxTipoEjecucion.Name = "comboBoxTipoEjecucion";
            this.comboBoxTipoEjecucion.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoEjecucion.TabIndex = 10;
            // 
            // buttonEjecutar
            // 
            this.buttonEjecutar.Location = new System.Drawing.Point(367, 238);
            this.buttonEjecutar.Name = "buttonEjecutar";
            this.buttonEjecutar.Size = new System.Drawing.Size(75, 23);
            this.buttonEjecutar.TabIndex = 11;
            this.buttonEjecutar.Text = "Ejecutar";
            this.buttonEjecutar.UseVisualStyleBackColor = true;
            this.buttonEjecutar.Click += new System.EventHandler(this.button2_Click);
            // 
            // TBCantValores
            // 
            this.TBCantValores.Location = new System.Drawing.Point(219, 241);
            this.TBCantValores.Name = "TBCantValores";
            this.TBCantValores.Size = new System.Drawing.Size(121, 20);
            this.TBCantValores.TabIndex = 12;
            // 
            // TBtiempoSecuencial
            // 
            this.TBtiempoSecuencial.Location = new System.Drawing.Point(219, 272);
            this.TBtiempoSecuencial.Name = "TBtiempoSecuencial";
            this.TBtiempoSecuencial.ReadOnly = true;
            this.TBtiempoSecuencial.Size = new System.Drawing.Size(121, 20);
            this.TBtiempoSecuencial.TabIndex = 13;
            // 
            // TBtiempoParalelo
            // 
            this.TBtiempoParalelo.Location = new System.Drawing.Point(219, 303);
            this.TBtiempoParalelo.Name = "TBtiempoParalelo";
            this.TBtiempoParalelo.ReadOnly = true;
            this.TBtiempoParalelo.Size = new System.Drawing.Size(121, 20);
            this.TBtiempoParalelo.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tiempo de Duración Paralela";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(491, 178);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(408, 249);
            this.chart1.TabIndex = 16;
            this.chart1.Text = "chart1";
            // 
            // textBoxProcesador
            // 
            this.textBoxProcesador.Location = new System.Drawing.Point(167, 46);
            this.textBoxProcesador.Name = "textBoxProcesador";
            this.textBoxProcesador.ReadOnly = true;
            this.textBoxProcesador.Size = new System.Drawing.Size(352, 20);
            this.textBoxProcesador.TabIndex = 17;
            // 
            // textBoxRAM
            // 
            this.textBoxRAM.Location = new System.Drawing.Point(167, 81);
            this.textBoxRAM.Name = "textBoxRAM";
            this.textBoxRAM.ReadOnly = true;
            this.textBoxRAM.Size = new System.Drawing.Size(194, 20);
            this.textBoxRAM.TabIndex = 18;
            // 
            // textBoxCore
            // 
            this.textBoxCore.Location = new System.Drawing.Point(167, 121);
            this.textBoxCore.Name = "textBoxCore";
            this.textBoxCore.ReadOnly = true;
            this.textBoxCore.Size = new System.Drawing.Size(194, 20);
            this.textBoxCore.TabIndex = 19;
            // 
            // labelProcesador
            // 
            this.labelProcesador.AutoSize = true;
            this.labelProcesador.Location = new System.Drawing.Point(26, 46);
            this.labelProcesador.Name = "labelProcesador";
            this.labelProcesador.Size = new System.Drawing.Size(61, 13);
            this.labelProcesador.TabIndex = 20;
            this.labelProcesador.Text = "Procesador";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Memoria RAM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Cantidad de nucleos";
            // 
            // textBoxConsumoProcesador
            // 
            this.textBoxConsumoProcesador.Location = new System.Drawing.Point(167, 157);
            this.textBoxConsumoProcesador.Name = "textBoxConsumoProcesador";
            this.textBoxConsumoProcesador.ReadOnly = true;
            this.textBoxConsumoProcesador.Size = new System.Drawing.Size(194, 20);
            this.textBoxConsumoProcesador.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Consumo del procesador";
            // 
            // comboBoxCantProcesadoresSelect
            // 
            this.comboBoxCantProcesadoresSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCantProcesadoresSelect.FormattingEnabled = true;
            this.comboBoxCantProcesadoresSelect.Location = new System.Drawing.Point(381, 120);
            this.comboBoxCantProcesadoresSelect.Name = "comboBoxCantProcesadoresSelect";
            this.comboBoxCantProcesadoresSelect.Size = new System.Drawing.Size(105, 21);
            this.comboBoxCantProcesadoresSelect.TabIndex = 25;
            this.comboBoxCantProcesadoresSelect.SelectedIndexChanged += new System.EventHandler(this.comboBoxCantProcesadoresSelect_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(508, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Seleccionar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // InformacionBurbuja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 458);
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
            this.Name = "InformacionBurbuja";
            this.Text = "Algoritmo Burbuja";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxTipoEjecucion;
        private System.Windows.Forms.Button buttonEjecutar;
        private System.Windows.Forms.TextBox TBCantValores;
        private System.Windows.Forms.TextBox TBtiempoSecuencial;
        private System.Windows.Forms.TextBox TBtiempoParalelo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBoxProcesador;
        private System.Windows.Forms.TextBox textBoxRAM;
        private System.Windows.Forms.TextBox textBoxCore;
        private System.Windows.Forms.Label labelProcesador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxConsumoProcesador;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxCantProcesadoresSelect;
        private System.Windows.Forms.Button button2;
    }
}