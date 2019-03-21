namespace BellV2
{
    partial class BellV2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Main = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.ToDaysBellStatus = new System.Windows.Forms.Label();
            this.TimeToNextBell = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NextBell = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CurrentTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TimeTables = new System.Windows.Forms.TabPage();
            this.AddTimeTable = new System.Windows.Forms.TabControl();
            this.TimeTable1 = new System.Windows.Forms.TabPage();
            this.AddTimeTableTab = new System.Windows.Forms.TabPage();
            this.Sounds = new System.Windows.Forms.TabPage();
            this.Settings = new System.Windows.Forms.TabPage();
            this.AddMoreTimeTable = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.AmountOfBellTTable = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.ChoseTheSound = new System.Windows.Forms.Button();
            this.SaveTheSound = new System.Windows.Forms.Button();
            this.l1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ChosedSound = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SaveDays = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabControl1.SuspendLayout();
            this.Main.SuspendLayout();
            this.TimeTables.SuspendLayout();
            this.AddTimeTable.SuspendLayout();
            this.TimeTable1.SuspendLayout();
            this.AddTimeTableTab.SuspendLayout();
            this.Sounds.SuspendLayout();
            this.Settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Main);
            this.tabControl1.Controls.Add(this.TimeTables);
            this.tabControl1.Controls.Add(this.Sounds);
            this.tabControl1.Controls.Add(this.Settings);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(760, 513);
            this.tabControl1.TabIndex = 0;
            // 
            // Main
            // 
            this.Main.Controls.Add(this.label7);
            this.Main.Controls.Add(this.ToDaysBellStatus);
            this.Main.Controls.Add(this.TimeToNextBell);
            this.Main.Controls.Add(this.label6);
            this.Main.Controls.Add(this.label5);
            this.Main.Controls.Add(this.label4);
            this.Main.Controls.Add(this.label3);
            this.Main.Controls.Add(this.NextBell);
            this.Main.Controls.Add(this.label2);
            this.Main.Controls.Add(this.CurrentTime);
            this.Main.Controls.Add(this.label1);
            this.Main.Location = new System.Drawing.Point(4, 22);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(752, 487);
            this.Main.TabIndex = 0;
            this.Main.Text = "Main";
            this.Main.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(269, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Choose the Next Bell from below";
            // 
            // ToDaysBellStatus
            // 
            this.ToDaysBellStatus.AutoSize = true;
            this.ToDaysBellStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDaysBellStatus.Location = new System.Drawing.Point(4, 64);
            this.ToDaysBellStatus.Name = "ToDaysBellStatus";
            this.ToDaysBellStatus.Size = new System.Drawing.Size(152, 20);
            this.ToDaysBellStatus.TabIndex = 9;
            this.ToDaysBellStatus.Text = "ToDaysBellStatus";
            // 
            // TimeToNextBell
            // 
            this.TimeToNextBell.AutoSize = true;
            this.TimeToNextBell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeToNextBell.Location = new System.Drawing.Point(178, 44);
            this.TimeToNextBell.Name = "TimeToNextBell";
            this.TimeToNextBell.Size = new System.Drawing.Size(133, 20);
            this.TimeToNextBell.TabIndex = 8;
            this.TimeToNextBell.Text = "TimeToNextBell";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(158, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(158, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Time To Next Bell";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(158, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = ":";
            // 
            // NextBell
            // 
            this.NextBell.AutoSize = true;
            this.NextBell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextBell.Location = new System.Drawing.Point(178, 24);
            this.NextBell.Name = "NextBell";
            this.NextBell.Size = new System.Drawing.Size(75, 20);
            this.NextBell.TabIndex = 3;
            this.NextBell.Text = "NextBell";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Next Bell";
            // 
            // CurrentTime
            // 
            this.CurrentTime.AutoSize = true;
            this.CurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentTime.Location = new System.Drawing.Point(178, 4);
            this.CurrentTime.Name = "CurrentTime";
            this.CurrentTime.Size = new System.Drawing.Size(107, 20);
            this.CurrentTime.TabIndex = 1;
            this.CurrentTime.Text = "CurrentTime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Time";
            // 
            // TimeTables
            // 
            this.TimeTables.Controls.Add(this.button2);
            this.TimeTables.Controls.Add(this.AddTimeTable);
            this.TimeTables.Location = new System.Drawing.Point(4, 22);
            this.TimeTables.Name = "TimeTables";
            this.TimeTables.Size = new System.Drawing.Size(752, 511);
            this.TimeTables.TabIndex = 1;
            this.TimeTables.Text = "Time Tables";
            this.TimeTables.UseVisualStyleBackColor = true;
            // 
            // AddTimeTable
            // 
            this.AddTimeTable.Controls.Add(this.TimeTable1);
            this.AddTimeTable.Controls.Add(this.AddTimeTableTab);
            this.AddTimeTable.Location = new System.Drawing.Point(-4, 0);
            this.AddTimeTable.Name = "AddTimeTable";
            this.AddTimeTable.SelectedIndex = 0;
            this.AddTimeTable.Size = new System.Drawing.Size(760, 479);
            this.AddTimeTable.TabIndex = 0;
            // 
            // TimeTable1
            // 
            this.TimeTable1.AutoScroll = true;
            this.TimeTable1.Controls.Add(this.label9);
            this.TimeTable1.Controls.Add(this.AmountOfBellTTable);
            this.TimeTable1.Controls.Add(this.label8);
            this.TimeTable1.Location = new System.Drawing.Point(4, 22);
            this.TimeTable1.Name = "TimeTable1";
            this.TimeTable1.Padding = new System.Windows.Forms.Padding(3);
            this.TimeTable1.Size = new System.Drawing.Size(752, 453);
            this.TimeTable1.TabIndex = 0;
            this.TimeTable1.Text = "Time Table 1";
            this.TimeTable1.UseVisualStyleBackColor = true;
            // 
            // AddTimeTableTab
            // 
            this.AddTimeTableTab.Controls.Add(this.AddMoreTimeTable);
            this.AddTimeTableTab.Location = new System.Drawing.Point(4, 22);
            this.AddTimeTableTab.Name = "AddTimeTableTab";
            this.AddTimeTableTab.Padding = new System.Windows.Forms.Padding(3);
            this.AddTimeTableTab.Size = new System.Drawing.Size(752, 453);
            this.AddTimeTableTab.TabIndex = 1;
            this.AddTimeTableTab.Text = ".....";
            this.AddTimeTableTab.UseVisualStyleBackColor = true;
            // 
            // Sounds
            // 
            this.Sounds.Controls.Add(this.ChosedSound);
            this.Sounds.Controls.Add(this.label11);
            this.Sounds.Controls.Add(this.l1);
            this.Sounds.Controls.Add(this.SaveTheSound);
            this.Sounds.Controls.Add(this.ChoseTheSound);
            this.Sounds.Location = new System.Drawing.Point(4, 22);
            this.Sounds.Name = "Sounds";
            this.Sounds.Size = new System.Drawing.Size(752, 511);
            this.Sounds.TabIndex = 2;
            this.Sounds.Text = "Sounds";
            this.Sounds.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.label12);
            this.Settings.Controls.Add(this.SaveDays);
            this.Settings.Controls.Add(this.label10);
            this.Settings.Location = new System.Drawing.Point(4, 22);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(752, 511);
            this.Settings.TabIndex = 3;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // AddMoreTimeTable
            // 
            this.AddMoreTimeTable.Location = new System.Drawing.Point(7, 7);
            this.AddMoreTimeTable.Name = "AddMoreTimeTable";
            this.AddMoreTimeTable.Size = new System.Drawing.Size(165, 23);
            this.AddMoreTimeTable.TabIndex = 0;
            this.AddMoreTimeTable.Text = "Add More Time Table";
            this.AddMoreTimeTable.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(306, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "How many bell do you want to ring? : ";
            // 
            // AmountOfBellTTable
            // 
            this.AmountOfBellTTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountOfBellTTable.Location = new System.Drawing.Point(315, 6);
            this.AmountOfBellTTable.Name = "AmountOfBellTTable";
            this.AmountOfBellTTable.Size = new System.Drawing.Size(100, 26);
            this.AmountOfBellTTable.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(342, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Please add the bell times in order? Use this fromat 15:15:00/HH:mm:ss ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 481);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(740, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Click Here To Save The Time Tables";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ChoseTheSound
            // 
            this.ChoseTheSound.Location = new System.Drawing.Point(3, 20);
            this.ChoseTheSound.Name = "ChoseTheSound";
            this.ChoseTheSound.Size = new System.Drawing.Size(126, 23);
            this.ChoseTheSound.TabIndex = 0;
            this.ChoseTheSound.Text = "Chose The Sound";
            this.ChoseTheSound.UseVisualStyleBackColor = true;
            // 
            // SaveTheSound
            // 
            this.SaveTheSound.Location = new System.Drawing.Point(135, 20);
            this.SaveTheSound.Name = "SaveTheSound";
            this.SaveTheSound.Size = new System.Drawing.Size(114, 23);
            this.SaveTheSound.TabIndex = 1;
            this.SaveTheSound.Text = "Save The sound";
            this.SaveTheSound.UseVisualStyleBackColor = true;
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(3, 4);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(77, 13);
            this.l1.TabIndex = 2;
            this.l1.Text = "Chosed Sound";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(86, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = ":";
            // 
            // ChosedSound
            // 
            this.ChosedSound.AutoSize = true;
            this.ChosedSound.Location = new System.Drawing.Point(102, 4);
            this.ChosedSound.Name = "ChosedSound";
            this.ChosedSound.Size = new System.Drawing.Size(74, 13);
            this.ChosedSound.TabIndex = 5;
            this.ChosedSound.Text = "ChosedSound";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Chose days to ring bells";
            // 
            // SaveDays
            // 
            this.SaveDays.Location = new System.Drawing.Point(164, 50);
            this.SaveDays.Name = "SaveDays";
            this.SaveDays.Size = new System.Drawing.Size(75, 23);
            this.SaveDays.TabIndex = 1;
            this.SaveDays.Text = "Save";
            this.SaveDays.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(39, 92);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(184, 65);
            this.label12.TabIndex = 2;
            this.label12.Text = "Days time Table save\r\nWeek days,  Specific Days.\r\nDays\t\tDay Picker\r\nSave\r\nAdd exc" +
    "eptional days to not ring save\r\n";
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // BellV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Name = "BellV2";
            this.Text = "eHiT Bell System";
            this.tabControl1.ResumeLayout(false);
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            this.TimeTables.ResumeLayout(false);
            this.AddTimeTable.ResumeLayout(false);
            this.TimeTable1.ResumeLayout(false);
            this.TimeTable1.PerformLayout();
            this.AddTimeTableTab.ResumeLayout(false);
            this.Sounds.ResumeLayout(false);
            this.Sounds.PerformLayout();
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Main;
        private System.Windows.Forms.TabPage TimeTables;
        private System.Windows.Forms.TabPage Sounds;
        private System.Windows.Forms.TabPage Settings;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ToDaysBellStatus;
        private System.Windows.Forms.Label TimeToNextBell;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label NextBell;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CurrentTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl AddTimeTable;
        private System.Windows.Forms.TabPage TimeTable1;
        private System.Windows.Forms.TabPage AddTimeTableTab;
        private System.Windows.Forms.Button AddMoreTimeTable;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox AmountOfBellTTable;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label ChosedSound;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Button SaveTheSound;
        private System.Windows.Forms.Button ChoseTheSound;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button SaveDays;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}