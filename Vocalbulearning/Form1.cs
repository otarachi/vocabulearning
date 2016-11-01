using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using System.Linq;

namespace Vocalbulearning
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // 
            // notifyIcon1
            // 
            this.Icon = Properties.Resources.Icon;
            this.notifyIcon1.Icon = Properties.Resources.Icon;

            this.settingsToolStripMenuItem.Click += SettingsToolStripMenuItem_Click;
            this.exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            this.learntToolStripMenuItem.Click += LearntToolStripMenuItem_Click;
            this.neverToolStripMenuItem.Click += NeverToolStripMenuItem_Click;

            this.Hide();
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
        }
        private UtilsHelper utilsHelper = new UtilsHelper();
        private ConfigHelper configHelper = new ConfigHelper();
        
        private AppSetting appSetting = new AppSetting();
        private List<EntityVocal> lstVocal = new List<EntityVocal>();
        private int idx = -1;
        Random rnd = new Random();
        private int totalMemorizedToday = 0;
        private int TryGetVocal = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSetting();
            GetSetting();
            
            try
            {
                string jsonContent = string.Empty;
                using (var file = new StreamReader(appSetting.dict))
                {
                    jsonContent = file.ReadToEnd();
                }

                var jss = new JavaScriptSerializer();
                lstVocal = jss.Deserialize<List<EntityVocal>>(jsonContent);
                if (lstVocal.Count == 0)
                    throw new Exception();

                utilsHelper.Shuffle(ref lstVocal);

                timer1.Interval = appSetting.repeat;
                timer1.Start();                
            }
            catch (Exception)
            {
                timer1.Enabled = false;
                showPopup("Oops, something wrong!", "Can not read the dictionary!");
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.BringToFront();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(300);
                this.Hide();
                this.ShowInTaskbar = false;
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Remember what've you learnt 
            var jss = new JavaScriptSerializer();
            using (var file = new StreamWriter(File.Create(appSetting.dict)))
            {
                file.Write(jss.Serialize(lstVocal));
            }
            //Stop the timer, don't show anything.
            timer1.Stop();
            timer1.Enabled = false;

            //Show your effort
            if (totalMemorizedToday > 0)
                MessageBox.Show("Chúc mừng! Hôm nay bạn đã học " + totalMemorizedToday + " từ.", "Thành quả hôm nay", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Hôm nay bạn không học được từ nào sao?", "Thành quả hôm nay", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            SaveSetting();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("IsMouseEnter." + popupNotifier1.IsMouseEnter.ToString());
            if (popupNotifier1.IsMouseEnter)
                return;
            int iterations = lstVocal.Count;
            int curVocal = -1;
            for (int i = idx + 1; i < iterations; i++)
            {
                var vocalInfo = lstVocal[i];
                if (rnd.Next(100 - vocalInfo.p, 101) == 100)
                {
                    curVocal = i;
                    idx = i;
                    break;
                }
            }

            if (curVocal < 0)
            {
                if (TryGetVocal > 4)
                {
                    DialogResult retVal = MessageBox.Show("", "", MessageBoxButtons.YesNo);
                    if (retVal == DialogResult.Yes)
                    {
                        //Reset dictionary
                        lstVocal = lstVocal.Select(x => new EntityVocal() { m = x.m, p = 0, v = x.v }).ToList();
                    }
                    else
                    {
                        curVocal = rnd.Next(iterations);
                        showPopup(lstVocal[curVocal].v, lstVocal[curVocal].m);
                    }
                }
                else
                {
                    curVocal = rnd.Next(iterations);
                    showPopup(lstVocal[curVocal].v, lstVocal[curVocal].m);
                    TryGetVocal++;
                }
            }
            else
                showPopup(lstVocal[idx].v, lstVocal[idx].m);

            if (idx == (iterations - 1))
                idx = -1;
            learntToolStripMenuItem.Enabled = true;
            neverToolStripMenuItem.Enabled = true;
        }

        private void NotifyIcon1_DoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }
        
        private void OptionsMenu_MouseEnter(object sender, System.EventArgs e)
        {
            popupNotifier1.IsMouseEnter = true;
            System.Diagnostics.Debug.WriteLine("Main IsMouseEnter." + popupNotifier1.IsMouseEnter.ToString());
        }

        private void SettingsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }

        private void ExitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void NeverToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (lstVocal[idx].p >= 100)
                return;

            //Increase your memorized
            lstVocal[idx].p = 100;
            totalMemorizedToday++;
            System.Diagnostics.Debug.WriteLine("NeverToolStripMenuItem_Click." + totalMemorizedToday.ToString());
            neverToolStripMenuItem.Enabled = false;
        }

        private void LearntToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (lstVocal[idx].p >= 100)
                return;

            //Increase your memorized
            lstVocal[idx].p += (100 / appSetting.memorized);
            totalMemorizedToday++;
            System.Diagnostics.Debug.WriteLine("LearntToolStripMenuItem_Click." + totalMemorizedToday.ToString());
            learntToolStripMenuItem.Enabled = false;
        }

        private void txtTitle_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Dictionary Files|*.txt";
            openFileDialog1.Title = "Select a Dictionary File";            
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtTitle.Text = openFileDialog1.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetSetting();
            this.Hide();
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(300);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(300);
        }

        private void showPopup(string title, string content)
        {
            popupNotifier1.TitleText = title;
            popupNotifier1.ContentText = content;

            popupNotifier1.Delay = appSetting.delay;
            popupNotifier1.AnimationInterval = appSetting.aInterval;
            popupNotifier1.AnimationDuration = appSetting.aDuration;

            popupNotifier1.Image = Properties.Resources._157_GetPermission_48x48_72;

            popupNotifier1.Size = new System.Drawing.Size(appSetting.width, appSetting.height);
            this.popupNotifier1.ContentFont = new System.Drawing.Font("Segoe UI", appSetting.fontContent);
            this.popupNotifier1.TitleFont = new System.Drawing.Font("Segoe UI", appSetting.fontTitle, System.Drawing.FontStyle.Bold);

            popupNotifier1.Popup();
        }
        
        private void LoadSetting()
        {
            appSetting.dict = configHelper.getStringAppSetting("dict", "dictVoval.txt");
            if (appSetting.dict.Split('\\').Length < 2)
                appSetting.dict = AppDomain.CurrentDomain.BaseDirectory + @"\" + configHelper.getStringAppSetting("dict", "dictVoval.txt");
            appSetting.delay = configHelper.getIntAppSetting("delay", 3000);
            appSetting.repeat = configHelper.getIntAppSetting("repeat", 5000);
            appSetting.memorized = configHelper.getIntAppSetting("memorized", 20);
            appSetting.aInterval = configHelper.getIntAppSetting("aInterval", 10);
            appSetting.aDuration = configHelper.getIntAppSetting("aDuration", 500);
            appSetting.width = configHelper.getIntAppSetting("width", 300);
            appSetting.height = configHelper.getIntAppSetting("height", 74);
            appSetting.fontTitle = configHelper.getIntAppSetting("fontTitle", 12);
            appSetting.fontContent = configHelper.getIntAppSetting("fontContent", 10);
        }
        private void GetSetting()
        {
            txtTitle.Text = appSetting.dict;
            txtDelay.Value = appSetting.delay;
            txtRepeat.Value = appSetting.repeat;
            txtTimeLearnt.Value = appSetting.memorized;
            txtInterval.Value = appSetting.aInterval;
            txtAnimationDuration.Value = appSetting.aDuration;
            txtWidth.Value = appSetting.width;
            txtHeight.Value = appSetting.height;
            txtFontTitle.Value = appSetting.fontTitle;
            txtFontContent.Value = appSetting.fontContent;
        }
        private void SetSetting()
        {
            appSetting.dict = txtTitle.Text;
            appSetting.delay = (int)txtDelay.Value;
            appSetting.repeat = (int)txtRepeat.Value;
            appSetting.memorized = (int)txtTimeLearnt.Value;
            appSetting.aInterval = (int)txtInterval.Value;
            appSetting.aDuration = (int)txtAnimationDuration.Value;
            appSetting.width = (int)txtWidth.Value;
            appSetting.height = (int)txtHeight.Value;
            appSetting.fontTitle = (int)txtFontTitle.Value;
            appSetting.fontContent = (int)txtFontContent.Value;
            System.Diagnostics.Debug.WriteLine("SetSetting." + appSetting.dict);
        }
        private void SaveSetting()
        {
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["dict"].Value = appSetting.dict;
            config.AppSettings.Settings["delay"].Value = appSetting.delay.ToString();
            config.AppSettings.Settings["repeat"].Value = appSetting.repeat.ToString();
            config.AppSettings.Settings["memorized"].Value = appSetting.memorized.ToString();
            config.AppSettings.Settings["aInterval"].Value = appSetting.aInterval.ToString();
            config.AppSettings.Settings["aDuration"].Value = appSetting.aDuration.ToString();
            config.AppSettings.Settings["width"].Value = appSetting.width.ToString();
            config.AppSettings.Settings["height"].Value = appSetting.height.ToString();
            config.AppSettings.Settings["fontTitle"].Value = appSetting.fontTitle.ToString();
            config.AppSettings.Settings["fontContent"].Value = appSetting.fontContent.ToString();
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

    }
}
