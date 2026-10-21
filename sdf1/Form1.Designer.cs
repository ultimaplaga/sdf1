namespace sdf1
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.telebe = new System.Windows.Forms.ToolStripMenuItem();
            this.elaveet = new System.Windows.Forms.ToolStripMenuItem();
            this.qiymetyaz = new System.Windows.Forms.ToolStripMenuItem();
            this.butuntelebeler = new System.Windows.Forms.ToolStripMenuItem();
            this.statistika = new System.Windows.Forms.ToolStripMenuItem();
            this.goster = new System.Windows.Forms.ToolStripMenuItem();
            this.cixis = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlStudent = new System.Windows.Forms.Panel();
            this.btnSaveStudent = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.pnlGrade = new System.Windows.Forms.Panel();
            this.btnSaveGrade = new System.Windows.Forms.Button();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.txtGradeStudentCode = new System.Windows.Forms.TextBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblGradeCode = new System.Windows.Forms.Label();
            this.pnlStatistics = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtStatsResult = new System.Windows.Forms.TextBox();
            this.txtSearchCode = new System.Windows.Forms.TextBox();
            this.lblSearchCode = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlStudent.SuspendLayout();
            this.pnlGrade.SuspendLayout();
            this.pnlStatistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.telebe,
            this.statistika,
            this.cixis});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1175, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // telebe
            // 
            this.telebe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.elaveet,
            this.qiymetyaz,
            this.butuntelebeler});
            this.telebe.Name = "telebe";
            this.telebe.Size = new System.Drawing.Size(68, 26);
            this.telebe.Text = "Tələbə";
            this.telebe.Click += new System.EventHandler(this.tələbəToolStripMenuItem_Click);
            // 
            // elaveet
            // 
            this.elaveet.Name = "elaveet";
            this.elaveet.Size = new System.Drawing.Size(193, 26);
            this.elaveet.Text = "Əlavə et";
            // 
            // qiymetyaz
            // 
            this.qiymetyaz.Name = "qiymetyaz";
            this.qiymetyaz.Size = new System.Drawing.Size(193, 26);
            this.qiymetyaz.Text = "Qiymət yaz";
            // 
            // butuntelebeler
            // 
            this.butuntelebeler.Name = "butuntelebeler";
            this.butuntelebeler.Size = new System.Drawing.Size(193, 26);
            this.butuntelebeler.Text = "Bütün tələbələr";
            // 
            // statistika
            // 
            this.statistika.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goster});
            this.statistika.Name = "statistika";
            this.statistika.Size = new System.Drawing.Size(83, 26);
            this.statistika.Text = "Statistika";
            // 
            // goster
            // 
            this.goster.Name = "goster";
            this.goster.Size = new System.Drawing.Size(224, 26);
            this.goster.Text = "Göstər";
            // 
            // cixis
            // 
            this.cixis.Name = "cixis";
            this.cixis.Size = new System.Drawing.Size(53, 26);
            this.cixis.Text = "Çıxış";
            // 
            // pnlStudent
            // 
            this.pnlStudent.Controls.Add(this.btnSaveStudent);
            this.pnlStudent.Controls.Add(this.txtAge);
            this.pnlStudent.Controls.Add(this.txtLastName);
            this.pnlStudent.Controls.Add(this.txtFirstName);
            this.pnlStudent.Controls.Add(this.txtCode);
            this.pnlStudent.Controls.Add(this.lblAge);
            this.pnlStudent.Controls.Add(this.lblLastName);
            this.pnlStudent.Controls.Add(this.lblFirstName);
            this.pnlStudent.Controls.Add(this.lblCode);
            this.pnlStudent.Location = new System.Drawing.Point(20, 40);
            this.pnlStudent.Name = "pnlStudent";
            this.pnlStudent.Size = new System.Drawing.Size(409, 195);
            this.pnlStudent.TabIndex = 1;
            // 
            // btnSaveStudent
            // 
            this.btnSaveStudent.Location = new System.Drawing.Point(307, 160);
            this.btnSaveStudent.Name = "btnSaveStudent";
            this.btnSaveStudent.Size = new System.Drawing.Size(75, 23);
            this.btnSaveStudent.TabIndex = 8;
            this.btnSaveStudent.Text = "əlavə et";
            this.btnSaveStudent.UseVisualStyleBackColor = true;
            this.btnSaveStudent.Click += new System.EventHandler(this.btnSaveStudent_Click);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(206, 132);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 22);
            this.txtAge.TabIndex = 7;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(206, 102);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 22);
            this.txtLastName.TabIndex = 6;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(206, 67);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 22);
            this.txtFirstName.TabIndex = 5;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(206, 26);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 22);
            this.txtCode.TabIndex = 4;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(16, 132);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(31, 16);
            this.lblAge.TabIndex = 3;
            this.lblAge.Text = "Yaş";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(16, 102);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(47, 16);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Soyad";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(16, 67);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(24, 16);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "Ad";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(10, 26);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(84, 16);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "Tələbə kodu";
            // 
            // pnlGrade
            // 
            this.pnlGrade.Controls.Add(this.btnSaveGrade);
            this.pnlGrade.Controls.Add(this.txtSubject);
            this.pnlGrade.Controls.Add(this.txtScore);
            this.pnlGrade.Controls.Add(this.txtGradeStudentCode);
            this.pnlGrade.Controls.Add(this.lblScore);
            this.pnlGrade.Controls.Add(this.lblSubject);
            this.pnlGrade.Controls.Add(this.lblGradeCode);
            this.pnlGrade.Location = new System.Drawing.Point(20, 40);
            this.pnlGrade.Name = "pnlGrade";
            this.pnlGrade.Size = new System.Drawing.Size(500, 180);
            this.pnlGrade.TabIndex = 2;
            // 
            // btnSaveGrade
            // 
            this.btnSaveGrade.Location = new System.Drawing.Point(393, 142);
            this.btnSaveGrade.Name = "btnSaveGrade";
            this.btnSaveGrade.Size = new System.Drawing.Size(75, 23);
            this.btnSaveGrade.TabIndex = 6;
            this.btnSaveGrade.Text = " əlavə et";
            this.btnSaveGrade.UseVisualStyleBackColor = true;
            this.btnSaveGrade.Click += new System.EventHandler(this.btnSaveGrade_Click);
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(200, 56);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(100, 22);
            this.txtSubject.TabIndex = 5;
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(200, 84);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(100, 22);
            this.txtScore.TabIndex = 4;
            // 
            // txtGradeStudentCode
            // 
            this.txtGradeStudentCode.Location = new System.Drawing.Point(200, 26);
            this.txtGradeStudentCode.Name = "txtGradeStudentCode";
            this.txtGradeStudentCode.Size = new System.Drawing.Size(100, 22);
            this.txtGradeStudentCode.TabIndex = 3;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(40, 82);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(49, 16);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Qiymət";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(40, 54);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(37, 16);
            this.lblSubject.TabIndex = 1;
            this.lblSubject.Text = "Fənn";
            // 
            // lblGradeCode
            // 
            this.lblGradeCode.AutoSize = true;
            this.lblGradeCode.Location = new System.Drawing.Point(40, 26);
            this.lblGradeCode.Name = "lblGradeCode";
            this.lblGradeCode.Size = new System.Drawing.Size(84, 16);
            this.lblGradeCode.TabIndex = 0;
            this.lblGradeCode.Text = "Tələbə kodu";
            // 
            // pnlStatistics
            // 
            this.pnlStatistics.Controls.Add(this.btnSearch);
            this.pnlStatistics.Controls.Add(this.txtStatsResult);
            this.pnlStatistics.Controls.Add(this.txtSearchCode);
            this.pnlStatistics.Controls.Add(this.lblSearchCode);
            this.pnlStatistics.Location = new System.Drawing.Point(20, 40);
            this.pnlStatistics.Name = "pnlStatistics";
            this.pnlStatistics.Size = new System.Drawing.Size(409, 169);
            this.pnlStatistics.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(307, 128);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Axtar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtStatsResult
            // 
            this.txtStatsResult.Location = new System.Drawing.Point(190, 64);
            this.txtStatsResult.Multiline = true;
            this.txtStatsResult.Name = "txtStatsResult";
            this.txtStatsResult.ReadOnly = true;
            this.txtStatsResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStatsResult.Size = new System.Drawing.Size(500, 180);
            this.txtStatsResult.TabIndex = 2;
            // 
            // txtSearchCode
            // 
            this.txtSearchCode.Location = new System.Drawing.Point(190, 25);
            this.txtSearchCode.Name = "txtSearchCode";
            this.txtSearchCode.Size = new System.Drawing.Size(100, 22);
            this.txtSearchCode.TabIndex = 1;
            // 
            // lblSearchCode
            // 
            this.lblSearchCode.AutoSize = true;
            this.lblSearchCode.Location = new System.Drawing.Point(19, 25);
            this.lblSearchCode.Name = "lblSearchCode";
            this.lblSearchCode.Size = new System.Drawing.Size(84, 16);
            this.lblSearchCode.TabIndex = 0;
            this.lblSearchCode.Text = "Tələbə kodu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 544);
            this.Controls.Add(this.pnlStatistics);
            this.Controls.Add(this.pnlGrade);
            this.Controls.Add(this.pnlStudent);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telebe qiymet sdf";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlStudent.ResumeLayout(false);
            this.pnlStudent.PerformLayout();
            this.pnlGrade.ResumeLayout(false);
            this.pnlGrade.PerformLayout();
            this.pnlStatistics.ResumeLayout(false);
            this.pnlStatistics.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem telebe;
        private System.Windows.Forms.ToolStripMenuItem statistika;
        private System.Windows.Forms.ToolStripMenuItem cixis;
        private System.Windows.Forms.ToolStripMenuItem elaveet;
        private System.Windows.Forms.ToolStripMenuItem qiymetyaz;
        private System.Windows.Forms.ToolStripMenuItem butuntelebeler;
        private System.Windows.Forms.ToolStripMenuItem goster;
        private System.Windows.Forms.Panel pnlStudent;
        private System.Windows.Forms.Button btnSaveStudent;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Panel pnlGrade;
        private System.Windows.Forms.Button btnSaveGrade;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.TextBox txtGradeStudentCode;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblGradeCode;
        private System.Windows.Forms.Panel pnlStatistics;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtStatsResult;
        private System.Windows.Forms.TextBox txtSearchCode;
        private System.Windows.Forms.Label lblSearchCode;
    }
}

