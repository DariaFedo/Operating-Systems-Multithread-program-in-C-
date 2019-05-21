namespace SystemyOperacyjneProjekt
{
    partial class Form1
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
            this.trainBox = new System.Windows.Forms.PictureBox();
            this.blueCarBox = new System.Windows.Forms.PictureBox();
            this.blackCarBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trainBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueCarBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackCarBox)).BeginInit();
            this.SuspendLayout();
            // 
            // trainBox
            // 
            this.trainBox.BackColor = System.Drawing.Color.Transparent;
            this.trainBox.BackgroundImage = global::SystemyOperacyjneProjekt.Properties.Resources.train;
            this.trainBox.Location = new System.Drawing.Point(0, 313);
            this.trainBox.Name = "trainBox";
            this.trainBox.Size = new System.Drawing.Size(100, 50);
            this.trainBox.TabIndex = 0;
            this.trainBox.TabStop = false;
            // 
            // blueCarBox
            // 
            this.blueCarBox.BackColor = System.Drawing.Color.Transparent;
            this.blueCarBox.BackgroundImage = global::SystemyOperacyjneProjekt.Properties.Resources.output_onlinepngtools;
            this.blueCarBox.Location = new System.Drawing.Point(89, 193);
            this.blueCarBox.Name = "blueCarBox";
            this.blueCarBox.Size = new System.Drawing.Size(75, 35);
            this.blueCarBox.TabIndex = 1;
            this.blueCarBox.TabStop = false;
            // 
            // blackCarBox
            // 
            this.blackCarBox.BackColor = System.Drawing.Color.Transparent;
            this.blackCarBox.BackgroundImage = global::SystemyOperacyjneProjekt.Properties.Resources.blackCar;
            this.blackCarBox.Location = new System.Drawing.Point(882, 648);
            this.blackCarBox.Name = "blackCarBox";
            this.blackCarBox.Size = new System.Drawing.Size(75, 35);
            this.blackCarBox.TabIndex = 2;
            this.blackCarBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SystemyOperacyjneProjekt.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1008, 728);
            this.Controls.Add(this.blackCarBox);
            this.Controls.Add(this.blueCarBox);
            this.Controls.Add(this.trainBox);
            this.Name = "Form1";
            this.Text = "DFproject";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trainBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueCarBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackCarBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox trainBox;
        private System.Windows.Forms.PictureBox blueCarBox;
        private System.Windows.Forms.PictureBox blackCarBox;
    }
}

