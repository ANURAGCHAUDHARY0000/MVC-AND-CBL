using SyncAwaitApp.Service;

namespace SyncAwaitApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new TimePrinterService().Print();
            MessageBox.Show("End of Click");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Task.Run(new TimePrinterService().Print);
            MessageBox.Show("End Of Click");

        }

        private async void button4_Click(object sender, EventArgs e)
        {
            await new TimePrinterService().PrintAsync();
            MessageBox.Show("End Of Click");
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            Task<string> task = new TimePrinterService().PrintAsyncWithResult();
            string result = await task;
            MessageBox.Show(result);
            MessageBox.Show("End Of Click");

        }
    }
}