using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using SpaceShooter.Object.SpaceShip;
using SpaceShooter.Object.SpaceStone;
using SpaceShooter.Utils;

namespace SpaceShooter
{
    /// <summary>
    /// Interaktionslogik für GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        
        public GameWindow()
        {
            InitializeComponent();

            PlayerShip playerShip = new PlayerShip();
            GameManager.playerContainer.Add(playerShip);
            playerShip.Draw(spielfeld);

            Type1Stone type1Stone = new Type1Stone();
            GameManager.type1StoneContainer.Add(type1Stone);
            type1Stone.Draw(spielfeld);


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }


        private void window_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.W:
                    GameManager.direction = "up";
                    GameManager.playerContainer[0].pos_y -= 10;
                    break;
                case Key.S:
                    GameManager.direction = "down";
                    GameManager.playerContainer[0].pos_y += 10;
                    break;
                case Key.A:
                    GameManager.direction = "left";
                    GameManager.playerContainer[0].pos_x -= 10;
                    break;
                case Key.D:
                    GameManager.direction = "right";
                    GameManager.playerContainer[0].pos_x += 10;
                    break;
            }

            MoveHandler.callMoveEvent(spielfeld);

        }
    }
}
