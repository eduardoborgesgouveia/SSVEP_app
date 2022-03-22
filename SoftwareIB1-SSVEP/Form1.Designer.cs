namespace SoftwareIB1_SSVEP
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Sinal = new System.Windows.Forms.GroupBox();
            this.rdButtonSeno = new System.Windows.Forms.RadioButton();
            this.rdButtonQuadrada = new System.Windows.Forms.RadioButton();
            this.lb_amplitude = new System.Windows.Forms.Label();
            this.lb_freq = new System.Windows.Forms.Label();
            this.lb_freqAm = new System.Windows.Forms.Label();
            this.tb_amplitude = new System.Windows.Forms.TextBox();
            this.tb_freqAm = new System.Windows.Forms.TextBox();
            this.tb_freq = new System.Windows.Forms.TextBox();
            this.bt_startGerador = new System.Windows.Forms.Button();
            this.bt_stopGerador = new System.Windows.Forms.Button();
            this.timerGerador = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.Sinal.SuspendLayout();
            this.SuspendLayout();
            // 
            // Chart
            // 
            chartArea4.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea4);
            this.Chart.Dock = System.Windows.Forms.DockStyle.Right;
            legend4.Name = "Legend1";
            this.Chart.Legends.Add(legend4);
            this.Chart.Location = new System.Drawing.Point(213, 0);
            this.Chart.Name = "Chart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.Chart.Series.Add(series4);
            this.Chart.Size = new System.Drawing.Size(799, 477);
            this.Chart.TabIndex = 0;
            this.Chart.Text = "chart1";
            // 
            // Sinal
            // 
            this.Sinal.Controls.Add(this.rdButtonQuadrada);
            this.Sinal.Controls.Add(this.rdButtonSeno);
            this.Sinal.Location = new System.Drawing.Point(12, 43);
            this.Sinal.Name = "Sinal";
            this.Sinal.Size = new System.Drawing.Size(178, 100);
            this.Sinal.TabIndex = 1;
            this.Sinal.TabStop = false;
            this.Sinal.Text = "Sinal";
            // 
            // rdButtonSeno
            // 
            this.rdButtonSeno.AutoSize = true;
            this.rdButtonSeno.Location = new System.Drawing.Point(54, 28);
            this.rdButtonSeno.Name = "rdButtonSeno";
            this.rdButtonSeno.Size = new System.Drawing.Size(66, 17);
            this.rdButtonSeno.TabIndex = 0;
            this.rdButtonSeno.TabStop = true;
            this.rdButtonSeno.Text = "Senoidal";
            this.rdButtonSeno.UseVisualStyleBackColor = true;
            // 
            // rdButtonQuadrada
            // 
            this.rdButtonQuadrada.AutoSize = true;
            this.rdButtonQuadrada.Location = new System.Drawing.Point(54, 60);
            this.rdButtonQuadrada.Name = "rdButtonQuadrada";
            this.rdButtonQuadrada.Size = new System.Drawing.Size(72, 17);
            this.rdButtonQuadrada.TabIndex = 1;
            this.rdButtonQuadrada.TabStop = true;
            this.rdButtonQuadrada.Text = "Quadrada";
            this.rdButtonQuadrada.UseVisualStyleBackColor = true;
            // 
            // lb_amplitude
            // 
            this.lb_amplitude.AutoSize = true;
            this.lb_amplitude.Location = new System.Drawing.Point(35, 199);
            this.lb_amplitude.Name = "lb_amplitude";
            this.lb_amplitude.Size = new System.Drawing.Size(56, 13);
            this.lb_amplitude.TabIndex = 2;
            this.lb_amplitude.Text = "Amplitude:";
            // 
            // lb_freq
            // 
            this.lb_freq.AutoSize = true;
            this.lb_freq.Location = new System.Drawing.Point(35, 270);
            this.lb_freq.Name = "lb_freq";
            this.lb_freq.Size = new System.Drawing.Size(63, 13);
            this.lb_freq.TabIndex = 3;
            this.lb_freq.Text = "Frequência:";
            // 
            // lb_freqAm
            // 
            this.lb_freqAm.AutoSize = true;
            this.lb_freqAm.Location = new System.Drawing.Point(36, 239);
            this.lb_freqAm.Name = "lb_freqAm";
            this.lb_freqAm.Size = new System.Drawing.Size(46, 13);
            this.lb_freqAm.TabIndex = 4;
            this.lb_freqAm.Text = "FreqAm:";
            // 
            // tb_amplitude
            // 
            this.tb_amplitude.Location = new System.Drawing.Point(116, 192);
            this.tb_amplitude.Name = "tb_amplitude";
            this.tb_amplitude.Size = new System.Drawing.Size(43, 20);
            this.tb_amplitude.TabIndex = 5;
            // 
            // tb_freqAm
            // 
            this.tb_freqAm.Location = new System.Drawing.Point(116, 232);
            this.tb_freqAm.Name = "tb_freqAm";
            this.tb_freqAm.Size = new System.Drawing.Size(43, 20);
            this.tb_freqAm.TabIndex = 6;
            // 
            // tb_freq
            // 
            this.tb_freq.Location = new System.Drawing.Point(116, 263);
            this.tb_freq.Name = "tb_freq";
            this.tb_freq.Size = new System.Drawing.Size(43, 20);
            this.tb_freq.TabIndex = 7;
            // 
            // bt_startGerador
            // 
            this.bt_startGerador.BackColor = System.Drawing.Color.Teal;
            this.bt_startGerador.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_startGerador.Location = new System.Drawing.Point(38, 298);
            this.bt_startGerador.Name = "bt_startGerador";
            this.bt_startGerador.Size = new System.Drawing.Size(131, 73);
            this.bt_startGerador.TabIndex = 8;
            this.bt_startGerador.Text = "Start";
            this.bt_startGerador.UseVisualStyleBackColor = false;
            this.bt_startGerador.Click += new System.EventHandler(this.bt_startGerador_Click);
            // 
            // bt_stopGerador
            // 
            this.bt_stopGerador.BackColor = System.Drawing.Color.Teal;
            this.bt_stopGerador.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Bold);
            this.bt_stopGerador.Location = new System.Drawing.Point(39, 377);
            this.bt_stopGerador.Name = "bt_stopGerador";
            this.bt_stopGerador.Size = new System.Drawing.Size(131, 73);
            this.bt_stopGerador.TabIndex = 9;
            this.bt_stopGerador.Text = "Stop";
            this.bt_stopGerador.UseVisualStyleBackColor = false;
            this.bt_stopGerador.Click += new System.EventHandler(this.bt_stopGerador_Click);
            // 
            // timerGerador
            // 
            this.timerGerador.Interval = 1;
            this.timerGerador.Tick += new System.EventHandler(this.timerGerador_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 477);
            this.Controls.Add(this.bt_stopGerador);
            this.Controls.Add(this.bt_startGerador);
            this.Controls.Add(this.tb_freq);
            this.Controls.Add(this.tb_freqAm);
            this.Controls.Add(this.tb_amplitude);
            this.Controls.Add(this.lb_freqAm);
            this.Controls.Add(this.lb_freq);
            this.Controls.Add(this.lb_amplitude);
            this.Controls.Add(this.Sinal);
            this.Controls.Add(this.Chart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.Sinal.ResumeLayout(false);
            this.Sinal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private System.Windows.Forms.GroupBox Sinal;
        private System.Windows.Forms.RadioButton rdButtonQuadrada;
        private System.Windows.Forms.RadioButton rdButtonSeno;
        private System.Windows.Forms.Label lb_amplitude;
        private System.Windows.Forms.Label lb_freq;
        private System.Windows.Forms.Label lb_freqAm;
        private System.Windows.Forms.TextBox tb_amplitude;
        private System.Windows.Forms.TextBox tb_freqAm;
        private System.Windows.Forms.TextBox tb_freq;
        private System.Windows.Forms.Button bt_startGerador;
        private System.Windows.Forms.Button bt_stopGerador;
        private System.Windows.Forms.Timer timerGerador;
    }
}

