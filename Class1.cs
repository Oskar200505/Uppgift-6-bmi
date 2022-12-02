using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift_bmi;

namespace Uppgift_bmi1
{
    public class BMI
    {
        public void bmiräknare()
        {
            int vikt;
            int längd;
            int bmi;
            vikt = int.Parse(textBox2.Text);
            längd = int.Parse(textBox3.Text);
            bmi = (vikt * 703) / (längd * längd);
            if (bmi < 18.5)
            {
                textBox4.Text = bmi + "\n Undervikt" + "\n ät mer och gå till gymmet";
            }
            if (bmi > 18.5 && bmi < 24.9)
            {
                textBox4.Text = bmi + "\n Normal" + "\n Sexig";
            }
            if (bmi > 25 && bmi < 29.9)
            {
                textBox4.Text = bmi + "\n banta" + "\n din gris";
            }
            else if (bmi > 30)
            {
                textBox4.Text = bmi + "\n extrem tjockis" + "\n sök hjälp annars dör du";
            }
        }
    }
}
