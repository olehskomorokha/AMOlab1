namespace lab1AMO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab1Algoritm test = new Lab1Algoritm();
            if (double.TryParse(textBoxZ.Text, out double Z) &&
                double.TryParse(textBoxXx.Text, out double X) &&
                double.TryParse(textBoxY.Text, out double Y) &&
                double.TryParse(textBoxG.Text, out double G) &&
                double.TryParse(textBoxH.Text, out double H))
            {
                MessageBox.Show($"Result: " + test.LineAlgoritm(Z, X, Y, G, H).ToString());
            }
            else
            {
                MessageBox.Show("Invalid value entered!");
            }
        }
        private void solution2_Click(object sender, EventArgs e)
        {

            Lab1Algoritm test = new Lab1Algoritm();
            if (double.TryParse(textBoxU.Text, out double U) &&
                double.TryParse(textBoxB.Text, out double B) &&
                double.TryParse(textBoxYy.Text, out double Y) &&
                double.TryParse(textBoxT.Text, out double T) &&
                double.TryParse(textBoxGg.Text, out double G) &&
                double.TryParse(textBoxS.Text, out double S))
            {
                MessageBox.Show($"Result: " + test.branchout(U, B, Y, T, G, S).ToString());
            }
            else
            {
                MessageBox.Show("Invalid value entered!");
            }
            //Lab1Algoritm test = new Lab1Algoritm();
            //if (double.TryParse(textBoxN.Text, out double N))
            //{
            //    MessageBox.Show($"Result: " + test.Cyclic(N).ToString());
            //}
            //else
            //{
            //    MessageBox.Show("Invalid value entered!");
            //}
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {


        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBoxN_Click(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lab1Algoritm test = new Lab1Algoritm();
            if (double.TryParse(textBoxN.Text, out double N))
            {
                MessageBox.Show($"Result: " + test.Cyclic(N).ToString());
            }
            else
            {
                MessageBox.Show("Invalid value entered!");
            }
        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            // Generate random values for each textbox
            textBoxZ.Text = Math.Round((rand.NextDouble() * 20 - 10), 2).ToString();
            textBoxXx.Text = Math.Round((rand.NextDouble() * 20 - 10), 2).ToString();
            textBoxY.Text = Math.Round((rand.NextDouble() * 20 - 10), 2).ToString();
            textBoxG.Text = Math.Round((rand.NextDouble() * 20 - 10), 2).ToString();
            textBoxH.Text = Math.Round((rand.NextDouble() * 20 - 10), 2).ToString();
        }

        private void buttonRandom2_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            // Generate random values for each textbox
            textBoxU.Text = Math.Round((rand.NextDouble() * 20 - 10), 2).ToString();
            textBoxB.Text = Math.Round((rand.NextDouble() * 20 - 10), 2).ToString();
            textBoxYy.Text = Math.Round((rand.NextDouble() * 20 - 10), 2).ToString();
            textBoxT.Text = Math.Round((rand.NextDouble() * 20 - 10), 2).ToString();
            textBoxGg.Text = Math.Round((rand.NextDouble() * 20 - 10), 2).ToString();
            textBoxS.Text = Math.Round((rand.NextDouble() * 20 - 10), 2).ToString();
        }

        private void buttonRandom3_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            // Generate random values for each textbox
            textBoxN.Text = Math.Round((rand.NextDouble()), 2).ToString();
        }
    }
}