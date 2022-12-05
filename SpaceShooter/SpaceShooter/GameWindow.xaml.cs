using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Collections.Generic;

using SpaceShooter.Object.SpaceShip;
using SpaceShooter.Object.SpaceStone;
using SpaceShooter.Utils;
using SpaceShooter.Handlers;
using SpaceShooter.Exceptions;
using System.Windows.Threading;

namespace SpaceShooter
{
    /// <summary>
    /// Interaktionslogik für GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        ObjectCollisionHandler collisionHandler = new ObjectCollisionHandler();

        MoveHandler moveHandler = new MoveHandler();


        DispatcherTimer shipTimer = new DispatcherTimer();
        DispatcherTimer stoneTimer = new DispatcherTimer();

        Random random = new Random();

        public GameWindow()
        {
            InitializeComponent();
            GameManager.generatePossiblePosition();


            PlayerShip playerShip = new PlayerShip();
            GameManager.playerContainer.Add(playerShip);
            playerShip.Draw(spielfeld);

            generateStones(1);
            generateStones(2);

            shipTimer.Interval = TimeSpan.FromMilliseconds(50);
            shipTimer.Tick += movePlayerByTick;
            shipTimer.Start();

            stoneTimer.Interval = TimeSpan.FromMilliseconds(250);
            stoneTimer.Tick += moveStones;
            stoneTimer.Start();


        }

        public void generateStones(int amount)
        {
            Type1Stone target;
            List<int> possibleXpos = GameManager.possibleXpos;
            List<int> possibleYpos = GameManager.possibleYpos;

            for (int i = 0; i < amount; i++)
            {
                target = new Type1Stone();
                target.pos_x = GameManager.possibleXpos[random.Next(possibleXpos[0], possibleXpos[possibleXpos.Count])];
                target.pos_y = GameManager.possibleYpos[random.Next(possibleYpos[0], possibleYpos[possibleYpos.Count])];
                target.genererateSpray();

                //draw
                GameManager.type1StoneContainer.Add(target);
                

            }
        }

        public void moveStones(object sender, EventArgs e)
        {
            moveHandler.stoneDrop();
            moveHandler.callMoveEvent(spielfeld);
        }


        public void movePlayerByTick(object sender, EventArgs e)
        {

            switch (GameManager.direction)
            {
                case "up":
                    GameManager.playerContainer[0].pos_y -= 10;
                    GameManager.playerContainer[0].rotation = Rotation.Rotate0;
                    break;
                case "down":
                    GameManager.playerContainer[0].pos_y += 10;
                    GameManager.playerContainer[0].rotation = Rotation.Rotate180;
                    break;
                case "left":
                    GameManager.playerContainer[0].pos_x -= 10;
                    GameManager.playerContainer[0].rotation = Rotation.Rotate270;
                    break;
                case "right":
                    GameManager.playerContainer[0].pos_x += 10;
                    GameManager.playerContainer[0].rotation = Rotation.Rotate90;
                    break;
            }

            moveHandler.callMoveEvent(spielfeld);

            try
            {
                collisionHandler.checkPlayerBorderCollision();
                collisionHandler.checkStone1BorderCollision();
                collisionHandler.checkPlayerCollision();

            }
            catch (StoneHitException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (StoneHitBorderException ex)
            {
                generateStones(1);
            }
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
                    break;
                case Key.S:
                    GameManager.direction = "down";
                    break;
                case Key.A:
                    GameManager.direction = "left";
                    break;
                case Key.D:
                    GameManager.direction = "right";
                    break;
            }

        }
    }
}
