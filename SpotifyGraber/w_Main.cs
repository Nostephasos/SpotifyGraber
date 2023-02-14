using System.Diagnostics;
using System.Windows.Forms.VisualStyles;

namespace SpotifyGraber
{
    public partial class w_Main : Form
    {
        public w_Main()
        {
            InitializeComponent();
        }

        private void loop_Tick(object sender, EventArgs e)
        {
            File.WriteAllText(Path.Combine(Application.StartupPath, "SpotifyGraber.txt"), GetSpotifyTrackInfo());
        }
        private void item_Start_Click(object sender, EventArgs e)
        {
            if (!loop.Enabled)
            {
                loop.Start();
                item_Start.Checked = true;
                item_Stop.Enabled = true;
            }
        }
        private void item_Stop_Click(object sender, EventArgs e)
        {
            if (loop.Enabled) 
            {
                loop.Stop(); 
                item_Start.Checked = false;
                item_Stop.Enabled = false;
            }
        }
        private void item_Exit_Click(object sender, EventArgs e)
        {
            if (loop.Enabled) loop.Stop();
            Application.Exit();
        }

        private string GetSpotifyTrackInfo()
        {
            var proc = Process.GetProcessesByName("Spotify").FirstOrDefault(p => !string.IsNullOrWhiteSpace(p.MainWindowTitle));

            if (proc == null)
            {
                return "Spotify is not running!";
            }

            if (string.Equals(proc.MainWindowTitle, "Spotify", StringComparison.InvariantCultureIgnoreCase))
            {
                return "No track is playing";
            }

            return proc.MainWindowTitle;
        }
    }
}