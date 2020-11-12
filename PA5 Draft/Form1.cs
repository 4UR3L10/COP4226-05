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
        static int Step = 1;
        private readonly SnakeGame Game;
        private int NumberOfApples = 1;
        private Boolean flag = false;
        private int NumberOfApplesEaten = 0;
        private Boolean tickFlag = false;
        private Boolean cancelFlag = false;
        private Boolean validationCustom = false;
        private TextBox textBoxRows = new TextBox();
        int number1 = Step;

        // Constructor.
        public MainForm()
        {
            ShowMyDialogBox();
            InitializeComponent(); 
            Game = new SnakeGame(new System.Drawing.Point((Field.Width - 20) / 2, Field.Height / 2), 40, NumberOfApples, Field.Size);
            Field.Image = new Bitmap(Field.Width, Field.Height);
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

        // User sets apples to any positive integer.
        public void ShowMyDialogBox()
        {
            // Object Model.
            Size sizeObj = new Size(195, 178);

            // Label Rows.
            Label labelRows = new Label();
            labelRows.Size = new Size(37, 13);
            labelRows.Location = new System.Drawing.Point(12, 28);
            labelRows.Name = "labelRows";
            labelRows.Text = "Apples:";
            labelRows.AutoSize = true;

            // Textbox Rows.                
            textBoxRows.Size = new Size(100, 20);
            textBoxRows.Location = new System.Drawing.Point(68, 25);
            textBoxRows.Name = "textBoxRows";
            textBoxRows.TabIndex = 1;

            // OK Button.
            Button buttonOk = new Button();
            buttonOk.Size = new Size(75, 23);
            buttonOk.Location = new System.Drawing.Point(12, 142);
            buttonOk.DialogResult = DialogResult.OK;
            buttonOk.Click += ButtonOk_Click;
            buttonOk.Name = "buttonOk";
            buttonOk.Text = "&OK";
            buttonOk.TabIndex = 2;

            // Cancel Button.
            Button buttonCancel = new Button();
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.Location = new System.Drawing.Point(93, 142);
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Click += ButtonCancel_Click;
            buttonCancel.Name = "cancelButton";
            buttonCancel.Text = "&Cancel";
            buttonCancel.TabIndex = 3;

            // Inputbox Form.                
            Form inputBox = new Form();
            inputBox.FormBorderStyle = FormBorderStyle.FixedDialog;
            inputBox.ClientSize = sizeObj;
            inputBox.Text = "Custom";
            inputBox.Controls.Add(textBoxRows);
            inputBox.Controls.Add(buttonOk);
            inputBox.Controls.Add(buttonCancel);
            inputBox.Controls.Add(labelRows);

            inputBox.StartPosition = FormStartPosition.CenterScreen;
            inputBox.FormBorderStyle = FormBorderStyle.None;

            // Validation of the values for the dynamic Custom Form.
            do
            {
                // Resetting the values.
                textBoxRows.Text = "";
                DialogResult result = inputBox.ShowDialog();
            } while (validationCustom == true);

            if (cancelFlag == true)
            {
                cancelFlag = false;
                return;
            }
        }

        // Custom Dynamic Form Cancel Button.
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            // Cancel was pressed.
            cancelFlag = true;

            // Not need for validation.
            validationCustom = false;
        }

        // Custom Dynamic Form Ok Button.
        private void ButtonOk_Click(object sender, EventArgs e)
        {
            try
            {
                // Converting values to numbers.
                NumberOfApples = int.Parse(textBoxRows.Text);

                // Validation of the Apples.
                // Added the 40 restriction due to performance.
                if (NumberOfApples < 0)
                {
                    MessageBox.Show("Apples must be any positive integer.");
                    throw new FormatException();
                }


                // If everything was ok then do no need to show form again.
                validationCustom = false;
            }
            catch (FormatException)
            {
                MessageBox.Show("Validation Error");
                validationCustom = true;
            }
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
            SoundPlayer soundPlayer = new SoundPlayer(@"kill.wav");
            soundPlayer.Load();
            soundPlayer.Play();
            Field.Refresh();

            // When the game is lost, show a message declaring the number of eaten apples.
            MessageBox.Show("You Died\nThe number of apple eaten was: " + NumberOfApplesEaten.ToString());
        }
        private void Game_HitSnakeAndLose()
        {
            mainTimer.Stop();
            SoundPlayer soundPlayer = new SoundPlayer(@"hitsnakeandlose.wav");
            soundPlayer.Load();
            soundPlayer.Play();
            Field.Refresh();

            // When the game is lost, show a message declaring the number of eaten apples.
            MessageBox.Show("You Died\nThe number of apple(s) eaten were: " + NumberOfApplesEaten.ToString());           
        }

        private void Game_EatAndGrow()
        {
            // Counter for the number of apple eaten.
            NumberOfApplesEaten++;

            // After every 10 eaten apples, the speed of snake should increase.
            // The maximum speed of snake must by 10.
            if (NumberOfApplesEaten % 10 == 0 && NumberOfApplesEaten < 100)
            {
                Step++;
            }

            // Set the progress bar minimum, maximum, and current values
            this.progressBarStepValue.Minimum = 1;
            this.progressBarStepValue.Maximum = 10;

            if (Step < 10)
            {
                this.progressBarStepValue.Value = Step;
                
            }
            else
            {
                this.progressBarStepValue.Visible = false;
            }

            // Increment progress bar
            this.progressBarStepValue.Increment(1); // Range protection
            this.Refresh();
            textBoxStepValue.Text = Step.ToString();
        }
    }
}
