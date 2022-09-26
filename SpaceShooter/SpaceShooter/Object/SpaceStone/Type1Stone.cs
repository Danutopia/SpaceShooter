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

namespace SpaceShooter.Object.SpaceStone
{
    public class Type1Stone : DefaultStone, IDrawController
    {
        public Type1Stone()
        {
            object_height = default_height;
            object_width = default_width;

            pos_x = default_pos_x;
            pos_y = default_pos_y;
        }
        public int object_width { get; set; }
        public int object_height { get; set; }
        public int pos_x { get; set; }
        public int pos_y { get; set; }

        public void Draw(Canvas feld)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Height = object_height;
            rectangle.Width = object_width;

            SolidColorBrush brush = new SolidColorBrush();
            brush.Color = Color.FromRgb(244, 255, 90);
            rectangle.Fill = brush;

            Canvas.SetLeft(rectangle, pos_x);
            Canvas.SetTop(rectangle, pos_y);

            feld.Children.Add(rectangle);
        }
    }
}
