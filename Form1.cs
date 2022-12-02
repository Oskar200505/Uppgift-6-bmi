using Uppgift_bmi1;
namespace Uppgift_bmi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BMI BMI = new BMI();
        private void btn_bmi(object sender, EventArgs e)
        {
            BMI.bmiräknare();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}