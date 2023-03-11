namespace Calculator
{
    public partial class Form1 : Form
    {
        double n1;
        double n2;
        double res;
        string pro;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n2 = Convert.ToDouble(Lb_result.Text);
            if (pro == "+")
            {
                res=n1+ n2;
                Lb_result.Text=Convert.ToString(res);
            }
            else if (pro == "-")
            {
                res = n1 - n2;
                Lb_result.Text = Convert.ToString(res);
            }
            else if (pro == "*")
            {
                res = n1 * n2;
                Lb_result.Text = Convert.ToString(res);
            }
            else if (pro == "/")
            {
                res = n1 / n2;
                Lb_result.Text = Convert.ToString(res);
            }
            Lb_Calculating.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnEvent(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if(Lb_result.Text=="0")
            {
                Lb_result.Text = "";
                Lb_result.Text = Lb_result.Text + btn.Text;
               
            }
            else
            {
                Lb_result.Text = Lb_result.Text + btn.Text;
                
            }
            if(Lb_Calculating.Text!="") 
            {
                Lb_Calculating.Text = Lb_Calculating.Text + btn.Text;
            }
            else
            {
                Lb_Calculating.Text=Lb_result.Text;
            }



            

        }

        private void pro_click(object sender, EventArgs e)
        {
            Button Btn = (Button)sender;
            n1 = Convert.ToDouble(Lb_result.Text);
            pro = Btn.Text;
            if (Lb_Calculating.Text!= " ")
            {
                Lb_Calculating.Text = Lb_Calculating.Text + pro;
            }
            else
            {
                Lb_Calculating.Text = Lb_result.Text + pro;
            }
           
            Lb_result.Text = "";
        }
    }
}