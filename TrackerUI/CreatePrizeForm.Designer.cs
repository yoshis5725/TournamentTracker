namespace TrackerUI
{
    partial class CreatePrizeForm
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
            this.createPrizeLabel = new System.Windows.Forms.Label();
            this.PlaceNumberValue = new System.Windows.Forms.TextBox();
            this.PlaceNumberLabel = new System.Windows.Forms.Label();
            this.PrizeAmountValue = new System.Windows.Forms.TextBox();
            this.PrizeAmountLabel = new System.Windows.Forms.Label();
            this.PlaceNameValue = new System.Windows.Forms.TextBox();
            this.PlaceNameLabel = new System.Windows.Forms.Label();
            this.PrizePercentageValue = new System.Windows.Forms.TextBox();
            this.PrizePercentageLabel = new System.Windows.Forms.Label();
            this.orLabel = new System.Windows.Forms.Label();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createPrizeLabel
            // 
            this.createPrizeLabel.AutoSize = true;
            this.createPrizeLabel.Location = new System.Drawing.Point(28, 38);
            this.createPrizeLabel.Name = "createPrizeLabel";
            this.createPrizeLabel.Size = new System.Drawing.Size(250, 59);
            this.createPrizeLabel.TabIndex = 22;
            this.createPrizeLabel.Text = "Create Prize";
            // 
            // PlaceNumberValue
            // 
            this.PlaceNumberValue.Location = new System.Drawing.Point(386, 149);
            this.PlaceNumberValue.Name = "PlaceNumberValue";
            this.PlaceNumberValue.Size = new System.Drawing.Size(470, 65);
            this.PlaceNumberValue.TabIndex = 30;
            // 
            // PlaceNumberLabel
            // 
            this.PlaceNumberLabel.AutoSize = true;
            this.PlaceNumberLabel.Location = new System.Drawing.Point(36, 155);
            this.PlaceNumberLabel.Name = "PlaceNumberLabel";
            this.PlaceNumberLabel.Size = new System.Drawing.Size(290, 59);
            this.PlaceNumberLabel.TabIndex = 29;
            this.PlaceNumberLabel.Text = "Place Number";
            this.PlaceNumberLabel.Click += new System.EventHandler(this.PlaceNumberLabel_Click);
            // 
            // PrizeAmountValue
            // 
            this.PrizeAmountValue.Location = new System.Drawing.Point(386, 343);
            this.PrizeAmountValue.Name = "PrizeAmountValue";
            this.PrizeAmountValue.Size = new System.Drawing.Size(470, 65);
            this.PrizeAmountValue.TabIndex = 32;
            // 
            // PrizeAmountLabel
            // 
            this.PrizeAmountLabel.AutoSize = true;
            this.PrizeAmountLabel.Location = new System.Drawing.Point(36, 349);
            this.PrizeAmountLabel.Name = "PrizeAmountLabel";
            this.PrizeAmountLabel.Size = new System.Drawing.Size(288, 59);
            this.PrizeAmountLabel.TabIndex = 31;
            this.PrizeAmountLabel.Text = "Place Amount";
            // 
            // PlaceNameValue
            // 
            this.PlaceNameValue.Location = new System.Drawing.Point(386, 246);
            this.PlaceNameValue.Name = "PlaceNameValue";
            this.PlaceNameValue.Size = new System.Drawing.Size(470, 65);
            this.PlaceNameValue.TabIndex = 34;
            // 
            // PlaceNameLabel
            // 
            this.PlaceNameLabel.AutoSize = true;
            this.PlaceNameLabel.Location = new System.Drawing.Point(36, 249);
            this.PlaceNameLabel.Name = "PlaceNameLabel";
            this.PlaceNameLabel.Size = new System.Drawing.Size(248, 59);
            this.PlaceNameLabel.TabIndex = 33;
            this.PlaceNameLabel.Text = "Place Name";
            // 
            // PrizePercentageValue
            // 
            this.PrizePercentageValue.Location = new System.Drawing.Point(386, 561);
            this.PrizePercentageValue.Name = "PrizePercentageValue";
            this.PrizePercentageValue.Size = new System.Drawing.Size(470, 65);
            this.PrizePercentageValue.TabIndex = 36;
            // 
            // PrizePercentageLabel
            // 
            this.PrizePercentageLabel.AutoSize = true;
            this.PrizePercentageLabel.Location = new System.Drawing.Point(36, 567);
            this.PrizePercentageLabel.Name = "PrizePercentageLabel";
            this.PrizePercentageLabel.Size = new System.Drawing.Size(344, 59);
            this.PrizePercentageLabel.TabIndex = 35;
            this.PrizePercentageLabel.Text = "Place Percentage";
            // 
            // orLabel
            // 
            this.orLabel.AutoSize = true;
            this.orLabel.Location = new System.Drawing.Point(308, 457);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(123, 59);
            this.orLabel.TabIndex = 37;
            this.orLabel.Text = "- or -";
            this.orLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.Location = new System.Drawing.Point(234, 692);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(356, 98);
            this.createPrizeButton.TabIndex = 38;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // CreatePrizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(24F, 59F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1477, 830);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.orLabel);
            this.Controls.Add(this.PrizePercentageValue);
            this.Controls.Add(this.PrizePercentageLabel);
            this.Controls.Add(this.PlaceNameValue);
            this.Controls.Add(this.PlaceNameLabel);
            this.Controls.Add(this.PrizeAmountValue);
            this.Controls.Add(this.PrizeAmountLabel);
            this.Controls.Add(this.PlaceNumberValue);
            this.Controls.Add(this.PlaceNumberLabel);
            this.Controls.Add(this.createPrizeLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "CreatePrizeForm";
            this.Text = "CreatePrizeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label createPrizeLabel;
        private TextBox PlaceNumberValue;
        private Label PlaceNumberLabel;
        private TextBox PrizeAmountValue;
        private Label PrizeAmountLabel;
        private TextBox PlaceNameValue;
        private Label PlaceNameLabel;
        private TextBox PrizePercentageValue;
        private Label PrizePercentageLabel;
        private Label orLabel;
        private Button createPrizeButton;
    }
}