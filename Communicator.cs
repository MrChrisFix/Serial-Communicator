using System;
using System.IO.Ports;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;

namespace Serial_Communicator
{
    public partial class Communicator : Form
    {
        private SerialPort _serialPort;
        private Thread ReadCycle;
        private Options optionWindow;
        private Mutex WriteMutex = new();

        public Communicator()
        {
            InitializeComponent();
            this._serialPort = new SerialPort();
        }

        protected override void OnClosed(EventArgs e)
        {
            if (this._serialPort.IsOpen)
            {
                this._serialPort.Close();
                if (ReadCycle.IsAlive)
                    ReadCycle.Join();
            }
            base.OnClosed(e);
        }

        private void button_options_Click(object sender, EventArgs e)
        {
            this.optionWindow = new Options(this._serialPort, this);
            optionWindow.ShowDialog(this);
        }

        public void saveOptions(SerialPort newOptions)
        {
            this._serialPort = newOptions;
            this.closeOptions();
        }

        public void closeOptions()
        {
            this.optionWindow.Close();
        }

        private void button_ping_Click(object sender, EventArgs e)
        {
            try
            {
                this._serialPort.DiscardOutBuffer();
                this._serialPort.DiscardInBuffer();
                this._serialPort.WriteLine("Ping");
            }
            catch(Exception err)
            {
                MessageBox.Show("Coundn't connect to the device.\nReason:\n" + err.Message, "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            if (this.SendTextBox.Text.Length == 0) return;
            try
            {
                this._serialPort.DiscardOutBuffer();
                this._serialPort.DiscardInBuffer();
                this._serialPort.WriteLine(this.SendTextBox.Text);

                WriteMutex.WaitOne();
                this.RecieveTextBox.Text += "(You): " + this.SendTextBox.Text + '\n';

                WriteMutex.ReleaseMutex();
                this.SendTextBox.Text = "";
            }
            catch(Exception err)
            {
                MessageBox.Show("Coundn't connect to the device.\nReason:\n" + err.Message, "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            if(this.button_connect.Text == "Connect")
            {
                _serialPort.Open();
                if(_serialPort.IsOpen)
                {
                    this.button_connect.Text = "Disconnect";
                    this.button_ping.Enabled = true;
                    this.button_send.Enabled = true;
                    this.button_options.Enabled = false;
                    this.ReadCycle = new Thread(Read);
                    this.ReadCycle.Start();
                }
                else
                    MessageBox.Show("Coundn't connect to the device", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                _serialPort.Close();
                this.button_connect.Text = "Connect";
                this.button_ping.Enabled = false;
                this.button_send.Enabled = false;
                this.button_options.Enabled = true;
            }
            
        }

        private void Read()
        {
            while(_serialPort.IsOpen)
            {
                try
                {
                    string message = _serialPort.ReadLine();
                    if(message.Equals("Ping"))
                    {
                        this._serialPort.DiscardOutBuffer();
                        this._serialPort.DiscardInBuffer();
                        this._serialPort.WriteLine("Pong");
                        continue;
                    }
                    else if (message.Equals("Pong"))
                    {
                        MessageBox.Show(this,"Successful ping!", "Pinging", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        continue;
                    }
                    WriteMutex.WaitOne();
                    this.RecieveTextBox.Text += message + '\n';
                    WriteMutex.ReleaseMutex();
                }
                catch(TimeoutException)
                { /** Do nothing and wait longer */}
                catch(Exception err)
                {
                    Console.WriteLine(err.Message);
                }
            }
        }

        private void SendTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode.Equals(Keys.Enter))
                e.SuppressKeyPress = true;
        }
    }
}
