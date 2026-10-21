using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace sdf1
{
    public partial class Form1 : Form
    {
        IStudentService service = new StudentService();

        public Form1()
        {
            InitializeComponent();

            elaveet.Click -= elaveet_Click;
            elaveet.Click += elaveet_Click;

            qiymetyaz.Click -= qiymetyaz_Click;
            qiymetyaz.Click += qiymetyaz_Click;

            butuntelebeler.Click -= butuntelebeler_Click;
            butuntelebeler.Click += butuntelebeler_Click;

            goster.Click -= goster_Click;
            goster.Click += goster_Click;

            cixis.Click -= cixis_Click;
            cixis.Click += cixis_Click;

            this.FormClosing += Form1_FormClosing;

            ShowPanel(pnlStudent);
        }

        private void ShowPanel(Panel panel)
        {
            pnlStudent.Visible = false;
            pnlGrade.Visible = false;
            pnlStatistics.Visible = false;

            panel.Visible = true;
            panel.BringToFront();
        }

        private void tələbəToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlStudent);
        }

        private void telebeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlStudent);
        }

        private void elaveet_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlStudent);
        }

        private void qiymetyaz_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlGrade);
        }

        private void goster_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlStatistics);
        }

        private void btnSaveStudent_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text.Trim();
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();

            int age;

            if (code == "" || firstName == "" || lastName == "")
            {
                MessageBox.Show("Bütün məlumatları daxil edin!");
                return;
            }

            if (!int.TryParse(txtAge.Text, out age) || age <= 0)
            {
                MessageBox.Show("Yaşı düzgün daxil edin!");
                return;
            }

            Student student = new Student();

            student.Code = code;
            student.FirstName = firstName;
            student.LastName = lastName;
            student.Age = age;

            bool result = service.AddStudent(student);

            if (result == true)
            {
                MessageBox.Show("Tələbə uğurla əlavə edildi!");

                txtCode.Clear();
                txtFirstName.Clear();
                txtLastName.Clear();
                txtAge.Clear();
            }
            else
            {
                MessageBox.Show("Bu kodla tələbə artıq mövcuddur!");
            }
        }

        private void btnSaveGrade_Click(object sender, EventArgs e)
        {
            string code = txtGradeStudentCode.Text.Trim();
            string subject = txtSubject.Text.Trim();

            int score;

            if (code == "" || subject == "")
            {
                MessageBox.Show("Bütün məlumatları daxil edin!");
                return;
            }

            if (!int.TryParse(txtScore.Text, out score))
            {
                MessageBox.Show("Qiymət düzgün daxil edilməyib!");
                return;
            }

            if (score < 0 || score > 100)
            {
                MessageBox.Show("Qiymət 0-100 arasında olmalıdır!");
                return;
            }

            bool result = service.AddGrade(code, subject, score);

            if (result == true)
            {
                MessageBox.Show("Qiymət uğurla əlavə edildi!");

                txtSubject.Clear();
                txtScore.Clear();
            }
            else
            {
                MessageBox.Show("Bu kodla tələbə tapılmadı!");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string code = txtSearchCode.Text.Trim();

            Student student = service.FindStudent(code);

            if (student == null)
            {
                MessageBox.Show("Bu kodla tələbə tapılmadı!");
                txtStatsResult.Clear();
                return;
            }

            string result = "";

            result += "Kod: " + student.Code + Environment.NewLine;
            result += "Ad: " + student.FirstName + Environment.NewLine;
            result += "Soyad: " + student.LastName + Environment.NewLine;
            result += "Yaş: " + student.Age + Environment.NewLine;

            result += Environment.NewLine;
            result += "QİYMƏTLƏR:" + Environment.NewLine;

            List<Grade> grades = service.GetStudentGrades(code);

            if (grades == null || grades.Count == 0)
            {
                result += "Qiymət yoxdur.";
            }
            else
            {
                foreach (Grade grade in grades)
                {
                    result += grade.Subject + ": " +
                              grade.Score + Environment.NewLine;
                }
            }

            txtStatsResult.Text = result;
        }

        private void butuntelebeler_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlStatistics);

            List<Student> students = service.GetAllStudents();

            string result = "BÜTÜN TƏLƏBƏLƏR";
            result += Environment.NewLine;
            result += "---------------------";
            result += Environment.NewLine;

            if (students.Count == 0)
            {
                result += "Tələbə yoxdur.";
            }
            else
            {
                foreach (Student student in students)
                {
                    result += student.Code + " - " +
                              student.FirstName + " " +
                              student.LastName + Environment.NewLine;
                }
            }

            txtStatsResult.Text = result;
        }

        private void cixis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Proqramdan çıxmaq istəyirsiniz?",
                "Çıxış",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}