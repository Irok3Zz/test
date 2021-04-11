
namespace krynkofibonacci
{
    partial class FormFib
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonStart = new System.Windows.Forms.Button();
            this.textTo = new System.Windows.Forms.TextBox();
            this.richTextBoxVivod = new System.Windows.Forms.RichTextBox();
            this.labelIndicator = new System.Windows.Forms.Label();
            this.buttonTest1 = new System.Windows.Forms.Button();
            this.buttonTest2 = new System.Windows.Forms.Button();
            this.labelTest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 38);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textTo
            // 
            this.textTo.Location = new System.Drawing.Point(12, 12);
            this.textTo.Name = "textTo";
            this.textTo.Size = new System.Drawing.Size(100, 20);
            this.textTo.TabIndex = 1;
            // 
            // richTextBoxVivod
            // 
            this.richTextBoxVivod.Location = new System.Drawing.Point(380, 12);
            this.richTextBoxVivod.Name = "richTextBoxVivod";
            this.richTextBoxVivod.Size = new System.Drawing.Size(408, 426);
            this.richTextBoxVivod.TabIndex = 2;
            this.richTextBoxVivod.Text = "";
            // 
            // labelIndicator
            // 
            this.labelIndicator.AutoSize = true;
            this.labelIndicator.Location = new System.Drawing.Point(304, 12);
            this.labelIndicator.Name = "labelIndicator";
            this.labelIndicator.Size = new System.Drawing.Size(70, 13);
            this.labelIndicator.TabIndex = 3;
            this.labelIndicator.Text = "labelIndicator";
            // 
            // buttonTest1
            // 
            this.buttonTest1.Location = new System.Drawing.Point(12, 415);
            this.buttonTest1.Name = "buttonTest1";
            this.buttonTest1.Size = new System.Drawing.Size(75, 23);
            this.buttonTest1.TabIndex = 4;
            this.buttonTest1.Text = "1";
            this.buttonTest1.UseVisualStyleBackColor = true;
            this.buttonTest1.Click += new System.EventHandler(this.buttonTest1_Click);
            // 
            // buttonTest2
            // 
            this.buttonTest2.Location = new System.Drawing.Point(93, 415);
            this.buttonTest2.Name = "buttonTest2";
            this.buttonTest2.Size = new System.Drawing.Size(75, 23);
            this.buttonTest2.TabIndex = 5;
            this.buttonTest2.Text = "2";
            this.buttonTest2.UseVisualStyleBackColor = true;
            this.buttonTest2.Click += new System.EventHandler(this.buttonTest2_Click);
            // 
            // labelTest
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.Location = new System.Drawing.Point(77, 399);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(50, 13);
            this.labelTest.TabIndex = 6;
            this.labelTest.Text = "labelTest";
            // 
            // FormFib
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTest);
            this.Controls.Add(this.buttonTest2);
            this.Controls.Add(this.buttonTest1);
            this.Controls.Add(this.labelIndicator);
            this.Controls.Add(this.richTextBoxVivod);
            this.Controls.Add(this.textTo);
            this.Controls.Add(this.buttonStart);
            this.Name = "FormFib";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormFib_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textTo;
        private System.Windows.Forms.RichTextBox richTextBoxVivod;
        private System.Windows.Forms.Label labelIndicator;
        private System.Windows.Forms.Button buttonTest1;
        private System.Windows.Forms.Button buttonTest2;
        private System.Windows.Forms.Label labelTest;
    }
}

