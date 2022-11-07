using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using SpaceShooter.Interfaces;


namespace SpaceShooter.Object.SpaceShip
{
    public class PlayerShip : DefaultShip, IDrawController
    {

        public PlayerShip()
        {
            object_height = default_height;
            object_width = default_width;
        }
        public int object_width { get; set; }
        public int object_height { get; set; }

        public int pos_x { get; set; } = 100;
        public int pos_y { get; set; } = 100;

        public Rotation rotation { get; set; } = Rotation.Rotate0;

        public void Draw(Canvas feld)
        {
                Rectangle blueRectangle = new Rectangle();
                blueRectangle.Height = object_height;
                blueRectangle.Width = object_width;
                
                ImageBrush imgBrush = new ImageBrush();
                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.UriSource = new Uri("pack://application:,,,/images/playerShip.ico");
                bitmapImage.EndInit();
                imgBrush.ImageSource = bitmapImage;
                blueRectangle.Fill = imgBrush;

                Canvas.SetLeft(blueRectangle, pos_x);
                Canvas.SetTop(blueRectangle, pos_y);

                feld.Children.Add(blueRectangle);
        }




    }
}
