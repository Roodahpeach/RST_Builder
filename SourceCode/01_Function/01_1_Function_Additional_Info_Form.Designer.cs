
namespace RST_File_Generator
{
    partial class Function_Additional_Info_Form
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
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BT_Common_Submit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.RT_Common_Description = new System.Windows.Forms.RichTextBox();
            this.GB_Common_notetype = new System.Windows.Forms.GroupBox();
            this.RB_COMMON_Hint = new System.Windows.Forms.RadioButton();
            this.RB_COMMON_warning = new System.Windows.Forms.RadioButton();
            this.RB_COMMON_note = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BT_Seealso_Submit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.LB_Seealso = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BT_Seealso_Delete = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.BT_Seealso_add = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TF_Seealso_Target = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.TF_Seealso_DisplayName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.BT_Example_Submit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BT_Example_Import = new MaterialSkin.Controls.MaterialRaisedButton();
            this.CB_Example_Language = new System.Windows.Forms.ComboBox();
            this.TF_Example_Emphasize = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.LB_Example_Linenumber = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.RT_Example_Examplecode = new System.Windows.Forms.RichTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.GB_Common_notetype.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(14, 151);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(890, 501);
            this.materialTabControl1.TabIndex = 1;
            this.materialTabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BT_Common_Submit);
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.Controls.Add(this.RT_Common_Description);
            this.tabPage1.Controls.Add(this.GB_Common_notetype);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(882, 472);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Common Notes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BT_Common_Submit
            // 
            this.BT_Common_Submit.Depth = 0;
            this.BT_Common_Submit.Location = new System.Drawing.Point(7, 396);
            this.BT_Common_Submit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BT_Common_Submit.MouseState = MaterialSkin.MouseState.HOVER;
            this.BT_Common_Submit.Name = "BT_Common_Submit";
            this.BT_Common_Submit.Primary = true;
            this.BT_Common_Submit.Size = new System.Drawing.Size(867, 65);
            this.BT_Common_Submit.TabIndex = 3;
            this.BT_Common_Submit.Text = "Submit";
            this.BT_Common_Submit.UseVisualStyleBackColor = true;
            this.BT_Common_Submit.Click += new System.EventHandler(this.BT_Common_Submit_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(25, 219);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(116, 24);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Description -";
            // 
            // RT_Common_Description
            // 
            this.RT_Common_Description.Location = new System.Drawing.Point(139, 76);
            this.RT_Common_Description.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RT_Common_Description.Name = "RT_Common_Description";
            this.RT_Common_Description.Size = new System.Drawing.Size(734, 299);
            this.RT_Common_Description.TabIndex = 1;
            this.RT_Common_Description.Text = "";
            // 
            // GB_Common_notetype
            // 
            this.GB_Common_notetype.Controls.Add(this.RB_COMMON_Hint);
            this.GB_Common_notetype.Controls.Add(this.RB_COMMON_warning);
            this.GB_Common_notetype.Controls.Add(this.RB_COMMON_note);
            this.GB_Common_notetype.ForeColor = System.Drawing.Color.Snow;
            this.GB_Common_notetype.Location = new System.Drawing.Point(7, 8);
            this.GB_Common_notetype.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GB_Common_notetype.Name = "GB_Common_notetype";
            this.GB_Common_notetype.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GB_Common_notetype.Size = new System.Drawing.Size(867, 61);
            this.GB_Common_notetype.TabIndex = 0;
            this.GB_Common_notetype.TabStop = false;
            this.GB_Common_notetype.Text = "Note Type";
            // 
            // RB_COMMON_Hint
            // 
            this.RB_COMMON_Hint.AutoSize = true;
            this.RB_COMMON_Hint.Location = new System.Drawing.Point(154, 25);
            this.RB_COMMON_Hint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RB_COMMON_Hint.Name = "RB_COMMON_Hint";
            this.RB_COMMON_Hint.Size = new System.Drawing.Size(53, 19);
            this.RB_COMMON_Hint.TabIndex = 2;
            this.RB_COMMON_Hint.Text = "Hint";
            this.RB_COMMON_Hint.UseVisualStyleBackColor = true;
            // 
            // RB_COMMON_warning
            // 
            this.RB_COMMON_warning.AutoSize = true;
            this.RB_COMMON_warning.Location = new System.Drawing.Point(70, 25);
            this.RB_COMMON_warning.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RB_COMMON_warning.Name = "RB_COMMON_warning";
            this.RB_COMMON_warning.Size = new System.Drawing.Size(81, 19);
            this.RB_COMMON_warning.TabIndex = 1;
            this.RB_COMMON_warning.Text = "Warning";
            this.RB_COMMON_warning.UseVisualStyleBackColor = true;
            // 
            // RB_COMMON_note
            // 
            this.RB_COMMON_note.AutoSize = true;
            this.RB_COMMON_note.Checked = true;
            this.RB_COMMON_note.Location = new System.Drawing.Point(7, 25);
            this.RB_COMMON_note.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RB_COMMON_note.Name = "RB_COMMON_note";
            this.RB_COMMON_note.Size = new System.Drawing.Size(58, 19);
            this.RB_COMMON_note.TabIndex = 0;
            this.RB_COMMON_note.TabStop = true;
            this.RB_COMMON_note.Text = "Note";
            this.RB_COMMON_note.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tabPage2.Controls.Add(this.BT_Seealso_Submit);
            this.tabPage2.Controls.Add(this.LB_Seealso);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(882, 472);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "See Also";
            // 
            // BT_Seealso_Submit
            // 
            this.BT_Seealso_Submit.Depth = 0;
            this.BT_Seealso_Submit.Location = new System.Drawing.Point(7, 382);
            this.BT_Seealso_Submit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BT_Seealso_Submit.MouseState = MaterialSkin.MouseState.HOVER;
            this.BT_Seealso_Submit.Name = "BT_Seealso_Submit";
            this.BT_Seealso_Submit.Primary = true;
            this.BT_Seealso_Submit.Size = new System.Drawing.Size(854, 79);
            this.BT_Seealso_Submit.TabIndex = 5;
            this.BT_Seealso_Submit.Text = "Submit";
            this.BT_Seealso_Submit.UseVisualStyleBackColor = true;
            this.BT_Seealso_Submit.Click += new System.EventHandler(this.BT_Seealso_Submit_Click);
            // 
            // LB_Seealso
            // 
            this.LB_Seealso.FormattingEnabled = true;
            this.LB_Seealso.ItemHeight = 15;
            this.LB_Seealso.Location = new System.Drawing.Point(7, 8);
            this.LB_Seealso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LB_Seealso.Name = "LB_Seealso";
            this.LB_Seealso.Size = new System.Drawing.Size(404, 364);
            this.LB_Seealso.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BT_Seealso_Delete);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.BT_Seealso_add);
            this.groupBox1.Controls.Add(this.TF_Seealso_Target);
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Controls.Add(this.TF_Seealso_DisplayName);
            this.groupBox1.Location = new System.Drawing.Point(423, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(438, 365);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // BT_Seealso_Delete
            // 
            this.BT_Seealso_Delete.Depth = 0;
            this.BT_Seealso_Delete.Location = new System.Drawing.Point(226, 210);
            this.BT_Seealso_Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BT_Seealso_Delete.MouseState = MaterialSkin.MouseState.HOVER;
            this.BT_Seealso_Delete.Name = "BT_Seealso_Delete";
            this.BT_Seealso_Delete.Primary = true;
            this.BT_Seealso_Delete.Size = new System.Drawing.Size(205, 129);
            this.BT_Seealso_Delete.TabIndex = 7;
            this.BT_Seealso_Delete.Text = "Delete";
            this.BT_Seealso_Delete.UseVisualStyleBackColor = true;
            this.BT_Seealso_Delete.Click += new System.EventHandler(this.BT_Seealso_Delete_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(7, 61);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(181, 24);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Target Label Name -";
            // 
            // BT_Seealso_add
            // 
            this.BT_Seealso_add.Depth = 0;
            this.BT_Seealso_add.Location = new System.Drawing.Point(11, 210);
            this.BT_Seealso_add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BT_Seealso_add.MouseState = MaterialSkin.MouseState.HOVER;
            this.BT_Seealso_add.Name = "BT_Seealso_add";
            this.BT_Seealso_add.Primary = true;
            this.BT_Seealso_add.Size = new System.Drawing.Size(205, 129);
            this.BT_Seealso_add.TabIndex = 6;
            this.BT_Seealso_add.Text = "Add";
            this.BT_Seealso_add.UseVisualStyleBackColor = true;
            this.BT_Seealso_add.Click += new System.EventHandler(this.BT_Seealso_add_Click);
            // 
            // TF_Seealso_Target
            // 
            this.TF_Seealso_Target.Depth = 0;
            this.TF_Seealso_Target.Hint = "Label Name (Link Name)";
            this.TF_Seealso_Target.Location = new System.Drawing.Point(179, 61);
            this.TF_Seealso_Target.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TF_Seealso_Target.MouseState = MaterialSkin.MouseState.HOVER;
            this.TF_Seealso_Target.Name = "TF_Seealso_Target";
            this.TF_Seealso_Target.PasswordChar = '\0';
            this.TF_Seealso_Target.SelectedText = "";
            this.TF_Seealso_Target.SelectionLength = 0;
            this.TF_Seealso_Target.SelectionStart = 0;
            this.TF_Seealso_Target.Size = new System.Drawing.Size(251, 28);
            this.TF_Seealso_Target.TabIndex = 3;
            this.TF_Seealso_Target.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(46, 129);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(138, 24);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Display Name -";
            // 
            // TF_Seealso_DisplayName
            // 
            this.TF_Seealso_DisplayName.Depth = 0;
            this.TF_Seealso_DisplayName.Hint = "(Optional)";
            this.TF_Seealso_DisplayName.Location = new System.Drawing.Point(179, 129);
            this.TF_Seealso_DisplayName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TF_Seealso_DisplayName.MouseState = MaterialSkin.MouseState.HOVER;
            this.TF_Seealso_DisplayName.Name = "TF_Seealso_DisplayName";
            this.TF_Seealso_DisplayName.PasswordChar = '\0';
            this.TF_Seealso_DisplayName.SelectedText = "";
            this.TF_Seealso_DisplayName.SelectionLength = 0;
            this.TF_Seealso_DisplayName.SelectionStart = 0;
            this.TF_Seealso_DisplayName.Size = new System.Drawing.Size(251, 28);
            this.TF_Seealso_DisplayName.TabIndex = 4;
            this.TF_Seealso_DisplayName.UseSystemPasswordChar = false;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tabPage3.Controls.Add(this.BT_Example_Submit);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.LB_Example_Linenumber);
            this.tabPage3.Controls.Add(this.materialLabel4);
            this.tabPage3.Controls.Add(this.RT_Example_Examplecode);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Size = new System.Drawing.Size(882, 472);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Example";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // BT_Example_Submit
            // 
            this.BT_Example_Submit.Depth = 0;
            this.BT_Example_Submit.Location = new System.Drawing.Point(695, 305);
            this.BT_Example_Submit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BT_Example_Submit.MouseState = MaterialSkin.MouseState.HOVER;
            this.BT_Example_Submit.Name = "BT_Example_Submit";
            this.BT_Example_Submit.Primary = true;
            this.BT_Example_Submit.Size = new System.Drawing.Size(173, 156);
            this.BT_Example_Submit.TabIndex = 4;
            this.BT_Example_Submit.Text = "Submit";
            this.BT_Example_Submit.UseVisualStyleBackColor = true;
            this.BT_Example_Submit.Click += new System.EventHandler(this.BT_Example_Submit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BT_Example_Import);
            this.groupBox2.Controls.Add(this.CB_Example_Language);
            this.groupBox2.Controls.Add(this.TF_Example_Emphasize);
            this.groupBox2.Controls.Add(this.materialLabel5);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(688, 59);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(186, 239);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // BT_Example_Import
            // 
            this.BT_Example_Import.Depth = 0;
            this.BT_Example_Import.Location = new System.Drawing.Point(7, 171);
            this.BT_Example_Import.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BT_Example_Import.MouseState = MaterialSkin.MouseState.HOVER;
            this.BT_Example_Import.Name = "BT_Example_Import";
            this.BT_Example_Import.Primary = true;
            this.BT_Example_Import.Size = new System.Drawing.Size(173, 49);
            this.BT_Example_Import.TabIndex = 5;
            this.BT_Example_Import.Text = "Import Code File";
            this.BT_Example_Import.UseVisualStyleBackColor = true;
            this.BT_Example_Import.Click += new System.EventHandler(this.BT_Example_Import_Click);
            // 
            // CB_Example_Language
            // 
            this.CB_Example_Language.FormattingEnabled = true;
            this.CB_Example_Language.Items.AddRange(new object[] {
            "C++",
            "C#",
            "Delphi",
            "VB6.0"});
            this.CB_Example_Language.Location = new System.Drawing.Point(7, 49);
            this.CB_Example_Language.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CB_Example_Language.Name = "CB_Example_Language";
            this.CB_Example_Language.Size = new System.Drawing.Size(172, 23);
            this.CB_Example_Language.TabIndex = 1;
            // 
            // TF_Example_Emphasize
            // 
            this.TF_Example_Emphasize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TF_Example_Emphasize.Depth = 0;
            this.TF_Example_Emphasize.Hint = "Emphasize Line Num";
            this.TF_Example_Emphasize.Location = new System.Drawing.Point(7, 104);
            this.TF_Example_Emphasize.MouseState = MaterialSkin.MouseState.HOVER;
            this.TF_Example_Emphasize.Name = "TF_Example_Emphasize";
            this.TF_Example_Emphasize.PasswordChar = '\0';
            this.TF_Example_Emphasize.SelectedText = "";
            this.TF_Example_Emphasize.SelectionLength = 0;
            this.TF_Example_Emphasize.SelectionStart = 0;
            this.TF_Example_Emphasize.Size = new System.Drawing.Size(174, 28);
            this.TF_Example_Emphasize.TabIndex = 4;
            this.TF_Example_Emphasize.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(49, 21);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(92, 24);
            this.materialLabel5.TabIndex = 0;
            this.materialLabel5.Text = "Language";
            // 
            // LB_Example_Linenumber
            // 
            this.LB_Example_Linenumber.AutoSize = true;
            this.LB_Example_Linenumber.Depth = 0;
            this.LB_Example_Linenumber.Font = new System.Drawing.Font("Roboto", 11F);
            this.LB_Example_Linenumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LB_Example_Linenumber.Location = new System.Drawing.Point(831, 24);
            this.LB_Example_Linenumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.LB_Example_Linenumber.Name = "LB_Example_Linenumber";
            this.LB_Example_Linenumber.Size = new System.Drawing.Size(21, 24);
            this.LB_Example_Linenumber.TabIndex = 2;
            this.LB_Example_Linenumber.Text = "0";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(685, 24);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(166, 24);
            this.materialLabel4.TabIndex = 1;
            this.materialLabel4.Text = "Current Line Num -";
            // 
            // RT_Example_Examplecode
            // 
            this.RT_Example_Examplecode.AcceptsTab = true;
            this.RT_Example_Examplecode.Location = new System.Drawing.Point(7, 8);
            this.RT_Example_Examplecode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RT_Example_Examplecode.Name = "RT_Example_Examplecode";
            this.RT_Example_Examplecode.Size = new System.Drawing.Size(670, 453);
            this.RT_Example_Examplecode.TabIndex = 0;
            this.RT_Example_Examplecode.Text = "";
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage4.Size = new System.Drawing.Size(882, 472);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Image";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(13, 98);
            this.materialTabSelector1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.materialTabSelector1.Size = new System.Drawing.Size(882, 46);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "Test";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Function_Additional_Info_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 668);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Function_Additional_Info_Form";
            this.Text = "Additional Information Generator";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.GB_Common_notetype.ResumeLayout(false);
            this.GB_Common_notetype.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.GroupBox GB_Common_notetype;
        private System.Windows.Forms.RadioButton RB_COMMON_warning;
        private System.Windows.Forms.RadioButton RB_COMMON_note;
        private System.Windows.Forms.RadioButton RB_COMMON_Hint;
        private MaterialSkin.Controls.MaterialRaisedButton BT_Common_Submit;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.RichTextBox RT_Common_Description;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.ListBox LB_Seealso;
        private MaterialSkin.Controls.MaterialSingleLineTextField TF_Seealso_Target;
        private MaterialSkin.Controls.MaterialSingleLineTextField TF_Seealso_DisplayName;
        private MaterialSkin.Controls.MaterialRaisedButton BT_Seealso_Submit;
        private MaterialSkin.Controls.MaterialRaisedButton BT_Seealso_add;
        private MaterialSkin.Controls.MaterialRaisedButton BT_Seealso_Delete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage4;
        private MaterialSkin.Controls.MaterialLabel LB_Example_Linenumber;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.RichTextBox RT_Example_Examplecode;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.ComboBox CB_Example_Language;
        private MaterialSkin.Controls.MaterialSingleLineTextField TF_Example_Emphasize;
        private MaterialSkin.Controls.MaterialRaisedButton BT_Example_Import;
        private MaterialSkin.Controls.MaterialRaisedButton BT_Example_Submit;
    }
}