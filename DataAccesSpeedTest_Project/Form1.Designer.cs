namespace DataAccesSpeedTest_Project
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnConnected = new System.Windows.Forms.Button();
            this.listBoxConnected = new System.Windows.Forms.ListBox();
            this.TxtConnected = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxDisconnected = new System.Windows.Forms.ListBox();
            this.BtnDisconnected = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxEntityFramework = new System.Windows.Forms.ListBox();
            this.BtnEntity = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtDisc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtEF = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connected Architecture";
            // 
            // BtnConnected
            // 
            this.BtnConnected.BackColor = System.Drawing.Color.Blue;
            this.BtnConnected.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConnected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConnected.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnConnected.Location = new System.Drawing.Point(8, 33);
            this.BtnConnected.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnConnected.Name = "BtnConnected";
            this.BtnConnected.Size = new System.Drawing.Size(258, 31);
            this.BtnConnected.TabIndex = 1;
            this.BtnConnected.Text = "Get List Item";
            this.BtnConnected.UseVisualStyleBackColor = false;
            this.BtnConnected.Click += new System.EventHandler(this.BtnConnected_Click);
            // 
            // listBoxConnected
            // 
            this.listBoxConnected.FormattingEnabled = true;
            this.listBoxConnected.Location = new System.Drawing.Point(8, 70);
            this.listBoxConnected.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxConnected.Name = "listBoxConnected";
            this.listBoxConnected.Size = new System.Drawing.Size(257, 290);
            this.listBoxConnected.TabIndex = 2;
            // 
            // TxtConnected
            // 
            this.TxtConnected.Location = new System.Drawing.Point(49, 370);
            this.TxtConnected.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtConnected.Name = "TxtConnected";
            this.TxtConnected.Size = new System.Drawing.Size(216, 20);
            this.TxtConnected.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 373);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Time :";
            // 
            // listBoxDisconnected
            // 
            this.listBoxDisconnected.FormattingEnabled = true;
            this.listBoxDisconnected.Location = new System.Drawing.Point(335, 70);
            this.listBoxDisconnected.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxDisconnected.Name = "listBoxDisconnected";
            this.listBoxDisconnected.Size = new System.Drawing.Size(257, 290);
            this.listBoxDisconnected.TabIndex = 7;
            // 
            // BtnDisconnected
            // 
            this.BtnDisconnected.BackColor = System.Drawing.Color.Blue;
            this.BtnDisconnected.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDisconnected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDisconnected.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnDisconnected.Location = new System.Drawing.Point(335, 33);
            this.BtnDisconnected.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnDisconnected.Name = "BtnDisconnected";
            this.BtnDisconnected.Size = new System.Drawing.Size(258, 31);
            this.BtnDisconnected.TabIndex = 6;
            this.BtnDisconnected.Text = "Get List Item";
            this.BtnDisconnected.UseVisualStyleBackColor = false;
            this.BtnDisconnected.Click += new System.EventHandler(this.BtnDisconnected_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(357, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Disconnected Architecture";
            // 
            // listBoxEntityFramework
            // 
            this.listBoxEntityFramework.FormattingEnabled = true;
            this.listBoxEntityFramework.Location = new System.Drawing.Point(654, 70);
            this.listBoxEntityFramework.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxEntityFramework.Name = "listBoxEntityFramework";
            this.listBoxEntityFramework.Size = new System.Drawing.Size(257, 290);
            this.listBoxEntityFramework.TabIndex = 11;
            // 
            // BtnEntity
            // 
            this.BtnEntity.BackColor = System.Drawing.Color.Blue;
            this.BtnEntity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEntity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEntity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEntity.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnEntity.Location = new System.Drawing.Point(654, 33);
            this.BtnEntity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnEntity.Name = "BtnEntity";
            this.BtnEntity.Size = new System.Drawing.Size(258, 31);
            this.BtnEntity.TabIndex = 10;
            this.BtnEntity.Text = "Get List Item";
            this.BtnEntity.UseVisualStyleBackColor = false;
            this.BtnEntity.Click += new System.EventHandler(this.BtnEntity_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(653, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Entity Framework Architecture";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 377);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Time :";
            // 
            // TxtDisc
            // 
            this.TxtDisc.Location = new System.Drawing.Point(376, 373);
            this.TxtDisc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtDisc.Name = "TxtDisc";
            this.TxtDisc.Size = new System.Drawing.Size(216, 20);
            this.TxtDisc.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(651, 377);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Time :";
            // 
            // TxtEF
            // 
            this.TxtEF.Location = new System.Drawing.Point(695, 374);
            this.TxtEF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtEF.Name = "TxtEF";
            this.TxtEF.Size = new System.Drawing.Size(216, 20);
            this.TxtEF.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(934, 427);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtEF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtDisc);
            this.Controls.Add(this.listBoxEntityFramework);
            this.Controls.Add(this.BtnEntity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxDisconnected);
            this.Controls.Add(this.BtnDisconnected);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtConnected);
            this.Controls.Add(this.listBoxConnected);
            this.Controls.Add(this.BtnConnected);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Acces Speed Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnConnected;
        private System.Windows.Forms.ListBox listBoxConnected;
        private System.Windows.Forms.TextBox TxtConnected;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxDisconnected;
        private System.Windows.Forms.Button BtnDisconnected;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxEntityFramework;
        private System.Windows.Forms.Button BtnEntity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtDisc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtEF;
    }
}

