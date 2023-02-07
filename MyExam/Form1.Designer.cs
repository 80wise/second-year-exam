namespace MyExam
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
            this.components = new System.ComponentModel.Container();
            this.TransportDGV = new System.Windows.Forms.DataGridView();
            this.ShowBtn = new System.Windows.Forms.Button();
            this.SortBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowNumberBtn = new System.Windows.Forms.Button();
            this.DiagramShow = new System.Windows.Forms.Button();
            this.myTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TransportDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // TransportDGV
            // 
            this.TransportDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransportDGV.Location = new System.Drawing.Point(63, 71);
            this.TransportDGV.Name = "TransportDGV";
            this.TransportDGV.Size = new System.Drawing.Size(398, 159);
            this.TransportDGV.TabIndex = 0;
            // 
            // ShowBtn
            // 
            this.ShowBtn.Location = new System.Drawing.Point(63, 236);
            this.ShowBtn.Name = "ShowBtn";
            this.ShowBtn.Size = new System.Drawing.Size(86, 23);
            this.ShowBtn.TabIndex = 1;
            this.ShowBtn.Text = "Show All";
            this.ShowBtn.UseVisualStyleBackColor = true;
            this.ShowBtn.Click += new System.EventHandler(this.ShowBtn_Click);
            // 
            // SortBtn
            // 
            this.SortBtn.Location = new System.Drawing.Point(215, 236);
            this.SortBtn.Name = "SortBtn";
            this.SortBtn.Size = new System.Drawing.Size(75, 23);
            this.SortBtn.TabIndex = 2;
            this.SortBtn.Text = "Sort";
            this.SortBtn.UseVisualStyleBackColor = true;
            this.SortBtn.Click += new System.EventHandler(this.SortBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Save trams";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(511, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(508, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Number of red transport mean cheaper than 20000 USD ";
            // 
            // ShowNumberBtn
            // 
            this.ShowNumberBtn.Location = new System.Drawing.Point(689, 96);
            this.ShowNumberBtn.Name = "ShowNumberBtn";
            this.ShowNumberBtn.Size = new System.Drawing.Size(94, 23);
            this.ShowNumberBtn.TabIndex = 6;
            this.ShowNumberBtn.Text = "show number";
            this.ShowNumberBtn.UseVisualStyleBackColor = true;
            this.ShowNumberBtn.Click += new System.EventHandler(this.ShowNumberBtn_Click);
            // 
            // DiagramShow
            // 
            this.DiagramShow.Location = new System.Drawing.Point(511, 179);
            this.DiagramShow.Name = "DiagramShow";
            this.DiagramShow.Size = new System.Drawing.Size(75, 23);
            this.DiagramShow.TabIndex = 7;
            this.DiagramShow.Text = "Diagram";
            this.DiagramShow.UseVisualStyleBackColor = true;
            this.DiagramShow.Click += new System.EventHandler(this.DiagramShow_Click);
            // 
            // myTimer
            // 
            this.myTimer.Interval = 10000;
            this.myTimer.Tick += new System.EventHandler(this.myTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 275);
            this.Controls.Add(this.DiagramShow);
            this.Controls.Add(this.ShowNumberBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SortBtn);
            this.Controls.Add(this.ShowBtn);
            this.Controls.Add(this.TransportDGV);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TransportDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TransportDGV;
        private System.Windows.Forms.Button ShowBtn;
        private System.Windows.Forms.Button SortBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ShowNumberBtn;
        private System.Windows.Forms.Button DiagramShow;
        public System.Windows.Forms.Timer myTimer;
    }
}

