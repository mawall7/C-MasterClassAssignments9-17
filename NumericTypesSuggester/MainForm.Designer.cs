namespace NumericTypesSuggester
{
    partial class MainForm
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
            IntegralOnlyCheckbox = new CheckBox();
            MustBePreciseCheckbox = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            MinValueTextBox = new TextBox();
            MaxValueTextBox = new TextBox();
            SuggestedTypeLabel = new Label();
            SuspendLayout();
            // 
            // IntegralOnlyCheckbox
            // 
            IntegralOnlyCheckbox.AutoSize = true;
            IntegralOnlyCheckbox.CheckAlign = ContentAlignment.MiddleRight;
            IntegralOnlyCheckbox.Checked = true;
            IntegralOnlyCheckbox.CheckState = CheckState.Checked;
            IntegralOnlyCheckbox.Location = new Point(65, 101);
            IntegralOnlyCheckbox.Name = "IntegralOnlyCheckbox";
            IntegralOnlyCheckbox.Size = new Size(97, 19);
            IntegralOnlyCheckbox.TabIndex = 0;
            IntegralOnlyCheckbox.Text = "Integral only?";
            IntegralOnlyCheckbox.UseVisualStyleBackColor = true;
            IntegralOnlyCheckbox.CheckedChanged += IntegralOnlyCheckBox_Checked;
            // 
            // MustBePreciseCheckbox
            // 
            MustBePreciseCheckbox.AutoSize = true;
            MustBePreciseCheckbox.CheckAlign = ContentAlignment.MiddleRight;
            MustBePreciseCheckbox.Location = new Point(48, 126);
            MustBePreciseCheckbox.Name = "MustBePreciseCheckbox";
            MustBePreciseCheckbox.Size = new Size(114, 19);
            MustBePreciseCheckbox.TabIndex = 1;
            MustBePreciseCheckbox.Text = "Must be precise?";
            MustBePreciseCheckbox.UseVisualStyleBackColor = true;
            MustBePreciseCheckbox.Visible = false;
            MustBePreciseCheckbox.CheckedChanged += MustBePreciseCheckbox_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 31);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 2;
            label1.Text = "Min value:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 61);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 3;
            label2.Text = "Max value:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(48, 159);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 4;
            label3.Text = "Suggested type:";
            // 
            // MinValueTextBox
            // 
            MinValueTextBox.Location = new Point(151, 23);
            MinValueTextBox.Name = "MinValueTextBox";
            MinValueTextBox.Size = new Size(401, 23);
            MinValueTextBox.TabIndex = 5;
            MinValueTextBox.TextChanged += TextBox_TextChanged;
            MinValueTextBox.KeyPress += TextBox_KeyPress;
            // 
            // MaxValueTextBox
            // 
            MaxValueTextBox.Location = new Point(151, 58);
            MaxValueTextBox.Name = "MaxValueTextBox";
            MaxValueTextBox.Size = new Size(401, 23);
            MaxValueTextBox.TabIndex = 6;
            MaxValueTextBox.TextChanged += TextBox_TextChanged;
            MaxValueTextBox.KeyPress += TextBox_KeyPress;
            // 
            // SuggestedTypeLabel
            // 
            SuggestedTypeLabel.AutoSize = true;
            SuggestedTypeLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SuggestedTypeLabel.Location = new Point(151, 159);
            SuggestedTypeLabel.Name = "SuggestedTypeLabel";
            SuggestedTypeLabel.Size = new Size(98, 15);
            SuggestedTypeLabel.TabIndex = 7;
            SuggestedTypeLabel.Text = "not enough data";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(558, 222);
            Controls.Add(SuggestedTypeLabel);
            Controls.Add(MaxValueTextBox);
            Controls.Add(MinValueTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(MustBePreciseCheckbox);
            Controls.Add(IntegralOnlyCheckbox);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox IntegralOnlyCheckbox;
        private CheckBox MustBePreciseCheckbox;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox MinValueTextBox;
        private TextBox MaxValueTextBox;
        private Label SuggestedTypeLabel;
    }
}
