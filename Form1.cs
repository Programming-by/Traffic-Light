using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traffic_Light_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ctrlTrafficLight1.Start();
        }

        private void ctrlTrafficLight1_RedLightOn(object sender, ctrlTrafficLight.TrafficLightEventArgs e)
        {
            MessageBox.Show(e.CurrentLight.ToString());
        }

        private void ctrlTrafficLight1_OrangeLightOn(object sender, ctrlTrafficLight.TrafficLightEventArgs e)
        {
            MessageBox.Show(e.CurrentLight.ToString());

        }

        private void ctrlTrafficLight1_GreenLightOn(object sender, ctrlTrafficLight.TrafficLightEventArgs e)
        {
            MessageBox.Show(e.CurrentLight.ToString());
        }
    }
}
