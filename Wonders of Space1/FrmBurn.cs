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
        Random speed = new Random(10);
        Random speed1 = new Random(20);
        
   
        int[] meteorspeed = new int[5];
        int[] satspeed = new int[5];

        int scorenum = 0;
        int livesnum = 0;
        
        
        int x2 =250, y2 = 100;//starting position of of the Aircraft
        // Load our Three images from bin,debug folder
        Image Aircraft = Image.FromFile(Application.StartupPath + @"\Aircraft.png");
        Image Satellites = Image.FromFile(Application.StartupPath + @"\Satellites.png");
        Image Meteors = Image.FromFile(Application.StartupPath + @"\Meteors.png");

        bool left, right, up, down;
        

        int usernamevalid = 0;

        int levelnum = 1;
        


        public FrmBurn()
        {
            InitializeComponent();

            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PnlGame, new object[] { true });

            areaAircraft = new Rectangle(x2, y2, 40, 40);
             
  
            
            for (int i = 0; i <= 4; i++)
            {
                areamet[i] = new Rectangle(y,x + 70 * i, 35, 35);

                

                if (levelnum == 1)//Increases speed of the Meteors when reaching that level 
                {
                    meteorspeed[i] = speed.Next(3,5 );
                }
                
                if( levelnum == 2)//Increases speed of the Meteors when reaching that level and Mulitiply by 1
                {
                    meteorspeed[i] = speed.Next(6,9*1);
                }

                if (levelnum == 3)//Increases speed of the Meteors when reaching that level and Mulitiply by 2
                {
                    meteorspeed [i] = speed.Next(9,16*2);
                }

                if (levelnum == 4)//Increases speed of the Meteors when reaching that level and Mulitiply by 2
                {
                    meteorspeed[i] = speed.Next(18, 26*2);
                }

                if (levelnum == 5)//Increases speed of the Meteors when reaching that level and Mulitiply by 3
                {
                    meteorspeed[i] = speed.Next(26, 32 *3);
                }

                if ( levelnum > 6)//Increases speed of the Meteors when reaching that level and Mulitiply by 4
                {
                    meteorspeed[i] = speed.Next(40,80 * 4);
                }

            }
            
            for (int i = 0; i <= 4; i++)
            {
                areasat[i] = new Rectangle(x1 + 70 * i, y1, 35, 35);

                if (levelnum == 1)// Increases speed of the Sattilite when reaching that level 
                {
                    satspeed[i] = speed1.Next(4,4);
                } 

                if (levelnum == 2)// Increases speed ofthe Sattilite when reaching that level and Mulitiply by 1
                {
                    satspeed[i] = speed1.Next(6,6*1);
                }

                if (levelnum == 3)// Increases speed of the Sattilite when reaching that level and Mulitiply by 2
                {
                   satspeed[i] = speed1.Next(10,10*2);
                }

                if (levelnum == 4)// Increases speed of the Sattilite when reaching that level and Mulitiply by 2
                {
                    satspeed[i] = speed1.Next(20,20*2);
                }

                if (levelnum == 5)// Increases speed of the Sattilite when reaching that level and Mulitiply by 3
                {
                    satspeed[i] = speed1.Next(25, 25*3);
                }

                if (levelnum == 6)//Increases speed of the Sattilite when reaching that level and Mulitiply by 3
                {
                    satspeed[i] = speed1.Next(32, 32*3);
                }

                if (levelnum >7)//Increases speed of the Sattilite when reaching that level and Mulitiply by 4
                {
                    satspeed[i] = speed1.Next(32, 32 *4);
                }
            }






            
        }



       


        private void Tmraircraft_Tick_1(object sender, EventArgs e)
        {
            if (left)
            { // If the left arrow key is set to true
                if (areaAircraft.X < 10)
                { // If the Aircraft is within 10 of the left side
                    areaAircraft.X = 10; // Set the Aircraft to 'bounce' of the side of the panel (at position 10 on the X axis)
                }
                else
                {
                    areaAircraft.X -= 9; // Else move the Aircraft 9 towards to the left in the panel
                }
            }
            if (right)
            { // If the right arrow key is set to true
                if (areaAircraft.X > PnlGame.Width - 40)
                { // If the Aircraft is within 10 of the right side
                    areaAircraft.X = PnlGame.Width - 40; // Set the Aircraft to 'bounce' of the side of the panel (at position of 40 less than the PnlGame width)
                }

                else
                {
                    areaAircraft.X += 9; // Else move the Aircraft 9 towards to the right in the panel
                }
            }

            if (up)
            { // If the up arrow key is set to true
                if (areaAircraft.Y < 15)
                { // If the Aircraft is within 15 of the top
                    areaAircraft.Y = 15; // Set the Aircraft to 'bounce' of the side of the panel (at position of 15 from the top of the panel)
                }
                else
                {
                    areaAircraft.Y -= 9; // Else move the Aircraft 9 towards to the top in the panel
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
            if (usernamevalid == 0)
            {
                int strung = int.Parse(lives.Text);
                livesnum = strung; // Add one to level count
                lives.Enabled = false;
               

                MessageBox.Show("Game Instructions is as following. You as the Player are trying to dodge the meteors and satellites of the game by useing the  arrow keys on the keyboard. You have 40 lives, and on a score of 20, the level will increase, and the speed of the meteors and satellites will increase to make it a bit difficult for you as the player. Just letting you know the game doesn't have a stop button,  the only way to stop is to die. Good Luck and I hope that you will succeed!!!  "); // Display the game over message, telling the user their level and score count
                Tmrmeteor.Enabled = true;
                Tmrsat.Enabled = true;
                Tmraircraft.Enabled = true;

                username.Enabled = false;
                startbtn.Enabled = false;
            }
            if (livesnum == 0)
            {

                livesnum = 20;

               
                Tmrmeteor.Enabled = true;
                Tmrsat.Enabled = true;
                Tmraircraft.Enabled = true;
                lives.Enabled = false;
                username.Enabled = false;
                startbtn.Enabled = false;
            }
        }

        private void Tmrmeteor_Tick(object sender, EventArgs e)
        {


            for (int i=0; i<=4; i++)
            {
                areamet[i].X += meteorspeed[i];

                if (areamet[i].IntersectsWith(areaAircraft))
                { // If the surfer collides with any shark
                    areamet[i].X = 25; // Move the meteors back to the begining of the panel
                    livesnum -= 1; // Reduce lives count by one
                    lives.Text = livesnum.ToString(); // Display the score count on the Scorenum textbox
                    CheckLives();
                }



                if (areamet[i].X > PnlGame.Width)
                { // If the Meteor reaches the end of the panel
                    scorenum += 1;
                    score.Text = scorenum.ToString(); // Display the score count on the Scorenum textbox
                    areamet[i].X = -35; // Move the meteor back to the begining of the panel
                    CheckScore();
                }
            }

            PnlGame.Invalidate();//meke the paint even fire to redraw the panel

        }

     

        private void username_TextChanged_1(object sender, EventArgs e)
        {
            string context = username.Text; // Create a string with the value of the username value
            bool isletter = true; // Create a bool that sets isletter to ture

            if (context == "")
            { // If the username textbox is empty
                usernamevalid = 1; // Set the usernamevalid to 1, which disables the timers
            }

            else
            { // The username is not empty
                usernamevalid = 0; // Set the usernamevalid to 0, which enables the timers
            }

            for (int i = 0; i < context.Length; i++)
            {
                if (!char.IsLetter(context[i]))
                { // If the current character is not a letter
                    isletter = false; // Make isletter false
                    usernamevalid = 1; // Set the usernamevalid to 1, which disables the timers
                }

                else
                {
                    usernamevalid = 0; // Set the usernamevalid to 0, which enables the timers
                }
            }

            // if not a letter clear the textbox and focus on it
            // to enter name again
            if (isletter == false)
            { // If isletter is equal to false 
                username.Clear(); // Remove all characters in the username textbox 
                username.Focus(); // Focuse the user onto the username textbox to set the user to editing the username

                usernamevalid = 1; // Set the usernamevalid to 1, which disables the timers
            }

            else
            {
                usernamevalid = 0; // Set the usernamevalid to 0, which enables the timers
            }
        }

        private void CheckScore()
        { // Initiate the CheckScore method/ function
            if (scorenum % 20 == 0)
            { // If the score is divisible by 25
                levelnum += 1; // Add one to level count
                level.Text = levelnum.ToString(); // Convert the level to a string, then display it on the Lvelnum textbox


                scorenum = 0; // Set the score count to 0
                score.Text = scorenum.ToString(); // Convert the score to a string, then display it on the Scorenum textbox

            }
        }


        private void Tmrsat_Tick_1(object sender, EventArgs e)
        {
            for (int i = 0; i <= 4; i++)
            {

                areasat[i].Y += satspeed[i];

                if (areasat[i].IntersectsWith(areaAircraft))
                { // If the Aircraft collides with any sattillites or Meteors
                    areasat[i].Y = 25; // Move the Sattllite back to the begining of the panel
                    livesnum -= 1; // Reduce lives count by one
                    lives.Text = livesnum.ToString(); // Display the score count on the Scorenum textbox
                    CheckLives();
                }

                if (areasat[i].Y > PnlGame.Height)
                { // If the shark reaches the end of the panel
                    scorenum += 1;
                    score.Text = scorenum.ToString(); // Display the score count on the Scorenum textbox
                    areasat[i].Y = -35; // Move the sattelite back to the begining of the panel
                    CheckScore();
                }

            }

            PnlGame.Invalidate();//meke the paint even fire to redraw the panel
        }








        private void CheckLives()
        { // Initiate the CheckLives method/ function
            if (livesnum == 0)
            { // If the user has no lives left
                Tmrmeteor.Enabled = false;
                Tmrsat.Enabled = false;
                Tmraircraft.Enabled = false;

                
                MessageBox.Show("Game Over, " + username.Text + "!! You reached Level " + levelnum + " Score " + scorenum + "!"); // Display the game over message, telling the user their level and score count
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
