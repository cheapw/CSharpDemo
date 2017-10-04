namespace StudentManagementSystem
{
    partial class fmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gboxStudentQuery = new System.Windows.Forms.GroupBox();
            this.txtQueryTelephone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQueryName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuerySNO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInport = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gboxStudentDetail = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.btnCommit = new System.Windows.Forms.Button();
            this.stpBirthday = new System.Windows.Forms.DateTimePicker();
            this.btnChoosePicture = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHomeAddress = new System.Windows.Forms.TextBox();
            this.txtSNO = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gboxStudentQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.gboxStudentDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(343, 686);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gboxStudentQuery
            // 
            this.gboxStudentQuery.Controls.Add(this.txtQueryTelephone);
            this.gboxStudentQuery.Controls.Add(this.label3);
            this.gboxStudentQuery.Controls.Add(this.txtQueryName);
            this.gboxStudentQuery.Controls.Add(this.label2);
            this.gboxStudentQuery.Controls.Add(this.txtQuerySNO);
            this.gboxStudentQuery.Controls.Add(this.label1);
            this.gboxStudentQuery.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gboxStudentQuery.ForeColor = System.Drawing.Color.White;
            this.gboxStudentQuery.Location = new System.Drawing.Point(415, 47);
            this.gboxStudentQuery.Name = "gboxStudentQuery";
            this.gboxStudentQuery.Size = new System.Drawing.Size(932, 94);
            this.gboxStudentQuery.TabIndex = 1;
            this.gboxStudentQuery.TabStop = false;
            this.gboxStudentQuery.Text = "学生信息查询：";
            // 
            // txtQueryTelephone
            // 
            this.txtQueryTelephone.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtQueryTelephone.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtQueryTelephone.Location = new System.Drawing.Point(716, 37);
            this.txtQueryTelephone.Name = "txtQueryTelephone";
            this.txtQueryTelephone.Size = new System.Drawing.Size(140, 26);
            this.txtQueryTelephone.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(649, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "电话：";
            // 
            // txtQueryName
            // 
            this.txtQueryName.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtQueryName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtQueryName.Location = new System.Drawing.Point(412, 37);
            this.txtQueryName.Name = "txtQueryName";
            this.txtQueryName.Size = new System.Drawing.Size(140, 26);
            this.txtQueryName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(345, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "姓名：";
            // 
            // txtQuerySNO
            // 
            this.txtQuerySNO.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtQuerySNO.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtQuerySNO.Location = new System.Drawing.Point(108, 37);
            this.txtQuerySNO.Name = "txtQuerySNO";
            this.txtQuerySNO.Size = new System.Drawing.Size(140, 26);
            this.txtQuerySNO.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(41, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "学号：";
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AllowUserToDeleteRows = false;
            this.dgvStudent.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvStudent.EnableHeadersVisualStyles = false;
            this.dgvStudent.Location = new System.Drawing.Point(415, 166);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.ReadOnly = true;
            this.dgvStudent.RowHeadersVisible = false;
            this.dgvStudent.RowTemplate.Height = 23;
            this.dgvStudent.Size = new System.Drawing.Size(806, 261);
            this.dgvStudent.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "学号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "姓名";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "性别";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "出生日期";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 180;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "手机号码";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // btnInport
            // 
            this.btnInport.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnInport.FlatAppearance.BorderSize = 2;
            this.btnInport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInport.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnInport.ForeColor = System.Drawing.Color.White;
            this.btnInport.Location = new System.Drawing.Point(1245, 166);
            this.btnInport.Name = "btnInport";
            this.btnInport.Size = new System.Drawing.Size(102, 50);
            this.btnInport.TabIndex = 3;
            this.btnInport.Text = "导入数据";
            this.btnInport.UseVisualStyleBackColor = true;
            this.btnInport.Click += new System.EventHandler(this.btnInport_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.BorderSize = 2;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(1245, 236);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 50);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUpdate.FlatAppearance.BorderSize = 2;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(1245, 306);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 50);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.BorderSize = 2;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(1245, 376);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 50);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // gboxStudentDetail
            // 
            this.gboxStudentDetail.Controls.Add(this.rbFemale);
            this.gboxStudentDetail.Controls.Add(this.btnCancel);
            this.gboxStudentDetail.Controls.Add(this.rbMale);
            this.gboxStudentDetail.Controls.Add(this.btnCommit);
            this.gboxStudentDetail.Controls.Add(this.stpBirthday);
            this.gboxStudentDetail.Controls.Add(this.btnChoosePicture);
            this.gboxStudentDetail.Controls.Add(this.pictureBox2);
            this.gboxStudentDetail.Controls.Add(this.txtEmailAddress);
            this.gboxStudentDetail.Controls.Add(this.txtTelephone);
            this.gboxStudentDetail.Controls.Add(this.txtName);
            this.gboxStudentDetail.Controls.Add(this.label6);
            this.gboxStudentDetail.Controls.Add(this.label9);
            this.gboxStudentDetail.Controls.Add(this.label8);
            this.gboxStudentDetail.Controls.Add(this.label5);
            this.gboxStudentDetail.Controls.Add(this.txtHomeAddress);
            this.gboxStudentDetail.Controls.Add(this.txtSNO);
            this.gboxStudentDetail.Controls.Add(this.label10);
            this.gboxStudentDetail.Controls.Add(this.label7);
            this.gboxStudentDetail.Controls.Add(this.label4);
            this.gboxStudentDetail.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gboxStudentDetail.ForeColor = System.Drawing.Color.White;
            this.gboxStudentDetail.Location = new System.Drawing.Point(415, 450);
            this.gboxStudentDetail.Name = "gboxStudentDetail";
            this.gboxStudentDetail.Size = new System.Drawing.Size(932, 250);
            this.gboxStudentDetail.TabIndex = 4;
            this.gboxStudentDetail.TabStop = false;
            this.gboxStudentDetail.Text = "学生明细信息";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbFemale.Location = new System.Drawing.Point(301, 118);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(44, 25);
            this.rbFemale.TabIndex = 5;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "女";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.BorderSize = 2;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(830, 156);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 53);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbMale.Location = new System.Drawing.Point(240, 118);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(44, 25);
            this.rbMale.TabIndex = 5;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "男";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // btnCommit
            // 
            this.btnCommit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCommit.FlatAppearance.BorderSize = 2;
            this.btnCommit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommit.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCommit.ForeColor = System.Drawing.Color.White;
            this.btnCommit.Location = new System.Drawing.Point(830, 70);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(81, 53);
            this.btnCommit.TabIndex = 3;
            this.btnCommit.Text = "提交";
            this.btnCommit.UseVisualStyleBackColor = true;
            // 
            // stpBirthday
            // 
            this.stpBirthday.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.stpBirthday.Location = new System.Drawing.Point(653, 44);
            this.stpBirthday.Name = "stpBirthday";
            this.stpBirthday.Size = new System.Drawing.Size(151, 29);
            this.stpBirthday.TabIndex = 4;
            // 
            // btnChoosePicture
            // 
            this.btnChoosePicture.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnChoosePicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoosePicture.ForeColor = System.Drawing.Color.White;
            this.btnChoosePicture.Location = new System.Drawing.Point(40, 184);
            this.btnChoosePicture.Name = "btnChoosePicture";
            this.btnChoosePicture.Size = new System.Drawing.Size(84, 39);
            this.btnChoosePicture.TabIndex = 3;
            this.btnChoosePicture.Text = "选择";
            this.btnChoosePicture.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(13, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 216);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtEmailAddress.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtEmailAddress.Location = new System.Drawing.Point(639, 117);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(166, 29);
            this.txtEmailAddress.TabIndex = 1;
            // 
            // txtTelephone
            // 
            this.txtTelephone.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtTelephone.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTelephone.Location = new System.Drawing.Point(402, 117);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(125, 29);
            this.txtTelephone.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtName.Location = new System.Drawing.Point(444, 44);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(93, 29);
            this.txtName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(557, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "出生日期：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(551, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "邮箱地址：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(350, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "电话：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(380, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "姓名：";
            // 
            // txtHomeAddress
            // 
            this.txtHomeAddress.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtHomeAddress.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtHomeAddress.Location = new System.Drawing.Point(267, 189);
            this.txtHomeAddress.Name = "txtHomeAddress";
            this.txtHomeAddress.Size = new System.Drawing.Size(537, 29);
            this.txtHomeAddress.TabIndex = 1;
            // 
            // txtSNO
            // 
            this.txtSNO.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtSNO.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSNO.Location = new System.Drawing.Point(241, 44);
            this.txtSNO.Name = "txtSNO";
            this.txtSNO.Size = new System.Drawing.Size(114, 29);
            this.txtSNO.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(171, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "家庭住址：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(170, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "性别：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(171, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "学号：";
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderSize = 2;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1324, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(33, 35);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1386, 712);
            this.Controls.Add(this.gboxStudentDetail);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnInport);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.gboxStudentQuery);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gboxStudentQuery.ResumeLayout(false);
            this.gboxStudentQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.gboxStudentDetail.ResumeLayout(false);
            this.gboxStudentDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gboxStudentQuery;
        private System.Windows.Forms.TextBox txtQueryTelephone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQueryName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuerySNO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Button btnInport;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gboxStudentDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DateTimePicker stpBirthday;
        private System.Windows.Forms.Button btnChoosePicture;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSNO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHomeAddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Button btnExit;
    }
}

