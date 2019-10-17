using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RobotCtrl;

namespace TestConsole
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            RobotConsole robotConsole = new RobotCtrl.RobotConsole();
            consoleView1.RobotConsole = robotConsole;

            //verkSchalterLed ist jeweils der Handler der Events
            robotConsole[Switches.Switch1].SwitchStateChanged += verkSchalterLed1;
            robotConsole[Switches.Switch2].SwitchStateChanged += verkSchalterLed2;
            robotConsole[Switches.Switch3].SwitchStateChanged += verkSchalterLed3;
            robotConsole[Switches.Switch4].SwitchStateChanged += verkSchalterLed4;

        }

        private void verkSchalterLed1(object sender, SwitchEventArgs e)
        {

            if (e.SwitchEnabled == true)
            {
                consoleView1.RobotConsole[Leds.Led1].LedEnabled = true;
            }
            else if (e.SwitchEnabled == false)
            {
                consoleView1.RobotConsole[Leds.Led1].LedEnabled = false;
            }
        }

        private void verkSchalterLed2(object sender, SwitchEventArgs e)
        {
            if (e.SwitchEnabled == true)
            {
                consoleView1.RobotConsole[Leds.Led2].LedEnabled = true;
            }
            else if (e.SwitchEnabled == false)
            {
                consoleView1.RobotConsole[Leds.Led2].LedEnabled = false;
            }
        }

        private void verkSchalterLed3(object sender, SwitchEventArgs e)
        {

            if (e.SwitchEnabled == true)
            {
                consoleView1.RobotConsole[Leds.Led3].LedEnabled = true;
            }
            else if (e.SwitchEnabled == false)
            {
                consoleView1.RobotConsole[Leds.Led3].LedEnabled = false;
            }
        }

        private void verkSchalterLed4(object sender, SwitchEventArgs e)
        {

            if (e.SwitchEnabled == true)
            {
                consoleView1.RobotConsole[Leds.Led4].LedEnabled = true;
            }
            else if (e.SwitchEnabled == false)
            {
                consoleView1.RobotConsole[Leds.Led4].LedEnabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
