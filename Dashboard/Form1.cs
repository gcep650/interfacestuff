using InterfacesStuff;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class Form1 : Form
    {
        private ICarInterface m_car;
        public Form1()
        {
            m_car = new Car(15, 30, "Example Car");
            m_car.setSpeed(30);
            InitializeComponent();
            UpdateForm();
        }

        public void UpdateForm()
        {
            carName.Text = m_car.getName();
            speed.Text = m_car.getSpeed().ToString();
            mpg.Text = m_car.getMPG().ToString();
            gas.Text = m_car.gasLeft().ToString();
            capacity.Text = m_car.getCapacity().ToString();
            miles.Text = m_car.getMiles().ToString();
            minTB.Text = "0";
            galTB.Text = "0";
            speedTB.Text = "0";
        }

        private void newCar_Click(object sender, EventArgs e)
        {

        }

        private void driveB_Click(object sender, EventArgs e)
        {
            try
            {
            m_car.drive(int.Parse(minTB.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Parameters.");
            }
            UpdateForm();
        }

        private void fillB_Click(object sender, EventArgs e)
        {
            try
            {
            m_car.fill(int.Parse(galTB.Text));

            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Parameters.");
            }
            UpdateForm();
        }

        private void setSpeed_Click(object sender, EventArgs e)
        {
            try
            {
                m_car.setSpeed(int.Parse(speedTB.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Parameters");
            }
            UpdateForm();
        }
    }
}
