namespace Hotet_System.Forms
{
    partial class FormReservation
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReservation));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgReservationDetail = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.epCustomers = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel21 = new System.Windows.Forms.Panel();
            this.txtNC = new System.Windows.Forms.TextBox();
            this.panel22 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.txtNA = new System.Windows.Forms.TextBox();
            this.panel20 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.cboPayment = new System.Windows.Forms.ComboBox();
            this.panel18 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.cboCheckOut = new System.Windows.Forms.ComboBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cboCheckin = new System.Windows.Forms.ComboBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel23 = new System.Windows.Forms.Panel();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.panel25 = new System.Windows.Forms.Panel();
            this.txtReservationId = new System.Windows.Forms.TextBox();
            this.btnNext = new Hotet_System.Controller.MyButton();
            this.btnPervious = new Hotet_System.Controller.MyButton();
            this.btnEdit = new Hotet_System.Controller.MyButton();
            this.btnSave = new Hotet_System.Controller.MyButton();
            this.btnNew = new Hotet_System.Controller.MyButton();
            this.btnDelete = new Hotet_System.Controller.MyButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel13.SuspendLayout();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReservationDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCustomers)).BeginInit();
            this.panel21.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel23.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2038, 66);
            this.panel2.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.label4.Location = new System.Drawing.Point(77, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 41);
            this.label4.TabIndex = 5;
            this.label4.Text = "  /  Reservation";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(41, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.panel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel11.Location = new System.Drawing.Point(0, 66);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(35, 1035);
            this.panel11.TabIndex = 38;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.White;
            this.panel13.Controls.Add(this.panel15);
            this.panel13.Controls.Add(this.label5);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(35, 66);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(2003, 84);
            this.panel13.TabIndex = 40;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.btnEdit);
            this.panel15.Controls.Add(this.btnSave);
            this.panel15.Controls.Add(this.btnNew);
            this.panel15.Controls.Add(this.btnDelete);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel15.Location = new System.Drawing.Point(942, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(1061, 84);
            this.panel15.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.label5.Location = new System.Drawing.Point(20, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(445, 62);
            this.label5.TabIndex = 6;
            this.label5.Text = "Reservation Detail";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(35, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2003, 10);
            this.panel1.TabIndex = 41;
            // 
            // dgReservationDetail
            // 
            this.dgReservationDetail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgReservationDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgReservationDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReservationDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgReservationDetail.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgReservationDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgReservationDetail.Location = new System.Drawing.Point(35, 761);
            this.dgReservationDetail.Name = "dgReservationDetail";
            this.dgReservationDetail.RowHeadersVisible = false;
            this.dgReservationDetail.RowHeadersWidth = 62;
            this.dgReservationDetail.RowTemplate.Height = 28;
            this.dgReservationDetail.Size = new System.Drawing.Size(2003, 340);
            this.dgReservationDetail.TabIndex = 42;
            this.dgReservationDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgReservationDetails_CellContentClick);
            this.dgReservationDetail.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgReservationDetail_CellValueChanged);
            this.dgReservationDetail.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgReservationDetail_DataError);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.Width = 150;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Column8";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            this.Column8.Width = 150;
            // 
            // epCustomers
            // 
            this.epCustomers.ContainerControl = this;
            // 
            // txtMemo
            // 
            this.txtMemo.BackColor = System.Drawing.Color.White;
            this.txtMemo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMemo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemo.ForeColor = System.Drawing.Color.Black;
            this.txtMemo.Location = new System.Drawing.Point(585, 287);
            this.txtMemo.Multiline = true;
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(465, 358);
            this.txtMemo.TabIndex = 148;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(578, 242);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 42);
            this.label13.TabIndex = 165;
            this.label13.Text = "Memo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(134, 536);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(357, 42);
            this.label11.TabIndex = 164;
            this.label11.Text = "Number of Childrens";
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.txtNC);
            this.panel21.Controls.Add(this.panel22);
            this.panel21.Location = new System.Drawing.Point(136, 581);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(377, 96);
            this.panel21.TabIndex = 163;
            // 
            // txtNC
            // 
            this.txtNC.BackColor = System.Drawing.Color.White;
            this.txtNC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNC.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNC.ForeColor = System.Drawing.Color.Black;
            this.txtNC.Location = new System.Drawing.Point(5, 24);
            this.txtNC.Name = "txtNC";
            this.txtNC.Size = new System.Drawing.Size(353, 31);
            this.txtNC.TabIndex = 5;
            // 
            // panel22
            // 
            this.panel22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel22.Location = new System.Drawing.Point(4, 61);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(354, 3);
            this.panel22.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(134, 392);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(309, 42);
            this.label10.TabIndex = 162;
            this.label10.Text = "Number of Adults";
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.txtNA);
            this.panel19.Controls.Add(this.panel20);
            this.panel19.Location = new System.Drawing.Point(136, 437);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(377, 79);
            this.panel19.TabIndex = 161;
            // 
            // txtNA
            // 
            this.txtNA.BackColor = System.Drawing.Color.White;
            this.txtNA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNA.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNA.ForeColor = System.Drawing.Color.Black;
            this.txtNA.Location = new System.Drawing.Point(5, 24);
            this.txtNA.Name = "txtNA";
            this.txtNA.Size = new System.Drawing.Size(353, 31);
            this.txtNA.TabIndex = 5;
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel20.Location = new System.Drawing.Point(4, 61);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(354, 3);
            this.panel20.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1579, 536);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 42);
            this.label9.TabIndex = 160;
            this.label9.Text = "Payment";
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.cboPayment);
            this.panel17.Controls.Add(this.panel18);
            this.panel17.Location = new System.Drawing.Point(1581, 581);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(386, 79);
            this.panel17.TabIndex = 159;
            // 
            // cboPayment
            // 
            this.cboPayment.BackColor = System.Drawing.Color.White;
            this.cboPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPayment.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPayment.ForeColor = System.Drawing.Color.Black;
            this.cboPayment.FormattingEnabled = true;
            this.cboPayment.Location = new System.Drawing.Point(5, 16);
            this.cboPayment.Name = "cboPayment";
            this.cboPayment.Size = new System.Drawing.Size(353, 39);
            this.cboPayment.TabIndex = 8;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel18.Location = new System.Drawing.Point(4, 61);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(354, 3);
            this.panel18.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1577, 392);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 42);
            this.label7.TabIndex = 158;
            this.label7.Text = "Check Out";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.cboCheckOut);
            this.panel10.Controls.Add(this.panel14);
            this.panel10.Location = new System.Drawing.Point(1582, 437);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(385, 79);
            this.panel10.TabIndex = 157;
            // 
            // cboCheckOut
            // 
            this.cboCheckOut.BackColor = System.Drawing.Color.White;
            this.cboCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCheckOut.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCheckOut.ForeColor = System.Drawing.Color.Black;
            this.cboCheckOut.FormattingEnabled = true;
            this.cboCheckOut.Location = new System.Drawing.Point(5, 16);
            this.cboCheckOut.Name = "cboCheckOut";
            this.cboCheckOut.Size = new System.Drawing.Size(353, 39);
            this.cboCheckOut.TabIndex = 8;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel14.Location = new System.Drawing.Point(4, 61);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(354, 3);
            this.panel14.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1124, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(271, 42);
            this.label6.TabIndex = 156;
            this.label6.Text = "Check Out Date";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.dtpCheckOut);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Location = new System.Drawing.Point(1120, 437);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(390, 79);
            this.panel8.TabIndex = 155;
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.CalendarFont = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckOut.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckOut.Location = new System.Drawing.Point(5, 23);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(378, 33);
            this.dtpCheckOut.TabIndex = 74;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel9.Location = new System.Drawing.Point(4, 61);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(379, 3);
            this.panel9.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1573, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 42);
            this.label3.TabIndex = 154;
            this.label3.Text = "Check In";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cboCheckin);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(1580, 287);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(390, 79);
            this.panel6.TabIndex = 153;
            // 
            // cboCheckin
            // 
            this.cboCheckin.BackColor = System.Drawing.Color.White;
            this.cboCheckin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCheckin.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCheckin.ForeColor = System.Drawing.Color.Black;
            this.cboCheckin.FormattingEnabled = true;
            this.cboCheckin.Location = new System.Drawing.Point(5, 16);
            this.cboCheckin.Name = "cboCheckin";
            this.cboCheckin.Size = new System.Drawing.Size(353, 39);
            this.cboCheckin.TabIndex = 8;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel7.Location = new System.Drawing.Point(4, 61);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(354, 3);
            this.panel7.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1120, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 42);
            this.label1.TabIndex = 152;
            this.label1.Text = "Check In Date";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dtpCheckIn);
            this.panel5.Controls.Add(this.panel12);
            this.panel5.Location = new System.Drawing.Point(1120, 287);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(390, 79);
            this.panel5.TabIndex = 151;
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.CalendarFont = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckIn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckIn.Location = new System.Drawing.Point(5, 23);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(378, 33);
            this.dtpCheckIn.TabIndex = 73;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel12.Location = new System.Drawing.Point(4, 61);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(379, 3);
            this.panel12.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 42);
            this.label2.TabIndex = 150;
            this.label2.Text = "Customer";
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.cboCustomer);
            this.panel23.Controls.Add(this.panel25);
            this.panel23.Location = new System.Drawing.Point(141, 287);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(377, 79);
            this.panel23.TabIndex = 149;
            // 
            // cboCustomer
            // 
            this.cboCustomer.BackColor = System.Drawing.Color.White;
            this.cboCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCustomer.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCustomer.ForeColor = System.Drawing.Color.Black;
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(5, 16);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(353, 39);
            this.cboCustomer.TabIndex = 8;
            // 
            // panel25
            // 
            this.panel25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel25.Location = new System.Drawing.Point(4, 61);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(354, 3);
            this.panel25.TabIndex = 4;
            // 
            // txtReservationId
            // 
            this.txtReservationId.BackColor = System.Drawing.Color.White;
            this.txtReservationId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReservationId.ForeColor = System.Drawing.Color.White;
            this.txtReservationId.Location = new System.Drawing.Point(449, 188);
            this.txtReservationId.Name = "txtReservationId";
            this.txtReservationId.Size = new System.Drawing.Size(100, 19);
            this.txtReservationId.TabIndex = 168;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnNext.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnNext.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNext.BorderRadius = 20;
            this.btnNext.BorderSize = 0;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(1348, 578);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(162, 67);
            this.btnNext.TabIndex = 167;
            this.btnNext.Text = ">";
            this.btnNext.TextColor = System.Drawing.Color.White;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click_2);
            // 
            // btnPervious
            // 
            this.btnPervious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnPervious.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnPervious.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPervious.BorderRadius = 20;
            this.btnPervious.BorderSize = 0;
            this.btnPervious.FlatAppearance.BorderSize = 0;
            this.btnPervious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPervious.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPervious.ForeColor = System.Drawing.Color.White;
            this.btnPervious.Location = new System.Drawing.Point(1125, 578);
            this.btnPervious.Name = "btnPervious";
            this.btnPervious.Size = new System.Drawing.Size(162, 67);
            this.btnPervious.TabIndex = 166;
            this.btnPervious.Text = "<";
            this.btnPervious.TextColor = System.Drawing.Color.White;
            this.btnPervious.UseVisualStyleBackColor = false;
            this.btnPervious.Click += new System.EventHandler(this.btnPervious_Click_2);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnEdit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnEdit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEdit.BorderRadius = 20;
            this.btnEdit.BorderSize = 0;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(459, 6);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(182, 67);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextColor = System.Drawing.Color.White;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnSave.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSave.BorderRadius = 20;
            this.btnSave.BorderSize = 0;
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(867, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(182, 67);
            this.btnSave.TabIndex = 43;
            this.btnSave.Text = "Save";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnNew.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnNew.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNew.BorderRadius = 20;
            this.btnNew.BorderSize = 0;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(247, 6);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(182, 67);
            this.btnNew.TabIndex = 7;
            this.btnNew.Text = "New";
            this.btnNew.TextColor = System.Drawing.Color.White;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Visible = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnDelete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnDelete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDelete.BorderRadius = 20;
            this.btnDelete.BorderSize = 0;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(670, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(182, 67);
            this.btnDelete.TabIndex = 42;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FormReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2038, 1101);
            this.Controls.Add(this.txtReservationId);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPervious);
            this.Controls.Add(this.txtMemo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel21);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel19);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel17);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel23);
            this.Controls.Add(this.dgReservationDetail);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReservation";
            this.Text = "FormReservation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormReservation_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgReservationDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCustomers)).EndInit();
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel23.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgReservationDetail;
        private System.Windows.Forms.ErrorProvider epCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column3;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column4;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Panel panel15;
        private Controller.MyButton btnEdit;
        private Controller.MyButton btnSave;
        private Controller.MyButton btnNew;
        private Controller.MyButton btnDelete;
        private Controller.MyButton btnNext;
        private Controller.MyButton btnPervious;
        private System.Windows.Forms.TextBox txtMemo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.TextBox txtNC;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.TextBox txtNA;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.ComboBox cboPayment;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.ComboBox cboCheckOut;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cboCheckin;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.TextBox txtReservationId;
    }
}