
namespace RST_File_Generator
{
    partial class _00_Struct_Enum_Form
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CB_prefix = new System.Windows.Forms.ComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.CB_doctype = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TF_Header5 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TF_Header4 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TF_Header3 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TF_Header2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.TF_Header1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TF_objectname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.BT_Generate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.ObjectNameTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Checkbox_seealso = new System.Windows.Forms.CheckBox();
            this.Checkbox_note = new System.Windows.Forms.CheckBox();
            this.CheckBox_Warning = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(6, 17);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(117, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Document Type";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.CB_prefix);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.CB_doctype);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(12, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 95);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // CB_prefix
            // 
            this.CB_prefix.Cursor = System.Windows.Forms.Cursors.Default;
            this.CB_prefix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_prefix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_prefix.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.CB_prefix.Items.AddRange(new object[] {
            "ecat",
            "swecat",
            "pulsemotion"});
            this.CB_prefix.Location = new System.Drawing.Point(129, 61);
            this.CB_prefix.Name = "CB_prefix";
            this.CB_prefix.Size = new System.Drawing.Size(134, 20);
            this.CB_prefix.TabIndex = 4;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(6, 62);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(117, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Product Prefix";
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CB_doctype
            // 
            this.CB_doctype.Cursor = System.Windows.Forms.Cursors.Default;
            this.CB_doctype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_doctype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_doctype.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.CB_doctype.Items.AddRange(new object[] {
            "enum",
            "struct",
            "union"});
            this.CB_doctype.Location = new System.Drawing.Point(129, 16);
            this.CB_doctype.Name = "CB_doctype";
            this.CB_doctype.Size = new System.Drawing.Size(134, 20);
            this.CB_doctype.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(12, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 261);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Paragraph Header";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.62055F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.37945F));
            this.tableLayoutPanel1.Controls.Add(this.TF_Header5, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.TF_Header4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.TF_Header3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.TF_Header2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.TF_Header1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(253, 239);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // TF_Header5
            // 
            this.TF_Header5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TF_Header5.Depth = 0;
            this.TF_Header5.Hint = "";
            this.TF_Header5.Location = new System.Drawing.Point(109, 202);
            this.TF_Header5.MouseState = MaterialSkin.MouseState.HOVER;
            this.TF_Header5.Name = "TF_Header5";
            this.TF_Header5.PasswordChar = '\0';
            this.TF_Header5.SelectedText = "";
            this.TF_Header5.SelectionLength = 0;
            this.TF_Header5.SelectionStart = 0;
            this.TF_Header5.Size = new System.Drawing.Size(113, 23);
            this.TF_Header5.TabIndex = 11;
            this.TF_Header5.UseSystemPasswordChar = false;
            // 
            // TF_Header4
            // 
            this.TF_Header4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TF_Header4.Depth = 0;
            this.TF_Header4.Hint = "";
            this.TF_Header4.Location = new System.Drawing.Point(109, 153);
            this.TF_Header4.MouseState = MaterialSkin.MouseState.HOVER;
            this.TF_Header4.Name = "TF_Header4";
            this.TF_Header4.PasswordChar = '\0';
            this.TF_Header4.SelectedText = "";
            this.TF_Header4.SelectionLength = 0;
            this.TF_Header4.SelectionStart = 0;
            this.TF_Header4.Size = new System.Drawing.Size(113, 23);
            this.TF_Header4.TabIndex = 10;
            this.TF_Header4.UseSystemPasswordChar = false;
            // 
            // TF_Header3
            // 
            this.TF_Header3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TF_Header3.Depth = 0;
            this.TF_Header3.Hint = "";
            this.TF_Header3.Location = new System.Drawing.Point(109, 106);
            this.TF_Header3.MouseState = MaterialSkin.MouseState.HOVER;
            this.TF_Header3.Name = "TF_Header3";
            this.TF_Header3.PasswordChar = '\0';
            this.TF_Header3.SelectedText = "";
            this.TF_Header3.SelectionLength = 0;
            this.TF_Header3.SelectionStart = 0;
            this.TF_Header3.Size = new System.Drawing.Size(113, 23);
            this.TF_Header3.TabIndex = 9;
            this.TF_Header3.UseSystemPasswordChar = false;
            // 
            // TF_Header2
            // 
            this.TF_Header2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TF_Header2.Depth = 0;
            this.TF_Header2.Hint = "";
            this.TF_Header2.Location = new System.Drawing.Point(109, 59);
            this.TF_Header2.MouseState = MaterialSkin.MouseState.HOVER;
            this.TF_Header2.Name = "TF_Header2";
            this.TF_Header2.PasswordChar = '\0';
            this.TF_Header2.SelectedText = "";
            this.TF_Header2.SelectionLength = 0;
            this.TF_Header2.SelectionStart = 0;
            this.TF_Header2.Size = new System.Drawing.Size(113, 23);
            this.TF_Header2.TabIndex = 8;
            this.TF_Header2.Text = "DESCRIPTION";
            this.TF_Header2.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(3, 14);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(73, 19);
            this.materialLabel3.TabIndex = 1;
            this.materialLabel3.Text = "Header 1";
            this.materialLabel3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(3, 61);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(73, 19);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "Header 2";
            this.materialLabel4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // materialLabel5
            // 
            this.materialLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(3, 108);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(73, 19);
            this.materialLabel5.TabIndex = 4;
            this.materialLabel5.Text = "Header 3";
            this.materialLabel5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // materialLabel6
            // 
            this.materialLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel6.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(3, 155);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(73, 19);
            this.materialLabel6.TabIndex = 5;
            this.materialLabel6.Text = "Header 4";
            this.materialLabel6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // materialLabel7
            // 
            this.materialLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel7.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(3, 204);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(73, 19);
            this.materialLabel7.TabIndex = 6;
            this.materialLabel7.Text = "Header 5";
            this.materialLabel7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TF_Header1
            // 
            this.TF_Header1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TF_Header1.Depth = 0;
            this.TF_Header1.Hint = "";
            this.TF_Header1.Location = new System.Drawing.Point(109, 12);
            this.TF_Header1.MouseState = MaterialSkin.MouseState.HOVER;
            this.TF_Header1.Name = "TF_Header1";
            this.TF_Header1.PasswordChar = '\0';
            this.TF_Header1.SelectedText = "";
            this.TF_Header1.SelectionLength = 0;
            this.TF_Header1.SelectionStart = 0;
            this.TF_Header1.Size = new System.Drawing.Size(113, 23);
            this.TF_Header1.TabIndex = 7;
            this.TF_Header1.Text = "SYNOPSIS";
            this.TF_Header1.UseSystemPasswordChar = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TF_objectname);
            this.groupBox3.Controls.Add(this.materialLabel8);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(299, 80);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(356, 50);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Options";
            // 
            // TF_objectname
            // 
            this.TF_objectname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TF_objectname.Depth = 0;
            this.TF_objectname.Hint = "생성할 파일의 오브젝트명 입력";
            this.TF_objectname.Location = new System.Drawing.Point(129, 17);
            this.TF_objectname.MouseState = MaterialSkin.MouseState.HOVER;
            this.TF_objectname.Name = "TF_objectname";
            this.TF_objectname.PasswordChar = '\0';
            this.TF_objectname.SelectedText = "";
            this.TF_objectname.SelectionLength = 0;
            this.TF_objectname.SelectionStart = 0;
            this.TF_objectname.Size = new System.Drawing.Size(221, 23);
            this.TF_objectname.TabIndex = 8;
            this.TF_objectname.UseSystemPasswordChar = false;
            // 
            // materialLabel8
            // 
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(6, 17);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(117, 19);
            this.materialLabel8.TabIndex = 1;
            this.materialLabel8.Text = "Object Name - ";
            this.materialLabel8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BT_Generate
            // 
            this.BT_Generate.Depth = 0;
            this.BT_Generate.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BT_Generate.Location = new System.Drawing.Point(12, 468);
            this.BT_Generate.MouseState = MaterialSkin.MouseState.HOVER;
            this.BT_Generate.Name = "BT_Generate";
            this.BT_Generate.Primary = true;
            this.BT_Generate.Size = new System.Drawing.Size(643, 45);
            this.BT_Generate.TabIndex = 6;
            this.BT_Generate.Text = "Generate RST File";
            this.BT_Generate.UseVisualStyleBackColor = true;
            this.BT_Generate.Click += new System.EventHandler(this.BT_Generate_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.materialLabel9);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Location = new System.Drawing.Point(299, 194);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(356, 261);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Table Data";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(158, 152);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(57, 19);
            this.materialLabel9.TabIndex = 0;
            this.materialLabel9.Text = "작업 예정";
            // 
            // ObjectNameTimer
            // 
            this.ObjectNameTimer.Enabled = true;
            this.ObjectNameTimer.Interval = 300;
            this.ObjectNameTimer.Tick += new System.EventHandler(this.ObjectNameTimer_Tick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Checkbox_seealso);
            this.groupBox5.Controls.Add(this.Checkbox_note);
            this.groupBox5.Controls.Add(this.CheckBox_Warning);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox5.Location = new System.Drawing.Point(299, 142);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(356, 46);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Additional Information";
            // 
            // Checkbox_seealso
            // 
            this.Checkbox_seealso.AutoSize = true;
            this.Checkbox_seealso.Location = new System.Drawing.Point(265, 17);
            this.Checkbox_seealso.Name = "Checkbox_seealso";
            this.Checkbox_seealso.Size = new System.Drawing.Size(75, 16);
            this.Checkbox_seealso.TabIndex = 2;
            this.Checkbox_seealso.Text = "See Also";
            this.Checkbox_seealso.UseVisualStyleBackColor = true;
            // 
            // Checkbox_note
            // 
            this.Checkbox_note.AutoSize = true;
            this.Checkbox_note.Location = new System.Drawing.Point(151, 18);
            this.Checkbox_note.Name = "Checkbox_note";
            this.Checkbox_note.Size = new System.Drawing.Size(50, 16);
            this.Checkbox_note.TabIndex = 1;
            this.Checkbox_note.Text = "Note";
            this.Checkbox_note.UseVisualStyleBackColor = true;
            // 
            // CheckBox_Warning
            // 
            this.CheckBox_Warning.AutoSize = true;
            this.CheckBox_Warning.Location = new System.Drawing.Point(10, 17);
            this.CheckBox_Warning.Name = "CheckBox_Warning";
            this.CheckBox_Warning.Size = new System.Drawing.Size(69, 16);
            this.CheckBox_Warning.TabIndex = 0;
            this.CheckBox_Warning.Text = "Warning";
            this.CheckBox_Warning.UseVisualStyleBackColor = true;
            // 
            // _00_Struct_Enum_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 520);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.BT_Generate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "_00_Struct_Enum_Form";
            this.Text = "Struct, Enum Form Generator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this._00_Struct_Enum_Form_FormClosed);
            this.Load += new System.EventHandler(this._00_Struct_Enum_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CB_doctype;
        private System.Windows.Forms.ComboBox CB_prefix;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialSingleLineTextField TF_Header1;
        private MaterialSkin.Controls.MaterialSingleLineTextField TF_Header5;
        private MaterialSkin.Controls.MaterialSingleLineTextField TF_Header4;
        private MaterialSkin.Controls.MaterialSingleLineTextField TF_Header3;
        private MaterialSkin.Controls.MaterialSingleLineTextField TF_Header2;
        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialSingleLineTextField TF_objectname;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialRaisedButton BT_Generate;
        private System.Windows.Forms.GroupBox groupBox4;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private System.Windows.Forms.Timer ObjectNameTimer;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox CheckBox_Warning;
        private System.Windows.Forms.CheckBox Checkbox_note;
        private System.Windows.Forms.CheckBox Checkbox_seealso;
    }
}