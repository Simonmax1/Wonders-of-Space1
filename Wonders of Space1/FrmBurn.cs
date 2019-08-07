using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wonders_of_Space1
{
    public partial class FrmBurn : Form
    {
        Graphics g; // declare the graphics objects
        int x = 20, y = 20; // strating position of Meteors
        int x1 = 35, y1 = 35;//strating position of Satellites
        //Declare the rectangles to display the Aircraft,Meteors and Satellites in 
        Rectangle area, area1, area2, area3, area4, area5, area6, area7, area8, area9, area10;
        Random speed = new Random();
        int speed1,speed2,speed3,speed4,speed5,speed6,speed7,speed8,speed9,speed10;
        int x2 = 50, y2 = 290;//starting position of of the Aircraft
        // Load our Three images from bin,debug folder
        Image Aircraft = Image.FromFile(Application.StartupPath + @"\Aircraft.png");
        Image Satellites = Image.FromFile(Application.StartupPath + @"\Satellites.png");
        Image Meteors = Image.FromFile(Application.StartupPath + @"\Meteors.png");

        public FrmBurn()
        {
            InitializeComponent();
            area = new Rectangle(x2, y2, 20,20);//Aircraft's rectangle
            area1 = new Rectangle(x, y, 20, 20);//Meteor1's rectangle
            area2 = new Rectangle(x, y, 21, 21);//Meteor2's rectangle
            area3 = new Rectangle(x, y, 22, 22);//Meteor3's rectangle
            area4 = new Rectangle(x, y, 23, 23);//Meteor4's rectnagle
            area5 = new Rectangle(x, y, 24, 24);//Meteor5's rectangle
            area6 = new Rectangle(x1, y1, 35, 35);//Satellite1's rectangle
            area7 = new Rectangle(x1, y1, 36, 36);//Satellite2's rectangle
            area8 = new Rectangle(x1, x1, 37, 37);//Satellite3's rectangle
            area9 = new Rectangle(x1, x1, 38, 38);//Satellite4's rectangle
            area10 = new Rectangle(x1, y1, 39, 39);//Satellite5's rectangle

            speed1 = speed.Next(5, 10);
            speed2 = speed.Next(5, 10);
            speed3 = speed.Next(5, 10);
            speed4 = speed.Next(5, 10);
            speed5 = speed.Next(5, 10);
            speed6 = speed.Next(5, 10);
            speed7 = speed.Next(5, 10);
            speed8 = speed.Next(5, 10);
            speed9 = speed.Next(5, 10);
            speed10 = speed.Next(5, 10);
        }

        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {
            // get the methods from the graphic's class to paint on the panel
            g = e.Graphics;
            // use the DrawImage method to draw the Aircraft on the panel
            g.DrawImage(Aircraft, area);
            //use the DrawImage method to draw the Meteor on the panel
            g.DrawImage(Meteors, area1);
            g.DrawImage(Meteors, area2);
            g.DrawImage(Meteors, area3);
            g.DrawImage(Meteors, area4);
            g.DrawImage(Meteors, area5);
            //use the DrawImage method to draw the Satellites on the panel
            g.DrawImage(Satellites, area6);
            g.DrawImage(Satellites, area7);
            g.DrawImage(Satellites, area8);
            g.DrawImage(Satellites, area9);
            g.DrawImage(Satellites, area10);
        }

        private void Tmrmeteor_Tick(object sender, EventArgs e)
        {
            
            area1.Y += speed1;//move the area(meteor) down the panel
            
            if (area1.Y > PnlGame.Height)
            {
                area1.Y = 20;
            }
            
            area2.Y += speed2;//move the area(meteor) down the panel

            if (area2.Y > PnlGame.Height)
            {
                area2.Y = 21;
            }
            
            area3.Y += speed3;//move the area(meteor) down the panel

            if (area3.Y > PnlGame.Height)
            {
                area3.Y = 22;
            }
            
            area4.Y += speed4;//move the area(meteor) down the panel

            if (area1.Y > PnlGame.Height)
            {
                area4.Y = 23;
            }
            
            area5.Y += speed5;//move the area(meteor) down the panel

            if (area5.Y > PnlGame.Height)
            {
                area5.Y = 24;
            }
            
            area6.Y += speed6;//move the area(meteor) down the panel

            if (area6.Y > PnlGame.Height)
            {
                area6.Y = 35;
            }
           
            area7.Y += speed7;//move the area(meteor) down the panel

            if (area7.Y > PnlGame.Height)
            {
                area7.Y = 36;
            }
            
            area8.Y += speed8;//move the area(meteor) down the panel

            if (area8.Y > PnlGame.Height)
            {
                area8.Y = 37;
            }
       
            area9.Y += speed9;//move the area(meteor) down the panel

            if (area9.Y > PnlGame.Height)
            {
                area9.Y = 38;
            }
           
            area10.Y += speed10;//move the area(meteor) down the panel

            if (area10.Y > PnlGame.Height)
            {
                area10.Y = 38;
            }


            PnlGame.Invalidate();//meke the paint even fire to redraw the panel

        }
    }
}
