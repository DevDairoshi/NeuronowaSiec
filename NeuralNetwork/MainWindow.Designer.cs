namespace NeuralNetwork
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.bLoad = new System.Windows.Forms.Button();
            this.lChoosenFile = new System.Windows.Forms.Label();
            this.test = new System.Windows.Forms.Label();
            this.ChooseFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.lNetwork = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lOutput = new System.Windows.Forms.Label();
            this.bSave = new System.Windows.Forms.Button();
            this.bProceed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bLoad
            // 
            this.bLoad.Location = new System.Drawing.Point(12, 12);
            this.bLoad.Name = "bLoad";
            this.bLoad.Size = new System.Drawing.Size(75, 23);
            this.bLoad.TabIndex = 0;
            this.bLoad.Text = "Load";
            this.bLoad.UseVisualStyleBackColor = true;
            this.bLoad.Click += new System.EventHandler(this.bLoad_Click);
            // 
            // lChoosenFile
            // 
            this.lChoosenFile.AutoSize = true;
            this.lChoosenFile.Location = new System.Drawing.Point(93, 17);
            this.lChoosenFile.Name = "lChoosenFile";
            this.lChoosenFile.Size = new System.Drawing.Size(29, 13);
            this.lChoosenFile.TabIndex = 1;
            this.lChoosenFile.Text = "File: ";
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Location = new System.Drawing.Point(27, 375);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(24, 13);
            this.test.TabIndex = 1;
            this.test.Text = "test";
            // 
            // ChooseFileDialog
            // 
            this.ChooseFileDialog.FileName = "file";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Loaded network:";
            // 
            // lNetwork
            // 
            this.lNetwork.AutoSize = true;
            this.lNetwork.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lNetwork.Location = new System.Drawing.Point(93, 43);
            this.lNetwork.Name = "lNetwork";
            this.lNetwork.Size = new System.Drawing.Size(11, 13);
            this.lNetwork.TabIndex = 3;
            this.lNetwork.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Inputs:";
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(349, 14);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(164, 20);
            this.tbInput.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Outputs:";
            // 
            // lOutput
            // 
            this.lOutput.AutoSize = true;
            this.lOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lOutput.Location = new System.Drawing.Point(357, 43);
            this.lOutput.Name = "lOutput";
            this.lOutput.Size = new System.Drawing.Size(11, 13);
            this.lOutput.TabIndex = 7;
            this.lOutput.Text = "-";
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(12, 70);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 8;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            // 
            // bProceed
            // 
            this.bProceed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bProceed.Location = new System.Drawing.Point(12, 41);
            this.bProceed.Name = "bProceed";
            this.bProceed.Size = new System.Drawing.Size(75, 23);
            this.bProceed.TabIndex = 9;
            this.bProceed.Text = "Proceed";
            this.bProceed.UseVisualStyleBackColor = true;
            this.bProceed.Click += new System.EventHandler(this.bProceed_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 450);
            this.Controls.Add(this.bProceed);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.lOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lNetwork);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.test);
            this.Controls.Add(this.lChoosenFile);
            this.Controls.Add(this.bLoad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "NeuralNetwork";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bLoad;
        private System.Windows.Forms.Label lChoosenFile;
        private System.Windows.Forms.Label test;
        private System.Windows.Forms.OpenFileDialog ChooseFileDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lNetwork;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lOutput;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bProceed;
    }
}

