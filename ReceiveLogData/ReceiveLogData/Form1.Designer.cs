namespace ReceiveLogData
{
    partial class GetDataFromQueue
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
                rabbitManager.Dispose();

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
            this.dataFromQueue = new System.Windows.Forms.ListBox();
            this.buttonGetFromQueue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dataFromQueue
            // 
            this.dataFromQueue.FormattingEnabled = true;
            this.dataFromQueue.Location = new System.Drawing.Point(13, 13);
            this.dataFromQueue.Name = "dataFromQueue";
            this.dataFromQueue.Size = new System.Drawing.Size(920, 238);
            this.dataFromQueue.TabIndex = 0;
            // 
            // buttonGetFromQueue
            // 
            this.buttonGetFromQueue.Location = new System.Drawing.Point(13, 269);
            this.buttonGetFromQueue.Name = "buttonGetFromQueue";
            this.buttonGetFromQueue.Size = new System.Drawing.Size(176, 23);
            this.buttonGetFromQueue.TabIndex = 1;
            this.buttonGetFromQueue.Text = "Get from queue";
            this.buttonGetFromQueue.UseVisualStyleBackColor = true;
            this.buttonGetFromQueue.Click += new System.EventHandler(this.buttonGetFromQueue_Click);
            // 
            // GetDataFromQueue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 477);
            this.Controls.Add(this.buttonGetFromQueue);
            this.Controls.Add(this.dataFromQueue);
            this.Name = "GetDataFromQueue";
            this.Text = "Get data from queue";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox dataFromQueue;
        private System.Windows.Forms.Button buttonGetFromQueue;
    }
}

