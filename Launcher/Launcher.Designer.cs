namespace Launcher
{
    partial class Launcher
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PlayButton = new Button();
            DownloadProgressBar = new ProgressBar();
            DownPanel = new Panel();
            ProgressLabel = new Label();
            DownloadStateLabel = new Label();
            GameLogo = new Panel();
            UpGamePanel = new Panel();
            GameNameLabel = new Label();
            UpNamePanel = new Panel();
            NameInput = new TextBox();
            DownPanel.SuspendLayout();
            UpGamePanel.SuspendLayout();
            UpNamePanel.SuspendLayout();
            SuspendLayout();
            // 
            // PlayButton
            // 
            PlayButton.BackColor = Color.LimeGreen;
            PlayButton.Cursor = Cursors.Hand;
            PlayButton.Font = new Font("Segoe UI", 15F);
            PlayButton.ForeColor = Color.White;
            PlayButton.Location = new Point(959, 606);
            PlayButton.Name = "PlayButton";
            PlayButton.Size = new Size(276, 51);
            PlayButton.TabIndex = 0;
            PlayButton.Text = "Играть >";
            PlayButton.UseVisualStyleBackColor = false;
            // 
            // DownloadProgressBar
            // 
            DownloadProgressBar.ForeColor = Color.Green;
            DownloadProgressBar.Location = new Point(117, 47);
            DownloadProgressBar.Name = "DownloadProgressBar";
            DownloadProgressBar.Size = new Size(763, 18);
            DownloadProgressBar.TabIndex = 1;
            DownloadProgressBar.Value = 100;
            // 
            // DownPanel
            // 
            DownPanel.BackColor = Color.DimGray;
            DownPanel.Controls.Add(ProgressLabel);
            DownPanel.Controls.Add(DownloadStateLabel);
            DownPanel.Controls.Add(DownloadProgressBar);
            DownPanel.Location = new Point(12, 585);
            DownPanel.Name = "DownPanel";
            DownPanel.Size = new Size(1240, 84);
            DownPanel.TabIndex = 2;
            // 
            // ProgressLabel
            // 
            ProgressLabel.Font = new Font("Segoe UI", 19F);
            ProgressLabel.ForeColor = Color.White;
            ProgressLabel.Location = new Point(12, 12);
            ProgressLabel.Name = "ProgressLabel";
            ProgressLabel.Size = new Size(79, 60);
            ProgressLabel.TabIndex = 3;
            ProgressLabel.Text = "100%";
            ProgressLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DownloadStateLabel
            // 
            DownloadStateLabel.Font = new Font("Segoe UI", 15F);
            DownloadStateLabel.ForeColor = Color.Silver;
            DownloadStateLabel.Location = new Point(117, 0);
            DownloadStateLabel.Name = "DownloadStateLabel";
            DownloadStateLabel.Size = new Size(365, 44);
            DownloadStateLabel.TabIndex = 3;
            DownloadStateLabel.Text = "Готово к игре";
            DownloadStateLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // GameLogo
            // 
            GameLogo.BackColor = Color.FromArgb(64, 64, 64);
            GameLogo.Location = new Point(3, 9);
            GameLogo.Name = "GameLogo";
            GameLogo.Size = new Size(48, 48);
            GameLogo.TabIndex = 3;
            // 
            // UpGamePanel
            // 
            UpGamePanel.BackColor = Color.DimGray;
            UpGamePanel.Controls.Add(GameNameLabel);
            UpGamePanel.Controls.Add(GameLogo);
            UpGamePanel.Location = new Point(12, 3);
            UpGamePanel.Name = "UpGamePanel";
            UpGamePanel.Size = new Size(482, 67);
            UpGamePanel.TabIndex = 4;
            // 
            // GameNameLabel
            // 
            GameNameLabel.Font = new Font("Segoe UI", 20F);
            GameNameLabel.ForeColor = Color.White;
            GameNameLabel.Location = new Point(72, 0);
            GameNameLabel.Name = "GameNameLabel";
            GameNameLabel.Size = new Size(395, 67);
            GameNameLabel.TabIndex = 4;
            GameNameLabel.Text = "Название игры";
            GameNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UpNamePanel
            // 
            UpNamePanel.BackColor = Color.DimGray;
            UpNamePanel.Controls.Add(NameInput);
            UpNamePanel.Location = new Point(500, 3);
            UpNamePanel.Name = "UpNamePanel";
            UpNamePanel.Size = new Size(262, 67);
            UpNamePanel.TabIndex = 5;
            // 
            // NameInput
            // 
            NameInput.BackColor = Color.DimGray;
            NameInput.BorderStyle = BorderStyle.None;
            NameInput.Font = new Font("Segoe UI", 20F);
            NameInput.ForeColor = Color.White;
            NameInput.Location = new Point(12, 9);
            NameInput.Name = "NameInput";
            NameInput.PlaceholderText = "Введите имя...";
            NameInput.Size = new Size(235, 36);
            NameInput.TabIndex = 6;
            // 
            // Launcher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(1264, 681);
            Controls.Add(UpNamePanel);
            Controls.Add(PlayButton);
            Controls.Add(DownPanel);
            Controls.Add(UpGamePanel);
            Name = "Launcher";
            Text = "Launcher";
            Load += Launcher_Load;
            DownPanel.ResumeLayout(false);
            UpGamePanel.ResumeLayout(false);
            UpNamePanel.ResumeLayout(false);
            UpNamePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button PlayButton;
        private ProgressBar DownloadProgressBar;
        private Panel DownPanel;
        private Label DownloadStateLabel;
        private Label ProgressLabel;
        private Panel GameLogo;
        private Panel UpGamePanel;
        private Label GameNameLabel;
        private Panel UpNamePanel;
        private TextBox NameInput;
    }
}
