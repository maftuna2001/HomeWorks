
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{

    public partial class form : Form

    {
        Employee employee = new Employee();

        public form()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {

            try
            {
                int quantity = int.Parse(quantityTextBox.Text);
                if (ChickenRadioButt1.Checked)
                {

                    ChickenOrder chickenOrder = new ChickenOrder(quantity);
                    string InspectionResult = employee.Inspect(chickenOrder);
                    employee.NewRequest(quantity, chickenOrder);
                    MessageBox.Show("Order Accepted!");
                    qualityLabel.Text = InspectionResult;
                    food.Items.Add($"Food Chicken, quantity: {quantity}");


                }
                else if (EggradioButt2.Checked)
                {
                    EggOrder eggOrder = new EggOrder(quantity);
                    string InspectionResult = employee.Inspect(eggOrder);
                    employee.NewRequest(quantity, eggOrder);
                    qualityLabel.Text = InspectionResult;
                    MessageBox.Show("Order Accepted!");
                    food.Items.Add($"Food Egg, quantity: {quantity}");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }




        }

        private void EggradioButt2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radiobutton = (RadioButton)sender;
            string MenuItem = EggradioButt2.Text;
        }

        private void copyRequestButt_Click(object sender, EventArgs e)
        {

            employee.CopyRequest();
            MessageBox.Show("Copied!");


        }

        private void prepareFoodButton_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(quantityTextBox.Text);
            if (ChickenRadioButt1.Checked)
            {
                ChickenOrder chickenOrder = new ChickenOrder(quantity);
                string result = employee.PrepareFood(chickenOrder);
                MessageBox.Show(result);


            }

            else if (EggradioButt2.Checked)
            {
                EggOrder eggOrder = new EggOrder(quantity);
                try
                {
                    eggOrder.Crack();
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }


                string result = employee.PrepareFood(eggOrder);
                MessageBox.Show(result);


            }

        }

        private void ChickenRadioButt1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            string MenuItem = ChickenRadioButt1.Text;

        }

        private void qualityLabel_Click(object sender, EventArgs e)
        {

        }

        private void food_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MenuGroupBox_Enter(object sender, EventArgs e)
        {

        }

        //private void ChickenRadioButt1_CheckedChanged(object sender, EventArgs e)
        //{

        //}
    }
}