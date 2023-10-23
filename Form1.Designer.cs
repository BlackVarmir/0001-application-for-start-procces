namespace _0001_додаток_для_запуску_процесів
{
    partial class Form1
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
            runningAppsListBox = new ListBox();
            availableAppsListBox = new ListBox();
            startbutton = new Button();
            stopbutton = new Button();
            SuspendLayout();
            // 
            // runningAppsListBox
            // 
            runningAppsListBox.FormattingEnabled = true;
            runningAppsListBox.ItemHeight = 15;
            runningAppsListBox.Location = new Point(12, 12);
            runningAppsListBox.Name = "runningAppsListBox";
            runningAppsListBox.Size = new Size(253, 424);
            runningAppsListBox.TabIndex = 0;
            // 
            // availableAppsListBox
            // 
            availableAppsListBox.FormattingEnabled = true;
            availableAppsListBox.ItemHeight = 15;
            availableAppsListBox.Location = new Point(535, 12);
            availableAppsListBox.Name = "availableAppsListBox";
            availableAppsListBox.Size = new Size(253, 424);
            availableAppsListBox.TabIndex = 1;
            // 
            // startbutton
            // 
            startbutton.Location = new Point(366, 136);
            startbutton.Name = "startbutton";
            startbutton.Size = new Size(75, 23);
            startbutton.TabIndex = 2;
            startbutton.Text = "Start";
            startbutton.UseVisualStyleBackColor = true;
            startbutton.Click += startbutton_Click;
            // 
            // stopbutton
            // 
            stopbutton.Location = new Point(366, 204);
            stopbutton.Name = "stopbutton";
            stopbutton.Size = new Size(75, 23);
            stopbutton.TabIndex = 3;
            stopbutton.Text = "Stop";
            stopbutton.UseVisualStyleBackColor = true;
            stopbutton.Click += stopbutton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(stopbutton);
            Controls.Add(startbutton);
            Controls.Add(availableAppsListBox);
            Controls.Add(runningAppsListBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox runningAppsListBox;
        private ListBox availableAppsListBox;
        private Button startbutton;
        private Button stopbutton;
    }
}