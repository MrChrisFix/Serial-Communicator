using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Serial_Communicator
{
    public partial class Options : Form
    {
        Communicator parent;
        SerialPort serialPort;

        public Options(SerialPort _serialPort, Communicator sender)
        {
            this.serialPort = _serialPort;
            this.parent = sender;
            InitializeComponent();
            this.InitSelectable();
            this.InitValues();
        }

        private void InitValues()
        {
            this.comboBox_Port.SelectedIndex = this.comboBox_Port.Items.IndexOf(this.serialPort.PortName);
            this.textBox_Speed.Text = this.serialPort.BaudRate.ToString();
        }

        private void InitSelectable()
        {
            this.updatePortList();

            //Parity
            foreach (Parity par in (Parity[])Enum.GetValues(typeof(Parity)))
            {
                string name = convertParity(par);
                if (name.Length > 0)
                    this.comboBox_Parity.Items.Add(name);
            }

            //DataField
            this.comboBox_Size.Items.Add(7);
            this.comboBox_Size.Items.Add(8);

            //Stop bits
            this.comboBox_Stop.Items.Add("One");
            this.comboBox_Stop.Items.Add("Two");

            //Flow control
            this.comboBox_Flow.Items.Add("None");
            this.comboBox_Flow.Items.Add("RTS");
            this.comboBox_Flow.Items.Add("XON/XOFF");

            //Terminator
            this.comboBox_Term.Items.Add("None");
            this.comboBox_Term.Items.Add("CR (/r)");
            this.comboBox_Term.Items.Add("LF (/n)");
            this.comboBox_Term.Items.Add("CRLF (/r/n)");
            this.comboBox_Term.Items.Add("Own");

            //SerialPort.
            //DataBits -> data field size
            //BaudRate -> speed
            //Parity
            //Stop
            //NewLine -> terminator:
            // /n is LF
            // /r is CR
            // /r/n is CRLF
            //Handshake -> flow control
        }

        private void updatePortList()
        {
            this.comboBox_Port.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            foreach (string name in ports)
                this.comboBox_Port.Items.Add(name);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            parent.saveOptions(this.serialPort);

            this.Close();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            this.updatePortList();
        }

        private string convertParity(Parity par)
        {
            switch(par)
            {
                case Parity.None:
                    return "None";
                case Parity.Even:
                    return "Even";
                case Parity.Odd:
                    return "Odd";
                default:
                    return "";

            }
        }

    }
}
