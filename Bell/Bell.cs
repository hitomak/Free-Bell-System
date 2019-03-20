using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Configuration;

namespace Bell
{
    public partial class Bell : Form
    {
        public String NBell = "";
        public String CTime = "";
        public String Today = DateTime.Now.ToString("ddd");
        public int BellIndex = 0;
        public int BellID = 0;
        public bool IfBellRinged = true;
        public bool result = false;
        public int LastBell = 20;

        public Bell()
        {
            InitializeComponent();
            GetSettings();
        }

        public void GetSettings()
        {

            Bell1.Text = ConfigurationManager.AppSettings.Get("bell0");
            Bell2.Text = ConfigurationManager.AppSettings.Get("bell1");
            Bell3.Text = ConfigurationManager.AppSettings.Get("bell2");
            Bell4.Text = ConfigurationManager.AppSettings.Get("bell3");
            Bell5.Text = ConfigurationManager.AppSettings.Get("bell4");
            Bell6.Text = ConfigurationManager.AppSettings.Get("bell5");
            Bell7.Text = ConfigurationManager.AppSettings.Get("bell6");
            Bell8.Text = ConfigurationManager.AppSettings.Get("bell7");
            Bell9.Text = ConfigurationManager.AppSettings.Get("bell8");
            Bell10.Text = ConfigurationManager.AppSettings.Get("bell9");
            Bell11.Text = ConfigurationManager.AppSettings.Get("bell10");
            Bell12.Text = ConfigurationManager.AppSettings.Get("bell11");
            Bell13.Text = ConfigurationManager.AppSettings.Get("bell12");
            Bell14.Text = ConfigurationManager.AppSettings.Get("bell13");
            Bell15.Text = ConfigurationManager.AppSettings.Get("bell14");
            Bell16.Text = ConfigurationManager.AppSettings.Get("bell15");
            Bell17.Text = ConfigurationManager.AppSettings.Get("bell16");
            Bell18.Text = ConfigurationManager.AppSettings.Get("bell17");
            Bell19.Text = ConfigurationManager.AppSettings.Get("bell18");
            Bell20.Text = ConfigurationManager.AppSettings.Get("bell19");
            Bell21.Text = ConfigurationManager.AppSettings.Get("bell20");
            Bell22.Text = ConfigurationManager.AppSettings.Get("bell21");
            Bell23.Text = ConfigurationManager.AppSettings.Get("bell22");
            Bell24.Text = ConfigurationManager.AppSettings.Get("bell23");
            Bell25.Text = ConfigurationManager.AppSettings.Get("bell24");
            Bell26.Text = ConfigurationManager.AppSettings.Get("bell25");
            
            if (ConfigurationManager.AppSettings.Get("Mon") == "True")
            {
                Days.SetItemChecked(0, true);
            }
            if (ConfigurationManager.AppSettings.Get("Tue") == "True")
            {
                Days.SetItemChecked(1, true);
            }
            if (ConfigurationManager.AppSettings.Get("Wed") == "True")
            {
                Days.SetItemChecked(2, true);
            }
            if (ConfigurationManager.AppSettings.Get("Thu") == "True")
            {
                Days.SetItemChecked(3, true);
            }
            if (ConfigurationManager.AppSettings.Get("Fri") == "True")
            {
                Days.SetItemChecked(4, true);
            }
            if (ConfigurationManager.AppSettings.Get("Sat") == "True")
            {
                Days.SetItemChecked(5, true);
            }
            if (ConfigurationManager.AppSettings.Get("Sun") == "True")
            {
                Days.SetItemChecked(6, true);
            }

            LastBell = int.Parse(ConfigurationManager.AppSettings.Get("LastBell"));
        }

        public bool ValidatTheTime()
        {
            return false;
        } //Not Working yet or not need

        public int CheckTheBell(string CurrentTime, string CurrentBell)
        {
            if (CurrentTime == CurrentBell)
            {
                return 1;
            }
            return 0;
        } //If Bell time has come

        private void Time_Tick(object sender, EventArgs e)
        {
            CTime = System.DateTime.Now.ToString("HH:mm:ss");
            Today = System.DateTime.Now.ToString("ddd");
            CurrentTimeHolder.Text = CTime;
            if (NBell == CTime)
            {
                Player.Play();
                IfBellRinged = true;
            }
            if (UpdateNextBell())
            {
                TimeHolderN.Text = NBell;
            }
            else
            {
                TimeHolderN.Text = "Update next bell failure or Day's not selected";
            }
        } //Auto runner for other functions

        private void ChoseTheMusic_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "WAV files|*.wav";
            od.Multiselect = true;
            if (od.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string MainFolder = Application.StartupPath;

                foreach (string fileName in od.FileNames)
                {
                    System.IO.File.Copy(fileName, MainFolder + @"\" + System.IO.Path.GetFileName(fileName));
                    MPath.Text = MainFolder + "\\" + System.IO.Path.GetFileName(fileName);
                    Player.SoundLocation = MainFolder + "\\" + System.IO.Path.GetFileName(fileName);
                }
            }
        } //Chose the Music button functions

        SoundPlayer Player = new SoundPlayer
        {
            SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\Melodi 1.wav"
        }; //Making Player for the Music

        private void PlayTheMusic_Click(object sender, EventArgs e)
        {
            Player.Play();
        } //PlayTheMusic

        private void Stop_Click(object sender, EventArgs e)
        {
            Player.Stop();
        }

        public bool IfToDaycheked(string cDate)
        {
            bool result=false;

            switch (cDate)
            {
                case "Mon":
                    if(Days.GetItemCheckState(0) == CheckState.Checked)
                        result=true;
                    ToDayIs.Text = "Today is : Monday Bell Is Running";
                    break;
                case "Tue":
                    if (Days.GetItemCheckState(1) == CheckState.Checked)
                        result = true;
                    ToDayIs.Text = "Today is : Tuesday Bell Is Running";
                    break;
                case "Wed":
                    if (Days.GetItemCheckState(2) == CheckState.Checked)
                        result = true;
                    ToDayIs.Text = "Today is : Wednesday Bell Is Running";
                    break;
                case "Thu":
                    if (Days.GetItemCheckState(3) == CheckState.Checked)
                        result = true;
                    ToDayIs.Text = "Today is : Thursday Bell Is Running";
                    break;
                case "Fri":
                    if (Days.GetItemCheckState(4) == CheckState.Checked)
                        result = true;
                    ToDayIs.Text = "Today is : Friday Bell Is Running";
                    break;
                case "Sat":
                    if (Days.GetItemCheckState(5) == CheckState.Checked)
                        result = false;
                    ToDayIs.Text = "Today is : Saturday Bell Is Not Running";
                    break;
                case "Sun":
                    if (Days.GetItemCheckState(6) == CheckState.Checked)
                        result = false;
                    ToDayIs.Text = "Today is : Sunday Bell Is Not Running";
                    break;
                default:
                    result = false;
                    ToDayIs.Text = "Failed to Select Day";
                    break;
            }
            return result;
        }

        public bool UpdateNextBell()
        {
            if (IfToDaycheked(Today)==false)
            {
                NBell = " To day Bell Is not Runing";
                BellID = 1;
                return true;
            }
            else
            {
                if (IfBellRinged)
                {
                    switch (BellID)
                    {
                        case 0:
                            NBell = Bell1.Text;
                            BellID = 1;
                            result = true;
                            break;
                        case 1:
                            NBell = Bell2.Text;
                            BellID = 2;
                            result = true;
                            break;
                        case 2:
                            NBell = Bell3.Text;
                            BellID = 3;
                            result = true;
                            break;
                        case 3:
                            NBell = Bell4.Text;
                            BellID = 4;
                            result = true;
                            break;
                        case 4:
                            NBell = Bell5.Text;
                            BellID = 5;
                            result=true;
                            break;
                        case 5:
                            NBell = Bell6.Text;
                            BellID = 6;
                            result=true;
                            break;
                        case 6:
                            NBell = Bell7.Text;
                            BellID = 7;
                            result = true;
                            break;
                        case 7:
                            NBell = Bell8.Text;
                            BellID = 8;
                            result = true;
                            break;
                        case 8:
                            NBell = Bell9.Text;
                            BellID = 9;
                            result = true;
                            break;
                        case 9:
                            NBell = Bell10.Text;
                            BellID = 10;
                            result = true;
                            break;
                        case 10:
                            NBell = Bell11.Text;
                            BellID = 11;
                            result = true;
                            break;
                        case 11:
                            NBell = Bell12.Text;
                            BellID = 12;
                            result = true;
                            break;
                        case 12:
                            NBell = Bell13.Text;
                            BellID = 13;
                            result = true;
                            break;
                        case 13:
                            NBell = Bell14.Text;
                            BellID = 14;
                            result = true;
                            break;
                        case 14:
                            NBell = Bell15.Text;
                            BellID = 15;
                            result = true;
                            break;
                        case 15:
                            NBell = Bell16.Text;
                            BellID = 16;
                            result = true;
                            break;
                        case 16:
                            NBell = Bell17.Text;
                            BellID = 17;
                            result = true;
                            break;
                        case 17:
                            NBell = Bell18.Text;
                            BellID = 18;
                            result = true;
                            break;
                        case 18:
                            NBell = Bell19.Text;
                            BellID = 19;
                            result = true;
                            break;
                        case 19:
                            NBell = Bell20.Text;
                            BellID = 20;
                            result = true;
                            break;
                        case 20:
                            NBell = Bell21.Text;
                            BellID = 21;
                            result = true;
                            break;
                        case 21:
                            NBell = Bell22.Text;
                            BellID = 22;
                            result = true;
                            break;
                        case 22:
                            NBell = Bell23.Text;
                            BellID = 23;
                            result = true;
                            break;
                        case 23:
                            NBell = Bell24.Text;
                            BellID = 24;
                            break;
                        case 24:
                            NBell = Bell25.Text;
                            BellID = 25;
                            result = true;
                            break;
                        case 25:
                            NBell = Bell26.Text;
                            BellID = 26;
                            result = true;
                            break;
                        case 26:
                            NBell = Bell1.Text;
                            BellID = 1;
                            result = true;
                            break;
                        default:
                            NBell = "Failure Selecting Bell Time";
                            return false;
                    }
                    IfBellRinged = false;

                    if (BellID > LastBell)
                    {
                        NBell = Bell1.Text;
                        BellID = 1;
                    }
                }
            }
            return result;
        }

        private void ChoseTheBell_SelectedIndexChanged(object sender, EventArgs e)
        {
            BellIndex = int.Parse(ChoseTheBell.GetItemText(ChoseTheBell.SelectedItem));
            BellID = BellIndex-1;
            IfBellRinged = true;
            UpdateNextBell();
        }

        private void TimeTableLimit_SelectedIndexChanged(object sender, EventArgs e)
        {
            LastBell = int.Parse(TimeTableLimit.GetItemText(TimeTableLimit.SelectedItem));
        }
    }
}
