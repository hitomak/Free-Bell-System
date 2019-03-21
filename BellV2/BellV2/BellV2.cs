using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BellV2
{
    public partial class BellV2 : Form
    {
        public string Today = "";
        public string CTime = "";
        public string NBell = "10:00:00";
        public int HowManyBellIndex = 0;
        public int NBellID = 0;
        public bool IfBellRinged = true;
        public int LastBell = 0;
        

        public BellV2()
        {
            InitializeComponent();
        }

        public bool GetDefaultConfigurations()
        {
            return true;
        }//Get Default Settings from Config File

        public bool ArangeIndexOfBell(int TimeTableID)
        {
            return true;
        }//Arange the time table given ID

        public bool SaveSettings(string what)
        {
            return true;
        } //Settingswill be saved to config file

        public bool StatusMesageHandler()
        {
            return true;
        }//Shows Status to Status bar

        public bool SelectTodaysTimeTable() 
        {
            return true;
        }//Selectto days time table

        public string RemainTime(string CurrentTime, string NextBellTime)
        {
            string a = "24:00:00";
            DateTime ctime = DateTime.ParseExact(CurrentTime, "HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
            DateTime nbell = DateTime.ParseExact(NextBellTime, "HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
            TimeSpan Hour24 = DateTime.ParseExact(a, "HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
            TimeSpan difrence = nbell - ctime;
            return difrence.ToString();
        }
        
        private void Timer_Tick(object sender, EventArgs e)
        {
            CTime = System.DateTime.Now.ToString("HH:mm:ss");
            Today = System.DateTime.Now.ToString("dddd");
            CurrentTime.Text = CTime;
            NextBell.Text = NBell;
            TimeToNextBell.Text = RemainTime(CTime, NBell);
            ToDaysBellStatus.Text = Today;

        }

        public bool IsToDayBellRunning()
        {
            return true;
        }
        
    }
}
