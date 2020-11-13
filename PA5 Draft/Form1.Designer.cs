namespace PA5_Draft
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Field = new System.Windows.Forms.PictureBox();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.progressBarStepValue = new System.Windows.Forms.ProgressBar();
            this.labelStepValue = new System.Windows.Forms.Label();
            this.textBoxStepValue = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.Field)).BeginInit();
            this.SuspendLayout();
            // 
            // Field
            // 
            this.Field.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Field.Location = new System.Drawing.Point(0, 24);
            this.Field.Name = "Field";
            this.Field.Size = new System.Drawing.Size(604, 557);
            this.Field.TabIndex = 0;
            this.Field.TabStop = false;
            this.Field.Click += new System.EventHandler(this.Field_Click);
            this.Field.Paint += new System.Windows.Forms.PaintEventHandler(this.Field_Paint);
            // 
            // mainTimer
            // 
            this.mainTimer.Enabled = true;
            this.mainTimer.Interval = 12;
            this.mainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // progressBarStepValue
            // 
            this.progressBarStepValue.Location = new System.Drawing.Point(300, -2);
            this.progressBarStepValue.Name = "progressBarStepValue";
            this.progressBarStepValue.Size = new System.Drawing.Size(292, 23);
            this.progressBarStepValue.TabIndex = 2;
            // 
            // labelStepValue
            // 
            this.labelStepValue.AutoSize = true;
            this.labelStepValue.Location = new System.Drawing.Point(12, 8);
            this.labelStepValue.Name = "labelStepValue";
            this.labelStepValue.Size = new System.Drawing.Size(144, 13);
            this.labelStepValue.TabIndex = 3;
            this.labelStepValue.Text = "The current value of Step is :";
            // 
            // textBoxStepValue
            // 
            this.textBoxStepValue.Enabled = false;
            this.textBoxStepValue.Location = new System.Drawing.Point(162, 1);
            this.textBoxStepValue.Name = "textBoxStepValue";
            this.textBoxStepValue.Size = new System.Drawing.Size(100, 20);
            this.textBoxStepValue.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(604, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 581);
            this.Controls.Add(this.textBoxStepValue);
            this.Controls.Add(this.labelStepValue);
            this.Controls.Add(this.progressBarStepValue);
            this.Controls.Add(this.Field);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(620, 620);
            this.MinimumSize = new System.Drawing.Size(620, 620);
            this.Name = "MainForm";
            this.Text = "Snakes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Snakes_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Field)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Field;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.ProgressBar progressBarStepValue;
        private System.Windows.Forms.Label labelStepValue;
        private System.Windows.Forms.TextBox textBoxStepValue;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

