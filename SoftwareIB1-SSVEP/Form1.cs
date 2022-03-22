using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading;

namespace SoftwareIB1_SSVEP
{
    public partial class Form1 : Form
    {
        //----------Declarando váriaveis relacionadas ao Chart-----------------------
        public static Series serieGrafico;
        public static ChartArea areaGrafico;
        public static Series serieGraficoSinalFiltrado;
        public static ChartArea areaGraficoFiltrado;
        //--------------------------------------------------------------------------

        //-------------Declarando variaveis gerais----------------------------------
        Gerador onda;
        BufferCircular buffer;
        int tipoSinal;
        double freqOnda, FreqAmostragemOnda, amplitudeOnda;
        double[] dados = new double[2];
        public static double interval = 0;
        //--------------------------------------------------------------------------

        //-------------Declarando as Threads---------------------------------------
        Thread plot;
        bool flagThreadPlot = false;
        //-------------------------------------------------------------------------

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //------------Inicializando os parametros do gráfico------------
            Chart.Series.Clear();
            Chart.ChartAreas.Clear();

            serieGrafico = new Series("Sinal");
            serieGraficoSinalFiltrado = new Series("SinalFiltrado");
            areaGrafico = new ChartArea("areaGrafico");
            areaGraficoFiltrado = new ChartArea("areaGraficoFiltrado");

            Chart.Series.Add(serieGrafico);
            Chart.Series.Add(serieGraficoSinalFiltrado);
            Chart.ChartAreas.Add(areaGrafico);
            Chart.ChartAreas.Add(areaGraficoFiltrado);


            serieGrafico.ChartType = SeriesChartType.FastLine;
            serieGrafico.BorderWidth = 3;
            serieGraficoSinalFiltrado.ChartType = SeriesChartType.FastLine;
            serieGraficoSinalFiltrado.BorderWidth = 3;

            areaGraficoFiltrado.AxisX.Maximum = 1;
            areaGraficoFiltrado.AxisX.Minimum = 0;
            areaGrafico.AxisX.Maximum = 1;
            areaGrafico.AxisX.Minimum = 0;
            areaGrafico.AxisX.Title = "Tempo(s)";
            areaGrafico.AxisY.Title = "Amplitude";
            areaGrafico.AxisX.LabelStyle.Format = "#";

            Chart.Series["Sinal"].ChartArea = "areaGrafico";
            Chart.Series["SinalFiltrado"].ChartArea = "areaGraficoFiltrado";

            //--------------------------------------------------------------

            //-----Inicializando as textBox---------------------------------
            tb_amplitude.Text = "1";
            tb_freq.Text = "1";
            tb_freqAm.Text = "100";
            //---------------------------------------------------------------

            //----------Inicializando o sinal--------------------------------
            onda = new Gerador(tipoSinal, amplitudeOnda, FreqAmostragemOnda, freqOnda);
            buffer = new BufferCircular(1000);
            dados[0] = 0;
            dados[1] = 0;
            //---------------------------------------------------------------

            //----------Inicializando a thread--------------------------------
            plot = new Thread(thread_plot);
            plot.Priority = ThreadPriority.Normal;
            //---------------------------------------------------------------
        }
        //-------------------Delegate para a thread de plotagem--------------
        delegate void VarDoublePto(double[] val);
        static void atribuirPto_WithDelegate(double[] val)
        {

            if (val[1] > areaGrafico.AxisX.Maximum)
            {
                if (serieGrafico.Points.Count > 0)
                {
                    serieGrafico.Points.RemoveAt(0);
                }
                areaGrafico.AxisX.Maximum = val[1] + interval;
                areaGrafico.AxisX.Minimum = interval + areaGrafico.AxisX.Minimum;
                areaGrafico.AxisX.RoundAxisValues();
                areaGrafico.AxisX.LabelStyle.Format = "#";
            }
            serieGrafico.Points.AddXY(val[1], val[0]);
        }
        VarDoublePto add_Pto;
        //---------------------------------------------------------------------


        //--------Start Gerador------------------------------------------------
        private void bt_startGerador_Click(object sender, EventArgs e)
        {
            flagThreadPlot = true;
            interval = 1 / Convert.ToDouble(tb_freqAm.Text);
            timerGerador.Start();
            plot.Start();
           
        }
        //----------Stop Gerador----------------------------------------------
        private void bt_stopGerador_Click(object sender, EventArgs e)
        {
            flagThreadPlot = false;
            timerGerador.Stop();
        }

        //---------------------------------------------------------------------


        //--------------------thread responsável por plotar o gráfico----------
        void thread_plot()
        {
            while (flagThreadPlot)
            {
                if (buffer.pop(ref dados))
                {
                    if (Chart.InvokeRequired)
                    {
                        add_Pto = new VarDoublePto(atribuirPto_WithDelegate);
                        Chart.BeginInvoke(add_Pto, new object[] { dados });
                    }
                }
            }
        }
        //--------------------------------------------------------------------
        private void timerGerador_Tick(object sender, EventArgs e)
        {
            if (rdButtonSeno.Checked == true)
                onda.tipo_sinal = 1;
            else if (rdButtonQuadrada.Checked == true)
                onda.tipo_sinal = 3;

            if (tb_freq.Text != "")
            {
                onda.freqSinal = Convert.ToInt16(tb_freq.Text);
            }
            if (tb_amplitude.Text != "")
            {
                onda.amplitude = Convert.ToInt16(tb_amplitude.Text);
            }
            if (tb_freqAm.Text != "")
            {
                onda.freqAmostragem = Convert.ToInt16(tb_freqAm.Text);
            }
            dados = onda.GerarAmostra();
            buffer.push(dados);
            
            areaGrafico.AxisY.Minimum = -1.5 * onda.amplitude;
            areaGrafico.AxisY.Maximum = +1.5 * onda.amplitude;
        }
    }
}
