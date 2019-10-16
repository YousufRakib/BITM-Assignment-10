using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VechicleAppPractice2
{
    public partial class VehicleUi : Form
    {
        public VehicleUi()
        {
            InitializeComponent();
        }
        SpeedCalculate _speedCalculate = new SpeedCalculate();
        string name;
        string regNumber;
        List<double> speed = new List<double> { };
        private void CreateButton_Click(object sender, EventArgs e)
        {
            name = vehicleNameTextBox.Text;
            regNumber = regNoTextBox.Text;
            MessageBox.Show("Saved");
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            speed.Add(Convert.ToDouble(speedTextBox.Text));
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(vehicleNameTextBox.Text))
            {
                MessageBox.Show("Please Enter vehicle name");
                return;
            }
            if (!String.IsNullOrEmpty(regNoTextBox.Text))
            {
                MessageBox.Show("Please Enter registration number");
                return;
            }

            //Max Speed Show
            double max = _speedCalculate.maxspeed(speed);
            maxSpeedTextBox.Text = max.ToString();

            //Min Speed Show
            double min = _speedCalculate.minspeed(speed);
            minSpeedTextBox.Text = min.ToString();

            //Avg Speed Show
            double avg = _speedCalculate.avgspeed(speed);
            averageSpeedTextBox.Text = avg.ToString();
        }
    }
}
