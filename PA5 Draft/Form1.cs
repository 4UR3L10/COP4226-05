using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace PA5_Draft
{
    public partial class MainForm : Form
    {
        // Global Variables.
        private int Step = 1;
        private int NumberOfApplesEaten = 0;
        private Boolean flag = false;        
        private Boolean tickFlag = false;
        private string patternChosen = "";
        private readonly SnakeGame Game;

        // Constructor.
        public MainForm(int NumberOfApples, string pattern)
        {
            InitializeComponent();
            Game = new SnakeGame(new System.Drawing.Point((Field.Width - 20) / 2, Field.Height / 2), 40, NumberOfApples, Field.Size);
            Field.Image = new Bitmap(Field.Width, Field.Height);
            patternChosen = pattern;
            Game.EatAndGrow += Game_EatAndGrow;
            Game.HitWallAndLose += Game_HitWallAndLose;
            Game.HitSnakeAndLose += Game_HitSnakeAndLose;            
        }

        // Design and set the objects.
        private void Field_Paint(object sender, PaintEventArgs e)
        {
            // Initializing the design for the objects of the game.
            Pen PenForObstacles = new Pen(Color.FromArgb(40,40,40),2);
            Pen PenForSnake = new Pen(Color.FromArgb(100, 100, 100), 2);
            Brush BackGroundBrush = new SolidBrush(Color.FromArgb(150, 250, 150));
            //Brush AppleBrush = new SolidBrush(Color.FromArgb(250, 50, 50));
            
            Brush AppleBrush = null;
            if (flag)
            {
                AppleBrush = new SolidBrush(Color.FromArgb(150, 250, 150));
                flag = false;
            }
            else
            {
                AppleBrush = new SolidBrush(Color.FromArgb(250, 50, 50));
                flag = true;
            }

            // Setting the graphics.
            using (Graphics g = Graphics.FromImage(Field.Image))
            {
                // Drawing the field.
                g.FillRectangle(BackGroundBrush,new Rectangle(0,0,Field.Width,Field.Height));

                // Drawing each apple.
                foreach (Point Apple in Game.Apples)
                    g.FillEllipse(AppleBrush, new Rectangle(Apple.X - SnakeGame.AppleSize / 2, Apple.Y - SnakeGame.AppleSize / 2,
                        SnakeGame.AppleSize, SnakeGame.AppleSize));

                // Drawing each obstacles.
                foreach (LineSeg Obstacle in Game.Obstacles)
                    g.DrawLine(PenForObstacles, new System.Drawing.Point(Obstacle.Start.X, Obstacle.Start.Y)
                        , new System.Drawing.Point(Obstacle.End.X, Obstacle.End.Y));

                // Drawing point of the snake until a line.
                foreach (LineSeg Body in Game.SnakeBody)
                    g.DrawLine(PenForSnake, new System.Drawing.Point((int)Body.Start.X, (int)Body.Start.Y)
                        , new System.Drawing.Point((int)Body.End.X, (int)Body.End.Y));
            }
        }

        /*
         * Sets the direction based on the key pressed (Up, Down, Left, Right).
         * Pass the direction to the Game Class to move the snake on that direction.
         */
        private void Snakes_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    Game.Move(Step, Direction.UP);
                    break;
                case Keys.Down:
                    Game.Move(Step, Direction.DOWN);
                    break;
                case Keys.Left:
                    Game.Move(Step, Direction.LEFT);
                    break;
                case Keys.Right:
                    Game.Move(Step, Direction.RIGHT);
                    break;
            }
        }

        // Aurelio Code Here - BEGIN  

        // Clicking anywhere on the game field pause/resume the game.
        private void Field_Click(object sender, EventArgs e)
        {
            if (tickFlag)
            {
                mainTimer.Start();
                tickFlag = false;
            }
            else
            {
                mainTimer.Stop();
                tickFlag = true;
            }
        }

        // Event when you pressed the X button.
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainTimer.Stop();
            this.Close();
        }
        // Aurelio Code Here - END

        // William Your Code.
        // William Your Code.

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            Game.Move(Step);
            
            Field.Invalidate();
        }

        private void Game_HitWallAndLose()
        {
            mainTimer.Stop();
            SoundPlayer soundPlayer = new SoundPlayer(@"Resources\kill.wav");
            soundPlayer.Load();
            soundPlayer.Play();
            Field.Refresh();

            // When the game is lost, show a message declaring the number of eaten apples.
            MessageBox.Show("You Died\nThe number of apple(s) eaten were: " + NumberOfApplesEaten.ToString());
            this.Close();
        }
        private void Game_HitSnakeAndLose()
        {
            mainTimer.Stop();
            SoundPlayer soundPlayer = new SoundPlayer(@"Resources\hitsnakeandlose.wav");
            soundPlayer.Load();
            soundPlayer.Play();
            Field.Refresh();

            // When the game is lost, show a message declaring the number of eaten apples.
            MessageBox.Show("You Died\nThe number of apple(s) eaten were: " + NumberOfApplesEaten.ToString());
            this.Close();
        }
                
        private void Game_EatAndGrow()
        {
            // Counter for the number of apple eaten.
            NumberOfApplesEaten++;

            // After every 10 eaten apples, the speed of snake should increase.
            // The maximum speed of snake must by 10.
            if (NumberOfApplesEaten % 10 == 0 && NumberOfApplesEaten <= 100)
            {
                Console.WriteLine(Step.ToString());
                Step++;
            }
        }
    }
}
