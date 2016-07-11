using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace 更新存盘
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// PCPath
        /// </summary>
        private string _pcPath = string.Empty;
        /// <summary>
        /// U盘Path
        /// </summary>
        private string _uPath = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 同步U盘
        /// 以U盘中文件为基准，同步到电脑中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSyncOut_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(_uPath, "*.*", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                string newFilePath = file.Replace(_uPath, _pcPath);
                string newPath = Path.GetDirectoryName(newFilePath);
                if (!Directory.Exists(newPath))
                {
                    Directory.CreateDirectory(newPath);
                }
                File.Copy(file, newFilePath, true);
            }
            MessageBox.Show("同步完成");
        }
        /// <summary>
        /// 同步电脑
        /// 以电脑中文件为基准，同步到U盘中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSyncIn_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(_pcPath, "*.*", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                string newFilePath = file.Replace(_pcPath, _uPath);
                string newPath = Path.GetDirectoryName(newFilePath);
                if (!Directory.Exists(newPath))
                {
                    Directory.CreateDirectory(newPath);
                }
                File.Copy(file, newFilePath, true);
            }
            MessageBox.Show("同步完成");
        }

        /// <summary>
        /// Load检查
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            {
                if (drive.VolumeLabel.ToUpper().Equals("STYLE"))
                {//存在Style盘
                    _uPath = Path.Combine(drive.Name, "存盘");

                    _pcPath = Path.Combine("D:\\works", "存盘");
                }
            }

            if (string.IsNullOrEmpty(_pcPath) || string.IsNullOrEmpty(_uPath))
            {
                MessageBox.Show("尚未插入U盘");
                this.Close();
            }
        }
    }
}
