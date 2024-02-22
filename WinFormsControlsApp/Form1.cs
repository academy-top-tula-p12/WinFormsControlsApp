namespace WinFormsControlsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            lblHello.Visible = true;
            lblHello.Text = "Hello";
            lblHello.Font = new Font("Impact", 24.0f);
            lblHello.ForeColor = Color.Coral;

            //btnFirst.BackgroundImage = (Image)new Bitmap(@"icon1.png");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("chrome.exe", "https://yandex.ru");
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clcked button OK");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clcked button CANCEL");
        }



        private void btnOk_MouseDown(object sender, MouseEventArgs e)
        {
            string str = e.Button.ToString();
            MessageBox.Show(str);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            string str = e.X.ToString() + " : " + e.Y.ToString();
            lblHello.Text = str;

        }
    }
}
