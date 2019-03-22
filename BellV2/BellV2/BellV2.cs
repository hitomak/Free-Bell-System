using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BellV2
{
    public partial class BellV2 : Form
    {
        public string Today = "";           //Contains Todays Name
        public string fToday = "";
        public string CTime = "";           //Contains Current Time
        public string NBell = "10:21:45";   //Contains NextBellTime
        public string SoundFile = "";
        public int AmountOfSound = 10;
        public int AmountOfTimeTable = 1;   //Contains Amount of time table
        public int HowManyBellInTable = 20;    //Conains How May Bell Going to Ring today
        public int NBellID = 0;             //Contains Nbells ID
        public bool IfBellRinged = false;    //Controling the bell rings and with this changing the Next Bell Time
        public int LastBell = 20;            //Last bell for today

        public string MainFolder = Application.StartupPath;

        public BellV2()
        {
            InitializeComponent();
            if (GenerateSoundList())
                eror.Text = "Bisey yanlis gitti";
        }

        public bool GenerateSoundList()
        {
            Label[] AutoGenerateLabel = new Label[AmountOfSound];
            Button[,] AutoGenerateButton = new Button[AmountOfSound, 3];
            int HeightDiff = 0;
            int tableindex = 10;

            for (int i = 0; i < AmountOfSound; i++)
            {

                AutoGenerateLabel[i] = new Label();
                AutoGenerateLabel[i].AutoSize = true;
                AutoGenerateLabel[i].Location = new Point(4, 85+HeightDiff);
                AutoGenerateLabel[i].Name = "AutoGenerateLabel" + i.ToString();
                AutoGenerateLabel[i].Size = new Size(55, 13);
                AutoGenerateLabel[i].TabIndex = tableindex;
                AutoGenerateLabel[i].Text = "AutoLabel"+i.ToString();
                AutoGenerateLabel[i].Visible = true;

                tableindex = tableindex + 1;

                AutoGenerateButton[i, 0] = new Button();
                AutoGenerateButton[i, 0].Location = new Point(210, 80+HeightDiff);
                AutoGenerateButton[i, 0].Name = "Play" + i.ToString();
                AutoGenerateButton[i, 0].Size = new Size(59, 23);
                AutoGenerateButton[i, 0].TabIndex = tableindex;
                AutoGenerateButton[i, 0].Text = "Play" + i.ToString();
                AutoGenerateButton[i, 0].UseVisualStyleBackColor = true;

                tableindex = tableindex + 1;

                AutoGenerateButton[i, 1] = new Button();
                AutoGenerateButton[i, 1].Location = new Point(275, 80 + HeightDiff);
                AutoGenerateButton[i, 1].Name = "Stop" + i.ToString();
                AutoGenerateButton[i, 1].Size = new Size(59, 23);
                AutoGenerateButton[i, 1].TabIndex = tableindex;
                AutoGenerateButton[i, 1].Text = "Stop" + i.ToString();
                AutoGenerateButton[i, 1].UseVisualStyleBackColor = true;

                tableindex = tableindex + 1;

                AutoGenerateButton[i, 2] = new Button();
                AutoGenerateButton[i, 2].Location = new Point(340, 80 + HeightDiff);
                AutoGenerateButton[i, 2].Name = "Assign" + i.ToString();
                AutoGenerateButton[i, 2].Size = new Size(59, 23);
                AutoGenerateButton[i, 2].TabIndex = tableindex;
                AutoGenerateButton[i, 2].Text = "Assign" + i.ToString();
                AutoGenerateButton[i, 2].UseVisualStyleBackColor = true;

                tableindex = tableindex + 1;
                HeightDiff = HeightDiff+30;

                Sounds.Controls.Add(AutoGenerateLabel[i]);
                Sounds.Controls.Add(AutoGenerateButton[i, 0]);
                Sounds.Controls.Add(AutoGenerateButton[i, 1]);
                Sounds.Controls.Add(AutoGenerateButton[i, 2]);
                
                AutoGenerateButton[i, 0].Click += new EventHandler(AutoGenerateButton_Play);
                AutoGenerateButton[i, 1].Click += new EventHandler(AutoGenerateButton_Stop);
                AutoGenerateButton[i, 2].Click += new EventHandler(AutoGenerateButton_Assign);

                void AutoGenerateButton_Play(object sender, EventArgs e)
                {
                    string OldSoundLocation = Player.SoundLocation;
                    Player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\Melodi.wav"; //Get it with sound tab
                    Player.Play();
                    Player.SoundLocation = OldSoundLocation;
                }
                void AutoGenerateButton_Stop(object sender, EventArgs e)
                {
                    Player.Stop();
                }
                void AutoGenerateButton_Assign(object sender, EventArgs e)
                {
                    Player.Stop();
                }

                eror.Text = i.ToString()+" "+ tableindex.ToString();

                if (i == AmountOfSound)
                {
                    eror.Text = i.ToString();
                    return true; }
            }
            return false;
        }

        public bool GetDefaultConfigurations()
        {
            AmountOfSound = ConfigurationManager.ConnectionStrings{Get};
            return true;
        }//Get Default Settings from Config File

        public bool ArangeIndexOfBell(int TimeTableID)
        {
            return true;
        }//Arange the time table given ID

        public bool SaveSettings(string what)
        {
            return true;
        } //Settings will be saved to config file

        public bool StatusMesageHandler()
        {
            return true;
        }//Shows Status to Status bar

        public bool SelectTodaysTimeTable() 
        {
            return true;
        }//Selectto days time table

        public string RemainTime()
        {
            DateTime ctime = DateTime.ParseExact(CTime, "HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
            DateTime nbell = DateTime.ParseExact(NBell, "HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
            TimeSpan difrence = nbell - ctime;
            if (difrence < new TimeSpan(0, 0, 0, 0, 0))
            {
                difrence = TimeSpan.FromDays(1)+difrence;
            }
            return difrence.ToString();
        }//Calculate reamin time to next ring.

        public bool UpdateNextBell()
        {
            return true;
        }
        
        private void Timer_Tick(object sender, EventArgs e)
        {
            CTime = System.DateTime.Now.ToString("HH:mm:ss");
            Today = System.DateTime.Now.ToString("ddd");
            fToday = System.DateTime.Now.ToString("dddd");
            CurrentTime.Text = CTime;   //Show current Time on GUI
            NextBell.Text = NBell;      //Show Next bell Time on GUI
            TimeToNextBell.Text = RemainTime(); // ShowRemaining time on GUi
            ToDaysBellStatus.Text = IsToDayBellRunning() ? "Today is " + fToday + " Bell is Runnig" : "Today is " + fToday + " Bell is Not Runnig";
            IfItIsBellTime();
        }

        SoundPlayer Player = new SoundPlayer
        {
           SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\Melodi.wav" //Get it with sound tab
        };

        public bool IfItIsBellTime() // If it is bell time play the music update the bell
        {
            if (CTime == NBell & IsToDayBellRunning())
            {
                IfBellRinged = true;
                Player.Play();
                return true;
            }
            return false;
        }

        public bool CheckTheDays(int a, string b)
        {
            if (DaysToRing.GetItemCheckState(a) == CheckState.Checked & Today == b)
            {
                return true;
            }
            return false;
        }//Is to day Bell Running Helper it checksif today selected for bellring

        public bool IsToDayBellRunning()
        {  
            if(CheckTheDays(0, "Mon"))
            {
                return true;
            }
            else if (CheckTheDays(1, "Tue"))
            {
                return true;
            }
            else if (CheckTheDays(2, "Wed"))
            {
                return true;
            }
            else if (CheckTheDays(3, "Thu"))
            {
                return true;
            }
            else if (CheckTheDays(4, "Fri"))
            {
                return true;
            }
            else if (CheckTheDays(5, "Sat"))
            {
                return true;
            }
            else if (CheckTheDays(6, "Sun"))
            {
                return true;
            }
            return false;
        }//If to days bell runing?

        private void ChangeNBell_Click(object sender, EventArgs e)
        {
            NBell = Change.Text;
        }

        private void StopMusic_Click(object sender, EventArgs e)
        {
            Player.Stop();
        }

        private void ChoseTheSound_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "WAV files|*.wav|MP3 files|*.mp3";
            od.Multiselect = true;
            if (od.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string fileName in od.FileNames)
                {
                    ChosedSound.Text = MainFolder + "\\" + System.IO.Path.GetFileName(fileName);
                    SoundFile = fileName;
                }
            }
        }

        private void SaveTheSound_Click(object sender, EventArgs e)
        {
            System.IO.File.Copy(SoundFile, MainFolder + @"\" + System.IO.Path.GetFileName(SoundFile));
        }

    }
}
