namespace FootballClubMS.Applications
{
    partial class TicketSeller
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTicketInfo = new MetroFramework.Controls.MetroGrid();
            this.serial_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.cmbCustomerType = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.btnGet = new MetroFramework.Controls.MetroButton();
            this.btnDone = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtTotalPrice = new MetroFramework.Controls.MetroTextBox();
            this.txtPricePerTicket = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.cmbTicketQuantity = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.cmbFanStatus = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtCustomerEmail = new MetroFramework.Controls.MetroTextBox();
            this.txtCustomerName = new MetroFramework.Controls.MetroTextBox();
            this.txtCustomerId = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnChangePassword = new MetroFramework.Controls.MetroButton();
            this.txtNewPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtOldPassword = new MetroFramework.Controls.MetroTextBox();
            this.lblEmployeeSalary = new MetroFramework.Controls.MetroLabel();
            this.lblEmployeeDesignaiton = new MetroFramework.Controls.MetroLabel();
            this.lblEmployeeEmail = new MetroFramework.Controls.MetroLabel();
            this.lblEmployeeId = new MetroFramework.Controls.MetroLabel();
            this.lblEmployeeName = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.btnLogOut2 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicketInfo)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTicketInfo
            // 
            this.dgvTicketInfo.AllowUserToAddRows = false;
            this.dgvTicketInfo.AllowUserToDeleteRows = false;
            this.dgvTicketInfo.AllowUserToResizeRows = false;
            this.dgvTicketInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvTicketInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTicketInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTicketInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTicketInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvTicketInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTicketInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serial_no,
            this.customer_id,
            this.price});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTicketInfo.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvTicketInfo.EnableHeadersVisualStyles = false;
            this.dgvTicketInfo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvTicketInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvTicketInfo.Location = new System.Drawing.Point(370, 42);
            this.dgvTicketInfo.Name = "dgvTicketInfo";
            this.dgvTicketInfo.ReadOnly = true;
            this.dgvTicketInfo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTicketInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvTicketInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTicketInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTicketInfo.Size = new System.Drawing.Size(414, 256);
            this.dgvTicketInfo.TabIndex = 15;
            // 
            // serial_no
            // 
            this.serial_no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.serial_no.DataPropertyName = "serial_no";
            this.serial_no.HeaderText = "Serial No";
            this.serial_no.Name = "serial_no";
            this.serial_no.ReadOnly = true;
            // 
            // customer_id
            // 
            this.customer_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customer_id.DataPropertyName = "customer_id";
            this.customer_id.HeaderText = "Buyer";
            this.customer_id.Name = "customer_id";
            this.customer_id.ReadOnly = true;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(370, 20);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(132, 19);
            this.metroLabel8.TabIndex = 16;
            this.metroLabel8.Text = "Ticket Information";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(28, 72);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(813, 388);
            this.metroTabControl1.TabIndex = 17;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.btnChangePassword);
            this.metroTabPage1.Controls.Add(this.txtNewPassword);
            this.metroTabPage1.Controls.Add(this.txtOldPassword);
            this.metroTabPage1.Controls.Add(this.lblEmployeeSalary);
            this.metroTabPage1.Controls.Add(this.lblEmployeeDesignaiton);
            this.metroTabPage1.Controls.Add(this.lblEmployeeEmail);
            this.metroTabPage1.Controls.Add(this.lblEmployeeId);
            this.metroTabPage1.Controls.Add(this.lblEmployeeName);
            this.metroTabPage1.Controls.Add(this.metroLabel10);
            this.metroTabPage1.Controls.Add(this.metroLabel11);
            this.metroTabPage1.Controls.Add(this.metroLabel12);
            this.metroTabPage1.Controls.Add(this.metroLabel13);
            this.metroTabPage1.Controls.Add(this.metroLabel14);
            this.metroTabPage1.Controls.Add(this.metroLabel15);
            this.metroTabPage1.Controls.Add(this.metroLabel16);
            this.metroTabPage1.Controls.Add(this.metroLabel17);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(805, 346);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Ticket Seller Information";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.cmbCustomerType);
            this.metroTabPage2.Controls.Add(this.metroLabel9);
            this.metroTabPage2.Controls.Add(this.btnGet);
            this.metroTabPage2.Controls.Add(this.metroLabel8);
            this.metroTabPage2.Controls.Add(this.btnDone);
            this.metroTabPage2.Controls.Add(this.metroLabel7);
            this.metroTabPage2.Controls.Add(this.dgvTicketInfo);
            this.metroTabPage2.Controls.Add(this.txtTotalPrice);
            this.metroTabPage2.Controls.Add(this.txtPricePerTicket);
            this.metroTabPage2.Controls.Add(this.metroLabel6);
            this.metroTabPage2.Controls.Add(this.cmbTicketQuantity);
            this.metroTabPage2.Controls.Add(this.metroLabel5);
            this.metroTabPage2.Controls.Add(this.cmbFanStatus);
            this.metroTabPage2.Controls.Add(this.metroLabel4);
            this.metroTabPage2.Controls.Add(this.metroLabel3);
            this.metroTabPage2.Controls.Add(this.metroLabel2);
            this.metroTabPage2.Controls.Add(this.txtCustomerEmail);
            this.metroTabPage2.Controls.Add(this.txtCustomerName);
            this.metroTabPage2.Controls.Add(this.txtCustomerId);
            this.metroTabPage2.Controls.Add(this.metroLabel1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(805, 346);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Ticket Selling";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // cmbCustomerType
            // 
            this.cmbCustomerType.FormattingEnabled = true;
            this.cmbCustomerType.ItemHeight = 23;
            this.cmbCustomerType.Items.AddRange(new object[] {
            "New",
            "Existing"});
            this.cmbCustomerType.Location = new System.Drawing.Point(138, 20);
            this.cmbCustomerType.Name = "cmbCustomerType";
            this.cmbCustomerType.Size = new System.Drawing.Size(121, 29);
            this.cmbCustomerType.TabIndex = 32;
            this.cmbCustomerType.UseSelectable = true;
            this.cmbCustomerType.SelectedIndexChanged += new System.EventHandler(this.CmbCustomerType_SelectedIndexChanged);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(3, 20);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(97, 19);
            this.metroLabel9.TabIndex = 31;
            this.metroLabel9.Text = "Customer Type";
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(252, 97);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(98, 23);
            this.btnGet.TabIndex = 30;
            this.btnGet.Text = "Get Customer";
            this.btnGet.UseSelectable = true;
            this.btnGet.Click += new System.EventHandler(this.BtnGet_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(252, 283);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(108, 26);
            this.btnDone.TabIndex = 29;
            this.btnDone.Text = "Done";
            this.btnDone.UseSelectable = true;
            this.btnDone.Click += new System.EventHandler(this.BtnDone_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(12, 283);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(69, 19);
            this.metroLabel7.TabIndex = 28;
            this.metroLabel7.Text = "Total Price";
            // 
            // txtTotalPrice
            // 
            // 
            // 
            // 
            this.txtTotalPrice.CustomButton.Image = null;
            this.txtTotalPrice.CustomButton.Location = new System.Drawing.Point(86, 1);
            this.txtTotalPrice.CustomButton.Name = "";
            this.txtTotalPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTotalPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotalPrice.CustomButton.TabIndex = 1;
            this.txtTotalPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotalPrice.CustomButton.UseSelectable = true;
            this.txtTotalPrice.CustomButton.Visible = false;
            this.txtTotalPrice.Lines = new string[0];
            this.txtTotalPrice.Location = new System.Drawing.Point(138, 283);
            this.txtTotalPrice.MaxLength = 32767;
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.PasswordChar = '\0';
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalPrice.SelectedText = "";
            this.txtTotalPrice.SelectionLength = 0;
            this.txtTotalPrice.SelectionStart = 0;
            this.txtTotalPrice.ShortcutsEnabled = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(108, 23);
            this.txtTotalPrice.TabIndex = 27;
            this.txtTotalPrice.UseSelectable = true;
            this.txtTotalPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotalPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPricePerTicket
            // 
            // 
            // 
            // 
            this.txtPricePerTicket.CustomButton.Image = null;
            this.txtPricePerTicket.CustomButton.Location = new System.Drawing.Point(86, 1);
            this.txtPricePerTicket.CustomButton.Name = "";
            this.txtPricePerTicket.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPricePerTicket.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPricePerTicket.CustomButton.TabIndex = 1;
            this.txtPricePerTicket.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPricePerTicket.CustomButton.UseSelectable = true;
            this.txtPricePerTicket.CustomButton.Visible = false;
            this.txtPricePerTicket.Lines = new string[0];
            this.txtPricePerTicket.Location = new System.Drawing.Point(138, 219);
            this.txtPricePerTicket.MaxLength = 32767;
            this.txtPricePerTicket.Name = "txtPricePerTicket";
            this.txtPricePerTicket.PasswordChar = '\0';
            this.txtPricePerTicket.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPricePerTicket.SelectedText = "";
            this.txtPricePerTicket.SelectionLength = 0;
            this.txtPricePerTicket.SelectionStart = 0;
            this.txtPricePerTicket.ShortcutsEnabled = true;
            this.txtPricePerTicket.Size = new System.Drawing.Size(108, 23);
            this.txtPricePerTicket.TabIndex = 26;
            this.txtPricePerTicket.UseSelectable = true;
            this.txtPricePerTicket.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPricePerTicket.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(12, 248);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(58, 19);
            this.metroLabel6.TabIndex = 25;
            this.metroLabel6.Text = "Quantity";
            // 
            // cmbTicketQuantity
            // 
            this.cmbTicketQuantity.FormattingEnabled = true;
            this.cmbTicketQuantity.ItemHeight = 23;
            this.cmbTicketQuantity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbTicketQuantity.Location = new System.Drawing.Point(138, 248);
            this.cmbTicketQuantity.Name = "cmbTicketQuantity";
            this.cmbTicketQuantity.Size = new System.Drawing.Size(108, 29);
            this.cmbTicketQuantity.TabIndex = 24;
            this.cmbTicketQuantity.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(12, 219);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(98, 19);
            this.metroLabel5.TabIndex = 23;
            this.metroLabel5.Text = "Price Per Ticket";
            // 
            // cmbFanStatus
            // 
            this.cmbFanStatus.FormattingEnabled = true;
            this.cmbFanStatus.ItemHeight = 23;
            this.cmbFanStatus.Items.AddRange(new object[] {
            "Not Fan",
            "Fan"});
            this.cmbFanStatus.Location = new System.Drawing.Point(138, 184);
            this.cmbFanStatus.Name = "cmbFanStatus";
            this.cmbFanStatus.Size = new System.Drawing.Size(108, 29);
            this.cmbFanStatus.TabIndex = 22;
            this.cmbFanStatus.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(12, 184);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(67, 19);
            this.metroLabel4.TabIndex = 21;
            this.metroLabel4.Text = "Fan Status";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(12, 155);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(47, 19);
            this.metroLabel3.TabIndex = 20;
            this.metroLabel3.Text = "E-mail";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(12, 126);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 19);
            this.metroLabel2.TabIndex = 19;
            this.metroLabel2.Text = "Name";
            // 
            // txtCustomerEmail
            // 
            // 
            // 
            // 
            this.txtCustomerEmail.CustomButton.Image = null;
            this.txtCustomerEmail.CustomButton.Location = new System.Drawing.Point(86, 1);
            this.txtCustomerEmail.CustomButton.Name = "";
            this.txtCustomerEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCustomerEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCustomerEmail.CustomButton.TabIndex = 1;
            this.txtCustomerEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCustomerEmail.CustomButton.UseSelectable = true;
            this.txtCustomerEmail.CustomButton.Visible = false;
            this.txtCustomerEmail.Lines = new string[0];
            this.txtCustomerEmail.Location = new System.Drawing.Point(138, 155);
            this.txtCustomerEmail.MaxLength = 32767;
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.PasswordChar = '\0';
            this.txtCustomerEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCustomerEmail.SelectedText = "";
            this.txtCustomerEmail.SelectionLength = 0;
            this.txtCustomerEmail.SelectionStart = 0;
            this.txtCustomerEmail.ShortcutsEnabled = true;
            this.txtCustomerEmail.Size = new System.Drawing.Size(108, 23);
            this.txtCustomerEmail.TabIndex = 18;
            this.txtCustomerEmail.UseSelectable = true;
            this.txtCustomerEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCustomerEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCustomerName
            // 
            // 
            // 
            // 
            this.txtCustomerName.CustomButton.Image = null;
            this.txtCustomerName.CustomButton.Location = new System.Drawing.Point(86, 1);
            this.txtCustomerName.CustomButton.Name = "";
            this.txtCustomerName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCustomerName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCustomerName.CustomButton.TabIndex = 1;
            this.txtCustomerName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCustomerName.CustomButton.UseSelectable = true;
            this.txtCustomerName.CustomButton.Visible = false;
            this.txtCustomerName.Lines = new string[0];
            this.txtCustomerName.Location = new System.Drawing.Point(138, 126);
            this.txtCustomerName.MaxLength = 32767;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.PasswordChar = '\0';
            this.txtCustomerName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCustomerName.SelectedText = "";
            this.txtCustomerName.SelectionLength = 0;
            this.txtCustomerName.SelectionStart = 0;
            this.txtCustomerName.ShortcutsEnabled = true;
            this.txtCustomerName.Size = new System.Drawing.Size(108, 23);
            this.txtCustomerName.TabIndex = 17;
            this.txtCustomerName.UseSelectable = true;
            this.txtCustomerName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCustomerName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCustomerId
            // 
            // 
            // 
            // 
            this.txtCustomerId.CustomButton.Image = null;
            this.txtCustomerId.CustomButton.Location = new System.Drawing.Point(86, 1);
            this.txtCustomerId.CustomButton.Name = "";
            this.txtCustomerId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCustomerId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCustomerId.CustomButton.TabIndex = 1;
            this.txtCustomerId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCustomerId.CustomButton.UseSelectable = true;
            this.txtCustomerId.CustomButton.Visible = false;
            this.txtCustomerId.Lines = new string[0];
            this.txtCustomerId.Location = new System.Drawing.Point(138, 97);
            this.txtCustomerId.MaxLength = 32767;
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.PasswordChar = '\0';
            this.txtCustomerId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCustomerId.SelectedText = "";
            this.txtCustomerId.SelectionLength = 0;
            this.txtCustomerId.SelectionStart = 0;
            this.txtCustomerId.ShortcutsEnabled = true;
            this.txtCustomerId.Size = new System.Drawing.Size(108, 23);
            this.txtCustomerId.TabIndex = 16;
            this.txtCustomerId.UseSelectable = true;
            this.txtCustomerId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCustomerId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 97);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(81, 19);
            this.metroLabel1.TabIndex = 15;
            this.metroLabel1.Text = "Customer Id";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(259, 300);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(75, 23);
            this.btnChangePassword.TabIndex = 32;
            this.btnChangePassword.Text = "Change";
            this.btnChangePassword.UseSelectable = true;
            this.btnChangePassword.Click += new System.EventHandler(this.BtnChangePassword_Click);
            // 
            // txtNewPassword
            // 
            // 
            // 
            // 
            this.txtNewPassword.CustomButton.Image = null;
            this.txtNewPassword.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.txtNewPassword.CustomButton.Name = "";
            this.txtNewPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNewPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNewPassword.CustomButton.TabIndex = 1;
            this.txtNewPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNewPassword.CustomButton.UseSelectable = true;
            this.txtNewPassword.CustomButton.Visible = false;
            this.txtNewPassword.Lines = new string[0];
            this.txtNewPassword.Location = new System.Drawing.Point(167, 271);
            this.txtNewPassword.MaxLength = 32767;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '\0';
            this.txtNewPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNewPassword.SelectedText = "";
            this.txtNewPassword.SelectionLength = 0;
            this.txtNewPassword.SelectionStart = 0;
            this.txtNewPassword.ShortcutsEnabled = true;
            this.txtNewPassword.Size = new System.Drawing.Size(167, 23);
            this.txtNewPassword.TabIndex = 31;
            this.txtNewPassword.UseSelectable = true;
            this.txtNewPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNewPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtOldPassword
            // 
            // 
            // 
            // 
            this.txtOldPassword.CustomButton.Image = null;
            this.txtOldPassword.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.txtOldPassword.CustomButton.Name = "";
            this.txtOldPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtOldPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOldPassword.CustomButton.TabIndex = 1;
            this.txtOldPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOldPassword.CustomButton.UseSelectable = true;
            this.txtOldPassword.CustomButton.Visible = false;
            this.txtOldPassword.Lines = new string[0];
            this.txtOldPassword.Location = new System.Drawing.Point(167, 237);
            this.txtOldPassword.MaxLength = 32767;
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.PasswordChar = '\0';
            this.txtOldPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOldPassword.SelectedText = "";
            this.txtOldPassword.SelectionLength = 0;
            this.txtOldPassword.SelectionStart = 0;
            this.txtOldPassword.ShortcutsEnabled = true;
            this.txtOldPassword.Size = new System.Drawing.Size(167, 23);
            this.txtOldPassword.TabIndex = 30;
            this.txtOldPassword.UseSelectable = true;
            this.txtOldPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOldPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblEmployeeSalary
            // 
            this.lblEmployeeSalary.AutoSize = true;
            this.lblEmployeeSalary.Location = new System.Drawing.Point(110, 157);
            this.lblEmployeeSalary.Name = "lblEmployeeSalary";
            this.lblEmployeeSalary.Size = new System.Drawing.Size(83, 19);
            this.lblEmployeeSalary.TabIndex = 29;
            this.lblEmployeeSalary.Text = "metroLabel9";
            // 
            // lblEmployeeDesignaiton
            // 
            this.lblEmployeeDesignaiton.AutoSize = true;
            this.lblEmployeeDesignaiton.Location = new System.Drawing.Point(110, 123);
            this.lblEmployeeDesignaiton.Name = "lblEmployeeDesignaiton";
            this.lblEmployeeDesignaiton.Size = new System.Drawing.Size(88, 19);
            this.lblEmployeeDesignaiton.TabIndex = 28;
            this.lblEmployeeDesignaiton.Text = "metroLabel10";
            // 
            // lblEmployeeEmail
            // 
            this.lblEmployeeEmail.AutoSize = true;
            this.lblEmployeeEmail.Location = new System.Drawing.Point(110, 91);
            this.lblEmployeeEmail.Name = "lblEmployeeEmail";
            this.lblEmployeeEmail.Size = new System.Drawing.Size(86, 19);
            this.lblEmployeeEmail.TabIndex = 27;
            this.lblEmployeeEmail.Text = "metroLabel11";
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Location = new System.Drawing.Point(110, 54);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(88, 19);
            this.lblEmployeeId.TabIndex = 26;
            this.lblEmployeeId.Text = "metroLabel12";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(110, 21);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(88, 19);
            this.lblEmployeeName.TabIndex = 25;
            this.lblEmployeeName.Text = "metroLabel13";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(3, 271);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(127, 19);
            this.metroLabel10.TabIndex = 24;
            this.metroLabel10.Text = "Enter New Password";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(3, 237);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(123, 19);
            this.metroLabel11.TabIndex = 23;
            this.metroLabel11.Text = "Enter Old Password";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel12.Location = new System.Drawing.Point(3, 193);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(161, 25);
            this.metroLabel12.TabIndex = 22;
            this.metroLabel12.Text = "Change Password";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(3, 157);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(45, 19);
            this.metroLabel13.TabIndex = 21;
            this.metroLabel13.Text = "Salary";
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(3, 123);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(77, 19);
            this.metroLabel14.TabIndex = 20;
            this.metroLabel14.Text = "Designation";
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(3, 91);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(41, 19);
            this.metroLabel15.TabIndex = 19;
            this.metroLabel15.Text = "Email";
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(3, 54);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(21, 19);
            this.metroLabel16.TabIndex = 18;
            this.metroLabel16.Text = "ID";
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(3, 21);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(45, 19);
            this.metroLabel17.TabIndex = 17;
            this.metroLabel17.Text = "Name";
            // 
            // btnLogOut2
            // 
            this.btnLogOut2.Location = new System.Drawing.Point(752, 34);
            this.btnLogOut2.Name = "btnLogOut2";
            this.btnLogOut2.Size = new System.Drawing.Size(85, 32);
            this.btnLogOut2.TabIndex = 34;
            this.btnLogOut2.Text = "LogOut";
            this.btnLogOut2.UseSelectable = true;
            this.btnLogOut2.Click += new System.EventHandler(this.BtnLogOut2_Click);
            // 
            // TicketSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 483);
            this.Controls.Add(this.btnLogOut2);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "TicketSeller";
            this.Text = "TicketSeller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TicketSeller_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicketInfo)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroGrid dgvTicketInfo;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.DataGridViewTextBoxColumn serial_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroComboBox cmbCustomerType;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroButton btnGet;
        private MetroFramework.Controls.MetroButton btnDone;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtTotalPrice;
        private MetroFramework.Controls.MetroTextBox txtPricePerTicket;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroComboBox cmbTicketQuantity;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox cmbFanStatus;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtCustomerEmail;
        private MetroFramework.Controls.MetroTextBox txtCustomerName;
        private MetroFramework.Controls.MetroTextBox txtCustomerId;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnChangePassword;
        private MetroFramework.Controls.MetroTextBox txtNewPassword;
        private MetroFramework.Controls.MetroTextBox txtOldPassword;
        private MetroFramework.Controls.MetroLabel lblEmployeeSalary;
        private MetroFramework.Controls.MetroLabel lblEmployeeDesignaiton;
        private MetroFramework.Controls.MetroLabel lblEmployeeEmail;
        private MetroFramework.Controls.MetroLabel lblEmployeeId;
        private MetroFramework.Controls.MetroLabel lblEmployeeName;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroButton btnLogOut2;
    }
}