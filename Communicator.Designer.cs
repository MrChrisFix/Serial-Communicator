
namespace Serial_Communicator
{
    partial class Communicator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SendTextBox = new System.Windows.Forms.RichTextBox();
            this.RecieveTextBox = new System.Windows.Forms.RichTextBox();
            this.button_options = new System.Windows.Forms.Button();
            this.button_ping = new System.Windows.Forms.Button();
            this.button_send = new System.Windows.Forms.Button();
            this.labelRecieve = new System.Windows.Forms.Label();
            this.labelSend = new System.Windows.Forms.Label();
            this.button_connect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SendTextBox
            // 
            this.SendTextBox.Location = new System.Drawing.Point(12, 37);
            this.SendTextBox.Name = "SendTextBox";
            this.SendTextBox.Size = new System.Drawing.Size(361, 336);
            this.SendTextBox.TabIndex = 0;
            this.SendTextBox.Text = "";
            // 
            // RecieveTextBox
            // 
            this.RecieveTextBox.Location = new System.Drawing.Point(427, 37);
            this.RecieveTextBox.Name = "RecieveTextBox";
            this.RecieveTextBox.ReadOnly = true;
            this.RecieveTextBox.Size = new System.Drawing.Size(361, 336);
            this.RecieveTextBox.TabIndex = 1;
            this.RecieveTextBox.Text = "";
            // 
            // button_options
            // 
            this.button_options.Location = new System.Drawing.Point(692, 404);
            this.button_options.Name = "button_options";
            this.button_options.Size = new System.Drawing.Size(96, 34);
            this.button_options.TabIndex = 2;
            this.button_options.Text = "Options";
            this.button_options.UseVisualStyleBackColor = true;
            this.button_options.Click += new System.EventHandler(this.button_options_Click);
            // 
            // button_ping
            // 
            this.button_ping.Enabled = false;
            this.button_ping.Location = new System.Drawing.Point(12, 460);
            this.button_ping.Name = "button_ping";
            this.button_ping.Size = new System.Drawing.Size(96, 34);
            this.button_ping.TabIndex = 3;
            this.button_ping.Text = "Ping";
            this.button_ping.UseVisualStyleBackColor = true;
            this.button_ping.Click += new System.EventHandler(this.button_ping_Click);
            // 
            // button_send
            // 
            this.button_send.Enabled = false;
            this.button_send.Location = new System.Drawing.Point(12, 404);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(96, 34);
            this.button_send.TabIndex = 4;
            this.button_send.Text = "Send";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // labelRecieve
            // 
            this.labelRecieve.AutoSize = true;
            this.labelRecieve.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRecieve.Location = new System.Drawing.Point(427, 13);
            this.labelRecieve.Name = "labelRecieve";
            this.labelRecieve.Size = new System.Drawing.Size(63, 21);
            this.labelRecieve.TabIndex = 5;
            this.labelRecieve.Text = "Recieve";
            // 
            // labelSend
            // 
            this.labelSend.AutoSize = true;
            this.labelSend.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSend.Location = new System.Drawing.Point(12, 13);
            this.labelSend.Name = "labelSend";
            this.labelSend.Size = new System.Drawing.Size(45, 21);
            this.labelSend.TabIndex = 6;
            this.labelSend.Text = "Send";
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(692, 460);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(96, 34);
            this.button_connect.TabIndex = 7;
            this.button_connect.Text = "Connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // Communicator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.labelSend);
            this.Controls.Add(this.labelRecieve);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.button_ping);
            this.Controls.Add(this.button_options);
            this.Controls.Add(this.RecieveTextBox);
            this.Controls.Add(this.SendTextBox);
            this.Name = "Communicator";
            this.Text = "Serial Communicator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox SendTextBox;
        private System.Windows.Forms.RichTextBox RecieveTextBox;
        private System.Windows.Forms.Button button_options;
        private System.Windows.Forms.Button button_ping;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.Label labelRecieve;
        private System.Windows.Forms.Label labelSend;
        private System.Windows.Forms.Button button_connect;
    }
}

