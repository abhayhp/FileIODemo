namespace FileIODemo
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnread = new System.Windows.Forms.Button();
            this.btnCreateDirectory = new System.Windows.Forms.Button();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.writeStreamClick = new System.Windows.Forms.Button();
            this.readStreamClick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(364, 112);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(269, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(364, 157);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(255, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter Location";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(364, 205);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(100, 20);
            this.txtLocation.TabIndex = 5;
            // 
            // btnWrite
            // 
            this.btnWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWrite.Location = new System.Drawing.Point(272, 263);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 6;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnread
            // 
            this.btnread.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnread.Location = new System.Drawing.Point(389, 263);
            this.btnread.Name = "btnread";
            this.btnread.Size = new System.Drawing.Size(75, 23);
            this.btnread.TabIndex = 7;
            this.btnread.Text = "Read";
            this.btnread.UseVisualStyleBackColor = true;
            this.btnread.Click += new System.EventHandler(this.btnread_Click);
            // 
            // btnCreateDirectory
            // 
            this.btnCreateDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateDirectory.Location = new System.Drawing.Point(272, 333);
            this.btnCreateDirectory.Name = "btnCreateDirectory";
            this.btnCreateDirectory.Size = new System.Drawing.Size(86, 60);
            this.btnCreateDirectory.TabIndex = 8;
            this.btnCreateDirectory.Text = "Create Directory";
            this.btnCreateDirectory.UseVisualStyleBackColor = true;
            this.btnCreateDirectory.Click += new System.EventHandler(this.btnCreateDirectory_Click);
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateFile.Location = new System.Drawing.Point(389, 333);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(86, 60);
            this.btnCreateFile.TabIndex = 9;
            this.btnCreateFile.Text = "Create File";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(562, 36);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(185, 96);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "In the planet Earth";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // writeStreamClick
            // 
            this.writeStreamClick.Location = new System.Drawing.Point(599, 158);
            this.writeStreamClick.Name = "writeStreamClick";
            this.writeStreamClick.Size = new System.Drawing.Size(110, 33);
            this.writeStreamClick.TabIndex = 11;
            this.writeStreamClick.Text = "Write using Stream";
            this.writeStreamClick.UseVisualStyleBackColor = true;
            this.writeStreamClick.Click += new System.EventHandler(this.writeStreamClick_Click);
            // 
            // readStreamClick
            // 
            this.readStreamClick.Location = new System.Drawing.Point(599, 218);
            this.readStreamClick.Name = "readStreamClick";
            this.readStreamClick.Size = new System.Drawing.Size(110, 35);
            this.readStreamClick.TabIndex = 12;
            this.readStreamClick.Text = "Read using Stream";
            this.readStreamClick.UseVisualStyleBackColor = true;
            this.readStreamClick.Click += new System.EventHandler(this.readStreamClick_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.readStreamClick);
            this.Controls.Add(this.writeStreamClick);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnCreateFile);
            this.Controls.Add(this.btnCreateDirectory);
            this.Controls.Add(this.btnread);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnread;
        private System.Windows.Forms.Button btnCreateDirectory;
        private System.Windows.Forms.Button btnCreateFile;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button writeStreamClick;
        private System.Windows.Forms.Button readStreamClick;
    }
}

