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
    public partial class SwitchView : UserControl
    {

        private bool state;
        private Switch switchRobo;
        public SwitchView()
        {
            InitializeComponent();
        }

        public bool State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
                if (state)
                {
                    pictureBox1.Image = Resource.SwitchOn;
                }
                else
                {
                    pictureBox1.Image = Resource.SwitchOff;
                }
            }
        }

        public Switch Switch
        {
            get { return switchRobo; }
            set
            {
                if (switchRobo != null) switchRobo.SwitchStateChanged -= SwitchStateChanged;
                switchRobo = value;
                if (switchRobo != null) switchRobo.SwitchStateChanged += SwitchStateChanged;
            }
        }

        private void SwitchStateChanged(object sender, RobotCtrl.SwitchEventArgs e)
        {
            State = e.SwitchEnabled;
        }


    }
}