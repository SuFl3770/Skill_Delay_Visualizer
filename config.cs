namespace Skill_Delay_Visualizer
{
    public partial class config : Form
    {
        JsonHandler json;
        bool isKeyInput = false;
        public config()
        {
            InitializeComponent();
            json = JsonHandler.Instance();
            json.LoadData();
            dataLoad();
        }

        private void dataLoad()
        {
            keyLabel.Text = json.key.ToString();
            timeInput.Value = json.time;
            timeLabel.Text = ((float)json.time / 100).ToString("f2") + "s";
        }

        private void time_ValueChanged(object sender, EventArgs e)
        {
            json.time = (int)timeInput.Value;
            dataLoad();
        }

        private void keySetupBT_Click(object sender, EventArgs e)
        {
            if(!isKeyInput)
            {
                isKeyInput = true;
                keySetupBT.Text = "Stop";
                timeInput.Enabled = false;
                KeyPooling.Start();
                saveBT.Enabled = false;
            }
            else
            {
                isKeyInput = false;
                keySetupBT.Text = "Set";
                timeInput.Enabled = true;
                KeyPooling.Stop();
                saveBT.Enabled = true;
            }
        }

        private void KeyPoolingTick(object sender, EventArgs e)
        {
            keyLabel.Text = KeyHook.nowKeyCode.ToString();
            json.key = KeyHook.nowKeyCode;
        }

        private void saveBT_Click(object sender, EventArgs e)
        {
            KeyHook.nowKeyCode = 0;
            json.SaveData();
            this.Close();
        }

        private void config_FormClosing(object sender, FormClosingEventArgs e)
        {
            KeyHook.nowKeyCode = 0;
            isKeyInput = false;
            keySetupBT.Text = "Set";
            timeInput.Enabled = true;
            KeyPooling.Stop();
            saveBT.Enabled = true;
        }
    }
}
