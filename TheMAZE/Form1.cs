namespace TheMAZE
{
    public partial class Form1 : Form
    {
        Point startPoint;
        int countSeconds;
        void StartGame()
        {
            startPoint = panel1.Location;
            Cursor.Position = PointToScreen(startPoint);
            countSeconds = 0;
            timer1.Start();
        }

        public Form1()
        {
            InitializeComponent();
           

            StartGame();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Text = countSeconds.ToString();
            countSeconds++;
            if (countSeconds == 15)
            {
                MessageBox.Show("Time is out! Meet your doom!");
                countSeconds = 0;
                StartGame();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have survived the maze and won the prize!");
            Close();
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("You have touched a wall. Apparently that's instant death! Try again!");
            timer1.Stop();
            StartGame();
        }
    }
}