namespace Skill_Delay_Visualizer
{
    partial class config
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.keySetupBT = new System.Windows.Forms.Button();
            this.keyLabel = new System.Windows.Forms.Label();
            this.timeInput = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.saveBT = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.KeyPooling = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.timeInput)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(28, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(216, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ver 0.1.0";
            // 
            // keySetupBT
            // 
            this.keySetupBT.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.keySetupBT.Location = new System.Drawing.Point(179, 29);
            this.keySetupBT.Name = "keySetupBT";
            this.keySetupBT.Size = new System.Drawing.Size(100, 30);
            this.keySetupBT.TabIndex = 3;
            this.keySetupBT.Text = "Set";
            this.keySetupBT.UseVisualStyleBackColor = true;
            this.keySetupBT.Click += new System.EventHandler(this.keySetupBT_Click);
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.Location = new System.Drawing.Point(129, 36);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(28, 15);
            this.keyLabel.TabIndex = 4;
            this.keyLabel.Text = "128";
            // 
            // timeInput
            // 
            this.timeInput.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeInput.Location = new System.Drawing.Point(122, 71);
            this.timeInput.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.timeInput.Name = "timeInput";
            this.timeInput.Size = new System.Drawing.Size(106, 29);
            this.timeInput.TabIndex = 5;
            this.timeInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.timeInput.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.timeInput.ValueChanged += new System.EventHandler(this.time_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "1/100s";
            // 
            // saveBT
            // 
            this.saveBT.Location = new System.Drawing.Point(28, 166);
            this.saveBT.Name = "saveBT";
            this.saveBT.Size = new System.Drawing.Size(75, 23);
            this.saveBT.TabIndex = 7;
            this.saveBT.Text = "Save";
            this.saveBT.UseVisualStyleBackColor = true;
            this.saveBT.Click += new System.EventHandler(this.saveBT_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.timeLabel.Location = new System.Drawing.Point(170, 103);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(43, 15);
            this.timeLabel.TabIndex = 8;
            this.timeLabel.Text = "39.39s";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // KeyPooling
            // 
            this.KeyPooling.Interval = 10;
            this.KeyPooling.Tick += new System.EventHandler(this.KeyPoolingTick);
            // 
            // config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 201);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.saveBT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.timeInput);
            this.Controls.Add(this.keyLabel);
            this.Controls.Add(this.keySetupBT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "config";
            this.Text = "config";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.config_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.timeInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button keySetupBT;
        private Label keyLabel;
        private NumericUpDown timeInput;
        private Label label5;
        private Button saveBT;
        private Label timeLabel;
        private System.Windows.Forms.Timer KeyPooling;
    }
}