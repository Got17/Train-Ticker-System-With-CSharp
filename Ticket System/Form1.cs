using System.Windows.Forms;

namespace Ticket_System
{
    public partial class Form1 : Form
    {

        SaveFileDialog saveWindow = new SaveFileDialog();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            summary.Items.Clear();
            double distances = Convert.ToDouble(kmTxtBox.Text);
            Pay.pay = distances * 0.2;

            summary.Items.Add($"{distances} km = {Pay.pay} €\n");

            if (travelClassCb.SelectedItem != null && travelClassCb.SelectedItem.ToString() == "First class")
            {
                summary.Items.Add(TravelClass.FirstClass(travelClassCb));

            }
            else if (travelClassCb.SelectedItem != null && travelClassCb.SelectedItem.ToString() == "Business class")
            {
                summary.Items.Add(TravelClass.BusinessClass(travelClassCb));

            }
            else if (travelClassCb.SelectedItem != null && travelClassCb.SelectedItem.ToString() == "Economy class")
            {
                summary.Items.Add(TravelClass.EconomyClass(travelClassCb));
            }

            if (radioButton1.Checked)
            {
                summary.Items.Add(ReduceFare.Senior(radioButton1));
            }
            else if (radioButton2.Checked)
            {
                summary.Items.Add(ReduceFare.Kid(radioButton2));
            }
            else if (radioButton3.Checked)
            {
                summary.Items.Add(ReduceFare.NoDiscount(radioButton1));
            }
            euroTxtBox.Text = Convert.ToString(Pay.pay);

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kmTxtBox.Text = string.Empty;
            travelClassCb.Text = string.Empty;
            euroTxtBox.Text = string.Empty;
            summary.Items.Clear();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = string.Empty;
            saveWindow.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveWindow.InitialDirectory = @"D:\Documents";


            foreach (var item in summary.Items)
            {
                text += item.ToString();
            }

            try
            {
                saveWindow.ShowDialog();
                Files.Save(saveWindow.FileName, text);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            summary.Items.Clear();
            string text = string.Empty;
            OpenFileDialog OpenWindow = new OpenFileDialog();
            OpenWindow.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (OpenWindow.ShowDialog() == DialogResult.OK)
            {
                text = Files.Open(OpenWindow.FileName);
                summary.Items.Add(text);
            }
            else
            {
                MessageBox.Show("Not good file");
            }
        }

        private void cancelCurrentOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            summary.Items.Clear();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string rootFolder = @"D:\Documents";

            try
            {
                if (File.Exists(Path.Combine(rootFolder, saveWindow.FileName)))
                {
                    File.Delete(Path.Combine(rootFolder, saveWindow.FileName));
                    Console.WriteLine("File deleted.");
                }
                else Console.WriteLine("File not found");
            }
            catch (IOException ioExp)
            {
                Console.WriteLine(ioExp.Message);
            }
        }

        private void kmTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}