namespace DanciNotebook
{
    partial class DanciNotebook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanciNotebook));
            this.word = new System.Windows.Forms.Label();
            this.translate = new System.Windows.Forms.Label();
            this.example = new System.Windows.Forms.Label();
            this.knownbtn = new System.Windows.Forms.Button();
            this.unknownbtn = new System.Windows.Forms.Button();
            this.Label_1 = new System.Windows.Forms.Label();
            this.grade = new System.Windows.Forms.Label();
            this.newword = new System.Windows.Forms.TextBox();
            this.newtranslate = new System.Windows.Forms.TextBox();
            this.newexample = new System.Windows.Forms.TextBox();
            this.addbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.savebtn = new System.Windows.Forms.Button();
            this.showbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // word
            // 
            this.word.AutoSize = true;
            this.word.BackColor = System.Drawing.Color.Transparent;
            this.word.Location = new System.Drawing.Point(366, 75);
            this.word.Name = "word";
            this.word.Size = new System.Drawing.Size(55, 15);
            this.word.TabIndex = 0;
            this.word.Text = "label1";
            // 
            // translate
            // 
            this.translate.AutoSize = true;
            this.translate.BackColor = System.Drawing.Color.Transparent;
            this.translate.Location = new System.Drawing.Point(366, 137);
            this.translate.Name = "translate";
            this.translate.Size = new System.Drawing.Size(55, 15);
            this.translate.TabIndex = 1;
            this.translate.Text = "label2";
            // 
            // example
            // 
            this.example.AutoSize = true;
            this.example.BackColor = System.Drawing.Color.Transparent;
            this.example.Location = new System.Drawing.Point(366, 201);
            this.example.Name = "example";
            this.example.Size = new System.Drawing.Size(55, 15);
            this.example.TabIndex = 2;
            this.example.Text = "label3";
            // 
            // knownbtn
            // 
            this.knownbtn.Location = new System.Drawing.Point(260, 260);
            this.knownbtn.Name = "knownbtn";
            this.knownbtn.Size = new System.Drawing.Size(75, 29);
            this.knownbtn.TabIndex = 3;
            this.knownbtn.Text = "我会了";
            this.knownbtn.UseVisualStyleBackColor = true;
            this.knownbtn.Click += new System.EventHandler(this.knownbtn_Click);
            // 
            // unknownbtn
            // 
            this.unknownbtn.Location = new System.Drawing.Point(458, 260);
            this.unknownbtn.Name = "unknownbtn";
            this.unknownbtn.Size = new System.Drawing.Size(75, 29);
            this.unknownbtn.TabIndex = 4;
            this.unknownbtn.Text = "我不会";
            this.unknownbtn.UseVisualStyleBackColor = true;
            this.unknownbtn.Click += new System.EventHandler(this.unknownbtn_Click);
            // 
            // Label_1
            // 
            this.Label_1.AutoSize = true;
            this.Label_1.BackColor = System.Drawing.Color.Transparent;
            this.Label_1.Location = new System.Drawing.Point(47, 75);
            this.Label_1.Name = "Label_1";
            this.Label_1.Size = new System.Drawing.Size(143, 15);
            this.Label_1.TabIndex = 5;
            this.Label_1.Text = "掌握度(越高越差)：";
            // 
            // grade
            // 
            this.grade.AutoSize = true;
            this.grade.BackColor = System.Drawing.Color.Transparent;
            this.grade.Location = new System.Drawing.Point(187, 75);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(55, 15);
            this.grade.TabIndex = 6;
            this.grade.Text = "label1";
            // 
            // newword
            // 
            this.newword.Location = new System.Drawing.Point(50, 323);
            this.newword.Name = "newword";
            this.newword.Size = new System.Drawing.Size(100, 25);
            this.newword.TabIndex = 7;
            // 
            // newtranslate
            // 
            this.newtranslate.Location = new System.Drawing.Point(174, 323);
            this.newtranslate.Name = "newtranslate";
            this.newtranslate.Size = new System.Drawing.Size(100, 25);
            this.newtranslate.TabIndex = 8;
            // 
            // newexample
            // 
            this.newexample.Location = new System.Drawing.Point(297, 323);
            this.newexample.Name = "newexample";
            this.newexample.Size = new System.Drawing.Size(463, 25);
            this.newexample.TabIndex = 9;
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(348, 382);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(91, 29);
            this.addbtn.TabIndex = 10;
            this.addbtn.Text = "添加新单词";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Stencil", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "新单词";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(171, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "释义";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(294, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "例句";
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(713, 12);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(75, 23);
            this.savebtn.TabIndex = 14;
            this.savebtn.Text = "保存";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // showbtn
            // 
            this.showbtn.Location = new System.Drawing.Point(685, 260);
            this.showbtn.Name = "showbtn";
            this.showbtn.Size = new System.Drawing.Size(75, 23);
            this.showbtn.TabIndex = 15;
            this.showbtn.Text = "显示释义";
            this.showbtn.UseVisualStyleBackColor = true;
            this.showbtn.Click += new System.EventHandler(this.showbtn_Click);
            // 
            // DanciNotebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showbtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.newexample);
            this.Controls.Add(this.newtranslate);
            this.Controls.Add(this.newword);
            this.Controls.Add(this.grade);
            this.Controls.Add(this.Label_1);
            this.Controls.Add(this.unknownbtn);
            this.Controls.Add(this.knownbtn);
            this.Controls.Add(this.example);
            this.Controls.Add(this.translate);
            this.Controls.Add(this.word);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DanciNotebook";
            this.Text = "DanciNotebook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label word;
        private System.Windows.Forms.Label translate;
        private System.Windows.Forms.Label example;
        private System.Windows.Forms.Button knownbtn;
        private System.Windows.Forms.Button unknownbtn;
        private System.Windows.Forms.Label Label_1;
        private System.Windows.Forms.Label grade;
        private System.Windows.Forms.TextBox newword;
        private System.Windows.Forms.TextBox newtranslate;
        private System.Windows.Forms.TextBox newexample;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button showbtn;
    }
}

