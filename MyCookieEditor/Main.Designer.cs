namespace MyCookieEditor
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_input = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox_input = new System.Windows.Forms.RichTextBox();
            this.groupBox_view = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_generate = new System.Windows.Forms.Button();
            this.comboBox_generate = new System.Windows.Forms.ComboBox();
            this.richTextBox_generate = new System.Windows.Forms.RichTextBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_value = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.button_del = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox_view.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_input);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.richTextBox_input);
            this.groupBox1.Location = new System.Drawing.Point(12, 419);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // comboBox_input
            // 
            this.comboBox_input.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_input.FormattingEnabled = true;
            this.comboBox_input.Items.AddRange(new object[] {
            "Raw",
            "Json"});
            this.comboBox_input.Location = new System.Drawing.Point(344, 29);
            this.comboBox_input.Name = "comboBox_input";
            this.comboBox_input.Size = new System.Drawing.Size(87, 20);
            this.comboBox_input.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox_input
            // 
            this.richTextBox_input.Location = new System.Drawing.Point(16, 29);
            this.richTextBox_input.Name = "richTextBox_input";
            this.richTextBox_input.Size = new System.Drawing.Size(309, 129);
            this.richTextBox_input.TabIndex = 0;
            this.richTextBox_input.Text = resources.GetString("richTextBox_input.Text");
            // 
            // groupBox_view
            // 
            this.groupBox_view.Controls.Add(this.button_del);
            this.groupBox_view.Controls.Add(this.button_add);
            this.groupBox_view.Controls.Add(this.textBox_value);
            this.groupBox_view.Controls.Add(this.label2);
            this.groupBox_view.Controls.Add(this.label1);
            this.groupBox_view.Controls.Add(this.textBox_name);
            this.groupBox_view.Controls.Add(this.listView1);
            this.groupBox_view.Location = new System.Drawing.Point(12, 12);
            this.groupBox_view.Name = "groupBox_view";
            this.groupBox_view.Size = new System.Drawing.Size(950, 377);
            this.groupBox_view.TabIndex = 1;
            this.groupBox_view.TabStop = false;
            this.groupBox_view.Text = "View";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.LabelEdit = true;
            this.listView1.Location = new System.Drawing.Point(15, 20);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(917, 285);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_generate);
            this.groupBox3.Controls.Add(this.comboBox_generate);
            this.groupBox3.Controls.Add(this.richTextBox_generate);
            this.groupBox3.Location = new System.Drawing.Point(506, 419);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(456, 175);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Output";
            // 
            // button_generate
            // 
            this.button_generate.Location = new System.Drawing.Point(366, 135);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(72, 23);
            this.button_generate.TabIndex = 2;
            this.button_generate.Text = "Generate";
            this.button_generate.UseVisualStyleBackColor = true;
            this.button_generate.Click += new System.EventHandler(this.button_generate_Click);
            // 
            // comboBox_generate
            // 
            this.comboBox_generate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_generate.FormattingEnabled = true;
            this.comboBox_generate.Items.AddRange(new object[] {
            "Raw",
            "Json"});
            this.comboBox_generate.Location = new System.Drawing.Point(366, 29);
            this.comboBox_generate.Name = "comboBox_generate";
            this.comboBox_generate.Size = new System.Drawing.Size(72, 20);
            this.comboBox_generate.TabIndex = 1;
            // 
            // richTextBox_generate
            // 
            this.richTextBox_generate.Location = new System.Drawing.Point(15, 29);
            this.richTextBox_generate.Name = "richTextBox_generate";
            this.richTextBox_generate.Size = new System.Drawing.Size(337, 129);
            this.richTextBox_generate.TabIndex = 0;
            this.richTextBox_generate.Text = "";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 123;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Value";
            this.columnHeader2.Width = 129;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Path";
            this.columnHeader3.Width = 51;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Domain";
            this.columnHeader4.Width = 190;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ExpDate";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "SameSite";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "HostOnly";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "HttpOnly";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Secure";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Session";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "StoreId";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(66, 325);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 21);
            this.textBox_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Value: ";
            // 
            // textBox_value
            // 
            this.textBox_value.Location = new System.Drawing.Point(250, 324);
            this.textBox_value.Name = "textBox_value";
            this.textBox_value.Size = new System.Drawing.Size(100, 21);
            this.textBox_value.TabIndex = 4;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(377, 323);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 5;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_del
            // 
            this.button_del.Location = new System.Drawing.Point(468, 323);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(97, 23);
            this.button_del.TabIndex = 6;
            this.button_del.Text = "Del selected";
            this.button_del.UseVisualStyleBackColor = true;
            this.button_del.Click += new System.EventHandler(this.button_del_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 606);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox_view);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "MyCookieEditor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox_view.ResumeLayout(false);
            this.groupBox_view.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox_input;
        private System.Windows.Forms.GroupBox groupBox_view;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox_input;
        private System.Windows.Forms.Button button_generate;
        private System.Windows.Forms.ComboBox comboBox_generate;
        private System.Windows.Forms.RichTextBox richTextBox_generate;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox textBox_value;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Button button_del;
    }
}

