using System;

using UIKit;

namespace BMIcalculator
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        double result = 0.0;
        double bmi,weight, height = 0.0;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            calcBtn.TouchUpInside += CalcBtn_TouchUpInside;
            clearBtn.TouchUpInside += ClearBtn_TouchUpInside;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        void CalcBtn_TouchUpInside(object sender, EventArgs e)
        {
            weight = double.Parse(weightTextField.Text);
            height = double.Parse(heightTextField.Text);

                result = ((weight / height) / height);
                bmi = Math.Round(result, 2);
            


            if (bmi >= 30)
            {
                bmiLabel.BackgroundColor = UIColor.Red;
                bmiLabel.Text = bmi.ToString() + "Kg/m2";
                verdictLabel.TextColor = UIColor.Red;
                verdictLabel.Text = "Obese";
            }
            else if (bmi >= 25 && bmi <= 29.9)
            {
                bmiLabel.BackgroundColor = UIColor.Yellow;
                bmiLabel.Text = bmi.ToString() + "Kg/m2";
                verdictLabel.TextColor = UIColor.Yellow;
                verdictLabel.Text = "Overweight";
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                bmiLabel.BackgroundColor = UIColor.Green;
                bmiLabel.Text = bmi.ToString() + "Kg/m2";
                verdictLabel.TextColor = UIColor.Green;
                verdictLabel.Text = "Healthy";
            }
            else
            {
                bmiLabel.Text = bmi.ToString() + "Kg/m2";
            }
        }

        void ClearBtn_TouchUpInside(object sender, EventArgs e)
        {
            weightTextField.Text = "";
            heightTextField.Text = "";
            bmiLabel.Text = "0.0";
            bmiLabel.BackgroundColor = UIColor.White;
            verdictLabel.Text = "";
        }
    }//end of class
}
/**A BMI below 18.5 (shown in white) is considered underweight.
A BMI of 18.5 to 24.9 (green) is considered healthy.
A BMI of 25 to 29.9 (yellow) is considered overweight.
A BMI of 30 or higher (red) is considered obese.**/