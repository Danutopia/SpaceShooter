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
        public void Draw(Canvas feld)
        {

            BitmapImage theImage = new BitmapImage
                (new Uri("images/playerShip.ico", UriKind.Relative));

            ImageBrush myImageBrush = new ImageBrush(theImage);

            rectangle.Fill = myImageBrush;

            feld.Children.Add(rectangle);
        }
    }
}
