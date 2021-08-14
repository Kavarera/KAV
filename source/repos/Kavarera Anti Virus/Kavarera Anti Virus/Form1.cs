using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Security.AccessControl;
using System.Security.Principal;
using System.IO;

namespace Kavarera_Anti_Virus
{
    public partial class Form1 : Form
    {
         

        bool scan, Password, Settings;
        bool drive1bool, drive2bool, drive3bool, drive4bool, drive5bool, drive6bool=false;
        int DirCount = 0;
        string[] direk;
        string namafilemd5,lokasifile;


        private void drive3btn_Click(object sender, EventArgs e)
        {
            if(drive3bool==false)
            {
                drive3bool = true;
                drive3btn.BackColor = Color.Green;
            }
            else
            {
                drive3bool = false;
                drive3btn.BackColor = Color.FromArgb(58, 58, 58);
            }
        }

        private void drive1btn_Click(object sender, EventArgs e)
        {
            if(drive1bool==false)
            {
                drive1bool = true;
                drive1btn.BackColor = Color.Green;
            }
            else
            {
                drive1bool = false;
                drive1btn.BackColor = Color.FromArgb(58, 58, 58);
            }
        }

        private void drive2btn_Click(object sender, EventArgs e)
        {
            if(drive2bool)
            {
                drive2bool = false;
                drive2btn.BackColor = Color.FromArgb(58, 58, 58);
            }
            else
            {
                drive2bool = true;
                drive2btn.BackColor = Color.Green;
            }
        }

        private void drive4btn_Click(object sender, EventArgs e)
        {
            if(drive4bool)
            {
                drive4bool = false;
                drive4btn.BackColor = Color.FromArgb(58, 58, 58);
            }
            else
            {
                drive4bool = true;
                drive4btn.BackColor = Color.Green;
            }
        }

        
        private void Browse_scanbtn_Click(object sender, EventArgs e)
        {
            //sudah

            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog()==DialogResult.OK)
            {
                namafilemd5 = GetMD5FromFile(ofd.FileName);
                Location_tb.Text = Path.GetFullPath(ofd.FileName);
                lokasifile = Path.GetFullPath(ofd.FileName);
            }

        }

        int pewaktu1=0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            pewaktu1 = pewaktu1 + 1;
            ADlbl.Show();
            if(pewaktu1==10)
            {
                ADlbl.Hide();
            }
        }

        string filedirektori;

        private void scanbtn_Click(object sender, EventArgs e)
        {

        }

        private void Settingsbtn_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("suksess");
        }

        private void Scanscanbtn_Click(object sender, EventArgs e)
        {
            
            
            if(FileRB.Checked)
            {
                if (Location_tb.Text == lokasifile)
                {
                    MessageBox.Show(lokasifile);
                }
                

                else
                {
                    MessageBox.Show("File Location is not detected,if you\ndont know it, please use Browse Button", "ERROR");
                }

            }
            if(DirRB.Checked)
            {
                string lokasidirek;
                string filenya;
                if(DirCount==2)
                {
                    /*lokasidirek = direk[0];
                    MessageBox.Show(lokasidirek);
                    string jumlahfile;
                    jumlahfile = Path.GetFileName(lokasidirek);
                    MessageBox.Show(Path.GetFileName(direk[0]));
                    foreach (int itungfile in Path.GetFileName(lokasidirek))
                    {
                        filenya = jumlahfile;
                        filenya = GetMD5FromFile(jumlahfile);
                        MessageBox.Show(filenya);
                    }*/
                    lokasidirek = direk[0];

                    string[] files = Directory.GetFiles(lokasidirek);
                    
                    string[] dirs = Directory.GetDirectories(lokasidirek, "*", SearchOption.AllDirectories);
                    
                    int virus =0;
                    int hiddenfile = 0;
                    foreach(string file in files)
                    {
                        if (file.Contains(".sys"))
                        {
                            hiddenfile++;
                        }
                        else
                        {
                            string encfile = GetMD5FromFile(file);
                            MessageBox.Show(file, virus.ToString());
                            virus++;
                            MessageBox.Show(encfile, "virus detected:"+virus + 1.ToString());
                        }
                    }

                    int dirss = 0;
                    int dirss1 = 0;
                    
                    int DirFiVirus = 0;
                    foreach(string dir in dirs)
                    {
                        if (dirs.Contains("C:'\'Documents and Settings"))
                        {
                            
                        }
                        MessageBox.Show(dir, dirss.ToString());

                        /*foreach(string dir1 in Directory.GetFiles(dir))
                        {
                            MessageBox.Show("Direcotry1", "Nama file : " + dir1 + "Di direktori : " + dirs);
                        }
                        foreach(string file1 in Directory.GetDirectories(dir))
                        {

                        }*/
                        dirss++;
                    }
                }
            }
        }


        public Form1()
        {
            InitializeComponent();
            Panel_Scan.Hide();
            DirectoryScan();
            ADlbl.Hide();
        }

        
        public string GetMD5FromFile(string lokasifile)
        {
            //sudah

            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(lokasifile))
                {
                    return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-",string.Empty).ToLower();
                }
            }
        }
      


        public void DirectoryScan()
        {
            //sudah
            DriveInfo[] Driverlist = DriveInfo.GetDrives();
            
            foreach (DriveInfo D in Driverlist)
            {
                DirCount = DirCount + 1;
            }
            
            direk = new string[DirCount];
            
            DirCount = 0;
            foreach(DriveInfo D in Driverlist)
            {
                direk[DirCount] = D.Name;
                MessageBox.Show(direk[DirCount]);
                
                DirCount = DirCount + 1;
                
            }
            

            
        }
        private void Closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Scan_Click(object sender, EventArgs e)
        {
            //sudah

            DirtotalLabel.Text = "Total Drive : ";
            DirRB.Checked = false;
            FileRB.Checked = true;
            Panel_Scan.Show();
            scan = true;
            Location_tb.Show();
            Location_label.Show();
            Browse_scanbtn.Show();
            DirtotalLabel.Text += DirCount.ToString();
            drive1btn.Hide();
            drive2btn.Hide();
            drive3btn.Hide();
            drive4btn.Hide();
            scanbtn.Update();
            Scanlabel.Update();
            if(DirCount>4)
            {
                timer1.Start();
                MessageBox.Show("More than 4 drive is detected!\nWe just support 4 drive", "Another Driver is detected");
            }
        }
        private void ExitPanel_Click(object sender, EventArgs e)
        {
            if(scan)
            {
                Panel_Scan.Hide();
                scan = false;
            }
            if(Password)
            {
                
            }
            if (Settings)
            {

            }
            else
            {
                panel_bawah.Show();
            }
        }
        private void FileOption_Scan_Click(object sender, EventArgs e)
        {
            //sudah
            if(FileRB.Checked)
            {
                Location_tb.Show();
                Location_label.Show();
                Browse_scanbtn.Show();
                drive1btn.Hide();
                drive2btn.Hide();
                drive3btn.Hide();
                drive4btn.Hide();
                
            }
            if(DirRB.Checked)
            {
                Location_label.Hide();
                Location_tb.Hide();
                Browse_scanbtn.Hide();

                if(DirCount==1)
                {
                    drive1btn.Show();
                    drive1btn.Text = direk[0];
                }
                if(DirCount==2)
                {
                    drive1btn.Show();
                    drive2btn.Show();
                    drive1btn.Text = direk[0];
                    drive2btn.Text = direk[1];
                }
                if(DirCount==3)
                {
                    drive1btn.Show();
                    drive2btn.Show();
                    drive1btn.Text = direk[2];
                    drive2btn.Text = direk[1];
                    drive3btn.Show();
                    drive3btn.Text = direk[0];

                }
                if(DirCount==4)
                {
                    drive1btn.Show();
                    drive2btn.Show();
                    drive1btn.Text = direk[1];
                    drive2btn.Text = direk[2];
                    drive3btn.Show();
                    drive3btn.Text = direk[0];
                    drive4btn.Show();
                    drive4btn.Text = direk[3];
                    drive4bool = true;
                    drive3bool = false;
                    drive2bool = false;
                    drive1bool = false;
                }
            }
        }
        
        
    }
}
