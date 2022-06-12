namespace TrackerUI
{
    partial class TournamentDashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tournamentDashboardLabel = new System.Windows.Forms.Label();
            this.loadExistingTournamentLabel = new System.Windows.Forms.Label();
            this.loadExistingTournamentDropbox = new System.Windows.Forms.ComboBox();
            this.loadTournamentButton = new System.Windows.Forms.Button();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tournamentDashboardLabel
            // 
            this.tournamentDashboardLabel.AutoSize = true;
            this.tournamentDashboardLabel.Location = new System.Drawing.Point(426, 66);
            this.tournamentDashboardLabel.Name = "tournamentDashboardLabel";
            this.tournamentDashboardLabel.Size = new System.Drawing.Size(470, 59);
            this.tournamentDashboardLabel.TabIndex = 23;
            this.tournamentDashboardLabel.Text = "Tournament Dashboard";
            // 
            // loadExistingTournamentLabel
            // 
            this.loadExistingTournamentLabel.AutoSize = true;
            this.loadExistingTournamentLabel.Location = new System.Drawing.Point(409, 186);
            this.loadExistingTournamentLabel.Name = "loadExistingTournamentLabel";
            this.loadExistingTournamentLabel.Size = new System.Drawing.Size(512, 59);
            this.loadExistingTournamentLabel.TabIndex = 28;
            this.loadExistingTournamentLabel.Text = "Load Existing Tournament";
            // 
            // loadExistingTournamentDropbox
            // 
            this.loadExistingTournamentDropbox.FormattingEnabled = true;
            this.loadExistingTournamentDropbox.Location = new System.Drawing.Point(289, 292);
            this.loadExistingTournamentDropbox.Name = "loadExistingTournamentDropbox";
            this.loadExistingTournamentDropbox.Size = new System.Drawing.Size(753, 67);
            this.loadExistingTournamentDropbox.TabIndex = 27;
            // 
            // loadTournamentButton
            // 
            this.loadTournamentButton.Location = new System.Drawing.Point(444, 420);
            this.loadTournamentButton.Name = "loadTournamentButton";
            this.loadTournamentButton.Size = new System.Drawing.Size(452, 108);
            this.loadTournamentButton.TabIndex = 39;
            this.loadTournamentButton.Text = "Load Tournament";
            this.loadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.Location = new System.Drawing.Point(444, 581);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(452, 108);
            this.createTournamentButton.TabIndex = 40;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(24F, 59F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1477, 830);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.loadTournamentButton);
            this.Controls.Add(this.loadExistingTournamentLabel);
            this.Controls.Add(this.loadExistingTournamentDropbox);
            this.Controls.Add(this.tournamentDashboardLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "TournamentDashboardForm";
            this.Text = "TournamentDashboardForm";
            this.Load += new System.EventHandler(this.TournamentDashboardForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label tournamentDashboardLabel;
        private Label loadExistingTournamentLabel;
        private ComboBox loadExistingTournamentDropbox;
        private Button loadTournamentButton;
        private Button createTournamentButton;
    }
}