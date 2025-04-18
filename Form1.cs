using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Deployment;
using System.Deployment.Application;

namespace TFMusic_New
{
    public partial class Form1 : Form
    {

        Timer trkBar_Update = new Timer();
        string Volume = string.Empty;

        public Form1()
        {
            InitializeComponent();            
            
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public const int WM_LBUTTONDOWN = 0x0201;

        #region Arrastar Form sem borda
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_LBUTTONDOWN)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        private void btMudo_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.settings.mute)
            {
                axWindowsMediaPlayer1.settings.mute = false;
                btMudo.Image = TFMusic_New.Properties.Resources.MuteOn;
            }
            else if (!axWindowsMediaPlayer1.settings.mute)
            {
                axWindowsMediaPlayer1.settings.mute = true;
                btMudo.Image = TFMusic_New.Properties.Resources.Mute;
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.Ctlcontrols.currentPosition = this.trackBar2.Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
            trackBar2.Maximum = Convert.ToInt32(axWindowsMediaPlayer1.currentMedia.duration);//novo

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void btFrente_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.next();
            trackBar2.Maximum = Convert.ToInt32(axWindowsMediaPlayer1.currentMedia.duration);//novo
        }

        private void btTras_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.previous();
            trackBar2.Maximum = Convert.ToInt32(axWindowsMediaPlayer1.currentMedia.duration);//novo
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.settings.volume = trackBar1.Value;
            this.lblVolume.Text = trackBar1.Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region AtualizacaoOnline
            // Atualizar versao online
            if (ApplicationDeployment.IsNetworkDeployed)
            {
                if (ApplicationDeployment.CurrentDeployment.CurrentVersion != ApplicationDeployment.CurrentDeployment.UpdatedVersion)
                {
                    Application.ExitThread();
                    Application.Restart();
                }
            }
            #endregion
            //Version myVersion;
            //http://www.andrealveslima.com.br/blog/index.php/2017/06/21/como-atualizar-aplicacoes-net-automaticamente/
            if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
            {
                ApplicationDeployment cd = ApplicationDeployment.CurrentDeployment;
                string publishVersion = cd.CurrentVersion.ToString();
                // show publish version in title or About box...
            }
            System.Version version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            string sVersion = String.Format("{0}.{1}.{2}.{3}", version.Major, version.Minor, version.Build, version.Revision);

            this.lblVersao.Text = "V"+ sVersion;

            GeraInfo GeraInfo = new GeraInfo();
            string caminho = string.Empty;
            string text2 = string.Empty;
            //ArrayList nowPlaylist = new ArrayList();
            string[] TFMusicVolume = new string[1];
            TFMusicVolume[0] = "70";
            if (Environment.UserName.ToString() == "afl" || Environment.UserName.ToString() == "jsg")
            {
                //novo
                OpenFileDialog theDialog = new OpenFileDialog();
                theDialog.Title = "Selecione a pasta com suas musicas";
                theDialog.Filter = "MP3 files|*.mp3";
                theDialog.Multiselect = true;
                theDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);

                if (theDialog.ShowDialog() == DialogResult.OK)
                {
                    caminho = GeraInfo.CriaArqM3U(theDialog.FileName, theDialog.FileNames, ".M3U");
                }
                //novo

                #region wpl
                // Quando o arquivo é lista de reprodução no formato .WPL
                //caminho = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic) + "\\Playlists\\Rock.wpl";
                //this.cbPlaylist.Items.Clear();
                //readPlaylist readList = new readPlaylist();
                //readList.playListPath = caminho;
                //nowPlaylist = readList.PlayList;
                //for (int x = 0; x < nowPlaylist.Count; x++)
                //{
                //    cbPlaylist.Items.Add(nowPlaylist[x]);
                //    text2 = nowPlaylist[x].ToString();
                //}
                //cbPlaylist.SetSelected(0, true);


                //foreach (string file in Directory.GetFiles(caminho, "*.wpl"))
                //{
                //    this.cbPlaylist.Items.Add(file);
                //    text2 = file;
                //}
                //this.axWindowsMediaPlayer1.URL = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic) + "\\Playlists\\Rock.wpl"; //(text2);
                //this.axWindowsMediaPlayer1.currentPlaylist = this.axWindowsMediaPlayer1.newPlaylist(text2,"");
                #endregion

                //this.cbPlaylist.Items.Clear();
                //this.cbPlaylist.Items.Add(new DirectoryInfo(caminho).Parent.Name);

                this.axWindowsMediaPlayer1.URL = caminho; //(text2);
                //this.axWindowsMediaPlayer1.currentPlaylist = this.axWindowsMediaPlayer1.newPlaylist(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic) + text2.Replace("..", ""), ""); comentado
                this.axWindowsMediaPlayer1.Ctlcontrols.play();
                //this.cbPlaylist.Text = new DirectoryInfo(caminho).Parent.Name;// Environment.GetFolderPath(Environment.SpecialFolder.MyMusic) + text2.Replace("..", "");

                Volume = GeraInfo.CriaArqM3U(theDialog.FileName, TFMusicVolume, ".INI");
                AtualizaVolume(Volume);
            }
            else
            {
                foreach (string file in Directory.GetFiles("C:\\TF-MUSIC\\", "*.m3u", SearchOption.AllDirectories))
                {
                    string text = file.Substring(12);
                   // this.cbPlaylist.Items.Add(text.Remove(checked(text.Length - 4)));
                }
                //this.cbPlaylist.Items.Remove("TF-PLAYLIST");
                if (File.Exists("c:\\TF-MUSIC\\.TF-MUSIC.ini"))
                {
                    text2 = File.ReadAllText("c:\\TF-MUSIC\\.TF-MUSIC.ini");
                    this.axWindowsMediaPlayer1.URL = ("c:\\TF-MUSIC\\" + text2 + ".m3u");
                    //this.cbPlaylist.Text = text2;
                }

                AtualizaVolume("c:\\TF-MUSIC\\.TF-MUSIC1.ini");
                //if (File.Exists("c:\\TF-MUSIC\\.TF-MUSIC1.ini"))
                //{
                //    this.axWindowsMediaPlayer1.settings.volume = Convert.ToInt32(File.ReadAllText("c:\\tf-music\\.tf-music1.ini"));
                //    this.trackBar1.Value = this.axWindowsMediaPlayer1.settings.volume;
                //    this.lblVolume.Text = trackBar1.Value.ToString();
                //}
            }

            trkBar_Update = new Timer();
            trkBar_Update.Interval = 1000;
            trkBar_Update.Tick += new EventHandler(trkBar_Updating);
            trkBar_Update.Start();
                        
        }

        private void AtualizaVolume(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    this.axWindowsMediaPlayer1.settings.volume = Convert.ToInt32(File.ReadAllText(path));
                    this.trackBar1.Value = this.axWindowsMediaPlayer1.settings.volume;
                    this.lblVolume.Text = trackBar1.Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro em AtualizaVolume" + ex.Message.ToString());
            }

        }

        private void trkBar_Updating(object sender, EventArgs e) //Handles trkBar_Update.Tick
        {
            try
            {
                //trackBar2.Maximum = Convert.ToInt32(axWindowsMediaPlayer1.currentMedia.duration);
                trackBar2.Value = Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentPosition);
                lblTempo.Text = TimeSpan.FromMinutes(Math.Floor(Convert.ToDouble(axWindowsMediaPlayer1.currentMedia.duration - axWindowsMediaPlayer1.Ctlcontrols.currentPosition))).ToString();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Erro em trkBar_Updating: " + ex.Message.ToString());
            }

        }
        private void cbPlaylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.settings.setMode("shuffle", true);
            this.axWindowsMediaPlayer1.settings.setMode("loop", true);
            //string caminho = string.Empty;
            //if (Environment.UserName.ToString() == "jsg")
            //{
            //    this.axWindowsMediaPlayer1.settings.setMode("shuffle", true);
            //    this.axWindowsMediaPlayer1.settings.setMode("loop", true);
            //}
            //else
            //{
            //    this.axWindowsMediaPlayer1.URL = ("c:\\TF-MUSIC\\" + this.cbPlaylist.SelectedItem.ToString() + ".m3u");
            //    this.axWindowsMediaPlayer1.settings.setMode("shuffle", true);
            //    this.axWindowsMediaPlayer1.settings.setMode("loop", true);
            //    File.WriteAllText("c:\\TF-MUSIC\\.TF-MUSIC.ini", this.cbPlaylist.SelectedItem.ToString());
            //}
        }

        private void axWindowsMediaPlayer1_CurrentItemChange(object sender, AxWMPLib._WMPOCXEvents_CurrentItemChangeEvent e)
        {
            this.lblMusica.Text = this.axWindowsMediaPlayer1.currentMedia.name;
            trackBar2.Maximum = Convert.ToInt32(axWindowsMediaPlayer1.currentMedia.duration);// novo teste
        }

        private void axWindowsMediaPlayer1_PositionChange(object sender, AxWMPLib._WMPOCXEvents_PositionChangeEvent e)
        {
            //trackBar2.Value = e.newPosition();
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            //if (e.newState == 10)
                
        }

        private void btOff_Click(object sender, EventArgs e)
        {
            //File.WriteAllText("c:\\tf-music\\.tf-music1.ini", this.axWindowsMediaPlayer1.settings.volume.ToString());
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (Environment.UserName.ToString() == "jsg")
            {
                File.WriteAllText(Volume, this.axWindowsMediaPlayer1.settings.volume.ToString());
            }
            else
            {
                File.WriteAllText("c:\\tf-music\\.tf-music1.ini", this.axWindowsMediaPlayer1.settings.volume.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }
    }
}
