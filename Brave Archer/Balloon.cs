using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brave_Archer
{
    class Balloon
    {
        public int balloonSpeed;
        public int width;
        public int height;
        public int x, y;

        public PictureBox[] greenBalloons;
        public PictureBox[] yellowBalloons;
        public PictureBox[] redBalloons;


        Random rnd;
        Image greenBalloon = Image.FromFile("assets\\greenBalloon\\greenBalloon1.png");

        public Balloon()
        {
            balloonSpeed = 4;
            width = 60;
            height = 60;
            x = 150;
            y = 0;
    
        }

        //load object
        public virtual void load_Balloon(Form p)
        {
            rnd = new Random();
            PictureBox greenB = new PictureBox();
            greenB.Location = new Point(rnd.Next(100, 580), y);
            greenB.Size = new Size(width, height);
            greenB.BackgroundImage = greenBalloon;
            greenB.BackgroundImageLayout = ImageLayout.Stretch;
            greenB.Name = "greenBalloon";
            p.Controls.Add(greenB);
        }

        public virtual void CreateBalloons(Form p)
        {
            for (int i = 0; i < 20; i++)
            {
                load_Balloon(p);
            }
        }
    }

    class redBalloon : Balloon {

        Image redBalloonI = Image.FromFile("assets\\redBalloon\\redBalloon1.png");
        Random rnd;
        //load object
        public override void load_Balloon(Form p)
        {
            rnd = new Random();
            PictureBox redB = new PictureBox();
            redB.Location = new Point(rnd.Next(100, 580), y);
            redB.Size = new Size(width, height);
            redB.BackgroundImage = redBalloonI;
            redB.BackgroundImageLayout = ImageLayout.Stretch;
            redB.Name = "redBalloon";
            p.Controls.Add(redB);
        }
        public override void CreateBalloons(Form p)
        {
            for (int i = 0; i < 4; i++)
            {
                load_Balloon(p);
            }
        }
    }


    class yellowBalloon : Balloon {

        Image yellowBalloonI = Image.FromFile("assets\\yellowBalloon\\yellowBalloon1.png");
        Random rnd;
        //load object
        public override void load_Balloon(Form p)
        {
            rnd = new Random();
            PictureBox yellowB = new PictureBox();
            yellowB.Location = new Point(rnd.Next(400, 900), y);
            yellowB.Size = new Size(width, height);
            yellowB.BackgroundImage = yellowBalloonI;
            yellowB.BackgroundImageLayout = ImageLayout.Stretch;
            yellowB.Name = "yellowBalloon";
            p.Controls.Add(yellowB);
        }

        public override void CreateBalloons(Form p)
        {
            for (int i = 0; i < 6; i++)
            {
                load_Balloon(p);
            }
        }
    }
}
