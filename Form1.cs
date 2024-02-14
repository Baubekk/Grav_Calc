using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grav_force
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();
        private void Calc(double mass1, double mass2, double distance)//Нахождение силы притяжение
        {
            double result = 6.6743E-11 * mass1 * mass2 / (distance * distance);
            txtBox_Result.Text = result.ToString();

        }


        private void Button_Calc_Grav_force_Click(object sender, EventArgs e)
        {
            bool convertion_mass1 = double.TryParse(txtBox_mass_1.Text, out double mass1);
            bool convertion_mass2 = double.TryParse(txtBox_mass_2.Text, out double mass2);
            bool convertion_distance = double.TryParse(txtBox_Distance.Text, out double distance);//Проверяет, возможно ли проеброзование. Преоброзовывает если возможно

            if (convertion_mass1 && convertion_mass2 && convertion_distance)
                Calc(mass1, mass2, distance);

            else
                MessageBox.Show("Ошибка. Вводите числа следуя инструкциям!");

            if (distance == 0) MessageBox.Show("Ошибка. Дистанция равна 0!");

        }
    }
}
