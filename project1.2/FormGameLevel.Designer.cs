
namespace project1._2
{
    partial class FormGameLevel
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
            this.radioButtonEasyLevel = new System.Windows.Forms.RadioButton();
            this.radioButtonHardLevel = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButtonEasyLevel
            // 
            this.radioButtonEasyLevel.AutoSize = true;
            this.radioButtonEasyLevel.Location = new System.Drawing.Point(12, 49);
            this.radioButtonEasyLevel.Name = "radioButtonEasyLevel";
            this.radioButtonEasyLevel.Size = new System.Drawing.Size(72, 29);
            this.radioButtonEasyLevel.TabIndex = 0;
            this.radioButtonEasyLevel.TabStop = true;
            this.radioButtonEasyLevel.Text = "Easy";
            this.radioButtonEasyLevel.UseVisualStyleBackColor = true;
            // 
            // radioButtonHardLevel
            // 
            this.radioButtonHardLevel.AutoSize = true;
            this.radioButtonHardLevel.Location = new System.Drawing.Point(159, 49);
            this.radioButtonHardLevel.Name = "radioButtonHardLevel";
            this.radioButtonHardLevel.Size = new System.Drawing.Size(76, 29);
            this.radioButtonHardLevel.TabIndex = 1;
            this.radioButtonHardLevel.TabStop = true;
            this.radioButtonHardLevel.Text = "Hard";
            this.radioButtonHardLevel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Game Level";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(233, 102);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(112, 34);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(115, 102);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(112, 34);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormGameLevel
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(357, 148);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonHardLevel);
            this.Controls.Add(this.radioButtonEasyLevel);
            this.Name = "FormGameLevel";
            this.Text = "FormGameLevel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonEasyLevel;
        private System.Windows.Forms.RadioButton radioButtonHardLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }
}