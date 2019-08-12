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
        Rectangle areaAircraft;
        Rectangle[] area = new Rectangle[5];//area[1]to area[10] 
        Random speed = new Random();
        int[] meteorspeed = new int[11];
        int x2 = 50, y2 = 290;//starting position of of the Aircraft
        // Load our Three images from bin,debug folder
        Image Aircraft = Image.FromFile(Application.StartupPath + @"\Aircraft.png");
        Image Satellites = Image.FromFile(Application.StartupPath + @"\Satellites.png");
        Image Meteors = Image.FromFile(Application.StartupPath + @"\Meteors.png");

        public FrmBurn()
        {
            InitializeComponent();
            areaAircraft = new Rectangle(x2, y2, 30, 30);
            meteorspeed[0] = speed.Next(5, 11);

            for (int i = 0; i <= 11; i++)
            {
                area[0] = new Rectangle(x + 70 * 0, y, 40, 40);
            }
            for (int i = 0; i < 11; i++) 
            {
                area[1] = new Rectangle(x + 50 * 0, y, 20, 20);
              
            }
            for (int i = 1; i < 11; i++)
            {
                area[2] = new Rectangle(x + 50 * 1, y, 20, 20);
            }
            for (int i = 2; i < 11; i++)
            {
                area[3] = new Rectangle(x = 50 * 2, y, 20, 20);
            }
            for (int i = 3; i < 11; i++)
            {
                area[4] = new Rectangle(x = 50 * 3, y, 20, 20);
            }
            for(int i = 4 ;i<11;i++)
            {
                area[5] = new Rectangle(x = 50*1,y,20,20);
            }
           
            for (int i = 5; i < 11; i++)
            {
                area[6] = new Rectangle(x = 50 * 5, y, 20, 20);
            }
            for (int i = 0; i < 11; i++)
            {
                area[7] = new Rectangle(x1 = 70 * 0, y1, 35, 35);
            }
            for (int i = 1; i < 11; i++)
            {
                area[8] = new Rectangle(x1 = 70 * 1, y1, 36, 36);
            }
            for (int i = 2; i < 11; i++)
            {
                area[9] = new Rectangle(x1 = 70 * 2, y1, 37, 37);
            }
            for (int i = 3; i < 11; i++)
            {
                area[10] = new Rectangle(x1 = 70 * 3, y1, 38, 38);
            }
            for (int i = 4; i < 11; i++)
            {
                area[11] = new Rectangle(x1 = 70 * 4, y1, 39, 39);
            }



             
        }

        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {
            // get the methods from the graphic's class to paint on the panel
            g = e.Graphics;
            // use the DrawImage method to draw the Aircraft on the panel
            g.DrawImage(Aircraft, area[0]);
            for (int i = 0; i < 11; i++) 
            {
                g.DrawImage(Meteors, area[1]);
            }
            for (int i = 1; i < 11; i++) 
            {
                g.DrawImage(Meteors, area[2]);
            }
            for (int i = 2; i < 11; i++)
            {
                g.DrawImage(Meteors, area[3]);
            }
            for (int i = 3; i < 11; i++)
            {
                g.DrawImage(Meteors, area[4]);
            }
            for(int i = 4; i < 11; i++)
            {
                g.DrawImage(Meteors, area[5]);
            }
            for (int i = 5; i < 11; i++)
            {
                g.DrawImage(Meteors, area[6]);
            }
            for(int i = 6; i < 11; i++)
            {
                g.DrawImage(Satellites, area[7]);
            }
            for(int i = 7; i < 11; i++)
            {
                g.DrawImage(Satellites, area[8]);
            }
            for(int i = 8; i < 11; i++)
            {
                g.DrawImage(Satellites, area[9]);
            }
            for (int i = 9; i < 11; i++)
            {
                g.DrawImage(Satellites, area[10]);
            }
            for(int i = 10; i < 11; i++)
            {
                g.DrawImage(Satellites, area[11]);
            }
           
            
        }

        private void Tmrmeteor_Tick(object sender, EventArgs e)
        {
           for(int i =0;i<=10;i++)
            {
                area[i].Y += meteorspeed[i];
                if(area[i].Y>PnlGame.Height)
                {
                    area[i].Y = 20;
                }
            }

            PnlGame.Invalidate();//meke the paint even fire to redraw the panel

        }
    }
}
