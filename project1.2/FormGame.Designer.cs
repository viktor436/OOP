
namespace project1._2
{
    partial class FormGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStripShipMaxWeight = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelShipMaxWeight = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelArea = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonSail = new System.Windows.Forms.Button();
            this.buttonWait = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.statusStripShipMaxWeight.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.statusStripShipMaxWeight);
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Location = new System.Drawing.Point(12, 351);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 88);
            this.panel1.TabIndex = 1;
            // 
            // statusStripShipMaxWeight
            // 
            this.statusStripShipMaxWeight.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStripShipMaxWeight.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelShipMaxWeight});
            this.statusStripShipMaxWeight.Location = new System.Drawing.Point(0, 66);
            this.statusStripShipMaxWeight.Name = "statusStripShipMaxWeight";
            this.statusStripShipMaxWeight.Size = new System.Drawing.Size(561, 22);
            this.statusStripShipMaxWeight.TabIndex = 4;
            // 
            // toolStripStatusLabelShipMaxWeight
            // 
            this.toolStripStatusLabelShipMaxWeight.Name = "toolStripStatusLabelShipMaxWeight";
            this.toolStripStatusLabelShipMaxWeight.Size = new System.Drawing.Size(0, 15);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelArea});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(561, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStripArea";
            // 
            // toolStripStatusLabelArea
            // 
            this.toolStripStatusLabelArea.Name = "toolStripStatusLabelArea";
            this.toolStripStatusLabelArea.Size = new System.Drawing.Size(0, 15);
            // 
            // buttonSail
            // 
            this.buttonSail.Location = new System.Drawing.Point(685, 393);
            this.buttonSail.Name = "buttonSail";
            this.buttonSail.Size = new System.Drawing.Size(103, 45);
            this.buttonSail.TabIndex = 2;
            this.buttonSail.Text = "Sail away";
            this.buttonSail.UseVisualStyleBackColor = true;
            this.buttonSail.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonWait
            // 
            this.buttonWait.Location = new System.Drawing.Point(579, 392);
            this.buttonWait.Name = "buttonWait";
            this.buttonWait.Size = new System.Drawing.Size(103, 45);
            this.buttonWait.TabIndex = 3;
            this.buttonWait.Text = "Wait";
            this.buttonWait.UseVisualStyleBackColor = true;
            this.buttonWait.Click += new System.EventHandler(this.buttonWait_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(94, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(602, 336);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CancelButton = this.buttonWait;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonWait);
            this.Controls.Add(this.buttonSail);
            this.Controls.Add(this.panel1);
            this.Name = "FormGame";
            this.Text = "FormGame";
            this.Load += new System.EventHandler(this.FormGame_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStripShipMaxWeight.ResumeLayout(false);
            this.statusStripShipMaxWeight.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSail;
        private System.Windows.Forms.Button buttonWait;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelArea;
        private System.Windows.Forms.StatusStrip statusStripShipMaxWeight;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelShipMaxWeight;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}