using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MaterialSkin;
using MaterialSkin.Controls;

#region Memo
/*
 - 완료 목록
예제 입력 폼 완성
클리어 기능 구현
trim 구현
투명 배경색 이슈 해결 -> 해결. Tabstop의 배경색 지정 후 정상 동작 (this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));)
 */

/*
- 작업 예정 목록
메뉴 한글화 -> 영어로 풀어쓰니 가로로 너무 글씨가 많다. 영단어 생각도 잘 안남
Toctree Generator 만들기 (Index하고 Main.rst)
업무 계획, 보고, 주간 보고 Generator 만들기?
이미지 입력 폼 제작
테이블 제네레이터 제작? -> 보류
Unit Test 모듈 제작? -> 굳이? 일단 경험이라 생각하고 만들어보는거도 괜찮을듯
 */
#endregion



namespace RST_File_Generator
{
    
    public partial class MainForm : MaterialForm
    {
        public void functionform_reload()
        {
            new _01_Function_Form(this).Show();
        }

        public MainForm()
        {
            InitializeComponent();

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey500, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Red200, TextShade.WHITE);
        }

        private void Main_BT_struct_enum_Click(object sender, EventArgs e)
        {
            new _00_Struct_Enum_Form().Show();
        }

        private void BT_function_Click(object sender, EventArgs e)
        {
            new _01_Function_Form(this).Show();
        }

        private void BT_Toctree_Click(object sender, EventArgs e)
        {
            new Toctree_Form().Show();
        }
    }
}
