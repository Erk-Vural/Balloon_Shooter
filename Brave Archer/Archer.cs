using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brave_Archer
{
    class Archer
    {
        public int archerSpeed;
        public int width;
        public int height;
        public int x, y;
        public Point Location;
        Image archerI = Image.FromFile("assets\\archer\\archer1.png");

        public Archer()
        {
            archerSpeed = 5;
            width = 100;
            height = 200;
            x = 50;
            y = 300;
            Location.X = x;
            Location.Y = y;

        }

        public void load_archer(Form p)
        {
            PictureBox archer = new PictureBox();
            archer.Location = Location;
            archer.Size = new Size(width, height);
            archer.BackgroundImage = archerI;
            archer.BackgroundImageLayout = ImageLayout.Stretch;
            archer.Name = "Archer";
            p.Controls.Add(archer);
        }

    }
}
