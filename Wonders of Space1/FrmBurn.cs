using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Wonders_of_Space1
{
    public partial class FrmBurn : Form
    {
        Graphics g; // declare the graphics objects
        int x = -35, y = 20; // strating position of Meteors
        int x1 = 35, y1 = -35;//strating position of Satellites
        //Declare the rectangles to display the Aircraft,Meteors and Satellites in 
        Rectangle areaAircraft;
        Rectangle[] areamet = new Rectangle[5];//area[1]to area[10] 
        Rectangle[] areasat = new Rectangle[5];//area[1]to area[10]
        Random speed = new Random();
        Random speed1 = new Random();
        int[] meteorspeed = new int[5];
        int[] satspeed = new int[5];

        int scorenum = 0;
        int livesnum = 200;
        
        int x2 =350, y2 = 100;//starting position of of the Aircraft
        // Load our Three images from bin,debug folder
        Image Aircraft = Image.FromFile(Application.StartupPath + @"\Aircraft.png");
        Image Satellites = Image.FromFile(Application.StartupPath + @"\Satellites.png");
        Image Meteors = Image.FromFile(Application.StartupPath + @"\Meteors.png");

        bool left, right, up, down;

        int usermamevalid = 0;

        int levelnum = 1;



        public FrmBurn()
        {
            InitializeComponent();

            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PnlGame, new object[] { true });

            areaAircraft = new Rectangle(x2, y2, 30, 30);
  
            
            for (int i = 0; i <= 4; i++)
            {
                areamet[i] = new Rectangle(y,x + 70 * i, 35, 35);


                if (levelnum == 1)
                {
                    meteorspeed[i] = speed.Next(10, 22);
                }

                if (levelnum > 1)
                {
                    meteorspeed[i] = speed.Next(70, 100);
                }

            }
            
            for (int i = 0; i <= 4; i++)
            {
                areasat[i] = new Rectangle(x1 + 70 * i, y1, 35, 35);

                if (levelnum == 1)
                {
                    satspeed[i] = speed1.Next(6, 15);
                } 

                if (levelnum == 2)
                {
                    satspeed[i] = speed1.Next(20, 30);
                }


            }






            
        }

        private void score_TextChanged(object sender, EventArgs e)
        {

        }




        private void Tmraircraft_Tick_1(object sender, EventArgs e)
        {
            if (left)
            { // If the left arrow key is set to true
                if (areaAircraft.X < 10)
                { // If the surfer is within 10 of the left side
                    areaAircraft.X = 10; // Set the surfer to 'bounce' of the side of the panel (at position 10 on the X axis)
                }
                else
                {
                    areaAircraft.X -= 9; // Else move the surfer 9 towards to the left in the panel
                }
            }
            if (right)
            { // If the right arrow key is set to true
                if (areaAircraft.X > PnlGame.Width - 40)
                { // If the surfer is within 10 of the right side
                    areaAircraft.X = PnlGame.Width - 40; // Set the surfer to 'bounce' of the side of the panel (at position of 40 less than the PnlGame width)
                }

                else
                {
                    areaAircraft.X += 9; // Else move the surfer 9 towards to the right in the panel
                }
            }

            if (up)
            { // If the up arrow key is set to true
                if (areaAircraft.Y < 15)
                { // If the surfer is within 15 of the top
                    areaAircraft.Y = 15; // Set the surfer to 'bounce' of the side of the panel (at position of 15 from the top of the panel)
                }
                else
                {
                    areaAircraft.Y -= 9; // Else move the surfer 9 towards to the top in the panel
                }
            }

            if (down)
            { // If the down arrow key is set to true
                if (areaAircraft.Y > PnlGame.Height - 40)
                { // If the surfer is within 10 of the bottom of the panel
                    areaAircraft.Y = PnlGame.Height - 40; // Set the surfer to 'bounce' of the bottom of the panel (at position of 40 of the height of the panel)
                }
                else
                {
                    areaAircraft.Y += 9; // Else move the surfer 9 towards to the bottom in the panel
                }
            }
        }

        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {
            // get the methods from the graphic's class to paint on the panel
            g = e.Graphics;
            // use the DrawImage method to draw the Aircraft on the panel
            g.DrawImage(Aircraft, areaAircraft);
            for (int i = 0; i <= 4; i++) 
            {
                g.DrawImage(Meteors, areamet[i]);
            }
           
            for(int i = 0; i <= 4; i++)
            {
                g.DrawImage(Satellites, areasat[i]);
            }
          
           
            
        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            if (usermamevalid == 0)
            {
                Tmrmeteor.Enabled = true;
                Tmrsat.Enabled = true;
                Tmraircraft.Enabled = true;

                username.Enabled = false;
                startbtn.Enabled = false;


            }
        }

        private void TmrBullet_Tick(object sender, EventArgs e)
        {

        }

        
        private void Tmrmeteor_Tick(object sender, EventArgs e)
        {


            for (int i=0; i<=4; i++)
            {
                areamet[i].X += meteorspeed[i];

                if (areamet[i].IntersectsWith(areaAircraft))
                { // If the surfer collides with any shark
                    areamet[i].X = 25; // Move the shark back to the begining of the panel
                    livesnum -= 1; // Reduce lives count by one
                    lives.Text = livesnum.ToString(); // Display the score count on the ScoreTxt textbox
                    CheckLives();
                }



                if (areamet[i].X > PnlGame.Width)
                { // If the shark reaches the end of the panel
                    scorenum += 1;
                    score.Text = scorenum.ToString(); // Display the score count on the ScoreTxt textbox
                    areamet[i].X = -35; // Move the shark back to the begining of the panel
                    CheckScore();
                }
            }

            PnlGame.Invalidate();//meke the paint even fire to redraw the panel

        }


        private void CheckScore()
        { // Initiate the CheckScore method/ function
            if (scorenum % 20 == 0)
            { // If the score is divisible by 25
                levelnum += 1; // Add one to level count
                level.Text = levelnum.ToString(); // Convert the level to a string, then display it on the LvlTxt textbox


                scorenum = 0; // Set the score count to 0
                score.Text = scorenum.ToString(); // Convert the score to a string, then display it on the ScoreTxt textbox

            }
        }


        private void Tmrsat_Tick_1(object sender, EventArgs e)
        {
            for (int i = 0; i <= 4; i++)
            {

                areasat[i].Y += satspeed[i];

                if (areasat[i].IntersectsWith(areaAircraft))
                { // If the surfer collides with any shark
                    areasat[i].Y = 25; // Move the shark back to the begining of the panel
                    livesnum -= 1; // Reduce lives count by one
                    lives.Text = livesnum.ToString(); // Display the score count on the ScoreTxt textbox
                    CheckLives();
                }

                if (areasat[i].Y > PnlGame.Height)
                { // If the shark reaches the end of the panel
                    scorenum += 1;
                    score.Text = scorenum.ToString(); // Display the score count on the ScoreTxt textbox
                    areasat[i].Y = -35; // Move the shark back to the begining of the panel
                    CheckScore();
                }

            }

            PnlGame.Invalidate();//meke the paint even fire to redraw the panel
        }




        private void username_TextChanged(object sender, EventArgs e)
        { // On change up of the textbox
            string context = username.Text; // Create a string with the value of the TbUsername value
            bool isletter = true; // Create a bool that sets isletter to ture

            if (context == "")
            { // If the username textbox is empty
                usermamevalid = 1; // Set the usernamevalid to 1, which disables the user from selecting a difficulty
            }

            else
            { // The username is not empty
                usermamevalid = 0; // Set the usernamevalid to 0, which enables the user to select a difficulty
            }

            for (int i = 0; i < context.Length; i++)
            {
                if (!char.IsLetter(context[i]))
                { // If the current character is not a letter
                    isletter = false; // Make isletter false
                    usermamevalid = 1; // Set the usernamevalid to 1, which disables the user from selecting a difficulty
                }

                else
                {
                    usermamevalid = 0; // Set the usernamevalid to 0, which enables the user to select a difficulty
                }
            }

            // if not a letter clear the textbox and focus on it
            // to enter name again
            if (isletter == false)
            { // If isletter is equal to false 
                username.Clear(); // Remove all characters in the username textbox 
                username.Focus(); // Focuse the user onto the username textbox to set the user to editing the username

                usermamevalid = 1; // Set the usernamevalid to 1, which disables the user from selecting a difficulty
            }

            else
            {
                usermamevalid = 0; // Set the usernamevalid to 0, which enables the user to select a difficulty
            }
        }




        private void CheckLives()
        { // Initiate the CheckLives method/ function
            if (livesnum == 0)
            { // If the user has no lives left
                Tmrmeteor.Enabled = false;
                Tmrsat.Enabled = false;
                Tmraircraft.Enabled = false;


                MessageBox.Show("Game Over!! You reached score " + scorenum + "!"); // Display the game over message, telling the user their level and score count
                this.Close(); // Close the form
            }
        }




        private void FrmBurn_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = false; } // If the left key is pressed, then disable the surfer left fuction
            if (e.KeyData == Keys.Right) { right = false; } // If the right key is pressed, then disable the surfer right fuction
            if (e.KeyData == Keys.Up) { up = false; } // If the up key is pressed, then disable the surfer up fuction
            if (e.KeyData == Keys.Down) { down = false; } // If the down key is pressed, then disable the surfer down fuction
        }

        private void FrmBurn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = true; } // If the left key is pressed, then enable the surfer left fuction
            if (e.KeyData == Keys.Right) { right = true; } // If the right key is pressed, then enable the surfer right fuction
            if (e.KeyData == Keys.Up) { up = true; } // If the up key is pressed, then enable the surfer up fuction
            if (e.KeyData == Keys.Down) { down = true; } // If the down key is pressed, then enable the surfer down fuction
        }


    }
}
