namespace To_Do_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> items = new List<string>();
        int count = 0;
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            items.Add(textBoxItem.Text);
            count++;
            string number = Convert.ToString(count);
            label1.Text = label1.Text + "\n" + number + ". " + items[count - 1];
        }
    }
}