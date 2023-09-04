using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System.Windows.Forms;

namespace AudioLoopBackPlayer
{
    public partial class Form1 : Form
    {
        // Create a WaveOutEvent for audio output
        WaveOutEvent waveOut = new WaveOutEvent();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtName.Text = openFileDialog.FileName;
                PlayFile(txtName.Text);
            }
        }

        private void PlayFile(string name)
        {
            // Replace with your audio file path
            string audioFilePath = name;

            // Create a WaveFileReader from the audio file
            //var audioFileReader = new WaveFileReader(audioFilePath);
            var audioFileReader = new AudioFileReader(audioFilePath);

            // Set the desired start and end times (in seconds)
            double startTime = Convert.ToDouble(txtFrom.Text);
            double endTime = Convert.ToDouble(txtTo.Text);

            // Create a TimeSpan for the start and end times
            TimeSpan startTimeSpan = TimeSpan.FromSeconds(startTime);

            // Calculate the number of samples to take based on the end time
            int samplesToTake = (int)((endTime - startTime) * audioFileReader.WaveFormat.SampleRate);

            // Create an OffsetSampleProvider to play the specific portion
            var offsetSampleProvider = new OffsetSampleProvider(audioFileReader.ToSampleProvider())
            {
                SkipOver = startTimeSpan,
                Take = TimeSpan.FromSeconds(samplesToTake / (double)audioFileReader.WaveFormat.SampleRate)
            };

            // Hook up the OffsetSampleProvider to the WaveOutEvent
            waveOut.Init(offsetSampleProvider);

            // Play the audio from the defined timeline
            waveOut.Play();

            Console.WriteLine("Press Enter to stop.");
            Console.ReadLine();

            // Stop and clean up resources when done
            waveOut.Stop();
            waveOut.Dispose();
            audioFileReader.Dispose();
        }
    }
}