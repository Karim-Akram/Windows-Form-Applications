namespace Simple_Age_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int age;
                age = Convert.ToInt32(birthYear.Text);
                Result.Text = Convert.ToString(DateTime.Now.Year-age);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Attention Please Enter the correct year of birth in numbers!!");
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}