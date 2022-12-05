using System;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using SpaceShooter.Interfaces;

namespace SpaceShooter.Object.SpaceStone
{
    public class Type1Stone : DefaultStone, IDrawController
    {

        Random random = new Random();
        public Type1Stone()
        {
            pos_x = default_pos_x;
            pos_y = default_pos_y;
        }

        public int pos_x { get; set; }
        public int pos_y { get; set; }

        public int spray { get; set; }
        public String sprayDirection { get; set; }

        public void genererateSpray()
        {
            spray = random.Next(50, 150);

            switch (random.Next(0,5))
            {
                case 0:
                    sprayDirection = "up";
                    break;
                case 1:
                    sprayDirection = "down";
                    break;
                case 2:
                    sprayDirection = "downLeft";
                    break;
                case 3:
                    sprayDirection = "downRight";
                    break;
                case 4:
                    sprayDirection = "upLeft";
                    break;
                case 5:
                    sprayDirection = "upRight";
                    break;

            }
        }

        public void Draw(Canvas feld)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Height = default_height;
            rectangle.Width = default_width;

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri("pack://application:,,,/images/picwish.ico");
            bitmapImage.EndInit();
            imgBrush.ImageSource = bitmapImage;
            rectangle.Fill = imgBrush;

            Canvas.SetLeft(rectangle, pos_x);
            Canvas.SetTop(rectangle, pos_y);

            feld.Children.Add(rectangle);
        }
    }
}
