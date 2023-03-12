using System.Diagnostics;

namespace RDB4Scanner {
    public partial class FormMain : Form {
        public FormMain() {
            InitializeComponent();
        }

        private string loadedLogPath;

        // opens github repo in default browser:
        private void lblGitLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            string gitUrl = "https://github.com/RubberDuck01/RDB4Scanner";

            try {
                System.Diagnostics.Process.Start("cmd", $"/c start {gitUrl}");
            } catch (Exception ex) {
                MessageBox.Show("Something went wrong!\nStack:\n" + ex.Message, "RD's B4Scanner", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // opens file dialog
        private void btnOpen_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog.Filter = "Log files (*.log)|*.log|All files (*.*)|*.*";
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK) {
                loadedLogPath = openFileDialog.FileName;

                try {
                    string selectedFile = Path.GetFileName(openFileDialog.FileName);
                    lblFile.Text = selectedFile;
                    lblScnSts.Text = "Ready!";
                    clearAllLabels();
                } catch (Exception ex) {
                    MessageBox.Show("Something went wrong!\nStack:\n" + ex.Message, "RD's B4Scanner", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // starts the scan:
        private void btnScan_Click(object sender, EventArgs e) {
            // this will be deleted:
            if (!string.IsNullOrEmpty(loadedLogPath)) {
                MessageBox.Show($"Loaded Log: {loadedLogPath}", "RD's B4Scanner", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                MessageBox.Show("No file loaded!", "RD's B4Scanner", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // function to set all labels text to '...' :
        // mby I'll update/remove this... idk
        private void clearAllLabels() {
            lblStackOverflow.Text = "...";
            lblActiveEffects.Text = "...";
            lblBadMath.Text = "...";
            lblNull.Text = "...";
            lblDLL.Text = "...";
            lblLOD.Text = "...";
            lblMCM.Text = "...";
            lblDecal.Text = "...";
            lblEquip.Text = "...";
            lblScript.Text = "...";
            lblGeneric.Text = "...";
            lblArchives.Text = "...";
            lblRendering.Text = "...";
            lblGrid.Text = "...";
            lblNIF.Text = "...";
            lblDDS.Text = "...";
            lblBGSM.Text = "...";
            lblBitDefender.Text = "...";
            lblNPCPath.Text = "...";
            lblAudio.Text = "...";
            lblBodyPhysics.Text = "...";
            lblPluginLimit.Text = "...";
            lblPluginOrder.Text = "...";
            lblMO2Extractor.Text = "...";
            lblNvidiaDebris.Text = "...";
            lblNvidiaDriver.Text = "...";
            lblVulkanMem.Text = "...";
            lblVulkanSettings.Text = "...";
            lblCorruptAudio.Text = "...";
            lblConsoleCommand.Text = "...";
            lblParticleEffects.Text = "...";
            lblAnimationPhysics.Text = "...";
            lblArchiveInvalid.Text = "...";
            lblItem.Text = "...";
            lblSave.Text = "...";
            lblInput.Text = "...";
            lblBadIni.Text = "...";
            lblNPCPatrol.Text = "...";
            lblPrecombines.Text = "...";
            lblAmmoCounter.Text = "...";
            lblNPCProjectile.Text = "...";
            lblPlayerCharacter.Text = "...";
        }
    }
}