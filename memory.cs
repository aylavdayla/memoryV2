using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memoryV2
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        List<Image> images = new List<Image>()
        {
            Properties.Resources._1, Properties.Resources._1,
            Properties.Resources._2, Properties.Resources._2,
            Properties.Resources._3, Properties.Resources._3,
            Properties.Resources._4, Properties.Resources._4,
            Properties.Resources._5, Properties.Resources._5,
            Properties.Resources._6, Properties.Resources._6,
            Properties.Resources._7, Properties.Resources._7,
            Properties.Resources._8, Properties.Resources._8,
            Properties.Resources._9, Properties.Resources._9,
            Properties.Resources._10, Properties.Resources._10
        };

        private void ImagesToCards()
        {
            foreach (Control control in tableLayoutPanel2.Controls)
            {
                PictureBox iconImages = control as PictureBox;
                if (iconImages != null)
                {
                    int randomNumber = random.Next(images.Count);
                    iconImages.Image = images[randomNumber];
                    // iconImages.ForeColor = iconImages.BackColor; // zou ervoor moeten zorgen
                                                                 // dat de plaatjes verborgen blijven
                                                                 // maar werkt nog ff niet
                    images.RemoveAt(randomNumber);
                }
            }
        }

        public Form1()
        {
            InitializeComponent();

            ImagesToCards();
        }


    }
}
