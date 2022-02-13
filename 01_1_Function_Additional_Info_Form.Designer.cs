
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
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.GB_Common_notetype.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(12, 121);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(779, 401);
            this.materialTabControl1.TabIndex = 1;
            this.materialTabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BT_Common_Submit);
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.Controls.Add(this.RT_Common_Description);
            this.tabPage1.Controls.Add(this.GB_Common_notetype);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(771, 375);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Common Notes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BT_Common_Submit
            // 
            this.BT_Common_Submit.Depth = 0;
            this.BT_Common_Submit.Location = new System.Drawing.Point(6, 317);
            this.BT_Common_Submit.MouseState = MaterialSkin.MouseState.HOVER;
            this.BT_Common_Submit.Name = "BT_Common_Submit";
            this.BT_Common_Submit.Primary = true;
            this.BT_Common_Submit.Size = new System.Drawing.Size(759, 52);
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
            this.materialLabel1.Location = new System.Drawing.Point(22, 175);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(94, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Description -";
            // 
            // RT_Common_Description
            // 
            this.RT_Common_Description.Location = new System.Drawing.Point(122, 61);
            this.RT_Common_Description.Name = "RT_Common_Description";
            this.RT_Common_Description.Size = new System.Drawing.Size(643, 240);
            this.RT_Common_Description.TabIndex = 1;
            this.RT_Common_Description.Text = "";
            // 
            // GB_Common_notetype
            // 
            this.GB_Common_notetype.Controls.Add(this.RB_COMMON_Hint);
            this.GB_Common_notetype.Controls.Add(this.RB_COMMON_warning);
            this.GB_Common_notetype.Controls.Add(this.RB_COMMON_note);
            this.GB_Common_notetype.ForeColor = System.Drawing.Color.Snow;
            this.GB_Common_notetype.Location = new System.Drawing.Point(6, 6);
            this.GB_Common_notetype.Name = "GB_Common_notetype";
            this.GB_Common_notetype.Size = new System.Drawing.Size(759, 49);
            this.GB_Common_notetype.TabIndex = 0;
            this.GB_Common_notetype.TabStop = false;
            this.GB_Common_notetype.Text = "Note Type";
            // 
            // RB_COMMON_Hint
            // 
            this.RB_COMMON_Hint.AutoSize = true;
            this.RB_COMMON_Hint.Location = new System.Drawing.Point(135, 20);
            this.RB_COMMON_Hint.Name = "RB_COMMON_Hint";
            this.RB_COMMON_Hint.Size = new System.Drawing.Size(44, 16);
            this.RB_COMMON_Hint.TabIndex = 2;
            this.RB_COMMON_Hint.Text = "Hint";
            this.RB_COMMON_Hint.UseVisualStyleBackColor = true;
            // 
            // RB_COMMON_warning
            // 
            this.RB_COMMON_warning.AutoSize = true;
            this.RB_COMMON_warning.Location = new System.Drawing.Point(61, 20);
            this.RB_COMMON_warning.Name = "RB_COMMON_warning";
            this.RB_COMMON_warning.Size = new System.Drawing.Size(68, 16);
            this.RB_COMMON_warning.TabIndex = 1;
            this.RB_COMMON_warning.Text = "Warning";
            this.RB_COMMON_warning.UseVisualStyleBackColor = true;
            // 
            // RB_COMMON_note
            // 
            this.RB_COMMON_note.AutoSize = true;
            this.RB_COMMON_note.Checked = true;
            this.RB_COMMON_note.Location = new System.Drawing.Point(6, 20);
            this.RB_COMMON_note.Name = "RB_COMMON_note";
            this.RB_COMMON_note.Size = new System.Drawing.Size(49, 16);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(771, 375);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "See Also";
            // 
            // BT_Seealso_Submit
            // 
            this.BT_Seealso_Submit.Depth = 0;
            this.BT_Seealso_Submit.Location = new System.Drawing.Point(6, 306);
            this.BT_Seealso_Submit.MouseState = MaterialSkin.MouseState.HOVER;
            this.BT_Seealso_Submit.Name = "BT_Seealso_Submit";
            this.BT_Seealso_Submit.Primary = true;
            this.BT_Seealso_Submit.Size = new System.Drawing.Size(747, 63);
            this.BT_Seealso_Submit.TabIndex = 5;
            this.BT_Seealso_Submit.Text = "Submit";
            this.BT_Seealso_Submit.UseVisualStyleBackColor = true;
            this.BT_Seealso_Submit.Click += new System.EventHandler(this.BT_Seealso_Submit_Click);
            // 
            // LB_Seealso
            // 
            this.LB_Seealso.FormattingEnabled = true;
            this.LB_Seealso.ItemHeight = 12;
            this.LB_Seealso.Location = new System.Drawing.Point(6, 6);
            this.LB_Seealso.Name = "LB_Seealso";
            this.LB_Seealso.Size = new System.Drawing.Size(354, 292);
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
            this.groupBox1.Location = new System.Drawing.Point(370, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 292);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // BT_Seealso_Delete
            // 
            this.BT_Seealso_Delete.Depth = 0;
            this.BT_Seealso_Delete.Location = new System.Drawing.Point(198, 168);
            this.BT_Seealso_Delete.MouseState = MaterialSkin.MouseState.HOVER;
            this.BT_Seealso_Delete.Name = "BT_Seealso_Delete";
            this.BT_Seealso_Delete.Primary = true;
            this.BT_Seealso_Delete.Size = new System.Drawing.Size(179, 103);
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
            this.materialLabel2.Location = new System.Drawing.Point(6, 49);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(144, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Target Label Name -";
            // 
            // BT_Seealso_add
            // 
            this.BT_Seealso_add.Depth = 0;
            this.BT_Seealso_add.Location = new System.Drawing.Point(10, 168);
            this.BT_Seealso_add.MouseState = MaterialSkin.MouseState.HOVER;
            this.BT_Seealso_add.Name = "BT_Seealso_add";
            this.BT_Seealso_add.Primary = true;
            this.BT_Seealso_add.Size = new System.Drawing.Size(179, 103);
            this.BT_Seealso_add.TabIndex = 6;
            this.BT_Seealso_add.Text = "Add";
            this.BT_Seealso_add.UseVisualStyleBackColor = true;
            this.BT_Seealso_add.Click += new System.EventHandler(this.BT_Seealso_add_Click);
            // 
            // TF_Seealso_Target
            // 
            this.TF_Seealso_Target.Depth = 0;
            this.TF_Seealso_Target.Hint = "Label Name (Link Name)";
            this.TF_Seealso_Target.Location = new System.Drawing.Point(157, 49);
            this.TF_Seealso_Target.MouseState = MaterialSkin.MouseState.HOVER;
            this.TF_Seealso_Target.Name = "TF_Seealso_Target";
            this.TF_Seealso_Target.PasswordChar = '\0';
            this.TF_Seealso_Target.SelectedText = "";
            this.TF_Seealso_Target.SelectionLength = 0;
            this.TF_Seealso_Target.SelectionStart = 0;
            this.TF_Seealso_Target.Size = new System.Drawing.Size(220, 23);
            this.TF_Seealso_Target.TabIndex = 3;
            this.TF_Seealso_Target.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(40, 103);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(110, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Display Name -";
            // 
            // TF_Seealso_DisplayName
            // 
            this.TF_Seealso_DisplayName.Depth = 0;
            this.TF_Seealso_DisplayName.Hint = "(Optional)";
            this.TF_Seealso_DisplayName.Location = new System.Drawing.Point(157, 103);
            this.TF_Seealso_DisplayName.MouseState = MaterialSkin.MouseState.HOVER;
            this.TF_Seealso_DisplayName.Name = "TF_Seealso_DisplayName";
            this.TF_Seealso_DisplayName.PasswordChar = '\0';
            this.TF_Seealso_DisplayName.SelectedText = "";
            this.TF_Seealso_DisplayName.SelectionLength = 0;
            this.TF_Seealso_DisplayName.SelectionStart = 0;
            this.TF_Seealso_DisplayName.Size = new System.Drawing.Size(220, 23);
            this.TF_Seealso_DisplayName.TabIndex = 4;
            this.TF_Seealso_DisplayName.UseSystemPasswordChar = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(771, 375);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Example";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(11, 78);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.materialTabSelector1.Size = new System.Drawing.Size(772, 37);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "Test";
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(771, 375);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Image";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Function_Additional_Info_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 534);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
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
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
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
    }
}