using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brave_Archer
{
    class Arrow
    {
        //variables
        Archer Ar = new Archer();
        public int arrowSpeed;
        public bool fired;
        public int width;
        public int height;
        public Image arrowI = Image.FromFile("assets\\arrow\\arrow1.png");
       
        //init variables
        public Arrow()
        {
            arrowSpeed = 4;
            fired = false;
            width = 80;
            height = 30;
        }

        //load object
        public void load_arrow(Form p)
        {
            PictureBox arrow = new PictureBox();
            arrow.Location = new Point(Ar.Location.X+50 + Ar.width / 2, Ar.Location.Y +50);
            arrow.Size = new Size(width, height);
            arrow.BackgroundImage = arrowI;
            arrow.BackgroundImageLayout = ImageLayout.Stretch;
            arrow.Name = "Arrow";
            p.Controls.Add(arrow);
        }
        
    }
}
