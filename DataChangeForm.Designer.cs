namespace LibraryApp
{
    partial class DataChangeForm
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
            label1 = new Label();
            ChangeDataButton = new Button();
            DataChangeTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 9);
            label1.Name = "label1";
            label1.Size = new Size(95, 17);
            label1.TabIndex = 0;
            label1.Text = "Enter new data";
            // 
            // ChangeDataButton
            // 
            ChangeDataButton.Location = new Point(91, 96);
            ChangeDataButton.Name = "ChangeDataButton";
            ChangeDataButton.Size = new Size(115, 25);
            ChangeDataButton.TabIndex = 2;
            ChangeDataButton.Text = "Apply changes";
            ChangeDataButton.UseVisualStyleBackColor = true;
            ChangeDataButton.Click += ChangeDataButton_Click;
            // 
            // DataChangeTextBox
            // 
            DataChangeTextBox.Location = new Point(68, 41);
            DataChangeTextBox.Multiline = true;
            DataChangeTextBox.Name = "DataChangeTextBox";
            DataChangeTextBox.Size = new Size(157, 49);
            DataChangeTextBox.TabIndex = 3;
            DataChangeTextBox.TextChanged += DataChangeTextBox_TextChanged;
            // 
            // DataChangeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 133);
            Controls.Add(DataChangeTextBox);
            Controls.Add(ChangeDataButton);
            Controls.Add(label1);
            Name = "DataChangeForm";
            Text = "DataChangeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button ChangeDataButton;
        private TextBox DataChangeTextBox;
    }
}