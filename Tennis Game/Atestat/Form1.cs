namespace Atestat
{
    public partial class Form1 : Form
    {
        public int speed_left = 8;
        public int speed_top = 8;
        public int point = 0;

        //setting up the initial speed of the ball and the initial score
        public Form1(int i)
        {
            InitializeComponent();
            //inititalizing the rackets images
            //each player has their own racket so you will play the racket of the character you pick 
            //!!!!! if there will be an error here, do this: 
            // 1. go to the folder and enter "Atestat file" -> "bin" -> "Debug". In this file copy the paths to each image named 1.1, 2, 3.1, 4.1, 5.1, 6.1 doing this:
            //left click on an image -> rigt click on the image -> click copy as path
            //change the pathes in this lower section to the new paths. For exmaple:
            //change "C:\Users\vladi\Downloads\zip atestat\Atestat Vladimir Cuc 12F 2022\Atestat\bin\Debug\1.1.png"
            //including the qoates with the new path you just copied for each image
            //repeate the process for each image, save the program and play it again.
            Image image1 = Image.FromFile(@"C:\Users\vladi\Downloads\zip atestat\Atestat Vladimir Cuc 12F 2022\Atestat\bin\Debug\1.1.png");
            Image image2 = Image.FromFile(@"C:\Users\vladi\Downloads\zip atestat\Atestat Vladimir Cuc 12F 2022\Atestat\bin\Debug\2.png");
            Image image3 = Image.FromFile(@"C:\Users\vladi\Downloads\zip atestat\Atestat Vladimir Cuc 12F 2022\Atestat\bin\Debug\3.1.png");
            Image image4 = Image.FromFile(@"C:\Users\vladi\Downloads\zip atestat\Atestat Vladimir Cuc 12F 2022\Atestat\bin\Debug\4.1.png");
            Image image5 = Image.FromFile(@"C:\Users\vladi\Downloads\zip atestat\Atestat Vladimir Cuc 12F 2022\Atestat\bin\Debug\5.1.png");
            Image image6 = Image.FromFile(@"C:\Users\vladi\Downloads\zip atestat\Atestat Vladimir Cuc 12F 2022\Atestat\bin\Debug\6.1.png");
            if (i == 0)
                racket.Image = image1;
            if (i == 1)
                racket.Image = image2;
            if (i == 2)
                racket.Image = image3;
            if (i == 3)
                racket.Image = image4;
            if (i == 4)
                racket.Image = image5;
            if (i == 5)
                racket.Image = image6;

            //hiding the timer
            timer1.Enabled = true;
            Cursor.Hide();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            //setiing up the scene where the actual game is played 
            racket.Top = playground.Bottom - (playground.Bottom / 15);
            gameover_lbl.Left = (playground.Width / 2) - (gameover_lbl.Width / 2);
            gameover_lbl.Top = (playground.Height / 2) - (gameover_lbl.Height / 2);
            label1.Left = (playground.Width / 2) - (gameover_lbl.Width / 2);
            label1.Top = (playground.Height / 2) - (gameover_lbl.Height / 2) + gameover_lbl.Height;
            gameover_lbl.Visible = false;
            label1.Visible = false;

        }

        private void playground_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void racket_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            racket.Left = Cursor.Position.X - (racket.Width / 2);
            ball.Left += speed_left;
            ball.Top += speed_top;
            //initializing the position of the racket and incirsing the ball speed

            if(ball.Bottom >= racket.Top && ball.Bottom <= racket.Bottom && ball.Left >= racket.Left && ball.Right <= racket.Right)
            {
                Random rnd = new Random();
                int j;
                if (speed_top > 12 || speed_top < -12)
                {
                    //chaging the speed of the ball with a random speed
                    j = (rnd.Next(12, 16));
                    if (speed_left < 0)
                        speed_left = -j;
                    else
                        speed_left = j;

                    if (speed_top < 0)
                        speed_top = -j;
                    else
                        speed_top = j;
                    //if the ball hits a marging change the direction of its movement 
                }
                else
                {
                    speed_top += 2;
                    speed_left += 2;
                    //we accelerate the ball speed until it gets to one point
                }
                speed_top = -speed_top;
                point += 1;
                //when we hit the ball with the racjet we change the direction of the ball and increment the points 
                points_lbl.Text = point.ToString();

            }
            //changin the ball dircetion whe  it hits a nargin
            if(ball.Left <= playground.Left)
            {
                speed_left = -speed_left;
            }
            if(ball.Right >= playground.Right)
            {
                speed_left = -speed_left;
            }
            if(ball.Top <= playground.Top)
            {
                speed_top = -speed_top;
            }
            if(ball.Bottom >= playground.Bottom)
            {
                //if the ball hits the bottom past the racket end the timer and show the game over message
                //including score 
                timer1.Enabled = false;
                gameover_lbl.Visible = true;
                label1.Text = label1.Text + Convert.ToString(point);
                label1.Visible = true;
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                //settig up the commands after the game is over
                //ESC will end the game and get us to the initial screen
                Form3 newForm = new Form3();
                newForm.Show();
                this.Close();
                Cursor.Show();
            }
            if (e.KeyCode == Keys.Space)
            {
                //SPACE will restart the game
                //restarting the position of the ball and racket 
                //and restarting the timer
                ball.Top = 50;
                ball.Left = 50;
                speed_left = 8;
                speed_top = 8;
                point = 0;
                points_lbl.Text = "0";
                timer1.Enabled = true;
                gameover_lbl.Visible = false;
                label1.Text = "Final score is ";
                label1.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void points_lbl_Click(object sender, EventArgs e)
        {

        }

        private void ball_Click(object sender, EventArgs e)
        {

        }

        private void gameover_lbl_Click(object sender, EventArgs e)
        {

        }
    }
}