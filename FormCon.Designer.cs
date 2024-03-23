namespace LTWin_MDI
{
    partial class FormCon
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
            picBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picBox).BeginInit();
            SuspendLayout();
            // 
            // picBox
            // 
            picBox.Dock = DockStyle.Fill;
            picBox.Location = new Point(0, 0);
            picBox.Name = "picBox";
            picBox.Size = new Size(800, 450);
            picBox.SizeMode = PictureBoxSizeMode.CenterImage;
            picBox.TabIndex = 0;
            picBox.TabStop = false;
            // 
            // FormCon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(picBox);
            Name = "FormCon";
            Text = "FormCon";
            ((System.ComponentModel.ISupportInitialize)picBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picBox;
    }
}