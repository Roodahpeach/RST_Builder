namespace RST_File_Generator
{
    partial class Toctree_Form
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
            this.BT_FolderSelect = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Folder_Selection_Timer = new System.Windows.Forms.Timer(this.components);
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.LB_FolderName = new MaterialSkin.Controls.MaterialLabel();
            this.BT_MakeIndex = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BT_MakeFuncMain = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // BT_FolderSelect
            // 
            this.BT_FolderSelect.Depth = 0;
            this.BT_FolderSelect.Location = new System.Drawing.Point(12, 73);
            this.BT_FolderSelect.MouseState = MaterialSkin.MouseState.HOVER;
            this.BT_FolderSelect.Name = "BT_FolderSelect";
            this.BT_FolderSelect.Primary = true;
            this.BT_FolderSelect.Size = new System.Drawing.Size(737, 50);
            this.BT_FolderSelect.TabIndex = 1;
            this.BT_FolderSelect.Text = "Select RST Project Source Folder";
            this.BT_FolderSelect.UseVisualStyleBackColor = true;
            this.BT_FolderSelect.Click += new System.EventHandler(this.BT_FolderSelect_Click);
            // 
            // Folder_Selection_Timer
            // 
            this.Folder_Selection_Timer.Enabled = true;
            this.Folder_Selection_Timer.Interval = 500;
            this.Folder_Selection_Timer.Tick += new System.EventHandler(this.Folder_Selection_Timer_Tick);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(13, 130);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(157, 24);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Selected Folder - ";
            // 
            // LB_FolderName
            // 
            this.LB_FolderName.AutoSize = true;
            this.LB_FolderName.Depth = 0;
            this.LB_FolderName.Font = new System.Drawing.Font("Roboto", 11F);
            this.LB_FolderName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LB_FolderName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LB_FolderName.Location = new System.Drawing.Point(176, 130);
            this.LB_FolderName.MouseState = MaterialSkin.MouseState.HOVER;
            this.LB_FolderName.Name = "LB_FolderName";
            this.LB_FolderName.Size = new System.Drawing.Size(13, 28);
            this.LB_FolderName.TabIndex = 3;
            this.LB_FolderName.Text = "-";
            this.LB_FolderName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LB_FolderName.UseCompatibleTextRendering = true;
            // 
            // BT_MakeIndex
            // 
            this.BT_MakeIndex.Depth = 0;
            this.BT_MakeIndex.Location = new System.Drawing.Point(12, 170);
            this.BT_MakeIndex.MouseState = MaterialSkin.MouseState.HOVER;
            this.BT_MakeIndex.Name = "BT_MakeIndex";
            this.BT_MakeIndex.Primary = true;
            this.BT_MakeIndex.Size = new System.Drawing.Size(363, 88);
            this.BT_MakeIndex.TabIndex = 4;
            this.BT_MakeIndex.Text = "Make Index.rst & API_Main.rst";
            this.BT_MakeIndex.UseVisualStyleBackColor = true;
            this.BT_MakeIndex.Click += new System.EventHandler(this.BT_MakeIndex_Click);
            // 
            // BT_MakeFuncMain
            // 
            this.BT_MakeFuncMain.Depth = 0;
            this.BT_MakeFuncMain.Location = new System.Drawing.Point(401, 170);
            this.BT_MakeFuncMain.MouseState = MaterialSkin.MouseState.HOVER;
            this.BT_MakeFuncMain.Name = "BT_MakeFuncMain";
            this.BT_MakeFuncMain.Primary = true;
            this.BT_MakeFuncMain.Size = new System.Drawing.Size(348, 88);
            this.BT_MakeFuncMain.TabIndex = 5;
            this.BT_MakeFuncMain.Text = "Make Function_Main.rst";
            this.BT_MakeFuncMain.UseVisualStyleBackColor = true;
            this.BT_MakeFuncMain.Click += new System.EventHandler(this.BT_MakeFuncMain_Click);
            // 
            // Toctree_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(761, 270);
            this.Controls.Add(this.BT_MakeFuncMain);
            this.Controls.Add(this.BT_MakeIndex);
            this.Controls.Add(this.LB_FolderName);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.BT_FolderSelect);
            this.Name = "Toctree_Form";
            this.Text = "Toctree Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton BT_FolderSelect;
        private System.Windows.Forms.Timer Folder_Selection_Timer;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel LB_FolderName;
        private MaterialSkin.Controls.MaterialRaisedButton BT_MakeIndex;
        private MaterialSkin.Controls.MaterialRaisedButton BT_MakeFuncMain;
    }
}