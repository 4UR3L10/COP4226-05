namespace PA5_Draft
{
    partial class FormGameSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGameSettings));
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelNumberApples = new System.Windows.Forms.Label();
            this.labelSelectPattern = new System.Windows.Forms.Label();
            this.pictureBoxSelectPattern = new System.Windows.Forms.PictureBox();
            this.comboBoxSelectPattern = new System.Windows.Forms.ComboBox();
            this.textBoxNumberApples = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectPattern)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(17, 263);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 3;
            this.buttonOk.Text = "&Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(152, 263);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelNumberApples
            // 
            this.labelNumberApples.AutoSize = true;
            this.labelNumberApples.Location = new System.Drawing.Point(14, 18);
            this.labelNumberApples.Name = "labelNumberApples";
            this.labelNumberApples.Size = new System.Drawing.Size(94, 13);
            this.labelNumberApples.TabIndex = 2;
            this.labelNumberApples.Text = "Number of Apples:";
            // 
            // labelSelectPattern
            // 
            this.labelSelectPattern.AutoSize = true;
            this.labelSelectPattern.Location = new System.Drawing.Point(14, 49);
            this.labelSelectPattern.Name = "labelSelectPattern";
            this.labelSelectPattern.Size = new System.Drawing.Size(86, 13);
            this.labelSelectPattern.TabIndex = 3;
            this.labelSelectPattern.Text = "Select a Pattern:";
            // 
            // pictureBoxSelectPattern
            // 
            this.pictureBoxSelectPattern.ErrorImage = null;
            this.pictureBoxSelectPattern.Image = global::PA5_Draft.Properties.Resources.Default;
            this.pictureBoxSelectPattern.Location = new System.Drawing.Point(17, 73);
            this.pictureBoxSelectPattern.Name = "pictureBoxSelectPattern";
            this.pictureBoxSelectPattern.Size = new System.Drawing.Size(210, 173);
            this.pictureBoxSelectPattern.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSelectPattern.TabIndex = 4;
            this.pictureBoxSelectPattern.TabStop = false;
            // 
            // comboBoxSelectPattern
            // 
            this.comboBoxSelectPattern.FormattingEnabled = true;
            this.comboBoxSelectPattern.Items.AddRange(new object[] {
            "Default",
            "Pattern 01",
            "Pattern 02",
            "Pattern 03",
            "Pattern 04",
            "Pattern 05",
            "Pattern 06",
            "Pattern 07",
            "Pattern 08",
            "Pattern 09"});
            this.comboBoxSelectPattern.Location = new System.Drawing.Point(106, 46);
            this.comboBoxSelectPattern.Name = "comboBoxSelectPattern";
            this.comboBoxSelectPattern.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSelectPattern.TabIndex = 2;
            this.comboBoxSelectPattern.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectPattern_SelectedIndexChanged);
            // 
            // textBoxNumberApples
            // 
            this.textBoxNumberApples.Location = new System.Drawing.Point(106, 15);
            this.textBoxNumberApples.Name = "textBoxNumberApples";
            this.textBoxNumberApples.Size = new System.Drawing.Size(121, 20);
            this.textBoxNumberApples.TabIndex = 1;
            // 
            // FormGameSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 292);
            this.Controls.Add(this.textBoxNumberApples);
            this.Controls.Add(this.comboBoxSelectPattern);
            this.Controls.Add(this.pictureBoxSelectPattern);
            this.Controls.Add(this.labelSelectPattern);
            this.Controls.Add(this.labelNumberApples);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGameSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Settings";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectPattern)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelNumberApples;
        private System.Windows.Forms.Label labelSelectPattern;
        private System.Windows.Forms.PictureBox pictureBoxSelectPattern;
        private System.Windows.Forms.ComboBox comboBoxSelectPattern;
        private System.Windows.Forms.TextBox textBoxNumberApples;
    }
}


