
namespace Serial_Communicator
{
    partial class Options
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox_Port = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_update = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Parity = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Flow = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_Term = new System.Windows.Forms.ComboBox();
            this.textBox_Term = new System.Windows.Forms.TextBox();
            this.textBox_Speed = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.comboBox_Size = new System.Windows.Forms.ComboBox();
            this.comboBox_Stop = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_Port
            // 
            this.comboBox_Port.FormattingEnabled = true;
            this.comboBox_Port.Location = new System.Drawing.Point(12, 39);
            this.comboBox_Port.Name = "comboBox_Port";
            this.comboBox_Port.Size = new System.Drawing.Size(121, 23);
            this.comboBox_Port.TabIndex = 0;
            this.comboBox_Port.SelectedIndexChanged += new System.EventHandler(this.comboBox_Port_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port";
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(151, 39);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(80, 23);
            this.button_update.TabIndex = 2;
            this.button_update.Text = "Update list";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Parity";
            // 
            // comboBox_Parity
            // 
            this.comboBox_Parity.FormattingEnabled = true;
            this.comboBox_Parity.Location = new System.Drawing.Point(12, 118);
            this.comboBox_Parity.Name = "comboBox_Parity";
            this.comboBox_Parity.Size = new System.Drawing.Size(121, 23);
            this.comboBox_Parity.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Flow control (handshake)";
            // 
            // comboBox_Flow
            // 
            this.comboBox_Flow.FormattingEnabled = true;
            this.comboBox_Flow.Location = new System.Drawing.Point(12, 256);
            this.comboBox_Flow.Name = "comboBox_Flow";
            this.comboBox_Flow.Size = new System.Drawing.Size(121, 23);
            this.comboBox_Flow.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Terminator";
            // 
            // comboBox_Term
            // 
            this.comboBox_Term.FormattingEnabled = true;
            this.comboBox_Term.Location = new System.Drawing.Point(12, 323);
            this.comboBox_Term.Name = "comboBox_Term";
            this.comboBox_Term.Size = new System.Drawing.Size(121, 23);
            this.comboBox_Term.TabIndex = 7;
            this.comboBox_Term.SelectedIndexChanged += new System.EventHandler(this.comboBox_Term_SelectedIndexChanged);
            // 
            // textBox_Term
            // 
            this.textBox_Term.Enabled = false;
            this.textBox_Term.Location = new System.Drawing.Point(151, 323);
            this.textBox_Term.Name = "textBox_Term";
            this.textBox_Term.Size = new System.Drawing.Size(80, 23);
            this.textBox_Term.TabIndex = 9;
            // 
            // textBox_Speed
            // 
            this.textBox_Speed.Location = new System.Drawing.Point(150, 190);
            this.textBox_Speed.Name = "textBox_Speed";
            this.textBox_Speed.Size = new System.Drawing.Size(80, 23);
            this.textBox_Speed.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Speed";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "bit/s";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(108, 390);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(81, 27);
            this.buttonSave.TabIndex = 13;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // comboBox_Size
            // 
            this.comboBox_Size.FormattingEnabled = true;
            this.comboBox_Size.Location = new System.Drawing.Point(151, 118);
            this.comboBox_Size.Name = "comboBox_Size";
            this.comboBox_Size.Size = new System.Drawing.Size(121, 23);
            this.comboBox_Size.TabIndex = 14;
            // 
            // comboBox_Stop
            // 
            this.comboBox_Stop.FormattingEnabled = true;
            this.comboBox_Stop.Location = new System.Drawing.Point(12, 190);
            this.comboBox_Stop.Name = "comboBox_Stop";
            this.comboBox_Stop.Size = new System.Drawing.Size(121, 23);
            this.comboBox_Stop.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(151, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Data field size";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Stop bits";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(197, 390);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(81, 27);
            this.buttonCancel.TabIndex = 20;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 429);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox_Stop);
            this.Controls.Add(this.comboBox_Size);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Speed);
            this.Controls.Add(this.textBox_Term);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_Term);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_Flow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_Parity);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Port);
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Port;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Parity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Flow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_Term;
        private System.Windows.Forms.TextBox textBox_Term;
        private System.Windows.Forms.TextBox textBox_Speed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ComboBox comboBox_Size;
        private System.Windows.Forms.ComboBox comboBox_Stop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonCancel;
    }
}