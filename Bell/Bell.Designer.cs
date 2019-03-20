namespace Bell
{
    partial class Bell
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
            this.Menu = new System.Windows.Forms.TabControl();
            this.Main = new System.Windows.Forms.TabPage();
            this.label28 = new System.Windows.Forms.Label();
            this.ChoseTheBell = new System.Windows.Forms.ListBox();
            this.ToDayIs = new System.Windows.Forms.Label();
            this.CurrentTimeHolder = new System.Windows.Forms.Label();
            this.TimeHolderN = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l1 = new System.Windows.Forms.Label();
            this.NextBell = new System.Windows.Forms.Label();
            this.CurrentTime = new System.Windows.Forms.Label();
            this.TimeTable = new System.Windows.Forms.TabPage();
            this.Days = new System.Windows.Forms.CheckedListBox();
            this.label27 = new System.Windows.Forms.Label();
            this.Bell26 = new System.Windows.Forms.TextBox();
            this.Bell25 = new System.Windows.Forms.TextBox();
            this.Bell24 = new System.Windows.Forms.TextBox();
            this.Bell23 = new System.Windows.Forms.TextBox();
            this.Bell22 = new System.Windows.Forms.TextBox();
            this.Bell21 = new System.Windows.Forms.TextBox();
            this.Bell20 = new System.Windows.Forms.TextBox();
            this.Bell19 = new System.Windows.Forms.TextBox();
            this.Bell18 = new System.Windows.Forms.TextBox();
            this.Bell17 = new System.Windows.Forms.TextBox();
            this.Bell16 = new System.Windows.Forms.TextBox();
            this.Bell15 = new System.Windows.Forms.TextBox();
            this.Bell14 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Bell13 = new System.Windows.Forms.TextBox();
            this.Bell12 = new System.Windows.Forms.TextBox();
            this.Bell11 = new System.Windows.Forms.TextBox();
            this.Bell10 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Bell9 = new System.Windows.Forms.TextBox();
            this.Bell8 = new System.Windows.Forms.TextBox();
            this.Bell7 = new System.Windows.Forms.TextBox();
            this.Bell6 = new System.Windows.Forms.TextBox();
            this.Bell5 = new System.Windows.Forms.TextBox();
            this.Bell4 = new System.Windows.Forms.TextBox();
            this.Bell3 = new System.Windows.Forms.TextBox();
            this.Bell2 = new System.Windows.Forms.TextBox();
            this.Bell1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CustomTimeTable = new System.Windows.Forms.Label();
            this.PATTHText = new System.Windows.Forms.Label();
            this.DaysToRing = new System.Windows.Forms.Label();
            this.Settings = new System.Windows.Forms.TabPage();
            this.MPath = new System.Windows.Forms.Label();
            this.MPathText = new System.Windows.Forms.Label();
            this.Stop = new System.Windows.Forms.Button();
            this.PlayTheMusic = new System.Windows.Forms.Button();
            this.ChoseTheMusic = new System.Windows.Forms.Button();
            this.FileWatcher = new System.IO.FileSystemWatcher();
            this.Time = new System.Windows.Forms.Timer(this.components);
            this.TimeTableLimit = new System.Windows.Forms.ListBox();
            this.label29 = new System.Windows.Forms.Label();
            this.Menu.SuspendLayout();
            this.Main.SuspendLayout();
            this.TimeTable.SuspendLayout();
            this.Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FileWatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Controls.Add(this.Main);
            this.Menu.Controls.Add(this.TimeTable);
            this.Menu.Controls.Add(this.Settings);
            this.Menu.Location = new System.Drawing.Point(12, 12);
            this.Menu.Name = "Menu";
            this.Menu.SelectedIndex = 0;
            this.Menu.Size = new System.Drawing.Size(760, 537);
            this.Menu.TabIndex = 0;
            // 
            // Main
            // 
            this.Main.Controls.Add(this.label28);
            this.Main.Controls.Add(this.ChoseTheBell);
            this.Main.Controls.Add(this.ToDayIs);
            this.Main.Controls.Add(this.CurrentTimeHolder);
            this.Main.Controls.Add(this.TimeHolderN);
            this.Main.Controls.Add(this.l2);
            this.Main.Controls.Add(this.l1);
            this.Main.Controls.Add(this.NextBell);
            this.Main.Controls.Add(this.CurrentTime);
            this.Main.Location = new System.Drawing.Point(4, 22);
            this.Main.Name = "Main";
            this.Main.Padding = new System.Windows.Forms.Padding(3);
            this.Main.Size = new System.Drawing.Size(752, 511);
            this.Main.TabIndex = 0;
            this.Main.Text = "Main";
            this.Main.UseVisualStyleBackColor = true;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(8, 67);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(157, 13);
            this.label28.TabIndex = 8;
            this.label28.Text = "Chose the Next Bell From Down";
            // 
            // ChoseTheBell
            // 
            this.ChoseTheBell.ColumnWidth = 25;
            this.ChoseTheBell.FormattingEnabled = true;
            this.ChoseTheBell.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26"});
            this.ChoseTheBell.Location = new System.Drawing.Point(8, 83);
            this.ChoseTheBell.MultiColumn = true;
            this.ChoseTheBell.Name = "ChoseTheBell";
            this.ChoseTheBell.Size = new System.Drawing.Size(663, 17);
            this.ChoseTheBell.TabIndex = 7;
            this.ChoseTheBell.SelectedIndexChanged += new System.EventHandler(this.ChoseTheBell_SelectedIndexChanged);
            // 
            // ToDayIs
            // 
            this.ToDayIs.AutoSize = true;
            this.ToDayIs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDayIs.Location = new System.Drawing.Point(4, 47);
            this.ToDayIs.Name = "ToDayIs";
            this.ToDayIs.Size = new System.Drawing.Size(67, 20);
            this.ToDayIs.TabIndex = 6;
            this.ToDayIs.Text = "label28";
            // 
            // CurrentTimeHolder
            // 
            this.CurrentTimeHolder.AutoSize = true;
            this.CurrentTimeHolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentTimeHolder.Location = new System.Drawing.Point(133, 7);
            this.CurrentTimeHolder.Name = "CurrentTimeHolder";
            this.CurrentTimeHolder.Size = new System.Drawing.Size(99, 20);
            this.CurrentTimeHolder.TabIndex = 5;
            this.CurrentTimeHolder.Text = "1:11:21 PM";
            // 
            // TimeHolderN
            // 
            this.TimeHolderN.AutoSize = true;
            this.TimeHolderN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeHolderN.Location = new System.Drawing.Point(133, 27);
            this.TimeHolderN.Name = "TimeHolderN";
            this.TimeHolderN.Size = new System.Drawing.Size(112, 20);
            this.TimeHolderN.TabIndex = 4;
            this.TimeHolderN.Text = "TimeHolderN";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2.Location = new System.Drawing.Point(113, 27);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(14, 20);
            this.l2.TabIndex = 3;
            this.l2.Text = ":";
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1.Location = new System.Drawing.Point(113, 7);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(14, 20);
            this.l1.TabIndex = 2;
            this.l1.Text = ":";
            // 
            // NextBell
            // 
            this.NextBell.AutoSize = true;
            this.NextBell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextBell.Location = new System.Drawing.Point(4, 27);
            this.NextBell.Name = "NextBell";
            this.NextBell.Size = new System.Drawing.Size(80, 20);
            this.NextBell.TabIndex = 1;
            this.NextBell.Text = "Next Bell";
            // 
            // CurrentTime
            // 
            this.CurrentTime.AutoSize = true;
            this.CurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentTime.Location = new System.Drawing.Point(4, 7);
            this.CurrentTime.Name = "CurrentTime";
            this.CurrentTime.Size = new System.Drawing.Size(112, 20);
            this.CurrentTime.TabIndex = 0;
            this.CurrentTime.Text = "Current Time";
            // 
            // TimeTable
            // 
            this.TimeTable.Controls.Add(this.label29);
            this.TimeTable.Controls.Add(this.TimeTableLimit);
            this.TimeTable.Controls.Add(this.Days);
            this.TimeTable.Controls.Add(this.label27);
            this.TimeTable.Controls.Add(this.Bell26);
            this.TimeTable.Controls.Add(this.Bell25);
            this.TimeTable.Controls.Add(this.Bell24);
            this.TimeTable.Controls.Add(this.Bell23);
            this.TimeTable.Controls.Add(this.Bell22);
            this.TimeTable.Controls.Add(this.Bell21);
            this.TimeTable.Controls.Add(this.Bell20);
            this.TimeTable.Controls.Add(this.Bell19);
            this.TimeTable.Controls.Add(this.Bell18);
            this.TimeTable.Controls.Add(this.Bell17);
            this.TimeTable.Controls.Add(this.Bell16);
            this.TimeTable.Controls.Add(this.Bell15);
            this.TimeTable.Controls.Add(this.Bell14);
            this.TimeTable.Controls.Add(this.label26);
            this.TimeTable.Controls.Add(this.label25);
            this.TimeTable.Controls.Add(this.label24);
            this.TimeTable.Controls.Add(this.label23);
            this.TimeTable.Controls.Add(this.label22);
            this.TimeTable.Controls.Add(this.label21);
            this.TimeTable.Controls.Add(this.label20);
            this.TimeTable.Controls.Add(this.label19);
            this.TimeTable.Controls.Add(this.label18);
            this.TimeTable.Controls.Add(this.label17);
            this.TimeTable.Controls.Add(this.label16);
            this.TimeTable.Controls.Add(this.label1);
            this.TimeTable.Controls.Add(this.label15);
            this.TimeTable.Controls.Add(this.Bell13);
            this.TimeTable.Controls.Add(this.Bell12);
            this.TimeTable.Controls.Add(this.Bell11);
            this.TimeTable.Controls.Add(this.Bell10);
            this.TimeTable.Controls.Add(this.label14);
            this.TimeTable.Controls.Add(this.label13);
            this.TimeTable.Controls.Add(this.label12);
            this.TimeTable.Controls.Add(this.label11);
            this.TimeTable.Controls.Add(this.label10);
            this.TimeTable.Controls.Add(this.Bell9);
            this.TimeTable.Controls.Add(this.Bell8);
            this.TimeTable.Controls.Add(this.Bell7);
            this.TimeTable.Controls.Add(this.Bell6);
            this.TimeTable.Controls.Add(this.Bell5);
            this.TimeTable.Controls.Add(this.Bell4);
            this.TimeTable.Controls.Add(this.Bell3);
            this.TimeTable.Controls.Add(this.Bell2);
            this.TimeTable.Controls.Add(this.Bell1);
            this.TimeTable.Controls.Add(this.label9);
            this.TimeTable.Controls.Add(this.label8);
            this.TimeTable.Controls.Add(this.label7);
            this.TimeTable.Controls.Add(this.label6);
            this.TimeTable.Controls.Add(this.label5);
            this.TimeTable.Controls.Add(this.label4);
            this.TimeTable.Controls.Add(this.label3);
            this.TimeTable.Controls.Add(this.label2);
            this.TimeTable.Controls.Add(this.CustomTimeTable);
            this.TimeTable.Controls.Add(this.PATTHText);
            this.TimeTable.Controls.Add(this.DaysToRing);
            this.TimeTable.Location = new System.Drawing.Point(4, 22);
            this.TimeTable.Name = "TimeTable";
            this.TimeTable.Padding = new System.Windows.Forms.Padding(3);
            this.TimeTable.Size = new System.Drawing.Size(752, 511);
            this.TimeTable.TabIndex = 1;
            this.TimeTable.Text = "TimeTable";
            this.TimeTable.UseVisualStyleBackColor = true;
            // 
            // Days
            // 
            this.Days.ColumnWidth = 55;
            this.Days.FormattingEnabled = true;
            this.Days.Items.AddRange(new object[] {
            "Mon",
            "Tue",
            "Wed",
            "Thu",
            "Fri",
            "Sat",
            "Sun"});
            this.Days.Location = new System.Drawing.Point(136, 8);
            this.Days.MultiColumn = true;
            this.Days.Name = "Days";
            this.Days.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Days.Size = new System.Drawing.Size(389, 19);
            this.Days.TabIndex = 65;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(7, 68);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(278, 26);
            this.label27.TabIndex = 64;
            this.label27.Text = "Note use the time format like HH:mm:ss Exaple : 15:05:00\r\nIf you not use like thi" +
    "s system will not work!";
            // 
            // Bell26
            // 
            this.Bell26.Location = new System.Drawing.Point(215, 466);
            this.Bell26.Name = "Bell26";
            this.Bell26.Size = new System.Drawing.Size(100, 20);
            this.Bell26.TabIndex = 63;
            this.Bell26.Text = "00:00:00";
            // 
            // Bell25
            // 
            this.Bell25.Location = new System.Drawing.Point(215, 440);
            this.Bell25.Name = "Bell25";
            this.Bell25.Size = new System.Drawing.Size(100, 20);
            this.Bell25.TabIndex = 62;
            this.Bell25.Text = "00:00:00";
            // 
            // Bell24
            // 
            this.Bell24.Location = new System.Drawing.Point(215, 414);
            this.Bell24.Name = "Bell24";
            this.Bell24.Size = new System.Drawing.Size(100, 20);
            this.Bell24.TabIndex = 61;
            this.Bell24.Text = "00:00:00";
            // 
            // Bell23
            // 
            this.Bell23.Location = new System.Drawing.Point(215, 388);
            this.Bell23.Name = "Bell23";
            this.Bell23.Size = new System.Drawing.Size(100, 20);
            this.Bell23.TabIndex = 60;
            this.Bell23.Text = "00:00:00";
            // 
            // Bell22
            // 
            this.Bell22.Location = new System.Drawing.Point(215, 362);
            this.Bell22.Name = "Bell22";
            this.Bell22.Size = new System.Drawing.Size(100, 20);
            this.Bell22.TabIndex = 59;
            this.Bell22.Text = "00:00:00";
            // 
            // Bell21
            // 
            this.Bell21.Location = new System.Drawing.Point(215, 336);
            this.Bell21.Name = "Bell21";
            this.Bell21.Size = new System.Drawing.Size(100, 20);
            this.Bell21.TabIndex = 58;
            this.Bell21.Text = "00:00:00";
            // 
            // Bell20
            // 
            this.Bell20.Location = new System.Drawing.Point(215, 310);
            this.Bell20.Name = "Bell20";
            this.Bell20.Size = new System.Drawing.Size(100, 20);
            this.Bell20.TabIndex = 57;
            this.Bell20.Text = "00:00:00";
            // 
            // Bell19
            // 
            this.Bell19.Location = new System.Drawing.Point(215, 283);
            this.Bell19.Name = "Bell19";
            this.Bell19.Size = new System.Drawing.Size(100, 20);
            this.Bell19.TabIndex = 56;
            this.Bell19.Text = "00:00:00";
            // 
            // Bell18
            // 
            this.Bell18.Location = new System.Drawing.Point(215, 256);
            this.Bell18.Name = "Bell18";
            this.Bell18.Size = new System.Drawing.Size(100, 20);
            this.Bell18.TabIndex = 55;
            this.Bell18.Text = "00:00:00";
            // 
            // Bell17
            // 
            this.Bell17.Location = new System.Drawing.Point(215, 229);
            this.Bell17.Name = "Bell17";
            this.Bell17.Size = new System.Drawing.Size(100, 20);
            this.Bell17.TabIndex = 54;
            this.Bell17.Text = "00:00:00";
            // 
            // Bell16
            // 
            this.Bell16.Location = new System.Drawing.Point(215, 202);
            this.Bell16.Name = "Bell16";
            this.Bell16.Size = new System.Drawing.Size(100, 20);
            this.Bell16.TabIndex = 53;
            this.Bell16.Text = "00:00:00";
            // 
            // Bell15
            // 
            this.Bell15.Location = new System.Drawing.Point(215, 175);
            this.Bell15.Name = "Bell15";
            this.Bell15.Size = new System.Drawing.Size(100, 20);
            this.Bell15.TabIndex = 52;
            this.Bell15.Text = "00:00:00";
            // 
            // Bell14
            // 
            this.Bell14.Location = new System.Drawing.Point(215, 148);
            this.Bell14.Name = "Bell14";
            this.Bell14.Size = new System.Drawing.Size(100, 20);
            this.Bell14.TabIndex = 51;
            this.Bell14.Text = "00:00:00";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(190, 469);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(19, 13);
            this.label26.TabIndex = 50;
            this.label26.Text = "26";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(190, 443);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(19, 13);
            this.label25.TabIndex = 49;
            this.label25.Text = "25";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(190, 417);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(19, 13);
            this.label24.TabIndex = 48;
            this.label24.Text = "24";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(190, 391);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(19, 13);
            this.label23.TabIndex = 47;
            this.label23.Text = "23";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(190, 365);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(19, 13);
            this.label22.TabIndex = 46;
            this.label22.Text = "22";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(190, 339);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(19, 13);
            this.label21.TabIndex = 45;
            this.label21.Text = "21";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(190, 313);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(19, 13);
            this.label20.TabIndex = 44;
            this.label20.Text = "20";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(190, 286);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(19, 13);
            this.label19.TabIndex = 43;
            this.label19.Text = "19";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(190, 259);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(19, 13);
            this.label18.TabIndex = 42;
            this.label18.Text = "18";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(190, 232);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(19, 13);
            this.label17.TabIndex = 41;
            this.label17.Text = "17";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(190, 205);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(19, 13);
            this.label16.TabIndex = 40;
            this.label16.Text = "16";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "15";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(190, 151);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(19, 13);
            this.label15.TabIndex = 38;
            this.label15.Text = "14";
            // 
            // Bell13
            // 
            this.Bell13.Location = new System.Drawing.Point(26, 466);
            this.Bell13.Name = "Bell13";
            this.Bell13.Size = new System.Drawing.Size(100, 20);
            this.Bell13.TabIndex = 37;
            this.Bell13.Text = "00:00:00";
            // 
            // Bell12
            // 
            this.Bell12.Location = new System.Drawing.Point(26, 440);
            this.Bell12.Name = "Bell12";
            this.Bell12.Size = new System.Drawing.Size(100, 20);
            this.Bell12.TabIndex = 36;
            this.Bell12.Text = "00:00:00";
            // 
            // Bell11
            // 
            this.Bell11.Location = new System.Drawing.Point(26, 414);
            this.Bell11.Name = "Bell11";
            this.Bell11.Size = new System.Drawing.Size(100, 20);
            this.Bell11.TabIndex = 35;
            this.Bell11.Text = "00:00:00";
            // 
            // Bell10
            // 
            this.Bell10.Location = new System.Drawing.Point(26, 388);
            this.Bell10.Name = "Bell10";
            this.Bell10.Size = new System.Drawing.Size(100, 20);
            this.Bell10.TabIndex = 34;
            this.Bell10.Text = "00:00:00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1, 469);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "13";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1, 443);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "12";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1, 417);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "11";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1, 391);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "10";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 365);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "9";
            // 
            // Bell9
            // 
            this.Bell9.Location = new System.Drawing.Point(26, 362);
            this.Bell9.Name = "Bell9";
            this.Bell9.Size = new System.Drawing.Size(100, 20);
            this.Bell9.TabIndex = 28;
            this.Bell9.Text = "00:00:00";
            // 
            // Bell8
            // 
            this.Bell8.Location = new System.Drawing.Point(26, 336);
            this.Bell8.Name = "Bell8";
            this.Bell8.Size = new System.Drawing.Size(100, 20);
            this.Bell8.TabIndex = 27;
            this.Bell8.Text = "00:00:00";
            // 
            // Bell7
            // 
            this.Bell7.Location = new System.Drawing.Point(26, 310);
            this.Bell7.Name = "Bell7";
            this.Bell7.Size = new System.Drawing.Size(100, 20);
            this.Bell7.TabIndex = 26;
            this.Bell7.Text = "00:00:00";
            // 
            // Bell6
            // 
            this.Bell6.Location = new System.Drawing.Point(26, 283);
            this.Bell6.Name = "Bell6";
            this.Bell6.Size = new System.Drawing.Size(100, 20);
            this.Bell6.TabIndex = 25;
            this.Bell6.Text = "00:00:00";
            // 
            // Bell5
            // 
            this.Bell5.Location = new System.Drawing.Point(26, 256);
            this.Bell5.Name = "Bell5";
            this.Bell5.Size = new System.Drawing.Size(100, 20);
            this.Bell5.TabIndex = 24;
            this.Bell5.Text = "00:00:00";
            // 
            // Bell4
            // 
            this.Bell4.Location = new System.Drawing.Point(26, 229);
            this.Bell4.Name = "Bell4";
            this.Bell4.Size = new System.Drawing.Size(100, 20);
            this.Bell4.TabIndex = 23;
            this.Bell4.Text = "00:00:00";
            // 
            // Bell3
            // 
            this.Bell3.Location = new System.Drawing.Point(26, 202);
            this.Bell3.Name = "Bell3";
            this.Bell3.Size = new System.Drawing.Size(100, 20);
            this.Bell3.TabIndex = 22;
            this.Bell3.Text = "00:00:00";
            // 
            // Bell2
            // 
            this.Bell2.Location = new System.Drawing.Point(26, 175);
            this.Bell2.Name = "Bell2";
            this.Bell2.Size = new System.Drawing.Size(100, 20);
            this.Bell2.TabIndex = 21;
            this.Bell2.Text = "00:00:00";
            // 
            // Bell1
            // 
            this.Bell1.Location = new System.Drawing.Point(26, 148);
            this.Bell1.Name = "Bell1";
            this.Bell1.Size = new System.Drawing.Size(100, 20);
            this.Bell1.TabIndex = 20;
            this.Bell1.Text = "00:00:00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 339);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "8";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "7";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "1";
            // 
            // CustomTimeTable
            // 
            this.CustomTimeTable.AutoSize = true;
            this.CustomTimeTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomTimeTable.Location = new System.Drawing.Point(4, 125);
            this.CustomTimeTable.Name = "CustomTimeTable";
            this.CustomTimeTable.Size = new System.Drawing.Size(96, 20);
            this.CustomTimeTable.TabIndex = 11;
            this.CustomTimeTable.Text = "Time Table";
            // 
            // PATTHText
            // 
            this.PATTHText.AutoSize = true;
            this.PATTHText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PATTHText.Location = new System.Drawing.Point(4, 48);
            this.PATTHText.Name = "PATTHText";
            this.PATTHText.Size = new System.Drawing.Size(227, 20);
            this.PATTHText.TabIndex = 8;
            this.PATTHText.Text = "Please Add the Times Here";
            // 
            // DaysToRing
            // 
            this.DaysToRing.AutoSize = true;
            this.DaysToRing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DaysToRing.Location = new System.Drawing.Point(4, 7);
            this.DaysToRing.Name = "DaysToRing";
            this.DaysToRing.Size = new System.Drawing.Size(126, 20);
            this.DaysToRing.TabIndex = 0;
            this.DaysToRing.Text = "Days To Ring :";
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.MPath);
            this.Settings.Controls.Add(this.MPathText);
            this.Settings.Controls.Add(this.Stop);
            this.Settings.Controls.Add(this.PlayTheMusic);
            this.Settings.Controls.Add(this.ChoseTheMusic);
            this.Settings.Location = new System.Drawing.Point(4, 22);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(3);
            this.Settings.Size = new System.Drawing.Size(752, 511);
            this.Settings.TabIndex = 2;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // MPath
            // 
            this.MPath.AutoSize = true;
            this.MPath.Location = new System.Drawing.Point(117, 7);
            this.MPath.Name = "MPath";
            this.MPath.Size = new System.Drawing.Size(38, 13);
            this.MPath.TabIndex = 4;
            this.MPath.Text = "MPath";
            // 
            // MPathText
            // 
            this.MPathText.AutoSize = true;
            this.MPathText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MPathText.Location = new System.Drawing.Point(3, 3);
            this.MPathText.Name = "MPathText";
            this.MPathText.Size = new System.Drawing.Size(107, 20);
            this.MPathText.TabIndex = 3;
            this.MPathText.Text = "Music Path :";
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(258, 48);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(75, 23);
            this.Stop.TabIndex = 2;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // PlayTheMusic
            // 
            this.PlayTheMusic.Location = new System.Drawing.Point(139, 48);
            this.PlayTheMusic.Name = "PlayTheMusic";
            this.PlayTheMusic.Size = new System.Drawing.Size(113, 23);
            this.PlayTheMusic.TabIndex = 1;
            this.PlayTheMusic.Text = "Play The Music";
            this.PlayTheMusic.UseVisualStyleBackColor = true;
            this.PlayTheMusic.Click += new System.EventHandler(this.PlayTheMusic_Click);
            // 
            // ChoseTheMusic
            // 
            this.ChoseTheMusic.Location = new System.Drawing.Point(6, 48);
            this.ChoseTheMusic.Name = "ChoseTheMusic";
            this.ChoseTheMusic.Size = new System.Drawing.Size(127, 23);
            this.ChoseTheMusic.TabIndex = 0;
            this.ChoseTheMusic.Text = "Chose The Music";
            this.ChoseTheMusic.UseVisualStyleBackColor = true;
            this.ChoseTheMusic.Click += new System.EventHandler(this.ChoseTheMusic_Click);
            // 
            // FileWatcher
            // 
            this.FileWatcher.EnableRaisingEvents = true;
            this.FileWatcher.SynchronizingObject = this;
            // 
            // Time
            // 
            this.Time.Enabled = true;
            this.Time.Interval = 1000;
            this.Time.Tick += new System.EventHandler(this.Time_Tick);
            // 
            // TimeTableLimit
            // 
            this.TimeTableLimit.ColumnWidth = 20;
            this.TimeTableLimit.FormattingEnabled = true;
            this.TimeTableLimit.Items.AddRange(new object[] {
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26"});
            this.TimeTableLimit.Location = new System.Drawing.Point(356, 148);
            this.TimeTableLimit.MultiColumn = true;
            this.TimeTableLimit.Name = "TimeTableLimit";
            this.TimeTableLimit.Size = new System.Drawing.Size(354, 17);
            this.TimeTableLimit.TabIndex = 66;
            this.TimeTableLimit.SelectedIndexChanged += new System.EventHandler(this.TimeTableLimit_SelectedIndexChanged);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(352, 125);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(225, 20);
            this.label29.TabIndex = 67;
            this.label29.Text = "Chose Last Bell From Here";
            // 
            // Bell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Menu);
            this.Name = "Bell";
            this.Text = "Bell";
            this.Menu.ResumeLayout(false);
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            this.TimeTable.ResumeLayout(false);
            this.TimeTable.PerformLayout();
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FileWatcher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Menu;
        private System.Windows.Forms.TabPage Main;
        private System.Windows.Forms.TabPage TimeTable;
        private System.Windows.Forms.TabPage Settings;
        private System.Windows.Forms.Label NextBell;
        private System.Windows.Forms.Label CurrentTime;
        private System.Windows.Forms.Label DaysToRing;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CustomTimeTable;
        private System.Windows.Forms.Label PATTHText;
        private System.Windows.Forms.Button ChoseTheMusic;
        private System.IO.FileSystemWatcher FileWatcher;
        private System.Windows.Forms.Label CurrentTimeHolder;
        private System.Windows.Forms.Label TimeHolderN;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Timer Time;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button PlayTheMusic;
        private System.Windows.Forms.Label MPath;
        private System.Windows.Forms.Label MPathText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Bell13;
        private System.Windows.Forms.TextBox Bell12;
        private System.Windows.Forms.TextBox Bell11;
        private System.Windows.Forms.TextBox Bell10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Bell9;
        private System.Windows.Forms.TextBox Bell8;
        private System.Windows.Forms.TextBox Bell7;
        private System.Windows.Forms.TextBox Bell6;
        private System.Windows.Forms.TextBox Bell5;
        private System.Windows.Forms.TextBox Bell4;
        private System.Windows.Forms.TextBox Bell3;
        private System.Windows.Forms.TextBox Bell2;
        private System.Windows.Forms.TextBox Bell1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox Bell26;
        private System.Windows.Forms.TextBox Bell25;
        private System.Windows.Forms.TextBox Bell24;
        private System.Windows.Forms.TextBox Bell23;
        private System.Windows.Forms.TextBox Bell22;
        private System.Windows.Forms.TextBox Bell21;
        private System.Windows.Forms.TextBox Bell20;
        private System.Windows.Forms.TextBox Bell19;
        private System.Windows.Forms.TextBox Bell18;
        private System.Windows.Forms.TextBox Bell17;
        private System.Windows.Forms.TextBox Bell16;
        private System.Windows.Forms.TextBox Bell15;
        private System.Windows.Forms.TextBox Bell14;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox Days;
        private System.Windows.Forms.Label ToDayIs;
        private System.Windows.Forms.ListBox ChoseTheBell;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ListBox TimeTableLimit;
    }
}
