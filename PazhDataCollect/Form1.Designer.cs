namespace PazhDataCollect
{
    partial class mainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtPass = new System.Windows.Forms.MaskedTextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtBeforDays = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.dgLocal = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbDBList = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDBUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDBPassword = new System.Windows.Forms.MaskedTextBox();
            this.txtRserver = new System.Windows.Forms.TextBox();
            this.lbl_RServer = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbLDBname = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLDBUser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLPassword = new System.Windows.Forms.MaskedTextBox();
            this.txtLServer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chbTimer = new System.Windows.Forms.CheckBox();
            this.button9 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTimer = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.txtSQL = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.MainMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Restore = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtStat = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLocal)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtLog);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 767);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel6.Controls.Add(this.txtPass);
            this.panel6.Controls.Add(this.txtUser);
            this.panel6.Controls.Add(this.button7);
            this.panel6.Controls.Add(this.button6);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1039, 48);
            this.panel6.TabIndex = 24;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(383, 15);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(151, 23);
            this.txtPass.TabIndex = 6;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(607, 13);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(123, 23);
            this.txtUser.TabIndex = 5;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(57, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(132, 42);
            this.button7.TabIndex = 4;
            this.button7.Text = "قفل مجدد";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(206, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(132, 42);
            this.button6.TabIndex = 3;
            this.button6.Text = "ورود";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(540, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "رمز عبور:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(736, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "نام کاربری:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(879, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "ورود به حالت تنظیم:";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel8.Controls.Add(this.txtBeforDays);
            this.panel8.Controls.Add(this.label14);
            this.panel8.Controls.Add(this.pictureBox1);
            this.panel8.Controls.Add(this.lblCount);
            this.panel8.Controls.Add(this.dgLocal);
            this.panel8.Controls.Add(this.groupBox2);
            this.panel8.Controls.Add(this.button11);
            this.panel8.Controls.Add(this.groupBox1);
            this.panel8.Controls.Add(this.button10);
            this.panel8.Controls.Add(this.groupBox3);
            this.panel8.Controls.Add(this.txtSQL);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 153);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1039, 614);
            this.panel8.TabIndex = 23;
            // 
            // txtBeforDays
            // 
            this.txtBeforDays.Location = new System.Drawing.Point(908, 455);
            this.txtBeforDays.Mask = "0000";
            this.txtBeforDays.Name = "txtBeforDays";
            this.txtBeforDays.Size = new System.Drawing.Size(46, 23);
            this.txtBeforDays.TabIndex = 29;
            this.txtBeforDays.Text = "100";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(970, 458);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 16);
            this.label14.TabIndex = 28;
            this.label14.Text = "تعداد روز";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PazhDataCollect.Properties.Resources.SRC;
            this.pictureBox1.Location = new System.Drawing.Point(982, 489);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(57, 461);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(54, 16);
            this.lblCount.TabIndex = 27;
            this.lblCount.Text = "lblCount";
            // 
            // dgLocal
            // 
            this.dgLocal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLocal.Location = new System.Drawing.Point(4, 489);
            this.dgLocal.Name = "dgLocal";
            this.dgLocal.Size = new System.Drawing.Size(974, 122);
            this.dgLocal.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Location = new System.Drawing.Point(4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1022, 132);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "مشخصات سرور راه دور";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.cbDBList);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Enabled = false;
            this.panel3.Location = new System.Drawing.Point(6, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(512, 100);
            this.panel3.TabIndex = 1;
            // 
            // cbDBList
            // 
            this.cbDBList.FormattingEnabled = true;
            this.cbDBList.Location = new System.Drawing.Point(136, 23);
            this.cbDBList.Name = "cbDBList";
            this.cbDBList.Size = new System.Drawing.Size(195, 24);
            this.cbDBList.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(136, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 39);
            this.button2.TabIndex = 16;
            this.button2.Text = "ذخیره سازی اطلاعات";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(158, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "لیست بانک های اطلاعاتی";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtDBUser);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtDBPassword);
            this.panel2.Controls.Add(this.txtRserver);
            this.panel2.Controls.Add(this.lbl_RServer);
            this.panel2.Location = new System.Drawing.Point(522, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(494, 100);
            this.panel2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 39);
            this.button1.TabIndex = 16;
            this.button1.Text = "تست ارتباط و ادامه>>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "رمز عبور";
            // 
            // txtDBUser
            // 
            this.txtDBUser.Location = new System.Drawing.Point(187, 23);
            this.txtDBUser.Name = "txtDBUser";
            this.txtDBUser.Size = new System.Drawing.Size(109, 23);
            this.txtDBUser.TabIndex = 14;
            this.txtDBUser.Text = "sa";
            this.txtDBUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "نام کاربری";
            // 
            // txtDBPassword
            // 
            this.txtDBPassword.Location = new System.Drawing.Point(81, 23);
            this.txtDBPassword.Name = "txtDBPassword";
            this.txtDBPassword.PasswordChar = '*';
            this.txtDBPassword.Size = new System.Drawing.Size(100, 23);
            this.txtDBPassword.TabIndex = 12;
            this.txtDBPassword.Text = "lemon7430";
            this.txtDBPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRserver
            // 
            this.txtRserver.Location = new System.Drawing.Point(302, 23);
            this.txtRserver.Name = "txtRserver";
            this.txtRserver.Size = new System.Drawing.Size(180, 23);
            this.txtRserver.TabIndex = 9;
            this.txtRserver.Text = "2.180.2.45";
            this.txtRserver.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_RServer
            // 
            this.lbl_RServer.AutoSize = true;
            this.lbl_RServer.Location = new System.Drawing.Point(353, 4);
            this.lbl_RServer.Name = "lbl_RServer";
            this.lbl_RServer.Size = new System.Drawing.Size(70, 16);
            this.lbl_RServer.TabIndex = 8;
            this.lbl_RServer.Text = "آدرس سرور";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(127, 452);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(327, 35);
            this.button11.TabIndex = 26;
            this.button11.Text = "انتقال اطلاعات بصورت دستی";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Location = new System.Drawing.Point(3, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1025, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مشخصات سرور فروشگاه";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.cbLDBname);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Enabled = false;
            this.panel4.Location = new System.Drawing.Point(4, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(512, 100);
            this.panel4.TabIndex = 3;
            // 
            // cbLDBname
            // 
            this.cbLDBname.FormattingEnabled = true;
            this.cbLDBname.Location = new System.Drawing.Point(136, 23);
            this.cbLDBname.Name = "cbLDBname";
            this.cbLDBname.Size = new System.Drawing.Size(195, 24);
            this.cbLDBname.TabIndex = 17;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(136, 52);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(183, 39);
            this.button3.TabIndex = 16;
            this.button3.Text = "ذخیره سازی اطلاعات";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "لیست بانک های اطلاعاتی";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.button4);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.txtLDBUser);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.txtLPassword);
            this.panel5.Controls.Add(this.txtLServer);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(522, 25);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(498, 100);
            this.panel5.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(152, 52);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(183, 39);
            this.button4.TabIndex = 16;
            this.button4.Text = "تست ارتباط و ادامه>>";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "رمز عبور";
            // 
            // txtLDBUser
            // 
            this.txtLDBUser.Location = new System.Drawing.Point(187, 23);
            this.txtLDBUser.Name = "txtLDBUser";
            this.txtLDBUser.Size = new System.Drawing.Size(109, 23);
            this.txtLDBUser.TabIndex = 14;
            this.txtLDBUser.Text = "sa";
            this.txtLDBUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "نام کاربری";
            // 
            // txtLPassword
            // 
            this.txtLPassword.Location = new System.Drawing.Point(81, 23);
            this.txtLPassword.Name = "txtLPassword";
            this.txtLPassword.PasswordChar = '*';
            this.txtLPassword.Size = new System.Drawing.Size(100, 23);
            this.txtLPassword.TabIndex = 12;
            this.txtLPassword.Text = "lemon7430";
            this.txtLPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLServer
            // 
            this.txtLServer.Location = new System.Drawing.Point(302, 23);
            this.txtLServer.Name = "txtLServer";
            this.txtLServer.Size = new System.Drawing.Size(180, 23);
            this.txtLServer.TabIndex = 9;
            this.txtLServer.Text = "2.180.2.45";
            this.txtLServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(353, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "آدرس سرور";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(561, 449);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(341, 35);
            this.button10.TabIndex = 25;
            this.button10.Text = "تهیه Query و نمایش داده ها برای ارسال";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(this.txtStat);
            this.groupBox3.Controls.Add(this.chbTimer);
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtTimer);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Location = new System.Drawing.Point(3, 280);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1025, 73);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "تنظیمات مربوط به سرویس ویندوز برداشت اطلاعات";
            // 
            // chbTimer
            // 
            this.chbTimer.AutoSize = true;
            this.chbTimer.Location = new System.Drawing.Point(77, 32);
            this.chbTimer.Name = "chbTimer";
            this.chbTimer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chbTimer.Size = new System.Drawing.Size(109, 20);
            this.chbTimer.TabIndex = 21;
            this.chbTimer.Text = "فعالسازی تایمر";
            this.chbTimer.UseVisualStyleBackColor = true;
            this.chbTimer.CheckedChanged += new System.EventHandler(this.chbTimer_CheckedChanged);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(667, 22);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(136, 39);
            this.button9.TabIndex = 20;
            this.button9.Text = "ذخیره تنظیم تایمر";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(809, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "دقیقه";
            // 
            // txtTimer
            // 
            this.txtTimer.Location = new System.Drawing.Point(853, 38);
            this.txtTimer.Mask = "000";
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.Size = new System.Drawing.Size(46, 23);
            this.txtTimer.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(905, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "فاصله برداشت ها";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(369, 22);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(292, 39);
            this.button5.TabIndex = 18;
            this.button5.Text = "تنظیمات مربوط به بانک اطلاعاتی و تطبیق فیلدها";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtSQL
            // 
            this.txtSQL.BackColor = System.Drawing.Color.LightCyan;
            this.txtSQL.Location = new System.Drawing.Point(3, 359);
            this.txtSQL.Multiline = true;
            this.txtSQL.Name = "txtSQL";
            this.txtSQL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSQL.Size = new System.Drawing.Size(1025, 87);
            this.txtSQL.TabIndex = 24;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "برنامه ارسال اطلاعات پاژ";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Restore,
            this.Exit});
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(112, 48);
            this.MainMenu.Text = "منو اصلی";
            // 
            // Restore
            // 
            this.Restore.Name = "Restore";
            this.Restore.Size = new System.Drawing.Size(111, 22);
            this.Restore.Text = "بازگشت";
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(111, 22);
            this.Exit.Text = "خروج";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtStat
            // 
            this.txtStat.AutoSize = true;
            this.txtStat.Location = new System.Drawing.Point(26, 33);
            this.txtStat.Name = "txtStat";
            this.txtStat.Size = new System.Drawing.Size(45, 16);
            this.txtStat.TabIndex = 22;
            this.txtStat.Text = "txtStat";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(7, 51);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLog.Size = new System.Drawing.Size(1021, 96);
            this.txtLog.TabIndex = 25;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(227, 22);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(136, 39);
            this.button8.TabIndex = 23;
            this.button8.Text = "ذخیره در رجیستری";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // mainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 767);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "mainFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "برنامه برداشت اطلاعات پاژ";
            this.Load += new System.EventHandler(this.mainFrm_Load);
            this.Resize += new System.EventHandler(this.mainFrm_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLocal)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.MainMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDBUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtDBPassword;
        private System.Windows.Forms.TextBox txtRserver;
        private System.Windows.Forms.Label lbl_RServer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbDBList;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbLDBname;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLDBUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtLPassword;
        private System.Windows.Forms.TextBox txtLServer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtTimer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgLocal;
        private System.Windows.Forms.TextBox txtSQL;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem Restore;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.MaskedTextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MaskedTextBox txtBeforDays;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox chbTimer;
        private System.Windows.Forms.Label txtStat;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button button8;
    }
}

