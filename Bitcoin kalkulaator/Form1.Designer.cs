namespace Bitcoin_kalkulaator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.currencySelector = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bitcoinAmountInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tulemusLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // currencySelector
            // 
            this.currencySelector.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.currencySelector.FormattingEnabled = true;
            this.currencySelector.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "GBP",
            "EEK"});
            this.currencySelector.Location = new System.Drawing.Point(289, 290);
            this.currencySelector.Name = "currencySelector";
            this.currencySelector.Size = new System.Drawing.Size(137, 24);
            this.currencySelector.TabIndex = 0;
            this.currencySelector.Text = "Vali valuuta";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.button1.Location = new System.Drawing.Point(289, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 59);
            this.button1.TabIndex = 1;
            this.button1.Text = "Arvuta kurss";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bitcoinAmountInput
            // 
            this.bitcoinAmountInput.Location = new System.Drawing.Point(289, 228);
            this.bitcoinAmountInput.Name = "bitcoinAmountInput";
            this.bitcoinAmountInput.Size = new System.Drawing.Size(137, 20);
            this.bitcoinAmountInput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(285, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sisesta bitcoinide arv";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tulemusLabel
            // 
            this.tulemusLabel.AutoSize = true;
            this.tulemusLabel.BackColor = System.Drawing.Color.Transparent;
            this.tulemusLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.tulemusLabel.ForeColor = System.Drawing.Color.White;
            this.tulemusLabel.Location = new System.Drawing.Point(329, 442);
            this.tulemusLabel.Name = "tulemusLabel";
            this.tulemusLabel.Size = new System.Drawing.Size(63, 20);
            this.tulemusLabel.TabIndex = 4;
            this.tulemusLabel.Text = "Tulemus";
            this.tulemusLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.resultLabel.Location = new System.Drawing.Point(289, 465);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(138, 26);
            this.resultLabel.TabIndex = 5;
            this.resultLabel.TextChanged += new System.EventHandler(this.resultLabel_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(719, 784);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.tulemusLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bitcoinAmountInput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.currencySelector);
            this.Name = "Form1";
            this.Text = "Bitcoin Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox currencySelector;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox bitcoinAmountInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tulemusLabel;
        private System.Windows.Forms.TextBox resultLabel;
    }
}

