namespace PazhDataCollect
{
    partial class DataSchemeFrm
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
            this.gbRemote = new System.Windows.Forms.GroupBox();
            this.dgRemoteAdd = new System.Windows.Forms.DataGridView();
            this.dgRemote = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnRemote = new System.Windows.Forms.Button();
            this.cbRemote = new System.Windows.Forms.ComboBox();
            this.gbLocal = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLocal = new System.Windows.Forms.Button();
            this.cbLocal = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLocalSQL = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbDateField = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chbDate = new System.Windows.Forms.CheckBox();
            this.chbFormatDate = new System.Windows.Forms.CheckBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgSQLView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLocalDB = new System.Windows.Forms.TextBox();
            this.txtRemoteDB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtShopID = new System.Windows.Forms.TextBox();
            this.txtShopName = new System.Windows.Forms.TextBox();
            this.gbRemote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRemoteAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRemote)).BeginInit();
            this.gbLocal.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSQLView)).BeginInit();
            this.SuspendLayout();
            // 
            // gbRemote
            // 
            this.gbRemote.Controls.Add(this.dgRemoteAdd);
            this.gbRemote.Controls.Add(this.dgRemote);
            this.gbRemote.Controls.Add(this.label2);
            this.gbRemote.Controls.Add(this.BtnRemote);
            this.gbRemote.Controls.Add(this.cbRemote);
            this.gbRemote.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gbRemote.Location = new System.Drawing.Point(346, 17);
            this.gbRemote.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbRemote.Name = "gbRemote";
            this.gbRemote.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbRemote.Size = new System.Drawing.Size(328, 513);
            this.gbRemote.TabIndex = 0;
            this.gbRemote.TabStop = false;
            this.gbRemote.Text = "سرور ریموت(مادر)";
            // 
            // dgRemoteAdd
            // 
            this.dgRemoteAdd.AllowUserToOrderColumns = true;
            this.dgRemoteAdd.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgRemoteAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRemoteAdd.Location = new System.Drawing.Point(6, 306);
            this.dgRemoteAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgRemoteAdd.Name = "dgRemoteAdd";
            this.dgRemoteAdd.Size = new System.Drawing.Size(315, 204);
            this.dgRemoteAdd.TabIndex = 4;
            // 
            // dgRemote
            // 
            this.dgRemote.AllowUserToAddRows = false;
            this.dgRemote.AllowUserToOrderColumns = true;
            this.dgRemote.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgRemote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRemote.Location = new System.Drawing.Point(6, 101);
            this.dgRemote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgRemote.Name = "dgRemote";
            this.dgRemote.ReadOnly = true;
            this.dgRemote.ShowEditingIcon = false;
            this.dgRemote.Size = new System.Drawing.Size(315, 204);
            this.dgRemote.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "لیست جداول";
            // 
            // BtnRemote
            // 
            this.BtnRemote.Location = new System.Drawing.Point(17, 63);
            this.BtnRemote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRemote.Name = "BtnRemote";
            this.BtnRemote.Size = new System.Drawing.Size(222, 34);
            this.BtnRemote.TabIndex = 1;
            this.BtnRemote.Text = "دریافت لیست فیلدها";
            this.BtnRemote.UseVisualStyleBackColor = true;
            this.BtnRemote.Click += new System.EventHandler(this.BtnRemote_Click);
            // 
            // cbRemote
            // 
            this.cbRemote.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cbRemote.FormattingEnabled = true;
            this.cbRemote.Location = new System.Drawing.Point(17, 32);
            this.cbRemote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbRemote.Name = "cbRemote";
            this.cbRemote.Size = new System.Drawing.Size(222, 21);
            this.cbRemote.TabIndex = 0;
            // 
            // gbLocal
            // 
            this.gbLocal.Controls.Add(this.button3);
            this.gbLocal.Controls.Add(this.label3);
            this.gbLocal.Controls.Add(this.btnLocal);
            this.gbLocal.Controls.Add(this.cbLocal);
            this.gbLocal.Location = new System.Drawing.Point(12, 17);
            this.gbLocal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbLocal.Name = "gbLocal";
            this.gbLocal.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbLocal.Size = new System.Drawing.Size(328, 513);
            this.gbLocal.TabIndex = 1;
            this.gbLocal.TabStop = false;
            this.gbLocal.Text = "سرور محلی(فرزند)";
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::PazhDataCollect.Properties.Resources.if_Sql_runner_70664;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(7, 17);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(42, 38);
            this.button3.TabIndex = 11;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "لیست جداول";
            // 
            // btnLocal
            // 
            this.btnLocal.Location = new System.Drawing.Point(6, 63);
            this.btnLocal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLocal.Name = "btnLocal";
            this.btnLocal.Size = new System.Drawing.Size(222, 34);
            this.btnLocal.TabIndex = 7;
            this.btnLocal.Text = "دریافت لیست فیلدها";
            this.btnLocal.UseVisualStyleBackColor = true;
            this.btnLocal.Click += new System.EventHandler(this.btnLocal_Click);
            // 
            // cbLocal
            // 
            this.cbLocal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cbLocal.FormattingEnabled = true;
            this.cbLocal.Location = new System.Drawing.Point(55, 32);
            this.cbLocal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbLocal.Name = "cbLocal";
            this.cbLocal.Size = new System.Drawing.Size(173, 21);
            this.cbLocal.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(771, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "SQL Query مربوط به برداشت ";
            // 
            // txtLocalSQL
            // 
            this.txtLocalSQL.Location = new System.Drawing.Point(680, 110);
            this.txtLocalSQL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLocalSQL.Multiline = true;
            this.txtLocalSQL.Name = "txtLocalSQL";
            this.txtLocalSQL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLocalSQL.Size = new System.Drawing.Size(368, 118);
            this.txtLocalSQL.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(755, 34);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "<تبدیل به دستور SQL ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(755, 496);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(222, 34);
            this.button2.TabIndex = 10;
            this.button2.Text = "ذخیره تنظیمات";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbDateField
            // 
            this.cbDateField.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cbDateField.FormattingEnabled = true;
            this.cbDateField.Location = new System.Drawing.Point(755, 383);
            this.cbDateField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDateField.Name = "cbDateField";
            this.cbDateField.Size = new System.Drawing.Size(222, 21);
            this.cbDateField.TabIndex = 11;
            this.cbDateField.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cbDateField.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(988, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "فیلد تاریخ";
            // 
            // chbDate
            // 
            this.chbDate.AutoSize = true;
            this.chbDate.Location = new System.Drawing.Point(953, 439);
            this.chbDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbDate.Name = "chbDate";
            this.chbDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chbDate.Size = new System.Drawing.Size(95, 20);
            this.chbDate.TabIndex = 13;
            this.chbDate.Text = "تاریخ میلادی";
            this.chbDate.UseVisualStyleBackColor = true;
            // 
            // chbFormatDate
            // 
            this.chbFormatDate.AutoSize = true;
            this.chbFormatDate.Location = new System.Drawing.Point(814, 465);
            this.chbFormatDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbFormatDate.Name = "chbFormatDate";
            this.chbFormatDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chbFormatDate.Size = new System.Drawing.Size(231, 20);
            this.chbFormatDate.TabIndex = 14;
            this.chbFormatDate.Text = "(YY/MM/DD)فرمت تاریخ هشت حرفی";
            this.chbFormatDate.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(834, 414);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTextBox1.Mask = "000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(56, 23);
            this.maskedTextBox1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(896, 416);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "تعداد روز قبل جهت برداشت";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgSQLView);
            this.panel1.Location = new System.Drawing.Point(12, 538);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1036, 204);
            this.panel1.TabIndex = 17;
            // 
            // dgSQLView
            // 
            this.dgSQLView.AllowUserToOrderColumns = true;
            this.dgSQLView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgSQLView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSQLView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSQLView.Location = new System.Drawing.Point(0, 0);
            this.dgSQLView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgSQLView.Name = "dgSQLView";
            this.dgSQLView.Size = new System.Drawing.Size(1036, 204);
            this.dgSQLView.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(969, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "جدول مبدا";
            // 
            // txtLocalDB
            // 
            this.txtLocalDB.Location = new System.Drawing.Point(802, 349);
            this.txtLocalDB.Name = "txtLocalDB";
            this.txtLocalDB.Size = new System.Drawing.Size(161, 23);
            this.txtLocalDB.TabIndex = 18;
            // 
            // txtRemoteDB
            // 
            this.txtRemoteDB.Location = new System.Drawing.Point(802, 319);
            this.txtRemoteDB.Name = "txtRemoteDB";
            this.txtRemoteDB.Size = new System.Drawing.Size(161, 23);
            this.txtRemoteDB.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(969, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "جدول مقصد";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(923, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "شناسه (پلاک)فروشگاه";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(969, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "نام فروشگاه";
            // 
            // txtShopID
            // 
            this.txtShopID.BackColor = System.Drawing.Color.Khaki;
            this.txtShopID.Location = new System.Drawing.Point(755, 278);
            this.txtShopID.Name = "txtShopID";
            this.txtShopID.Size = new System.Drawing.Size(161, 23);
            this.txtShopID.TabIndex = 23;
            // 
            // txtShopName
            // 
            this.txtShopName.BackColor = System.Drawing.Color.Khaki;
            this.txtShopName.Location = new System.Drawing.Point(802, 244);
            this.txtShopName.Name = "txtShopName";
            this.txtShopName.Size = new System.Drawing.Size(161, 23);
            this.txtShopName.TabIndex = 24;
            // 
            // DataSchemeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 733);
            this.Controls.Add(this.txtShopName);
            this.Controls.Add(this.txtShopID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtRemoteDB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtLocalDB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.chbFormatDate);
            this.Controls.Add(this.chbDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbDateField);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtLocalSQL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbLocal);
            this.Controls.Add(this.gbRemote);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DataSchemeFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "تنظیمات مربوط به بانک اطلاعاتی";
            this.Load += new System.EventHandler(this.DataSchemeFrm_Load);
            this.gbRemote.ResumeLayout(false);
            this.gbRemote.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRemoteAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRemote)).EndInit();
            this.gbLocal.ResumeLayout(false);
            this.gbLocal.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSQLView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRemote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnRemote;
        private System.Windows.Forms.ComboBox cbRemote;
        private System.Windows.Forms.GroupBox gbLocal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLocal;
        private System.Windows.Forms.ComboBox cbLocal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLocalSQL;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbDateField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chbDate;
        private System.Windows.Forms.CheckBox chbFormatDate;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgSQLView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLocalDB;
        private System.Windows.Forms.TextBox txtRemoteDB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtShopID;
        private System.Windows.Forms.TextBox txtShopName;
        private System.Windows.Forms.DataGridView dgRemote;
        private System.Windows.Forms.DataGridView dgRemoteAdd;
    }
}