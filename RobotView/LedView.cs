using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using RobotCtrl;

namespace RobotView
{
    public partial class LedView : UserControl
    {
        private bool state;
        private Led led;

        //GUI Designer braucht parameterlosen Konstruktor darum Eventabonierung im Set oben
        public LedView()
        {
            InitializeComponent();
        }

        public bool State
        {
        get {
                return state;
        }
        set {
                state = value;
            if(state) {
                    pictureBox1.Image = Resource.LedOn;
            }
            else {
                    pictureBox1.Image = Resource.LedOff;
            }
        }
        }

        public Led Led {
        get { return led; } 
        set {
                if (led != null) led.LedStateChanged -= LedStateChanged;
                led = value;
                if (led != null) led.LedStateChanged += LedStateChanged;
        }
        }

        private void LedStateChanged(object sender, RobotCtrl.LedEventArgs e)
        {
            State = e.LedEnabled;
        }
    }
}