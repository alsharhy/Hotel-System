namespace Hospital_Managment_System.User_Control
{
    partial class UserControlRoom
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlRoom = new System.Windows.Forms.TabControl();
            this.tabPageAddRoom = new System.Windows.Forms.TabPage();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxRoomNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageSearchRoom = new System.Windows.Forms.TabPage();
            this.dataGridViewRoom = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxSearchRoomNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPageUpdateandDeleteRoom = new System.Windows.Forms.TabPage();
            this.radioButtonNo1 = new System.Windows.Forms.RadioButton();
            this.radioButtonYes1 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxType1 = new System.Windows.Forms.ComboBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxRoomNumer1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControlRoom.SuspendLayout();
            this.tabPageAddRoom.SuspendLayout();
            this.tabPageSearchRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).BeginInit();
            this.tabPageUpdateandDeleteRoom.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlRoom
            // 
            this.tabControlRoom.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlRoom.Controls.Add(this.tabPageAddRoom);
            this.tabControlRoom.Controls.Add(this.tabPageSearchRoom);
            this.tabControlRoom.Controls.Add(this.tabPageUpdateandDeleteRoom);
            this.tabControlRoom.Location = new System.Drawing.Point(36, 14);
            this.tabControlRoom.Name = "tabControlRoom";
            this.tabControlRoom.SelectedIndex = 0;
            this.tabControlRoom.Size = new System.Drawing.Size(1075, 528);
            this.tabControlRoom.TabIndex = 0;
            // 
            // tabPageAddRoom
            // 
            this.tabPageAddRoom.Controls.Add(this.radioButtonNo);
            this.tabPageAddRoom.Controls.Add(this.radioButtonYes);
            this.tabPageAddRoom.Controls.Add(this.label4);
            this.tabPageAddRoom.Controls.Add(this.comboBoxType);
            this.tabPageAddRoom.Controls.Add(this.buttonAdd);
            this.tabPageAddRoom.Controls.Add(this.textBoxRoomNumber);
            this.tabPageAddRoom.Controls.Add(this.label3);
            this.tabPageAddRoom.Controls.Add(this.label2);
            this.tabPageAddRoom.Controls.Add(this.label1);
            this.tabPageAddRoom.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddRoom.Name = "tabPageAddRoom";
            this.tabPageAddRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddRoom.Size = new System.Drawing.Size(1067, 494);
            this.tabPageAddRoom.TabIndex = 0;
            this.tabPageAddRoom.Text = "Add Room";
            this.tabPageAddRoom.UseVisualStyleBackColor = true;
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Location = new System.Drawing.Point(340, 271);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(55, 25);
            this.radioButtonNo.TabIndex = 15;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "No";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // radioButtonYes
            // 
            this.radioButtonYes.AutoSize = true;
            this.radioButtonYes.Location = new System.Drawing.Point(340, 240);
            this.radioButtonYes.Name = "radioButtonYes";
            this.radioButtonYes.Size = new System.Drawing.Size(60, 25);
            this.radioButtonYes.TabIndex = 14;
            this.radioButtonYes.TabStop = true;
            this.radioButtonYes.Text = "Yes";
            this.radioButtonYes.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(281, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Free:";
            // 
            // comboBoxType
            // 
            this.comboBoxType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Please select..",
            "single",
            "Double",
            "Famly",
            "Suite"});
            this.comboBoxType.Location = new System.Drawing.Point(285, 195);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(259, 29);
            this.comboBoxType.TabIndex = 12;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(275, 336);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(167, 60);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            // 
            // textBoxRoomNumber
            // 
            this.textBoxRoomNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxRoomNumber.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRoomNumber.Location = new System.Drawing.Point(621, 195);
            this.textBoxRoomNumber.Name = "textBoxRoomNumber";
            this.textBoxRoomNumber.Size = new System.Drawing.Size(259, 30);
            this.textBoxRoomNumber.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(617, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Room Number:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(281, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Type:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Add Room:";
            // 
            // tabPageSearchRoom
            // 
            this.tabPageSearchRoom.Controls.Add(this.dataGridViewRoom);
            this.tabPageSearchRoom.Controls.Add(this.textBoxSearchRoomNumber);
            this.tabPageSearchRoom.Controls.Add(this.label5);
            this.tabPageSearchRoom.Controls.Add(this.label6);
            this.tabPageSearchRoom.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchRoom.Name = "tabPageSearchRoom";
            this.tabPageSearchRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchRoom.Size = new System.Drawing.Size(1067, 494);
            this.tabPageSearchRoom.TabIndex = 1;
            this.tabPageSearchRoom.Text = "Search Room";
            this.tabPageSearchRoom.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRoom
            // 
            this.dataGridViewRoom.AllowUserToAddRows = false;
            this.dataGridViewRoom.AllowUserToDeleteRows = false;
            this.dataGridViewRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewRoom.Location = new System.Drawing.Point(19, 158);
            this.dataGridViewRoom.Name = "dataGridViewRoom";
            this.dataGridViewRoom.ReadOnly = true;
            this.dataGridViewRoom.RowTemplate.Height = 26;
            this.dataGridViewRoom.Size = new System.Drawing.Size(1014, 321);
            this.dataGridViewRoom.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Room_number";
            this.Column1.HeaderText = "Room Number";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Room_Type";
            this.Column2.HeaderText = "Type";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Phone_Room";
            this.Column3.HeaderText = "Phone";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Room_Free";
            this.Column4.HeaderText = "Is Free?";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // textBoxSearchRoomNumber
            // 
            this.textBoxSearchRoomNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSearchRoomNumber.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchRoomNumber.Location = new System.Drawing.Point(246, 91);
            this.textBoxSearchRoomNumber.Name = "textBoxSearchRoomNumber";
            this.textBoxSearchRoomNumber.Size = new System.Drawing.Size(259, 30);
            this.textBoxSearchRoomNumber.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(242, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Room Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label6.Location = new System.Drawing.Point(5, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "search Room:";
            // 
            // tabPageUpdateandDeleteRoom
            // 
            this.tabPageUpdateandDeleteRoom.Controls.Add(this.radioButtonNo1);
            this.tabPageUpdateandDeleteRoom.Controls.Add(this.radioButtonYes1);
            this.tabPageUpdateandDeleteRoom.Controls.Add(this.label7);
            this.tabPageUpdateandDeleteRoom.Controls.Add(this.textBoxType1);
            this.tabPageUpdateandDeleteRoom.Controls.Add(this.buttonDelete);
            this.tabPageUpdateandDeleteRoom.Controls.Add(this.buttonUpdate);
            this.tabPageUpdateandDeleteRoom.Controls.Add(this.textBoxRoomNumer1);
            this.tabPageUpdateandDeleteRoom.Controls.Add(this.label8);
            this.tabPageUpdateandDeleteRoom.Controls.Add(this.label9);
            this.tabPageUpdateandDeleteRoom.Controls.Add(this.label10);
            this.tabPageUpdateandDeleteRoom.Location = new System.Drawing.Point(4, 4);
            this.tabPageUpdateandDeleteRoom.Name = "tabPageUpdateandDeleteRoom";
            this.tabPageUpdateandDeleteRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdateandDeleteRoom.Size = new System.Drawing.Size(1067, 494);
            this.tabPageUpdateandDeleteRoom.TabIndex = 2;
            this.tabPageUpdateandDeleteRoom.Text = "Update and Delete Room";
            this.tabPageUpdateandDeleteRoom.UseVisualStyleBackColor = true;
            // 
            // radioButtonNo1
            // 
            this.radioButtonNo1.AutoSize = true;
            this.radioButtonNo1.Location = new System.Drawing.Point(309, 275);
            this.radioButtonNo1.Name = "radioButtonNo1";
            this.radioButtonNo1.Size = new System.Drawing.Size(55, 25);
            this.radioButtonNo1.TabIndex = 24;
            this.radioButtonNo1.TabStop = true;
            this.radioButtonNo1.Text = "No";
            this.radioButtonNo1.UseVisualStyleBackColor = true;
            // 
            // radioButtonYes1
            // 
            this.radioButtonYes1.AutoSize = true;
            this.radioButtonYes1.Location = new System.Drawing.Point(309, 244);
            this.radioButtonYes1.Name = "radioButtonYes1";
            this.radioButtonYes1.Size = new System.Drawing.Size(60, 25);
            this.radioButtonYes1.TabIndex = 23;
            this.radioButtonYes1.TabStop = true;
            this.radioButtonYes1.Text = "Yes";
            this.radioButtonYes1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(250, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 23);
            this.label7.TabIndex = 22;
            this.label7.Text = "Free:";
            // 
            // textBoxType1
            // 
            this.textBoxType1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxType1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBoxType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textBoxType1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textBoxType1.FormattingEnabled = true;
            this.textBoxType1.Items.AddRange(new object[] {
            "Plase select ..",
            "single",
            "Double",
            "Famly",
            "Suite"});
            this.textBoxType1.Location = new System.Drawing.Point(254, 199);
            this.textBoxType1.Name = "textBoxType1";
            this.textBoxType1.Size = new System.Drawing.Size(259, 29);
            this.textBoxType1.TabIndex = 21;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(451, 340);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(167, 60);
            this.buttonDelete.TabIndex = 20;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(244, 340);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(167, 60);
            this.buttonUpdate.TabIndex = 20;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            // 
            // textBoxRoomNumer1
            // 
            this.textBoxRoomNumer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxRoomNumer1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRoomNumer1.Location = new System.Drawing.Point(590, 199);
            this.textBoxRoomNumer1.Name = "textBoxRoomNumer1";
            this.textBoxRoomNumer1.Size = new System.Drawing.Size(259, 30);
            this.textBoxRoomNumer1.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(586, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 23);
            this.label8.TabIndex = 18;
            this.label8.Text = "Room Number:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(250, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 23);
            this.label9.TabIndex = 17;
            this.label9.Text = "Type:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label10.Location = new System.Drawing.Point(5, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(235, 23);
            this.label10.TabIndex = 16;
            this.label10.Text = "Update Or Delete Room:";
            // 
            // UserControlRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlRoom);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlRoom";
            this.Size = new System.Drawing.Size(1151, 647);
            this.tabControlRoom.ResumeLayout(false);
            this.tabPageAddRoom.ResumeLayout(false);
            this.tabPageAddRoom.PerformLayout();
            this.tabPageSearchRoom.ResumeLayout(false);
            this.tabPageSearchRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).EndInit();
            this.tabPageUpdateandDeleteRoom.ResumeLayout(false);
            this.tabPageUpdateandDeleteRoom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlRoom;
        private System.Windows.Forms.TabPage tabPageAddRoom;
        private System.Windows.Forms.TabPage tabPageSearchRoom;
        private System.Windows.Forms.TabPage tabPageUpdateandDeleteRoom;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxRoomNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.RadioButton radioButtonYes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewRoom;
        private System.Windows.Forms.TextBox textBoxSearchRoomNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.RadioButton radioButtonNo1;
        private System.Windows.Forms.RadioButton radioButtonYes1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox textBoxType1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxRoomNumer1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}
