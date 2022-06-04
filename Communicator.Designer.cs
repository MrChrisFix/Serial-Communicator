
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button_options = new System.Windows.Forms.Button();
            this.button_ping = new System.Windows.Forms.Button();
            this.button_send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(361, 361);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(427, 12);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(361, 361);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // button_options
            // 
            this.button_options.Location = new System.Drawing.Point(691, 404);
            this.button_options.Name = "button_options";
            this.button_options.Size = new System.Drawing.Size(96, 34);
            this.button_options.TabIndex = 2;
            this.button_options.Text = "Options";
            this.button_options.UseVisualStyleBackColor = true;
            this.button_options.Click += new System.EventHandler(this.button_options_Click);
            // 
            // button_ping
            // 
            this.button_ping.Location = new System.Drawing.Point(576, 404);
            this.button_ping.Name = "button_ping";
            this.button_ping.Size = new System.Drawing.Size(96, 34);
            this.button_ping.TabIndex = 3;
            this.button_ping.Text = "Ping";
            this.button_ping.UseVisualStyleBackColor = true;
            this.button_ping.Click += new System.EventHandler(this.button_ping_Click);
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(277, 404);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(96, 34);
            this.button_send.TabIndex = 4;
            this.button_send.Text = "Send";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // Communicator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.button_ping);
            this.Controls.Add(this.button_options);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Communicator";
            this.Text = "Serial Communicator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button button_options;
        private System.Windows.Forms.Button button_ping;
        private System.Windows.Forms.Button button_send;
    }
}

