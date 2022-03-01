
namespace RST_File_Generator
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BT_struct_enum = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BT_function = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BT_Toctree = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.BT_struct_enum, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BT_function, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BT_Toctree, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 169);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(536, 470);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // BT_struct_enum
            // 
            this.BT_struct_enum.Depth = 0;
            this.BT_struct_enum.Location = new System.Drawing.Point(3, 4);
            this.BT_struct_enum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BT_struct_enum.MouseState = MaterialSkin.MouseState.HOVER;
            this.BT_struct_enum.Name = "BT_struct_enum";
            this.BT_struct_enum.Primary = true;
            this.BT_struct_enum.Size = new System.Drawing.Size(261, 148);
            this.BT_struct_enum.TabIndex = 0;
            this.BT_struct_enum.Text = "Struct, Enum Form Generator";
            this.BT_struct_enum.UseVisualStyleBackColor = true;
            this.BT_struct_enum.Click += new System.EventHandler(this.Main_BT_struct_enum_Click);
            // 
            // BT_function
            // 
            this.BT_function.Depth = 0;
            this.BT_function.Location = new System.Drawing.Point(271, 4);
            this.BT_function.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BT_function.MouseState = MaterialSkin.MouseState.HOVER;
            this.BT_function.Name = "BT_function";
            this.BT_function.Primary = true;
            this.BT_function.Size = new System.Drawing.Size(261, 148);
            this.BT_function.TabIndex = 0;
            this.BT_function.Text = "Function Form Generator";
            this.BT_function.UseVisualStyleBackColor = true;
            this.BT_function.Click += new System.EventHandler(this.BT_function_Click);
            // 
            // BT_Toctree
            // 
            this.BT_Toctree.Depth = 0;
            this.BT_Toctree.Location = new System.Drawing.Point(3, 160);
            this.BT_Toctree.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BT_Toctree.MouseState = MaterialSkin.MouseState.HOVER;
            this.BT_Toctree.Name = "BT_Toctree";
            this.BT_Toctree.Primary = true;
            this.BT_Toctree.Size = new System.Drawing.Size(261, 148);
            this.BT_Toctree.TabIndex = 1;
            this.BT_Toctree.Text = "Toctree Builder";
            this.BT_Toctree.UseVisualStyleBackColor = true;
            this.BT_Toctree.Click += new System.EventHandler(this.BT_Toctree_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 654);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "RST_File_Generator V1.0.2.0";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialRaisedButton BT_struct_enum;
        private MaterialSkin.Controls.MaterialRaisedButton BT_function;
        private MaterialSkin.Controls.MaterialRaisedButton BT_Toctree;
    }
}

