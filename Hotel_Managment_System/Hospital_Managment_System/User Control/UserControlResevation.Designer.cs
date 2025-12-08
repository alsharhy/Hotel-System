namespace Hospital_Managment_System.User_Control
{
    partial class UserControlResevation
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
            this.tabControlResevation = new System.Windows.Forms.TabControl();
            this.tabPageAddResevation = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerOut = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerIn = new System.Windows.Forms.DateTimePicker();
            this.comboBoxRoomNumber = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.textBoxClientID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageSearchResevation = new System.Windows.Forms.TabPage();
            this.dataGridViewResevation = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxSearchClientID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPageUpdateandDelateResevation = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePickerOut1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerIn1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxrRoomNumber1 = new System.Windows.Forms.ComboBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.comboBoxType1 = new System.Windows.Forms.ComboBox();
            this.textBoxClientID1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tabControlResevation.SuspendLayout();
            this.tabPageAddResevation.SuspendLayout();
            this.tabPageSearchResevation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResevation)).BeginInit();
            this.tabPageUpdateandDelateResevation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlResevation
            // 
            this.tabControlResevation.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlResevation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlResevation.Controls.Add(this.tabPageAddResevation);
            this.tabControlResevation.Controls.Add(this.tabPageSearchResevation);
            this.tabControlResevation.Controls.Add(this.tabPageUpdateandDelateResevation);
            this.tabControlResevation.Location = new System.Drawing.Point(30, 72);
            this.tabControlResevation.Name = "tabControlResevation";
            this.tabControlResevation.SelectedIndex = 0;
            this.tabControlResevation.Size = new System.Drawing.Size(1127, 526);
            this.tabControlResevation.TabIndex = 0;
            // 
            // tabPageAddResevation
            // 
            this.tabPageAddResevation.Controls.Add(this.label6);
            this.tabPageAddResevation.Controls.Add(this.label5);
            this.tabPageAddResevation.Controls.Add(this.dateTimePickerOut);
            this.tabPageAddResevation.Controls.Add(this.dateTimePickerIn);
            this.tabPageAddResevation.Controls.Add(this.comboBoxRoomNumber);
            this.tabPageAddResevation.Controls.Add(this.buttonAdd);
            this.tabPageAddResevation.Controls.Add(this.comboBoxType);
            this.tabPageAddResevation.Controls.Add(this.textBoxClientID);
            this.tabPageAddResevation.Controls.Add(this.label4);
            this.tabPageAddResevation.Controls.Add(this.label3);
            this.tabPageAddResevation.Controls.Add(this.label2);
            this.tabPageAddResevation.Controls.Add(this.label1);
            this.tabPageAddResevation.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddResevation.Name = "tabPageAddResevation";
            this.tabPageAddResevation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddResevation.Size = new System.Drawing.Size(1119, 492);
            this.tabPageAddResevation.TabIndex = 0;
            this.tabPageAddResevation.Text = "Add Resevation";
            this.tabPageAddResevation.UseVisualStyleBackColor = true;
            this.tabPageAddResevation.Leave += new System.EventHandler(this.tabPageAddResevation_Leave);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(547, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 22);
            this.label6.TabIndex = 25;
            this.label6.Text = "Out:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(211, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 22);
            this.label5.TabIndex = 25;
            this.label5.Text = "In:";
            // 
            // dateTimePickerOut
            // 
            this.dateTimePickerOut.Location = new System.Drawing.Point(551, 268);
            this.dateTimePickerOut.Name = "dateTimePickerOut";
            this.dateTimePickerOut.Size = new System.Drawing.Size(259, 28);
            this.dateTimePickerOut.TabIndex = 24;
            // 
            // dateTimePickerIn
            // 
            this.dateTimePickerIn.Location = new System.Drawing.Point(215, 268);
            this.dateTimePickerIn.Name = "dateTimePickerIn";
            this.dateTimePickerIn.Size = new System.Drawing.Size(259, 28);
            this.dateTimePickerIn.TabIndex = 24;
            // 
            // comboBoxRoomNumber
            // 
            this.comboBoxRoomNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoomNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxRoomNumber.FormattingEnabled = true;
            this.comboBoxRoomNumber.Items.AddRange(new object[] {
            "Plase Select .."});
            this.comboBoxRoomNumber.Location = new System.Drawing.Point(551, 114);
            this.comboBoxRoomNumber.Name = "comboBoxRoomNumber";
            this.comboBoxRoomNumber.Size = new System.Drawing.Size(259, 29);
            this.comboBoxRoomNumber.TabIndex = 23;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(215, 352);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(167, 60);
            this.buttonAdd.TabIndex = 22;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Please selecr ...",
            "Single",
            "Double",
            "Family",
            "Suite"});
            this.comboBoxType.Location = new System.Drawing.Point(215, 114);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(259, 29);
            this.comboBoxType.TabIndex = 21;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // textBoxClientID
            // 
            this.textBoxClientID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxClientID.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxClientID.Location = new System.Drawing.Point(215, 197);
            this.textBoxClientID.Name = "textBoxClientID";
            this.textBoxClientID.Size = new System.Drawing.Size(259, 30);
            this.textBoxClientID.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(211, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 22);
            this.label4.TabIndex = 19;
            this.label4.Text = "Client ID:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(547, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "Room Number:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(211, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Room Type:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Add Resevation:";
            // 
            // tabPageSearchResevation
            // 
            this.tabPageSearchResevation.Controls.Add(this.dataGridViewResevation);
            this.tabPageSearchResevation.Controls.Add(this.textBoxSearchClientID);
            this.tabPageSearchResevation.Controls.Add(this.label7);
            this.tabPageSearchResevation.Controls.Add(this.label8);
            this.tabPageSearchResevation.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchResevation.Name = "tabPageSearchResevation";
            this.tabPageSearchResevation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchResevation.Size = new System.Drawing.Size(1119, 492);
            this.tabPageSearchResevation.TabIndex = 1;
            this.tabPageSearchResevation.Text = "Search Resevation";
            this.tabPageSearchResevation.UseVisualStyleBackColor = true;
            this.tabPageSearchResevation.Enter += new System.EventHandler(this.tabPageSearchResevation_Enter);
            this.tabPageSearchResevation.Leave += new System.EventHandler(this.tabPageSearchResevation_Leave);
            // 
            // dataGridViewResevation
            // 
            this.dataGridViewResevation.AllowUserToAddRows = false;
            this.dataGridViewResevation.AllowUserToDeleteRows = false;
            this.dataGridViewResevation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewResevation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewResevation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewResevation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResevation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridViewResevation.Location = new System.Drawing.Point(42, 158);
            this.dataGridViewResevation.Name = "dataGridViewResevation";
            this.dataGridViewResevation.ReadOnly = true;
            this.dataGridViewResevation.RowHeadersWidth = 51;
            this.dataGridViewResevation.RowTemplate.Height = 26;
            this.dataGridViewResevation.Size = new System.Drawing.Size(1014, 321);
            this.dataGridViewResevation.TabIndex = 13;
            this.dataGridViewResevation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewResevation_CellClick);
            this.dataGridViewResevation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClient_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Resevation_ID";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Resevation_Room_Tyoe";
            this.Column2.HeaderText = "Room Type";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Resevation_Room_Number";
            this.Column3.HeaderText = "Room Number";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Resevation_Client_ID";
            this.Column4.HeaderText = "Client ID";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Resevation_In";
            this.Column5.HeaderText = "In";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "_Out";
            this.Column6.HeaderText = "Out";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // textBoxSearchClientID
            // 
            this.textBoxSearchClientID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSearchClientID.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchClientID.Location = new System.Drawing.Point(253, 95);
            this.textBoxSearchClientID.Name = "textBoxSearchClientID";
            this.textBoxSearchClientID.Size = new System.Drawing.Size(259, 30);
            this.textBoxSearchClientID.TabIndex = 12;
            this.textBoxSearchClientID.TextChanged += new System.EventHandler(this.textBoxSearchphoneNo_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(249, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 22);
            this.label7.TabIndex = 11;
            this.label7.Text = "Client ID:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label8.Location = new System.Drawing.Point(6, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 22);
            this.label8.TabIndex = 10;
            this.label8.Text = "search Resevation:";
            // 
            // tabPageUpdateandDelateResevation
            // 
            this.tabPageUpdateandDelateResevation.Controls.Add(this.label9);
            this.tabPageUpdateandDelateResevation.Controls.Add(this.label10);
            this.tabPageUpdateandDelateResevation.Controls.Add(this.dateTimePickerOut1);
            this.tabPageUpdateandDelateResevation.Controls.Add(this.dateTimePickerIn1);
            this.tabPageUpdateandDelateResevation.Controls.Add(this.comboBoxrRoomNumber1);
            this.tabPageUpdateandDelateResevation.Controls.Add(this.buttonCancel);
            this.tabPageUpdateandDelateResevation.Controls.Add(this.buttonUpdate);
            this.tabPageUpdateandDelateResevation.Controls.Add(this.comboBoxType1);
            this.tabPageUpdateandDelateResevation.Controls.Add(this.textBoxClientID1);
            this.tabPageUpdateandDelateResevation.Controls.Add(this.label11);
            this.tabPageUpdateandDelateResevation.Controls.Add(this.label12);
            this.tabPageUpdateandDelateResevation.Controls.Add(this.label13);
            this.tabPageUpdateandDelateResevation.Controls.Add(this.label14);
            this.tabPageUpdateandDelateResevation.Location = new System.Drawing.Point(4, 4);
            this.tabPageUpdateandDelateResevation.Name = "tabPageUpdateandDelateResevation";
            this.tabPageUpdateandDelateResevation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdateandDelateResevation.Size = new System.Drawing.Size(1119, 492);
            this.tabPageUpdateandDelateResevation.TabIndex = 2;
            this.tabPageUpdateandDelateResevation.Text = "Update and Delate Resevation";
            this.tabPageUpdateandDelateResevation.UseVisualStyleBackColor = true;
            this.tabPageUpdateandDelateResevation.Leave += new System.EventHandler(this.tabPageUpdateandDelateResevation_Leave);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(538, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 22);
            this.label9.TabIndex = 36;
            this.label9.Text = "Out:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(202, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 22);
            this.label10.TabIndex = 37;
            this.label10.Text = "In:";
            // 
            // dateTimePickerOut1
            // 
            this.dateTimePickerOut1.Location = new System.Drawing.Point(542, 269);
            this.dateTimePickerOut1.Name = "dateTimePickerOut1";
            this.dateTimePickerOut1.Size = new System.Drawing.Size(259, 28);
            this.dateTimePickerOut1.TabIndex = 34;
            // 
            // dateTimePickerIn1
            // 
            this.dateTimePickerIn1.Location = new System.Drawing.Point(206, 269);
            this.dateTimePickerIn1.Name = "dateTimePickerIn1";
            this.dateTimePickerIn1.Size = new System.Drawing.Size(259, 28);
            this.dateTimePickerIn1.TabIndex = 35;
            // 
            // comboBoxrRoomNumber1
            // 
            this.comboBoxrRoomNumber1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxrRoomNumber1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxrRoomNumber1.FormattingEnabled = true;
            this.comboBoxrRoomNumber1.Items.AddRange(new object[] {
            "Plase select .."});
            this.comboBoxrRoomNumber1.Location = new System.Drawing.Point(542, 115);
            this.comboBoxrRoomNumber1.Name = "comboBoxrRoomNumber1";
            this.comboBoxrRoomNumber1.Size = new System.Drawing.Size(259, 29);
            this.comboBoxrRoomNumber1.TabIndex = 33;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(441, 353);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(167, 60);
            this.buttonCancel.TabIndex = 32;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(206, 353);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(167, 60);
            this.buttonUpdate.TabIndex = 32;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // comboBoxType1
            // 
            this.comboBoxType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxType1.FormattingEnabled = true;
            this.comboBoxType1.Items.AddRange(new object[] {
            "Plase select ..",
            "Single",
            "Double",
            "Family",
            "Suite"});
            this.comboBoxType1.Location = new System.Drawing.Point(206, 115);
            this.comboBoxType1.Name = "comboBoxType1";
            this.comboBoxType1.Size = new System.Drawing.Size(259, 29);
            this.comboBoxType1.TabIndex = 31;
            this.comboBoxType1.SelectedIndexChanged += new System.EventHandler(this.comboBoxType1_SelectedIndexChanged);
            // 
            // textBoxClientID1
            // 
            this.textBoxClientID1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxClientID1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxClientID1.Location = new System.Drawing.Point(206, 198);
            this.textBoxClientID1.Name = "textBoxClientID1";
            this.textBoxClientID1.Size = new System.Drawing.Size(259, 30);
            this.textBoxClientID1.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(202, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 22);
            this.label11.TabIndex = 29;
            this.label11.Text = "Client ID:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(538, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 22);
            this.label12.TabIndex = 28;
            this.label12.Text = "Room Number:";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(202, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 22);
            this.label13.TabIndex = 27;
            this.label13.Text = "Room Type:";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label14.Location = new System.Drawing.Point(6, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(291, 22);
            this.label14.TabIndex = 26;
            this.label14.Text = "Update and Cancel Resevation:";
            // 
            // UserControlResevation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlResevation);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlResevation";
            this.Size = new System.Drawing.Size(1205, 746);
            this.Load += new System.EventHandler(this.UserControlResevation_Load);
            this.tabControlResevation.ResumeLayout(false);
            this.tabPageAddResevation.ResumeLayout(false);
            this.tabPageAddResevation.PerformLayout();
            this.tabPageSearchResevation.ResumeLayout(false);
            this.tabPageSearchResevation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResevation)).EndInit();
            this.tabPageUpdateandDelateResevation.ResumeLayout(false);
            this.tabPageUpdateandDelateResevation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlResevation;
        private System.Windows.Forms.TabPage tabPageAddResevation;
        private System.Windows.Forms.TabPage tabPageSearchResevation;
        private System.Windows.Forms.TabPage tabPageUpdateandDelateResevation;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox textBoxClientID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerIn;
        private System.Windows.Forms.ComboBox comboBoxRoomNumber;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerOut;
        private System.Windows.Forms.DataGridView dataGridViewResevation;
        private System.Windows.Forms.TextBox textBoxSearchClientID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePickerOut1;
        private System.Windows.Forms.DateTimePicker dateTimePickerIn1;
        private System.Windows.Forms.ComboBox comboBoxrRoomNumber1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.ComboBox comboBoxType1;
        private System.Windows.Forms.TextBox textBoxClientID1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}
