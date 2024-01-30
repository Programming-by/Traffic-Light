﻿using System;
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
            ctrlTrafficLightFirst.Start();
        }
        private void ctrlTrafficLightFirst_SecondTrafficLightOn(object sender, ctrlTrafficLight.TrafficLightEventArgs e)
        {
           ctrlTrafficLightSecond.Start();
        }
        private void ctrlTrafficLightSecond_ThirdTrafficLightOn(object sender, ctrlTrafficLight.TrafficLightEventArgs e)
        {
            ctrlTrafficLightThird.Start();

        }
        private void ctrlTrafficLightThird_FourthTrafficLightOn(object sender, ctrlTrafficLight.TrafficLightEventArgs e)
        {
            ctrlTrafficLightFourth.Start();
        }
        private void ctrlTrafficLightFourth_FirstTrafficLightOn(object sender, ctrlTrafficLight.TrafficLightEventArgs e)
        {
            ctrlTrafficLightFirst.Start();

        }
    }
}
