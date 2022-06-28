
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SendTextBox
            // 
            this.SendTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SendTextBox.Location = new System.Drawing.Point(3, 28);
            this.SendTextBox.Name = "SendTextBox";
            this.SendTextBox.Size = new System.Drawing.Size(394, 475);
            this.SendTextBox.TabIndex = 0;
            this.SendTextBox.Text = "";
            // 
            // RecieveTextBox
            // 
            this.RecieveTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RecieveTextBox.Location = new System.Drawing.Point(403, 28);
            this.RecieveTextBox.Name = "RecieveTextBox";
            this.RecieveTextBox.ReadOnly = true;
            this.RecieveTextBox.Size = new System.Drawing.Size(394, 475);
            this.RecieveTextBox.TabIndex = 1;
            this.RecieveTextBox.Text = "";
            // 
            // button_options
            // 
            this.button_options.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_options.Location = new System.Drawing.Point(701, 8);
            this.button_options.Name = "button_options";
            this.button_options.Size = new System.Drawing.Size(96, 34);
            this.button_options.TabIndex = 2;
            this.button_options.Text = "Options";
            this.button_options.UseVisualStyleBackColor = true;
            this.button_options.Click += new System.EventHandler(this.button_options_Click);
            // 
            // button_ping
            // 
            this.button_ping.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_ping.Enabled = false;
            this.button_ping.Location = new System.Drawing.Point(3, 58);
            this.button_ping.Name = "button_ping";
            this.button_ping.Size = new System.Drawing.Size(96, 34);
            this.button_ping.TabIndex = 3;
            this.button_ping.Text = "Ping";
            this.button_ping.UseVisualStyleBackColor = true;
            this.button_ping.Click += new System.EventHandler(this.button_ping_Click);
            // 
            // button_send
            // 
            this.button_send.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_send.Enabled = false;
            this.button_send.Location = new System.Drawing.Point(3, 8);
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
            this.labelRecieve.Location = new System.Drawing.Point(403, 0);
            this.labelRecieve.Name = "labelRecieve";
            this.labelRecieve.Size = new System.Drawing.Size(63, 21);
            this.labelRecieve.TabIndex = 5;
            this.labelRecieve.Text = "Recieve";
            // 
            // labelSend
            // 
            this.labelSend.AutoSize = true;
            this.labelSend.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSend.Location = new System.Drawing.Point(3, 0);
            this.labelSend.Name = "labelSend";
            this.labelSend.Size = new System.Drawing.Size(45, 21);
            this.labelSend.TabIndex = 6;
            this.labelSend.Text = "Send";
            // 
            // button_connect
            // 
            this.button_connect.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_connect.Location = new System.Drawing.Point(701, 58);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(96, 34);
            this.button_connect.TabIndex = 7;
            this.button_connect.Text = "Connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.RecieveTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.SendTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelRecieve, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelSend, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 506);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.2518F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.7482F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel2.Controls.Add(this.button_send, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_ping, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.button_connect, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.button_options, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 406);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(800, 100);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // Communicator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Communicator";
            this.Text = "Serial Communicator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

