namespace Note_App
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
            this.TB_Message = new System.Windows.Forms.TextBox();
            this.TB_Title = new System.Windows.Forms.TextBox();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.BT_New = new System.Windows.Forms.Button();
            this.BT_Save = new System.Windows.Forms.Button();
            this.BT_Delete = new System.Windows.Forms.Button();
            this.BT_Open = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Message";
            // 
            // TB_Message
            // 
            this.TB_Message.Location = new System.Drawing.Point(68, 107);
            this.TB_Message.Multiline = true;
            this.TB_Message.Name = "TB_Message";
            this.TB_Message.Size = new System.Drawing.Size(389, 263);
            this.TB_Message.TabIndex = 2;
            // 
            // TB_Title
            // 
            this.TB_Title.Location = new System.Drawing.Point(68, 46);
            this.TB_Title.Name = "TB_Title";
            this.TB_Title.Size = new System.Drawing.Size(389, 20);
            this.TB_Title.TabIndex = 3;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AllowUserToResizeColumns = false;
            this.DataGridView1.AllowUserToResizeRows = false;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(529, 46);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.Size = new System.Drawing.Size(260, 324);
            this.DataGridView1.TabIndex = 4;
            // 
            // BT_New
            // 
            this.BT_New.Location = new System.Drawing.Point(68, 377);
            this.BT_New.Name = "BT_New";
            this.BT_New.Size = new System.Drawing.Size(75, 23);
            this.BT_New.TabIndex = 5;
            this.BT_New.Text = "New";
            this.BT_New.UseVisualStyleBackColor = true;
            this.BT_New.Click += new System.EventHandler(this.BT_New_Click);
            // 
            // BT_Save
            // 
            this.BT_Save.Location = new System.Drawing.Point(150, 377);
            this.BT_Save.Name = "BT_Save";
            this.BT_Save.Size = new System.Drawing.Size(75, 23);
            this.BT_Save.TabIndex = 6;
            this.BT_Save.Text = "Save";
            this.BT_Save.UseVisualStyleBackColor = true;
            this.BT_Save.Click += new System.EventHandler(this.BT_Save_Click);
            // 
            // BT_Delete
            // 
            this.BT_Delete.Location = new System.Drawing.Point(610, 376);
            this.BT_Delete.Name = "BT_Delete";
            this.BT_Delete.Size = new System.Drawing.Size(75, 23);
            this.BT_Delete.TabIndex = 8;
            this.BT_Delete.Text = "Delete";
            this.BT_Delete.UseVisualStyleBackColor = true;
            this.BT_Delete.Click += new System.EventHandler(this.BT_Delete_Click);
            // 
            // BT_Open
            // 
            this.BT_Open.Location = new System.Drawing.Point(529, 376);
            this.BT_Open.Name = "BT_Open";
            this.BT_Open.Size = new System.Drawing.Size(75, 23);
            this.BT_Open.TabIndex = 7;
            this.BT_Open.Text = "Open";
            this.BT_Open.UseVisualStyleBackColor = true;
            this.BT_Open.Click += new System.EventHandler(this.BT_Open_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 450);
            this.Controls.Add(this.BT_Delete);
            this.Controls.Add(this.BT_Open);
            this.Controls.Add(this.BT_Save);
            this.Controls.Add(this.BT_New);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.TB_Title);
            this.Controls.Add(this.TB_Message);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_Message;
        private System.Windows.Forms.TextBox TB_Title;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.Button BT_New;
        private System.Windows.Forms.Button BT_Save;
        private System.Windows.Forms.Button BT_Delete;
        private System.Windows.Forms.Button BT_Open;
    }
}

