using System.Media;

namespace Skill_Delay_Visualizer
{
    public partial class Skill_Timer : Form
    {
        config cf = new config();
        KeyHook kh = new KeyHook();
        SoundPlayer sp;
        JsonHandler json = JsonHandler.Instance();
        decimal time, startTime;

        public Skill_Timer()
        {
            kh.SetHook();
            json.LoadData();
            if (json.ReturnSoundPath() == "none")
            {
                MessageBox.Show("효과음이 없습니다. 효과음을 넣고 다시 시도해주세요.\n파일 이름은 sound.wav입니다.", ":(", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            sp = new SoundPlayer(json.ReturnSoundPath());
            json.LoadData();
            InitializeComponent();
            
        }

        private void keyPollingTime_Tick(object sender, EventArgs e)
        {
            if (KeyHook.nowKeyCode == json.key)
            {
                keyPollingTime.Stop();
                stateBar.Image = Properties.Resources.red;
                configBT.Enabled = false;
                startTime = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
                time = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() + json.time * 10;
                progressBarTimer.Start();
            }
            KeyHook.nowKeyCode = 0;
        }
        private void progressBarTick(object sender, EventArgs e)
        {
            decimal timeDiff = time - DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            timeLabel.Text = (timeDiff / 1000).ToString("f2") + "s";
 //         this.Text = ((DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() - startTime) / (time - startTime) * 100).ToString();
 //         timeBar.Value = Decimal.ToInt32((DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() - startTime) / (time - startTime) * 100);
            if (DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() >= time)
            {
                sp.Play();
                stateBar.Image = Properties.Resources.green;
                timeLabel.Text = "Ready";
                progressBarTimer.Stop();
                KeyHook.nowKeyCode = 0;
                keyPollingTime.Start();
                configBT.Enabled = true;
            }
        }

        private void keyLabel_Click(object sender, EventArgs e)
        {
            sp.Play();
        }

        private void configBT_Click(object sender, EventArgs e)
        {
            keyPollingTime.Stop();
            progressBarTimer.Stop();
            cf.ShowDialog();
            json.LoadData();
            keyPollingTime.Start();
        }
    }
}
