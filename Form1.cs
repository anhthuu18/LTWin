namespace LTWin_MDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dig = new OpenFileDialog();
            if (dig.ShowDialog() == DialogResult.OK)
            {
                FormCon formcon = new FormCon(dig.FileName);
                formcon.MdiParent = this;
                formcon.Show();
            }
        }


    }
}