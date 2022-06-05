using System;
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
            this.comboBox_Parity.SelectedIndex = Helper.ParityIdToInt(serialPort.Parity);
            this.comboBox_Stop.SelectedIndex = Helper.StopIdToInt(serialPort.StopBits);
            this.comboBox_Size.SelectedIndex = this.comboBox_Size.Items.IndexOf(serialPort.DataBits);
            this.comboBox_Flow.SelectedIndex = Helper.HandIdToInt(serialPort.Handshake);
            this.comboBox_Term.SelectedIndex = Helper.TermToInt(serialPort.NewLine);

            if (Helper.TermToInt(serialPort.NewLine) == 4)
            {
                this.textBox_Term.Enabled = true;
                this.textBox_Term.Text = Helper.convertTerminators(serialPort.NewLine);
            }

        }

        private void InitSelectable()
        {
            this.updatePortList();

            //Parity -> type Parity
            foreach (Parity par in (Parity[])Enum.GetValues(typeof(Parity)))
            {
                this.comboBox_Parity.Items.Add(Helper.ParityIdToString(par));
            }

            //DataField -> type int
            this.comboBox_Size.Items.Add(5);
            this.comboBox_Size.Items.Add(6);
            this.comboBox_Size.Items.Add(7);
            this.comboBox_Size.Items.Add(8);

            //Stop bits -> type StopBits
            foreach(StopBits stop in (StopBits[])Enum.GetValues(typeof(StopBits)))
            {
                this.comboBox_Stop.Items.Add(Helper.StopIdToString(stop));
            }

            //Flow control -> type Handshake
            foreach(Handshake hand in (Handshake[])Enum.GetValues(typeof(Handshake)))
            {
                this.comboBox_Flow.Items.Add(Helper.HandIdToString(hand));
            }

            //Terminator -> type string
            this.comboBox_Term.Items.Add("None");           //0
            this.comboBox_Term.Items.Add("CR (/r)");        //1
            this.comboBox_Term.Items.Add("LF (/n)");        //2
            this.comboBox_Term.Items.Add("CRLF (/r/n)");    //3
            this.comboBox_Term.Items.Add("Own");            //4

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
    }
}
