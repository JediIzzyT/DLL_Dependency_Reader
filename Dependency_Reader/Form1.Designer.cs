
namespace Dependency_Reader
{
    partial class DependencyReader
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
            this.inputFilePath = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.richTextDependencies = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // inputFilePath
            // 
            this.inputFilePath.AllowDrop = true;
            this.inputFilePath.Location = new System.Drawing.Point(87, 12);
            this.inputFilePath.Name = "inputFilePath";
            this.inputFilePath.Size = new System.Drawing.Size(320, 23);
            this.inputFilePath.TabIndex = 0;
            this.inputFilePath.DragDrop += new System.Windows.Forms.DragEventHandler(this.inputFilePath_DragDrop);
            this.inputFilePath.DragOver += new System.Windows.Forms.DragEventHandler(this.inputFilePath_DragOver);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(413, 12);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFilePath.Location = new System.Drawing.Point(12, 16);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(69, 15);
            this.lblFilePath.TabIndex = 2;
            this.lblFilePath.Text = "Path to .dll:";
            // 
            // richTextDependencies
            // 
            this.richTextDependencies.Location = new System.Drawing.Point(12, 64);
            this.richTextDependencies.Name = "richTextDependencies";
            this.richTextDependencies.ReadOnly = true;
            this.richTextDependencies.Size = new System.Drawing.Size(476, 374);
            this.richTextDependencies.TabIndex = 3;
            this.richTextDependencies.Text = "";
            // 
            // DependencyReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.richTextDependencies);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.inputFilePath);
            this.Name = "DependencyReader";
            this.Text = "Assembly Dependency Reader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputFilePath;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.RichTextBox richTextDependencies;
    }
}

