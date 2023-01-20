using System;
using System.Windows.Forms;


namespace calcular_intereses
{
    public partial class Form1 : Form
    {
        int dias = 0;
        int diasCal = 0;
        int subsidio = 438901;
        int minCapVig = 1000000 * 135;
        int maxCapVig = 1000000 * 400;
        int interes = 0;
        int subFin = 0;

        public Form1()
        {
            InitializeComponent();
        }

/// <summary>
/// Valida si los campos de fecha cumplen con los parámetros, de la misma forma se valida contenido 
/// de los campos de interés y capital al final hace un llamado a las funciones

/// </summary>

        private void button1_Click(object sender, EventArgs e)
        {

            if (dateTimePicker1.Value.Date > dateTimePicker2.Value.Date)
            {
                MessageBox.Show("La fecha inicial no debe ser mayo a la fecha fin");
                //txtSub.Text = dateTimePicker1.Value.Date.ToString();
            }else if(dateTimePicker1.Value.Date == dateTimePicker2.Value.Date)
            {
                MessageBox.Show("La fecha inicial debe ser diferente a la fecha fin");
            }
            else
            {
                if(txtCapCre.Text == "")
                {
                    MessageBox.Show("El capital debe ser mayor que cero");

                }else if(Convert.ToInt32(txtCapCre.Text) < minCapVig || Convert.ToInt32(txtCapCre.Text) > maxCapVig)
                {
                    MessageBox.Show("El capital debe estar dentro del rango de 135 SMMLV hasta 400 SMMLV");
                }
                else
                {
                    if(txtTasa.Text == "" || double.Parse(txtTasa.Text) == 0)
                    {
                        MessageBox.Show("La tasa de interes debe ser mayor a cero");
                    }
                    else
                    {
                        //dias
                        calDias();
                        //dias calendario
                        calDiaCal();
                        //subsidio
                        calSub();
                        //interes
                        calInt();
                        //total a pagar
                        totPgo();
                    }
                }
            }
        }

/// <summary>
/// Toma la diferencia entre dos fechas y devuelve el número de días entre ellas
/// </summary>
        private void calDias()
        {
            DateTime fechaInicio = dateTimePicker1.Value;
            DateTime fechaFin = dateTimePicker2.Value;
            int numerodias = (fechaFin - fechaInicio).Days;
            txtDias.Text = numerodias.ToString();
            dias = Convert.ToInt32(numerodias);

        }
/// <summary>
/// Toma la fecha del control dateTimePicker1,obtiene el primer día del mes
/// luego obtiene el último día del mes, establece el texto del control txtDiaCal al
/// último día del mes, establece la variable diasCal en el último día del mes.
/// </summary>
        private void calDiaCal()
        {
            DateTime date = dateTimePicker1.Value;
            DateTime oPrimerDiaDelMes = new DateTime(date.Year, date.Month, 1);
            DateTime oUltimoDiaDelMes = oPrimerDiaDelMes.AddMonths(1).AddDays(-1);
            txtDiaCal.Text = oUltimoDiaDelMes.Day.ToString();
            diasCal = oUltimoDiaDelMes.Day;


        }
/// <summary>
/// Si el número de días es 30, la subvención es igual al subsidio, en caso contrario subsidio es
/// subsidio dividida por el número de días del mes multiplicado por el número de días
/// </summary>
        private void calSub()
        {
            if(dias == 30)
            {
                txtSub.Text = subsidio.ToString();
                subFin = subsidio;
            }
            else
            {
                int calSub = Convert.ToInt32(Math.Round(((double)subsidio / (double)diasCal)*dias));
                txtSub.Text = calSub.ToString();
                subFin = Convert.ToInt32(calSub);
            }
        }
/// <summary>
/// toma el valor de la caja de texto txtTasa, lo divide por 100, lo redondea a 4 decimales,
/// lo multiplica por el valor del cuadro de texto txtCapCre, lo divide por 12, lo redondea a 2 decimales
/// decimales y asigna el resultado al cuadro de texto txtInter
/// </summary>
        private void calInt()
        {
            double tasaInt = double.Parse(txtTasa.Text);
            double calTasa = Math.Round(((double)tasaInt / 100), 4);
            int inter = Convert.ToInt32(txtCapCre.Text);
            int calInter = Convert.ToInt32(Math.Round(((double)inter * (calTasa / 12)), 2));
            txtInter.Text = calInter.ToString();
            interes = Convert.ToInt32(calInter);
        }

/// <summary>
/// Toma el valor de la caja de texto "txtInteres" y le resta el valor de la caja de texto "txtSubFin"
/// y luego muestra el resultado en el cuadro de texto "txtTotal".
/// </summary>
        private void totPgo()
        {
            int total = interes - subFin;
            txtTotal.Text = total.ToString();

        }
    }

}
