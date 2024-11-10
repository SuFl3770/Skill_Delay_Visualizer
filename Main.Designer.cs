namespace Skill_Delay_Visualizer
{
    partial class Skill_Timer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.keyPollingTime = new System.Windows.Forms.Timer(this.components);
            this.configBT = new System.Windows.Forms.Button();
            this.progressBarTimer = new System.Windows.Forms.Timer(this.components);
            this.stateBar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.stateBar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // timeLabel
            // 
            this.timeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.timeLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.timeLabel.Location = new System.Drawing.Point(0, 14);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(84, 21);
            this.timeLabel.TabIndex = 1;
            this.timeLabel.Text = "Ready";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.timeLabel.Click += new System.EventHandler(this.keyLabel_Click);
            // 
            // keyPollingTime
            // 
            this.keyPollingTime.Enabled = true;
            this.keyPollingTime.Interval = 1;
            this.keyPollingTime.Tick += new System.EventHandler(this.keyPollingTime_Tick);
            // 
            // configBT
            // 
            this.configBT.Location = new System.Drawing.Point(375, 14);
            this.configBT.Name = "configBT";
            this.configBT.Size = new System.Drawing.Size(75, 23);
            this.configBT.TabIndex = 3;
            this.configBT.Text = "Config";
            this.configBT.UseVisualStyleBackColor = true;
            this.configBT.Click += new System.EventHandler(this.configBT_Click);
            // 
            // progressBarTimer
            // 
            this.progressBarTimer.Interval = 1;
            this.progressBarTimer.Tick += new System.EventHandler(this.progressBarTick);
            // 
            // stateBar
            // 
            this.stateBar.Image = global::Skill_Delay_Visualizer.Properties.Resources.green;
            this.stateBar.Location = new System.Drawing.Point(106, 14);
            this.stateBar.Name = "stateBar";
            this.stateBar.Size = new System.Drawing.Size(251, 23);
            this.stateBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.stateBar.TabIndex = 4;
            this.stateBar.TabStop = false;
            // 
            // Skill_Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 49);
            this.Controls.Add(this.stateBar);
            this.Controls.Add(this.configBT);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Skill_Timer";
            this.ShowIcon = false;
            this.Text = "Skill_Timer";
            ((System.ComponentModel.ISupportInitialize)(this.stateBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label timeLabel;
        private System.Windows.Forms.Timer keyPollingTime;
        private Button configBT;
        private System.Windows.Forms.Timer progressBarTimer;
        private PictureBox stateBar;
    }
}