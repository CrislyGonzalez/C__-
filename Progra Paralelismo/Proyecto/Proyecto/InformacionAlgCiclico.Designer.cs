namespace Proyecto
{
    partial class InformacionAlgCiclico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformacionAlgCiclico));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.button1.Location = new System.Drawing.Point(24, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 59);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(500, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 46;
            this.button2.Text = "Seleccionar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxCantProcesadoresSelect
            // 
            this.comboBoxCantProcesadoresSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCantProcesadoresSelect.FormattingEnabled = true;
            this.comboBoxCantProcesadoresSelect.Location = new System.Drawing.Point(373, 103);
            this.comboBoxCantProcesadoresSelect.Name = "comboBoxCantProcesadoresSelect";
            this.comboBoxCantProcesadoresSelect.Size = new System.Drawing.Size(105, 21);
            this.comboBoxCantProcesadoresSelect.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Consumo del procesador";
            // 
            // textBoxConsumoProcesador
            // 
            this.textBoxConsumoProcesador.Location = new System.Drawing.Point(159, 140);
            this.textBoxConsumoProcesador.Name = "textBoxConsumoProcesador";
            this.textBoxConsumoProcesador.ReadOnly = true;
            this.textBoxConsumoProcesador.Size = new System.Drawing.Size(194, 20);
            this.textBoxConsumoProcesador.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Cantidad de nucleos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Memoria RAM";
            // 
            // labelProcesador
            // 
            this.labelProcesador.AutoSize = true;
            this.labelProcesador.Location = new System.Drawing.Point(18, 29);
            this.labelProcesador.Name = "labelProcesador";
            this.labelProcesador.Size = new System.Drawing.Size(61, 13);
            this.labelProcesador.TabIndex = 40;
            this.labelProcesador.Text = "Procesador";
            // 
            // textBoxCore
            // 
            this.textBoxCore.Location = new System.Drawing.Point(159, 104);
            this.textBoxCore.Name = "textBoxCore";
            this.textBoxCore.ReadOnly = true;
            this.textBoxCore.Size = new System.Drawing.Size(194, 20);
            this.textBoxCore.TabIndex = 39;
            // 
            // textBoxRAM
            // 
            this.textBoxRAM.Location = new System.Drawing.Point(159, 64);
            this.textBoxRAM.Name = "textBoxRAM";
            this.textBoxRAM.ReadOnly = true;
            this.textBoxRAM.Size = new System.Drawing.Size(194, 20);
            this.textBoxRAM.TabIndex = 38;
            // 
            // textBoxProcesador
            // 
            this.textBoxProcesador.Location = new System.Drawing.Point(159, 29);
            this.textBoxProcesador.Name = "textBoxProcesador";
            this.textBoxProcesador.ReadOnly = true;
            this.textBoxProcesador.Size = new System.Drawing.Size(352, 20);
            this.textBoxProcesador.TabIndex = 37;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(483, 161);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(408, 249);
            this.chart1.TabIndex = 36;
            this.chart1.Text = "chart1";
            // 
            // TBtiempoParalelo
            // 
            this.TBtiempoParalelo.Location = new System.Drawing.Point(211, 286);
            this.TBtiempoParalelo.Name = "TBtiempoParalelo";
            this.TBtiempoParalelo.ReadOnly = true;
            this.TBtiempoParalelo.Size = new System.Drawing.Size(121, 20);
            this.TBtiempoParalelo.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Tiempo de Duración Paralela";
            // 
            // TBtiempoSecuencial
            // 
            this.TBtiempoSecuencial.Location = new System.Drawing.Point(211, 255);
            this.TBtiempoSecuencial.Name = "TBtiempoSecuencial";
            this.TBtiempoSecuencial.ReadOnly = true;
            this.TBtiempoSecuencial.Size = new System.Drawing.Size(121, 20);
            this.TBtiempoSecuencial.TabIndex = 33;
            // 
            // TBCantValores
            // 
            this.TBCantValores.Location = new System.Drawing.Point(211, 224);
            this.TBCantValores.Name = "TBCantValores";
            this.TBCantValores.Size = new System.Drawing.Size(121, 20);
            this.TBCantValores.TabIndex = 32;
            // 
            // buttonEjecutar
            // 
            this.buttonEjecutar.Location = new System.Drawing.Point(359, 221);
            this.buttonEjecutar.Name = "buttonEjecutar";
            this.buttonEjecutar.Size = new System.Drawing.Size(75, 23);
            this.buttonEjecutar.TabIndex = 31;
            this.buttonEjecutar.Text = "Ejecutar";
            this.buttonEjecutar.UseVisualStyleBackColor = true;
            this.buttonEjecutar.Click += new System.EventHandler(this.buttonEjecutar_Click_1);
            // 
            // comboBoxTipoEjecucion
            // 
            this.comboBoxTipoEjecucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoEjecucion.FormattingEnabled = true;
            this.comboBoxTipoEjecucion.Items.AddRange(new object[] {
            "Secuencial",
            "Paralelo"});
            this.comboBoxTipoEjecucion.Location = new System.Drawing.Point(211, 191);
            this.comboBoxTipoEjecucion.Name = "comboBoxTipoEjecucion";
            this.comboBoxTipoEjecucion.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoEjecucion.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Tiempo de Duracion Secuencial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Insertar Cantidad de Valores";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Tipo de ejecución";
            // 
            // InformacionAlgCiclico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 442);
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
            this.Name = "InformacionAlgCiclico";
            this.Text = "Algoritmo Ciclico";
            this.Load += new System.EventHandler(this.InformacionAlgCiclico_Load);
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