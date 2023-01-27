using System.Diagnostics;

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

        private void btn_start_Click(object sender, EventArgs e)
        {
            loop.Start();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            loop.Stop();
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