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

namespace SrtCombine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "选择字幕文件";
            ofd.Filter = "(*.vtt;*.srt;*.txt) | *.vtt;*.srt;*.txt";
            ofd.ShowDialog();
            filePath1.Text = ofd.FileName;
            if (uf1.Checked)
                SetSaveName(filePath1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "选择字幕文件";
            ofd.Filter = "(*.vtt;*.srt;*.txt) | *.vtt;*.srt;*.txt";
            ofd.ShowDialog();
            filePath2.Text = ofd.FileName;
            if (uf2.Checked)
                SetSaveName(filePath2.Text);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "保存字幕文件";
            sfd.Filter = "(*.vtt;*.srt;*.txt) | *.vtt;*.srt;*.txt";
            sfd.ShowDialog();
            sfd.RestoreDirectory = true;
            SavePath.Text = sfd.FileName;
        }

        private void uf1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSaveSetting();
        }

        private void UpdateSaveSetting()
        {
            if (uf1.Checked || uf2.Checked)
            {
                SavePath.Enabled = false;
                SaveButton.Enabled = false;
                if (uf1.Checked)
                    SetSaveName(filePath1.Text);
                else if (uf2.Checked)
                    SetSaveName(filePath2.Text);
            }
            else
            {
                SavePath.Enabled = true;
                SaveButton.Enabled = true;
            }
        }

        private void SetSaveName(string fileName)
        {
            if (!string.IsNullOrEmpty(fileName))
            {
                if (checkBox1.Checked)
                {
                    string name, suffix;
                    int lastPos = fileName.LastIndexOf('.');
                    name = fileName.Substring(0, lastPos);
                    suffix = fileName.Substring(lastPos);
                    SavePath.Text = name + "_combine" + suffix;
                }
                else
                    SavePath.Text = fileName;
            }
        }

        private void uf2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSaveSetting();
        }

        private void uf3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSaveSetting();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filePath1.Text) || string.IsNullOrEmpty(filePath2.Text))
                MessageBox.Show("源文件地址无效");
            else if (!File.Exists(filePath1.Text) || !File.Exists(filePath2.Text))
                MessageBox.Show("源文件不存在");
            else
            {
                StreamReader sr1 = new StreamReader(filePath1.Text);
                StreamReader sr2 = new StreamReader(filePath2.Text);
                if (File.Exists(SavePath.Text + ".tmp"))
                    File.Delete(SavePath.Text + ".tmp");
                StreamWriter sw = new StreamWriter(SavePath.Text + ".tmp");
                string line1;
                string line2;
                while((line1 = sr1.ReadLine()) != null && (line2 = sr2.ReadLine()) !=null)
                {
                    if (line1.Contains("-->") || line2.Contains("-->"))
                        sw.WriteLine(line1); 
                    else if (line1 != line2)
                    {
                        sw.WriteLine(line1);
                        sw.WriteLine(line2);
                    }
                    else
                        sw.WriteLine(line1);
                }
                sw.Close();
                sr1.Close();
                sr2.Close();
                if(!checkBox1.Checked)
                {
                    File.Delete(filePath1.Text);
                    File.Delete(filePath2.Text);
                }
                FileInfo fi = new FileInfo(SavePath.Text + ".tmp");
                fi.MoveTo(SavePath.Text);
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (uf1.Checked && !string.IsNullOrEmpty(filePath1.Text))
                SetSaveName(filePath1.Text);
            else if (uf2.Checked && !string.IsNullOrEmpty(filePath2.Text))
                SetSaveName(filePath2.Text);
        }
    }
}
