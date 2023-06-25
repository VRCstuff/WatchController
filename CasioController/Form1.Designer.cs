namespace CasioController
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            secondTimer = new System.Windows.Forms.Timer(components);
            secondBeepTimer = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            CurrentTimeLabel = new Label();
            TestBeepButton = new Button();
            label2 = new Label();
            LastBeepLabel = new Label();
            hourlyBeepCheckbox = new CheckBox();
            watchType = new ComboBox();
            label3 = new Label();
            timezoneDropdown = new ComboBox();
            realTimeHour = new Label();
            realTimeMin = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // secondTimer
            // 
            secondTimer.Enabled = true;
            secondTimer.Tick += secondTimer_Tick;
            // 
            // secondBeepTimer
            // 
            secondBeepTimer.Interval = 200;
            secondBeepTimer.Tick += secondBeepTimer_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 54);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 1;
            label1.Text = "Real Time Sender";
            // 
            // CurrentTimeLabel
            // 
            CurrentTimeLabel.AutoSize = true;
            CurrentTimeLabel.ForeColor = Color.White;
            CurrentTimeLabel.Location = new Point(12, 98);
            CurrentTimeLabel.Name = "CurrentTimeLabel";
            CurrentTimeLabel.Size = new Size(79, 15);
            CurrentTimeLabel.TabIndex = 2;
            CurrentTimeLabel.Text = "Current Time:";
            // 
            // TestBeepButton
            // 
            TestBeepButton.Location = new Point(249, 87);
            TestBeepButton.Name = "TestBeepButton";
            TestBeepButton.Size = new Size(216, 23);
            TestBeepButton.TabIndex = 4;
            TestBeepButton.Text = "Test Beep";
            TestBeepButton.UseVisualStyleBackColor = true;
            TestBeepButton.Click += TestBeepButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(247, 54);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 5;
            label2.Text = "Watch Beep Stuff";
            // 
            // LastBeepLabel
            // 
            LastBeepLabel.AutoSize = true;
            LastBeepLabel.ForeColor = Color.White;
            LastBeepLabel.Location = new Point(249, 69);
            LastBeepLabel.Name = "LastBeepLabel";
            LastBeepLabel.Size = new Size(123, 15);
            LastBeepLabel.TabIndex = 6;
            LastBeepLabel.Text = "Last Beep Time: Never";
            // 
            // hourlyBeepCheckbox
            // 
            hourlyBeepCheckbox.AutoSize = true;
            hourlyBeepCheckbox.ForeColor = Color.White;
            hourlyBeepCheckbox.Location = new Point(249, 116);
            hourlyBeepCheckbox.Name = "hourlyBeepCheckbox";
            hourlyBeepCheckbox.Size = new Size(91, 19);
            hourlyBeepCheckbox.TabIndex = 8;
            hourlyBeepCheckbox.Text = "Hourly Beep";
            hourlyBeepCheckbox.UseVisualStyleBackColor = true;
            hourlyBeepCheckbox.CheckedChanged += hourlyBeepCheckbox_CheckedChanged;
            // 
            // watchType
            // 
            watchType.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            watchType.DropDownStyle = ComboBoxStyle.DropDownList;
            watchType.FormattingEnabled = true;
            watchType.Items.AddRange(new object[] { "Digital", "Analogue" });
            watchType.Location = new Point(12, 27);
            watchType.Name = "watchType";
            watchType.Size = new Size(453, 23);
            watchType.TabIndex = 9;
            watchType.SelectedIndexChanged += watchType_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 10;
            label3.Text = "Watch Type";
            // 
            // timezoneDropdown
            // 
            timezoneDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            timezoneDropdown.FormattingEnabled = true;
            timezoneDropdown.Items.AddRange(new object[] { "Local Timezone" });
            timezoneDropdown.Location = new Point(12, 72);
            timezoneDropdown.Name = "timezoneDropdown";
            timezoneDropdown.Size = new Size(219, 23);
            timezoneDropdown.TabIndex = 12;
            timezoneDropdown.SelectedIndexChanged += timezoneDropdown_SelectedIndexChanged;
            // 
            // realTimeHour
            // 
            realTimeHour.AutoSize = true;
            realTimeHour.ForeColor = Color.White;
            realTimeHour.Location = new Point(12, 117);
            realTimeHour.Name = "realTimeHour";
            realTimeHour.Size = new Size(88, 15);
            realTimeHour.TabIndex = 13;
            realTimeHour.Text = "RealTimeHour: ";
            // 
            // realTimeMin
            // 
            realTimeMin.AutoSize = true;
            realTimeMin.ForeColor = Color.White;
            realTimeMin.Location = new Point(12, 136);
            realTimeMin.Name = "realTimeMin";
            realTimeMin.Size = new Size(82, 15);
            realTimeMin.TabIndex = 14;
            realTimeMin.Text = "RealTimeMin: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(76, 195);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(50, 23);
            textBox1.TabIndex = 15;
            textBox1.Text = "9000";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(212, 195);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(50, 23);
            textBox2.TabIndex = 16;
            textBox2.Text = "9001";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 177);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 17;
            label4.Text = "OSC Settings";
            // 
            // label5
            // 
            label5.ForeColor = Color.White;
            label5.Location = new Point(12, 195);
            label5.Name = "label5";
            label5.Size = new Size(58, 23);
            label5.TabIndex = 18;
            label5.Text = "Send Port";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.ForeColor = Color.White;
            label6.Location = new Point(132, 195);
            label6.Name = "label6";
            label6.Size = new Size(74, 23);
            label6.TabIndex = 19;
            label6.Text = "Receive Port";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(477, 230);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(realTimeMin);
            Controls.Add(realTimeHour);
            Controls.Add(timezoneDropdown);
            Controls.Add(label3);
            Controls.Add(watchType);
            Controls.Add(hourlyBeepCheckbox);
            Controls.Add(LastBeepLabel);
            Controls.Add(label2);
            Controls.Add(TestBeepButton);
            Controls.Add(CurrentTimeLabel);
            Controls.Add(label1);
            Name = "Form1";
            Text = "CasioController";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer secondTimer;
        private System.Windows.Forms.Timer secondBeepTimer;
        private Label label1;
        private Label CurrentTimeLabel;
        private Button TestBeepButton;
        private Label label2;
        private Label LastBeepLabel;
        private CheckBox hourlyBeepCheckbox;
        private ComboBox watchType;
        private Label label3;
        private ComboBox timezoneDropdown;
        private Label realTimeHour;
        private Label realTimeMin;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}