
namespace krynkofileword
{
    partial class FormFile
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxFword = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.labelBrowse = new System.Windows.Forms.Label();
            this.labelFword = new System.Windows.Forms.Label();
            this.listViewWords = new System.Windows.Forms.ListView();
            this.labelCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 415);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBoxFword
            // 
            this.textBoxFword.Location = new System.Drawing.Point(12, 12);
            this.textBoxFword.Name = "textBoxFword";
            this.textBoxFword.Size = new System.Drawing.Size(776, 20);
            this.textBoxFword.TabIndex = 1;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(12, 51);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 2;
            this.buttonBrowse.Text = "Обзор";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // labelBrowse
            // 
            this.labelBrowse.AutoSize = true;
            this.labelBrowse.Location = new System.Drawing.Point(9, 35);
            this.labelBrowse.Name = "labelBrowse";
            this.labelBrowse.Size = new System.Drawing.Size(31, 13);
            this.labelBrowse.TabIndex = 3;
            this.labelBrowse.Text = "Путь";
            // 
            // labelFword
            // 
            this.labelFword.AutoSize = true;
            this.labelFword.Location = new System.Drawing.Point(12, 77);
            this.labelFword.Name = "labelFword";
            this.labelFword.Size = new System.Drawing.Size(36, 13);
            this.labelFword.TabIndex = 4;
            this.labelFword.Text = "Fword";
            // 
            // listViewWords
            // 
            this.listViewWords.HideSelection = false;
            this.listViewWords.Location = new System.Drawing.Point(12, 106);
            this.listViewWords.Name = "listViewWords";
            this.listViewWords.Size = new System.Drawing.Size(776, 303);
            this.listViewWords.TabIndex = 7;
            this.listViewWords.UseCompatibleStateImageBehavior = false;
            this.listViewWords.View = System.Windows.Forms.View.List;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(12, 90);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(13, 13);
            this.labelCount.TabIndex = 8;
            this.labelCount.Text = "0";
            // 
            // FormFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.listViewWords);
            this.Controls.Add(this.labelFword);
            this.Controls.Add(this.labelBrowse);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textBoxFword);
            this.Controls.Add(this.buttonStart);
            this.Name = "FormFile";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxFword;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Label labelBrowse;
        private System.Windows.Forms.Label labelFword;
        private System.Windows.Forms.ListView listViewWords;
        private System.Windows.Forms.Label labelCount;
    }
}

