namespace Calculator
{
    public partial class Calculator : Form
    {
        const double unit = 10;
        
        double num1 = 0;
        double num2 = 0;
        double numPrec = 0;
        int oper;
        bool operClicked = false;
        bool isImp = false;
        bool calcDone = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void canc(object sender, EventArgs e)
        {
            Display.Text = "";
            num1 = 0;
            num2 = 0;
            isImp = false;
            operClicked = false;
            calcDone = false;
        }

        private void ce(object sender, EventArgs e)
        {
            if (!operClicked) num1 = 0;
            else num2 = 0;

            dispNum();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            Sum.Tag = 0;
            Sottr.Tag = 1;
            Molt.Tag = 2;
            Div.Tag = 3;
            Mod.Tag = 4;
        }

        private void dispNum()
        {
            String disp = "";
            if (!operClicked)
            {
                disp = Convert.ToString(num1);
            }
            else
            {
                disp += Convert.ToString(num1);
                switch(oper)
                {
                    case 0:
                        disp += " + ";
                        break;
                    case 1:
                        disp += " - ";
                        break;
                    case 2:
                        disp += " X ";
                        break;
                    case 3:
                        disp += " / ";
                        break;
                    case 4:
                        disp += " % ";
                        break;
                }
                disp += Convert.ToString(num2);
            }

            Display.Text = disp;
        }

        private void dispRes()
        {
            if (isImp) Display.Text = "IMPOSSIBLE";
            else Display.Text = Convert.ToString(numPrec);
        }

        private void addNumber(object sender, EventArgs e)
        {
            if (!operClicked)
            {
                num1 *= unit;
                num1 += Convert.ToDouble(((Button)sender).Text);
                dispNum();
            }
            else
            {
                num2 *= unit;
                num2 += Convert.ToDouble(((Button)sender).Text);
                dispNum();
            }
        }

        private void addOper(object sender, EventArgs e)
        {
            if (!operClicked)
            {
                operClicked = true;
                oper = Convert.ToInt32(((Button)sender).Tag);
                dispNum();
            }
        }

        private void calculate(object sender, EventArgs e)
        {

            if (num2 == 0 && oper == 3)
            {
                isImp = true;
                calcDone = true;
            }
            if (!isImp && !calcDone)
            {
                calcDone = true;
                switch (oper)
                {
                    case 0:
                        numPrec = num1 + num2;
                        break;
                    case 1:
                        numPrec = num1 - num2;
                        break;
                    case 2:
                        numPrec = num1 * num2;
                        break;
                    case 3:
                        numPrec = num1 / num2;
                        break;
                    case 4:
                        numPrec = num1 % num2;
                        break;
                }
            }
            dispRes();
        }
    }
}