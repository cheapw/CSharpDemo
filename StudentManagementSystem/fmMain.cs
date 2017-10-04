using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class fmMain : Form
    {
        private string fileName = string.Empty;//定义变量保存读取文件路径的变量
        private List<string> objListStudent = new List<string>();//定义List存储读取到的学生信息
        public fmMain()
        {
            InitializeComponent();
        }
        //运行过程---业务逻辑
        //数据的导入和演示：选择文件--》导入到DateGridView中--》展示选择学生明细---》选择学生不同，明细数据随之发生变化

        
        //控制事件
        private void btnInport_Click(object sender, EventArgs e)
        {
            //【1】选择文件
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "CSV文件(*.csv)|*.csv|TXT文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            if (openFile.ShowDialog()==DialogResult.OK)
            {
                fileName = openFile.FileName;//把选择的文件路径赋值位全局变量fileName
            }

            //【2】把文件的数据读取到List中
            try
            {
                //读取文件
                objListStudent = ReadFileToList(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("读取文件出现错误，具体错误如下：" + ex.Message, "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //【3】把List中的数据展示在DateGridView中
        }
        
        //用户自定义方法

        private List<string> ReadFileToList(string filePath)//把某一个文件数据读取，并以List形式返回给调用者
        {
            List<string> objList = new List<string>();
            string line = string.Empty;
            try
            {
                StreamReader file = new StreamReader(filePath, Encoding.Default);
                while ((line = file.ReadLine()) != null)
                {
                    objList.Add(line);
                }
                file.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return objList;
            
        }
        private void 
    }
}
