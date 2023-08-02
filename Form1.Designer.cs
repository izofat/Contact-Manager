namespace Contact_Manager
{
    partial class Contact_Manager
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
            this.ContactsInfo = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPhonenum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelname = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPhonenum = new System.Windows.Forms.TextBox();
            this.labelPhonenum = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.labelsuccess = new System.Windows.Forms.Label();
            this.labelDelete = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.groupBoxAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContactsInfo
            // 
            this.ContactsInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderPhonenum,
            this.columnHeaderEmail});
            this.ContactsInfo.HideSelection = false;
            this.ContactsInfo.Location = new System.Drawing.Point(495, 12);
            this.ContactsInfo.Name = "ContactsInfo";
            this.ContactsInfo.Size = new System.Drawing.Size(366, 479);
            this.ContactsInfo.TabIndex = 0;
            this.ContactsInfo.UseCompatibleStateImageBehavior = false;
            this.ContactsInfo.View = System.Windows.Forms.View.Details;
            this.ContactsInfo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ContactsInfo_MouseDoubleClick);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 100;
            // 
            // columnHeaderPhonenum
            // 
            this.columnHeaderPhonenum.Text = "Phonenumber";
            this.columnHeaderPhonenum.Width = 102;
            // 
            // columnHeaderEmail
            // 
            this.columnHeaderEmail.Text = "Email";
            this.columnHeaderEmail.Width = 157;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(358, 88);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(131, 50);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add Contact";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelname.Location = new System.Drawing.Point(68, 29);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(65, 23);
            this.labelname.TabIndex = 2;
            this.labelname.Text = "Name :";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(139, 23);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(195, 34);
            this.textBoxName.TabIndex = 3;
            // 
            // textBoxPhonenum
            // 
            this.textBoxPhonenum.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhonenum.Location = new System.Drawing.Point(139, 74);
            this.textBoxPhonenum.Name = "textBoxPhonenum";
            this.textBoxPhonenum.Size = new System.Drawing.Size(195, 34);
            this.textBoxPhonenum.TabIndex = 5;
            // 
            // labelPhonenum
            // 
            this.labelPhonenum.AutoSize = true;
            this.labelPhonenum.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhonenum.Location = new System.Drawing.Point(0, 80);
            this.labelPhonenum.Name = "labelPhonenum";
            this.labelPhonenum.Size = new System.Drawing.Size(133, 23);
            this.labelPhonenum.TabIndex = 4;
            this.labelPhonenum.Text = "Phone number :";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(139, 127);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(195, 34);
            this.textBoxEmail.TabIndex = 7;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(68, 133);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(63, 23);
            this.labelEmail.TabIndex = 6;
            this.labelEmail.Text = "Email :";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(358, 426);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(131, 55);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Delete Contact";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.Controls.Add(this.textBoxEmail);
            this.groupBoxAdd.Controls.Add(this.labelname);
            this.groupBoxAdd.Controls.Add(this.textBoxName);
            this.groupBoxAdd.Controls.Add(this.labelEmail);
            this.groupBoxAdd.Controls.Add(this.labelPhonenum);
            this.groupBoxAdd.Controls.Add(this.textBoxPhonenum);
            this.groupBoxAdd.Location = new System.Drawing.Point(12, 30);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Size = new System.Drawing.Size(340, 176);
            this.groupBoxAdd.TabIndex = 9;
            this.groupBoxAdd.TabStop = false;
            this.groupBoxAdd.Visible = false;
            // 
            // labelsuccess
            // 
            this.labelsuccess.AutoSize = true;
            this.labelsuccess.Font = new System.Drawing.Font("Calibri", 15.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelsuccess.Location = new System.Drawing.Point(236, 209);
            this.labelsuccess.Name = "labelsuccess";
            this.labelsuccess.Size = new System.Drawing.Size(186, 26);
            this.labelsuccess.TabIndex = 10;
            this.labelsuccess.Text = "Added successfully !";
            this.labelsuccess.Visible = false;
            // 
            // labelDelete
            // 
            this.labelDelete.AutoSize = true;
            this.labelDelete.Font = new System.Drawing.Font("Calibri", 12.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelDelete.Location = new System.Drawing.Point(12, 403);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(19, 21);
            this.labelDelete.TabIndex = 11;
            this.labelDelete.Text = "0";
            this.labelDelete.Visible = false;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(358, 332);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(131, 55);
            this.buttonUpdate.TabIndex = 12;
            this.buttonUpdate.Text = "Update Contact";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // Contact_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 503);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.labelDelete);
            this.Controls.Add(this.labelsuccess);
            this.Controls.Add(this.groupBoxAdd);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.ContactsInfo);
            this.Name = "Contact_Manager";
            this.Text = "v";
            this.Load += new System.EventHandler(this.Contact_Manager_Load);
            this.groupBoxAdd.ResumeLayout(false);
            this.groupBoxAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ContactsInfo;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderPhonenum;
        private System.Windows.Forms.ColumnHeader columnHeaderEmail;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPhonenum;
        private System.Windows.Forms.Label labelPhonenum;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.Label labelsuccess;
        private System.Windows.Forms.Label labelDelete;
        private System.Windows.Forms.Button buttonUpdate;
    }
}

