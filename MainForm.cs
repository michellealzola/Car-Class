using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Class
{
    public partial class MainForm : Form
    {
        private Car car;
        private int year;
        private double speed;
        
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void carData()
        {
            if (car == null)
            {
                if (!int.TryParse(tBoxInputYear.Text, out year))
                {
                    ErrorForm errorForm = new ErrorForm();
                    errorForm.ShowDialog();

                    tBoxInputYear.Text = "";
                    
                }
                car = new Car(year, tBoxInputMake.Text);
            }
        }

        private void btnAccelerate_Click(object sender, EventArgs e)
        {
            carData();

            if(tBoxInputYear.Text != "")
            {
                car.Accelerate();

                speed = car.Speed;

                lblOutSpeed.Text = speed.ToString();
            }
            
        }

        private void btnBrake_Click(object sender, EventArgs e)
        {
            carData();                    

            if (car.Speed > 0)
            {
                car.Brake();
            }

            speed = car.Speed;

            lblOutSpeed.Text = speed.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tBoxInputYear.Text = "";
            tBoxInputMake.Text = "";
            lblOutSpeed.Text = "";

            tBoxInputYear.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
