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
        Rectangle[] areamet = new Rectangle[5];//area[1]to area[10] 
        Rectangle[] areasat = new Rectangle[5];//area[1]to area[10]
        Random speed = new Random();
        int[] meteorspeed = new int[5];
        int[] satspeed = new int[5];
        
        int x2 = 50, y2 = 290;//starting position of of the Aircraft
        // Load our Three images from bin,debug folder
        Image Aircraft = Image.FromFile(Application.StartupPath + @"\Aircraft.png");
        Image Satellites = Image.FromFile(Application.StartupPath + @"\Satellites.png");
        Image Meteors = Image.FromFile(Application.StartupPath + @"\Meteors.png");

       

        public FrmBurn()
        {
           
            areaAircraft = new Rectangle(x2, y2, 30, 30);
  
            
            for (int i = 0; i <= 4; i++)
            {
                areamet[i] = new Rectangle(x2 + 70 * i, y2, 40, 40);
                meteorspeed[i] = speed.Next(6, 15);
            }
            
            for (int i = 0; i < 4; i++)
            {
                areasat[i] = new Rectangle(x1 + 70 * i, y1, 35, 35);
                satspeed[i] = speed.Next(6, 15);

            }






            InitializeComponent();
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

        private void Tmrmeteor_Tick(object sender, EventArgs e)
        {


            for (int i=0; i<=4; i++)
            {
                areamet[i].X += meteorspeed[i];
            }

            PnlGame.Invalidate();//meke the paint even fire to redraw the panel

        }


        private void Tmrsat_Tick(object sender, EventArgs e)
        {


            for (int i = 0; i <= 4; i++)
            {

                areasat[i].Y += satspeed[i];
            }

            PnlGame.Invalidate();//meke the paint even fire to redraw the panel

        }
    }
}
