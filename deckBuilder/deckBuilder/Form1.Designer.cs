namespace deckBuilder
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.lblZero = new System.Windows.Forms.TextBox();
            this.lblOne = new System.Windows.Forms.TextBox();
            this.lblTwo = new System.Windows.Forms.TextBox();
            this.lblThree = new System.Windows.Forms.TextBox();
            this.cardTotal = new System.Windows.Forms.TextBox();
            this.btnGradeZero = new System.Windows.Forms.Button();
            this.btnGradeOne = new System.Windows.Forms.Button();
            this.btnGradeTwo = new System.Windows.Forms.Button();
            this.btnGradeThree = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.cardsNeeded = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(142, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cardfight Vanguard";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Grade 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Grade 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Grade 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Grade 3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 594);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cards needed";
            // 
            // lblZero
            // 
            this.lblZero.Location = new System.Drawing.Point(164, 198);
            this.lblZero.Name = "lblZero";
            this.lblZero.Size = new System.Drawing.Size(332, 26);
            this.lblZero.TabIndex = 6;
            this.lblZero.Text = "1";
            this.lblZero.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblOne
            // 
            this.lblOne.Location = new System.Drawing.Point(164, 279);
            this.lblOne.Name = "lblOne";
            this.lblOne.Size = new System.Drawing.Size(332, 26);
            this.lblOne.TabIndex = 7;
            // 
            // lblTwo
            // 
            this.lblTwo.Location = new System.Drawing.Point(164, 358);
            this.lblTwo.Name = "lblTwo";
            this.lblTwo.Size = new System.Drawing.Size(332, 26);
            this.lblTwo.TabIndex = 8;
            // 
            // lblThree
            // 
            this.lblThree.Location = new System.Drawing.Point(164, 442);
            this.lblThree.Name = "lblThree";
            this.lblThree.Size = new System.Drawing.Size(332, 26);
            this.lblThree.TabIndex = 9;
            // 
            // cardTotal
            // 
            this.cardTotal.Location = new System.Drawing.Point(164, 528);
            this.cardTotal.Name = "cardTotal";
            this.cardTotal.Size = new System.Drawing.Size(332, 26);
            this.cardTotal.TabIndex = 10;
            this.cardTotal.TextChanged += new System.EventHandler(this.cardTotal_TextChanged);
            // 
            // btnGradeZero
            // 
            this.btnGradeZero.Location = new System.Drawing.Point(522, 195);
            this.btnGradeZero.Name = "btnGradeZero";
            this.btnGradeZero.Size = new System.Drawing.Size(141, 32);
            this.btnGradeZero.TabIndex = 11;
            this.btnGradeZero.Text = "AddG0";
            this.btnGradeZero.UseVisualStyleBackColor = true;
            this.btnGradeZero.Click += new System.EventHandler(this.btnGradeZero_Click);
            // 
            // btnGradeOne
            // 
            this.btnGradeOne.Location = new System.Drawing.Point(522, 279);
            this.btnGradeOne.Name = "btnGradeOne";
            this.btnGradeOne.Size = new System.Drawing.Size(141, 32);
            this.btnGradeOne.TabIndex = 12;
            this.btnGradeOne.Text = "AddG1";
            this.btnGradeOne.UseVisualStyleBackColor = true;
            this.btnGradeOne.Click += new System.EventHandler(this.btnGradeOne_Click);
            // 
            // btnGradeTwo
            // 
            this.btnGradeTwo.Location = new System.Drawing.Point(522, 358);
            this.btnGradeTwo.Name = "btnGradeTwo";
            this.btnGradeTwo.Size = new System.Drawing.Size(141, 32);
            this.btnGradeTwo.TabIndex = 13;
            this.btnGradeTwo.Text = "AddG2";
            this.btnGradeTwo.UseVisualStyleBackColor = true;
            this.btnGradeTwo.Click += new System.EventHandler(this.btnGradeTwo_Click);
            // 
            // btnGradeThree
            // 
            this.btnGradeThree.Location = new System.Drawing.Point(522, 439);
            this.btnGradeThree.Name = "btnGradeThree";
            this.btnGradeThree.Size = new System.Drawing.Size(141, 32);
            this.btnGradeThree.TabIndex = 14;
            this.btnGradeThree.Text = "AddG3";
            this.btnGradeThree.UseVisualStyleBackColor = true;
            this.btnGradeThree.Click += new System.EventHandler(this.btnGradeThree_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(522, 525);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(141, 32);
            this.button5.TabIndex = 15;
            this.button5.Text = "clear";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 531);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Cards Total";
            // 
            // cardsNeeded
            // 
            this.cardsNeeded.Location = new System.Drawing.Point(164, 591);
            this.cardsNeeded.Name = "cardsNeeded";
            this.cardsNeeded.Size = new System.Drawing.Size(332, 26);
            this.cardsNeeded.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(522, 587);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 34);
            this.button1.TabIndex = 18;
            this.button1.Text = "calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(728, 683);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cardsNeeded);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnGradeThree);
            this.Controls.Add(this.btnGradeTwo);
            this.Controls.Add(this.btnGradeOne);
            this.Controls.Add(this.btnGradeZero);
            this.Controls.Add(this.cardTotal);
            this.Controls.Add(this.lblThree);
            this.Controls.Add(this.lblTwo);
            this.Controls.Add(this.lblOne);
            this.Controls.Add(this.lblZero);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox lblZero;
        private System.Windows.Forms.TextBox lblOne;
        private System.Windows.Forms.TextBox lblTwo;
        private System.Windows.Forms.TextBox lblThree;
        private System.Windows.Forms.TextBox cardTotal;
        private System.Windows.Forms.Button btnGradeZero;
        private System.Windows.Forms.Button btnGradeOne;
        private System.Windows.Forms.Button btnGradeTwo;
        private System.Windows.Forms.Button btnGradeThree;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.TextBox cardsNeeded;
        private System.Windows.Forms.Button button1;
    }
}

