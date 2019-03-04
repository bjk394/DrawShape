namespace WindowsFormsApplication1
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
            this.Paintpanel = new System.Windows.Forms.Panel();
            this.OvalButton = new System.Windows.Forms.Button();
            this.RectButton = new System.Windows.Forms.Button();
            this.LineButton = new System.Windows.Forms.Button();
            this.RedBar = new System.Windows.Forms.TrackBar();
            this.BlueBar = new System.Windows.Forms.TrackBar();
            this.GreenBar = new System.Windows.Forms.TrackBar();
            this.cpanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.RedBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenBar)).BeginInit();
            this.SuspendLayout();
            // 
            // Paintpanel
            // 
            this.Paintpanel.BackColor = System.Drawing.Color.White;
            this.Paintpanel.Location = new System.Drawing.Point(-1, 53);
            this.Paintpanel.Name = "Paintpanel";
            this.Paintpanel.Size = new System.Drawing.Size(753, 348);
            this.Paintpanel.TabIndex = 0;
            this.Paintpanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Paintpanel_MouseDown);
            this.Paintpanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Paintpanel_MouseMove);
            this.Paintpanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Paintpanel_MouseUp);
            // 
            // OvalButton
            // 
            this.OvalButton.Location = new System.Drawing.Point(12, 2);
            this.OvalButton.Name = "OvalButton";
            this.OvalButton.Size = new System.Drawing.Size(75, 45);
            this.OvalButton.TabIndex = 1;
            this.OvalButton.Text = "Oval";
            this.OvalButton.UseVisualStyleBackColor = true;
            this.OvalButton.Click += new System.EventHandler(this.OvalButton_Click);
            // 
            // RectButton
            // 
            this.RectButton.Location = new System.Drawing.Point(93, 2);
            this.RectButton.Name = "RectButton";
            this.RectButton.Size = new System.Drawing.Size(75, 45);
            this.RectButton.TabIndex = 2;
            this.RectButton.Text = "Rectangle";
            this.RectButton.UseVisualStyleBackColor = true;
            this.RectButton.Click += new System.EventHandler(this.RectButton_Click);
            // 
            // LineButton
            // 
            this.LineButton.Location = new System.Drawing.Point(174, 2);
            this.LineButton.Name = "LineButton";
            this.LineButton.Size = new System.Drawing.Size(75, 45);
            this.LineButton.TabIndex = 3;
            this.LineButton.Text = "Line";
            this.LineButton.UseVisualStyleBackColor = true;
            this.LineButton.Click += new System.EventHandler(this.LineButton_Click);
            // 
            // RedBar
            // 
            this.RedBar.BackColor = System.Drawing.Color.Red;
            this.RedBar.Location = new System.Drawing.Point(329, 2);
            this.RedBar.Maximum = 255;
            this.RedBar.Name = "RedBar";
            this.RedBar.Size = new System.Drawing.Size(110, 45);
            this.RedBar.TabIndex = 4;
            this.RedBar.TickFrequency = 20;
            this.RedBar.Scroll += new System.EventHandler(this.RedBar_Scroll);
            // 
            // BlueBar
            // 
            this.BlueBar.BackColor = System.Drawing.Color.Blue;
            this.BlueBar.Location = new System.Drawing.Point(555, 2);
            this.BlueBar.Maximum = 255;
            this.BlueBar.Name = "BlueBar";
            this.BlueBar.Size = new System.Drawing.Size(104, 45);
            this.BlueBar.TabIndex = 5;
            this.BlueBar.TickFrequency = 20;
            this.BlueBar.Scroll += new System.EventHandler(this.BlueBar_Scroll);
            // 
            // GreenBar
            // 
            this.GreenBar.BackColor = System.Drawing.Color.Lime;
            this.GreenBar.Location = new System.Drawing.Point(445, 2);
            this.GreenBar.Maximum = 255;
            this.GreenBar.Name = "GreenBar";
            this.GreenBar.Size = new System.Drawing.Size(104, 45);
            this.GreenBar.TabIndex = 6;
            this.GreenBar.TickFrequency = 20;
            this.GreenBar.Scroll += new System.EventHandler(this.GreenBar_Scroll);
            // 
            // cpanel
            // 
            this.cpanel.Location = new System.Drawing.Point(665, 2);
            this.cpanel.Name = "cpanel";
            this.cpanel.Size = new System.Drawing.Size(87, 45);
            this.cpanel.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 399);
            this.Controls.Add(this.cpanel);
            this.Controls.Add(this.GreenBar);
            this.Controls.Add(this.BlueBar);
            this.Controls.Add(this.RedBar);
            this.Controls.Add(this.LineButton);
            this.Controls.Add(this.RectButton);
            this.Controls.Add(this.OvalButton);
            this.Controls.Add(this.Paintpanel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.RedBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Paintpanel;
        private System.Windows.Forms.Button OvalButton;
        private System.Windows.Forms.Button RectButton;
        private System.Windows.Forms.Button LineButton;
        private System.Windows.Forms.TrackBar RedBar;
        private System.Windows.Forms.TrackBar BlueBar;
        private System.Windows.Forms.TrackBar GreenBar;
        private System.Windows.Forms.Panel cpanel;
    }
}

