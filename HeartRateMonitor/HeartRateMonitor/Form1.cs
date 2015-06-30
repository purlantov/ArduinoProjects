using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using System.IO;
using System.IO.Ports;

namespace HeartRateMonitor
{
    public partial class HeartRateMonitor : Form
    {
        //some variables
        private SerialPort myPort;
        private Graphics drawArea;
        private string dataIn;
        int value = 0;
        int defaultValue = 286;
        bool eventHandler = true;

        Counter counter = new Counter();

        int x = 0;
        int y = 0;
        int oldX = 0;
        int oldY = 0;

        public HeartRateMonitor()
        {
            InitializeComponent();
            drawArea = pictureBox.CreateGraphics();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //TO DO
            //There is nothing to do
        }

        //
        //Start button
        //
        private void buttonStart_Click(object sender, EventArgs e)
        {
            myPort = new SerialPort();
            myPort.BaudRate = 9600;
            myPort.PortName = textBox_PortName.Text;
            myPort.Parity = Parity.None;
            myPort.DataBits = 8;
            myPort.StopBits = StopBits.One;
            myPort.DataReceived += myPort_DataReceived;

            try
            {
                myPort.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

            timer.Start();
        }

        //
        //Event Handler
        //
        public void myPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            dataIn = myPort.ReadLine();

            //Returns bool from TryParse
            //if inbound data posses enthing other than numbers return false 
            bool result = int.TryParse(dataIn, out value);

            //Parse it for real
            //Get only numbers
            if (result && value > 0 && value < 1024)
            {
                value = int.Parse(dataIn);
            }
            else
            {
                value = defaultValue;
            }

            this.Invoke(new EventHandler(displaydata_event));

            if (!eventHandler)
            {
                this.Close();
                this.Dispose();
                this.Refresh();


            }
        }

        private void displaydata_event(object sender, EventArgs ev)
        {
            label_value.Text = String.Format("RAW DATA: {0}", dataIn);
            DrawingLoop(value);
            progressBar.Value = progressBar.Maximum - value - 100;
            counter.Count(value);
            //label_HeartBeat.Text = counter.ToString();

        }

        //
        // Stop button
        //
        private void buttonStop_Click(object sender, EventArgs e)
        {
            eventHandler = false;
            try
            {
                myPort.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error while closing");
            }
        }

        //
        //Drawing Method to PictureBox
        //
        public void DrawingLoop(int value)
        {
            Pen pen = new Pen(Color.Blue, 1);
            oldX = x;
            oldY = y;
            y = value;
            x = oldX + 2;

            drawArea.DrawLine(pen, oldX, oldY, x, y);

            if (x >= pictureBox.Width)
            {
                x = 0;
                pictureBox.Image = null;
            }


        }

        //
        // Save button
        //
        private void buttonSave_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            label_HeartBeat.Text = counter.ToString();
            counter.Count(0);
        }
    }
}
