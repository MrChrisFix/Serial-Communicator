using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace Serial_Communicator
{
    public partial class Communicator : Form
    {
        private SerialPort _serialPort;

        public Communicator()
        {
            InitializeComponent();
            this._serialPort = new SerialPort();
        }

        private void button_options_Click(object sender, EventArgs e)
        {
            Options optionWindow = new Options(this._serialPort, this);
            optionWindow.Show();
            //TODO: disable multiple options windows
        }

        public void saveOptions(SerialPort newOptions)
        {
            this._serialPort = newOptions;
        }

        private void button_ping_Click(object sender, EventArgs e)
        {
            //TODO: messageBox
        }

        private void button_send_Click(object sender, EventArgs e)
        {

        }
    }
}
