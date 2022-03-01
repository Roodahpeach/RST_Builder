using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MaterialSkin;
using MaterialSkin.Controls;
namespace RST_File_Generator
{
    public partial class Toctree_Form : MaterialForm
    {
        #region GenFunc

        StreamWriter RST_File_Writer;
        string Manual_Name = "APIManual";
        int option_MaxDepth_Index = 2;
        int option_MaxDepth_FuncMain = 1;
        bool option_IsTitleOnly = true;
        bool option_IsUsingCaption = false;

        public void GenFunc_AddBlank()
        {
            RST_File_Writer.WriteLine();
            RST_File_Writer.WriteLine();
            RST_File_Writer.WriteLine();
        }

        public void GenFunc_AddHeader()
        {
            RST_File_Writer.WriteLine(Manual_Name);

            foreach (char c in Manual_Name)
            {
                RST_File_Writer.Write("=");
            }

            GenFunc_AddBlank();

        }

        public void GenFunc_AddHeader(string name)
        {
            RST_File_Writer.WriteLine(name);

            foreach (char c in name)
            {
                RST_File_Writer.Write("=");
            }

            GenFunc_AddBlank();

        }

        public void GenFunc_AddToctree(string toctree_name)
        {
            string indent_blank = "  ";

            RST_File_Writer.WriteLine(".. toctree::");
            RST_File_Writer.WriteLine(indent_blank + ":maxdepth: " + option_MaxDepth_Index.ToString()); //Maxdepth
            if (option_IsTitleOnly)
            {
                RST_File_Writer.WriteLine(indent_blank + ":titlesonly:"); //TitlesOnly
            }
            RST_File_Writer.WriteLine();

            RST_File_Writer.WriteLine(indent_blank + toctree_name + "/"+toctree_name+"_Main.rst");
            
            GenFunc_AddBlank();
        }

        public void GenFunc_AddToctree2(ArrayList chapter_list)
        {
            string indent_blank = "  ";

            RST_File_Writer.WriteLine(".. toctree::");
            RST_File_Writer.WriteLine(indent_blank + ":maxdepth: " + option_MaxDepth_FuncMain.ToString()); //Maxdepth
            if (option_IsTitleOnly)
            {
                RST_File_Writer.WriteLine(indent_blank + ":titlesonly:"); //TitlesOnly
            }
            RST_File_Writer.WriteLine();

            foreach(string str in chapter_list)
            {
                RST_File_Writer.WriteLine(indent_blank + str + "/Main.rst");
            }
            GenFunc_AddBlank();
        }

        #endregion

        #region Form Init

        public bool is_folder_selected = false;
        public bool is_folder_selected_color = false;

        string FolderPath;

        public Toctree_Form()
        {
            InitializeComponent();

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
        }

        #endregion


        #region EventHandler
        private void BT_FolderSelect_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog fld = new FolderBrowserDialog();
                if (fld.ShowDialog() == DialogResult.OK)
                {
                    this.FolderPath = fld.SelectedPath;

                    string[] temp = FolderPath.Split('\\');
                    //Source 폴더로 선택했는지 확인
                    if (temp[temp.Length-1] != "source")
                    {
                        MessageBox.Show("Webmanual 폴더의 source 폴더를 선택해주세요");
                        return;
                    }
                    if(FolderPath == null)
                    {
                        return;
                    }

                    //라벨에 표시하기전 폴더 이름을 정리하기
                    bool is_path_too_long = (this.FolderPath.Length > 30);

                    if (is_path_too_long)
                    {
                        //중간경로가 너무 긴경우
                        bool is_middle_path_too_long = (temp.Length > 7);
                        if (is_middle_path_too_long)
                        {
                            string new_path = temp[0] + "\\" + temp[1] + "\\ ... \\" + temp[temp.Length - 1];
                            LB_FolderName.Text = new_path;
                        }
                        else
                        {
                            //일단 모르겠으니 그냥 넣어봐
                            LB_FolderName.Text = FolderPath;
                        }
                    }
                    else
                    {
                        //그렇게 이름이 길지 않은 경우는 그대로 라벨에 표시
                        LB_FolderName.Text = FolderPath;
                    }

                    
                    

                    //타이머 이벤트 Off
                    is_folder_selected = true;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Folder_Selection_Timer_Tick(object sender, EventArgs e)
        {
            if (is_folder_selected)
            {
                materialLabel1.BackColor = Color.Transparent;
            }
            else
            {
                if (is_folder_selected_color)
                {
                    materialLabel1.BackColor = Color.Red;
                }
                else
                {
                    materialLabel1.BackColor = Color.Transparent;
                }
                is_folder_selected_color = !is_folder_selected_color;
            }
        }


        #endregion

        private void BT_MakeIndex_Click(object sender, EventArgs e)
        {
            ArrayList API_List = new ArrayList();

            //Source폴더의 폴더들 이름을 찾기
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(this.FolderPath);
            foreach (System.IO.DirectoryInfo dir in di.GetDirectories())
            {
                if(dir.Name != "_static")
                {
                    API_List.Add(dir.Name); // 리스트에 추가
                }
                
            }

            //Index.rst 파일 생성
            string object_name = "index";
            string filename = this.FolderPath + "\\" + object_name + ".rst";

            
            RST_File_Writer = File.CreateText(filename);

            //파일 내부 작성

            GenFunc_AddHeader();

            foreach(string s in API_List)
            {
                GenFunc_AddToctree(s);
            }

            //완료

            RST_File_Writer.Close();


            //폴더 하나씩 돌면서 각각 FuncMain 만들어주기

            foreach(string s in API_List)
            {
                string temp_folder_path = this.FolderPath + '\\' + s;
                string temp_filename = temp_folder_path + "\\" + s + "_Main.rst";

                ArrayList ChapterList = new ArrayList(); // 챕터 이름 저장

                System.IO.DirectoryInfo di2 = new System.IO.DirectoryInfo(temp_folder_path);
                foreach (System.IO.DirectoryInfo dir in di2.GetDirectories())
                {
                    if (dir.Name != "_static")
                    {
                        ChapterList.Add(dir.Name); // 리스트에 추가
                    }
                }

                //파일 생성
                RST_File_Writer = File.CreateText(temp_filename);

                //내용 채워넣기
                GenFunc_AddHeader(s); // 헤더 넣기
                GenFunc_AddToctree2(ChapterList);

                //완료
                RST_File_Writer.Close();
            }

            MessageBox.Show(filename + " 생성 완료");
        }

        private void BT_MakeFuncMain_Click(object sender, EventArgs e)
        {
 
        }
    }
}
