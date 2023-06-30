using BuildSoft.VRChat.Osc;

namespace WatchController
{
    public partial class Form1 : Form
    {
        private DateTime lastBeepSent = new DateTime();


        private TimeZoneInfo[] tz;

        public Form1()
        {
            InitializeComponent();

            tz = TimeZoneInfo.GetSystemTimeZones().ToArray();
            timezoneDropdown.Items.AddRange(tz);

            watchType.SelectedIndex = (int)Properties.Settings.Default["WatchType"];
            timezoneDropdown.SelectedIndex = (int)Properties.Settings.Default["Timezone"];
            hourlyBeepCheckbox.Checked = (bool)Properties.Settings.Default["HourlyBeep"];

            textBox1.Text = $"{(int)Properties.Settings.Default["SendPort"]}";
            OscConnectionSettings.SendPort = (int)Properties.Settings.Default["SendPort"];
            textBox2.Text = $"{(int)Properties.Settings.Default["ReceivePort"]}";
            OscConnectionSettings.ReceivePort = (int)Properties.Settings.Default["ReceivePort"];
        }

        private void secondTimer_Tick(object sender, EventArgs e)
        {
            DateTime dtNow = DateTime.Now;

            DateTime dtNowTZ = DateTime.Now;
            if (timezoneDropdown.SelectedIndex > 0)
                dtNowTZ = TimeZoneInfo.ConvertTime(DateTime.Now, tz[timezoneDropdown.SelectedIndex - 1]);

            if (hourlyBeepCheckbox.Checked)
            {
                if (dtNow.Minute == 0 && dtNow.Second == 0)
                {
                    SendBeep();
                    secondBeepTimer.Enabled = true;
                }
            }

            float eightBitMultiplier = 0.00787401574803149606299212598425f;

            float realTimeHour;
            float realTimeHourTZ;
            float realTimeMin;

            if (watchType.SelectedIndex == 0)
            {
                realTimeHour = dtNow.Hour * eightBitMultiplier;
                realTimeHourTZ = dtNowTZ.Hour * eightBitMultiplier;
                realTimeMin = dtNow.Minute * eightBitMultiplier;
            }
            else
            {
                realTimeHour = (float)(dtNow.TimeOfDay.Ticks / TimeSpan.TicksPerMillisecond) / (24 * 60 * 60 * 1000);
                realTimeHourTZ = (float)(dtNowTZ.TimeOfDay.Ticks / TimeSpan.TicksPerMillisecond) / (24 * 60 * 60 * 1000);
                realTimeMin = (dtNow.Minute * 60f + dtNow.Second + dtNow.Millisecond / 1000f) / 3600f;
            }

            // Update UI
            this.CurrentTimeLabel.Text = $"Current Time - {dtNow.Hour:00}:{dtNow.Minute:00}";
            this.realTimeHour.Text = $"RealTimeHour - {realTimeHour:0.00000000} TZ - {realTimeHourTZ:0.00000000}";
            this.realTimeMin.Text = $"RealTimeMin - {realTimeMin:0.00000000}";


            // Send data to OSC
            OscParameter.SendAvatarParameter("RealTimeHour", realTimeHour);
            OscParameter.SendAvatarParameter("RealTimeHourTZ", realTimeHourTZ);
            OscParameter.SendAvatarParameter("RealTimeMin", realTimeMin);
        }

        private void secondBeepTimer_Tick(object sender, EventArgs e)
        {
            secondBeepTimer.Enabled = false;
            SendBeep();
        }

        private void TestBeepButton_Click(object sender, EventArgs e)
        {
            SendBeep();
        }

        private void SendBeep()
        {
            OscParameter.SendAvatarParameter("WatchBeep", true);
            lastBeepSent = DateTime.Now;
            LastBeepLabel.Text = lastBeepSent.ToString();
        }

        private void hourlyBeepCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default["HourlyBeep"] = hourlyBeepCheckbox.Checked;
            Properties.Settings.Default.Save();
        }

        private void timezoneDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default["Timezone"] = timezoneDropdown.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        private void watchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default["WatchType"] = watchType.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int value))
            {
                Properties.Settings.Default["SendPort"] = value;
                Properties.Settings.Default.Save();

                OscConnectionSettings.SendPort = value;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out int value))
            {
                Properties.Settings.Default["ReceivePort"] = value;
                Properties.Settings.Default.Save();
                OscConnectionSettings.ReceivePort = value;
            }
        }
    }
}