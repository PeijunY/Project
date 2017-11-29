using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuckyDraw
{
    public partial class FrmDraw : Form
    {
        List<Colleague> objList = new List<Colleague>();
        int first = 0, second = 0, third = 0;
        string LuckyNameFile = "LuckyNameList.txt";
        string AbsenceNameFile = "AbsenceNameList.txt";
        //?
        int MaxValue=100;
        static Random random = new Random();
        public FrmDraw()
        {
            InitializeComponent();
        }

        private void btnAddPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog objOpenFile = new OpenFileDialog();
            objOpenFile.Filter = "所有文件|*.*";
            if (objOpenFile.ShowDialog() == DialogResult.OK)
            {
                //把文件的完整路径显示在文本框中
                this.tbxShowPath.Text = objOpenFile.FileName;
            }
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            //读取数据
            string ColleagueInfo = System.IO.File.ReadAllText(this.tbxShowPath.Text, Encoding.Default);

            //把读取的数据分割成一条一条记录(行数据)
            string[] ColleagueArray = ColleagueInfo.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string item in ColleagueArray)
            {
                //把每条记录的信息读取出来
                string[] ColleagueDetailArray = item.Split(',');

                Colleague objColleague = new Colleague
                {
                    CNum = int.Parse(ColleagueDetailArray[0]),
                    CApartment = ColleagueDetailArray[1],
                    CName = ColleagueDetailArray[2],
                    CEnglishName = ColleagueDetailArray[3],
                };
                objList.Add(objColleague);
            }
            //把数据展示在表格中
            this.dgvColleagueInfo.DataSource = null;
            this.dgvColleagueInfo.AutoGenerateColumns = false;
            this.dgvColleagueInfo.DataSource = objList;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {            
            random = new Random((int)DateTime.Now.Ticks);
            switch (comboxNum.Text)
            {
                case "1":                   
                    //ShowName(CollName);
                    this.lblRand01.Text = objList[random.Next(1, MaxValue)].CName;
                    break;
                case "2":
                    RandomNum();
                    this.lblRand01.Text = objList[first].CName;
                    this.lblRand02.Text = objList[second].CName;
                    break;
                case "3":
                    RandomNum();
                    this.lblRand01.Text = objList[first].CName;
                    this.lblRand02.Text = objList[second].CName;
                    this.lblRand03.Text = objList[third].CName;
                    break;
                default:
                    break;
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            this.timer1.Interval = 1000;
            this.timer1.Start();
            //if (timer1.Enabled)
            //{
                
            //}
        }
        private void btnAddName_Click(object sender, EventArgs e)
        {            
            if (!this.AwardList.Items.Contains(this.lblRand01.Text)&& !this.AbsenceList.Items.Contains(this.lblRand01.Text) && this.lblRand01.Text!="-")
            {
                this.AwardList.Items.Add(this.lblRand01.Text);
            }
            if (!this.AwardList.Items.Contains(this.lblRand02.Text) && !this.AbsenceList.Items.Contains(this.lblRand02.Text) && this.lblRand02.Text != "-")
            {
                this.AwardList.Items.Add(this.lblRand02.Text);
            }
            if (!this.AwardList.Items.Contains(this.lblRand03.Text) && !this.AbsenceList.Items.Contains(this.lblRand03.Text) && this.lblRand03.Text != "-")
            {
                this.AwardList.Items.Add(this.lblRand03.Text);
            }
        }

        private void btnRemoveto_Click(object sender, EventArgs e)
        {
            if (this.AwardList.Items.Count == 0)
            {
                MessageBox.Show("There is no one won!", "系统信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (this.AwardList.SelectedItems.Count==0)
            {
                MessageBox.Show("There is no one selected!", "系统信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(!this.AbsenceList.Items.Contains(AwardList.SelectedItem))
            {
                this.AbsenceList.Items.Add(AwardList.SelectedItem);
                this.AwardList.Items.Remove(AwardList.SelectedItem);
            }

        }

        private void btnSaveName_Click(object sender, EventArgs e)
        {
            // If the file exists, loop all items in AwardList, then write into 'LuckyNameFile.txt'.
            // true means 'append'
            StreamWriter sw = new StreamWriter(LuckyNameFile,true,Encoding.Default);
            //string line;
            for (int i = 0; i < AwardList.Items.Count; i++)
            {
                sw.WriteLine(AwardList.Items[i].ToString());                     
            }
            sw.Flush();
            sw.Close();
        }

        private void btnNameload_Click(object sender, EventArgs e)
        {
            if (File.Exists(LuckyNameFile))
            {
                StreamReader sr = new StreamReader(LuckyNameFile,Encoding.Default);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    AwardList.Items.Add(line);
                }
                sr.Close();
            }
        }

        private void btnAbsenceNameSave_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(AbsenceNameFile, true, Encoding.Default);
            for (int i = 0; i < AbsenceList.Items.Count; i++)
            {
                sw.WriteLine(AbsenceList.Items[i].ToString());
            }
            sw.Flush();
            sw.Close();
        }

        private void btnAbsenNameLoad_Click(object sender, EventArgs e)
        {
            if (File.Exists(LuckyNameFile))
            {
                StreamReader sr = new StreamReader(AbsenceNameFile, Encoding.Default);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    AbsenceList.Items.Add(line);
                }
                sr.Close();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        public void RandomNum()
        {           
            for (int i = 0; i < int.Parse(comboxNum.Text); i++)
            {
                first = random.Next(1, MaxValue);
                TrySecond:
                second = random.Next(1, MaxValue);
                third = random.Next(1, MaxValue);
                if (second==first|| third==first||third==second)
                {
                    goto TrySecond;
                }
            }
        }
    }
}
