using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Note_App
{

    public partial class Form1 : Form
    {
        string filePath = "./Saves/dt.csv";
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //Creat Datatable file if you need
            if (!File.Exists(filePath))
            {
                System.IO.FileStream f = System.IO.File.Create(filePath);
                f.Close();
                dt = new DataTable();
                dt.Columns.Add("Title", typeof(String));
                dt.Columns.Add("Messages", typeof(String));

            } else
            {
                //Read Datatable
                dt = DataTableExtensions.ConvertCsvToDataTable(filePath);

            }
            DataGridView1.DataSource = dt;

            DataGridView1.Columns["Title"].Width = 260;
            DataGridView1.Columns["Messages"].Visible = false;

        }

        private void BT_New_Click(object sender, EventArgs e)
        {
            TB_Title.Clear();
            TB_Message.Clear();
        }

        private void BT_Save_Click(object sender, EventArgs e)
        {
            //Save only when it's not empyt
            if (TB_Title.Text != "" && TB_Message.Text != "")
            {
                //Save to ram
                dt.Rows.Add(TB_Title.Text, TB_Message.Text);

                TB_Title.Clear();
                TB_Message.Clear();

                //Save to "Saves" 
                DataTableExtensions.WriteToCsvFile(dt, filePath);
            }
        }

        private void BT_Open_Click(object sender, EventArgs e)
        {
            //Open only when there are files
            if (dt != null && dt.Rows.Count > 0)
            {
                int index = DataGridView1.CurrentCell.RowIndex;
                if (index > -1)
                {
                    TB_Title.Text = dt.Rows[index].ItemArray[0].ToString();
                    TB_Message.Text = dt.Rows[index].ItemArray[1].ToString();
                }
            }
        }

        private void BT_Delete_Click(object sender, EventArgs e)
        {
            //Delete when 
            if (dt != null && dt.Rows.Count > 0)
            {
                int index = DataGridView1.CurrentCell.RowIndex;
                dt.Rows[index].Delete();
            }
        }
    }

    public static class DataTableExtensions
    {
        public static void WriteToCsvFile(this DataTable dataTable, string filePath)
        {
            StringBuilder fileContent = new StringBuilder();

            foreach (var col in dataTable.Columns)
            {
                fileContent.Append(col.ToString() + ",");
            }

            fileContent.Replace(",", System.Environment.NewLine, fileContent.Length - 1, 1);

            foreach (DataRow dr in dataTable.Rows)
            {
                foreach (var column in dr.ItemArray)
                {
                    fileContent.Append("\"" + column.ToString() + "\",");
                }

                fileContent.Replace(",", System.Environment.NewLine, fileContent.Length - 1, 1);
            }

            System.IO.File.WriteAllText(filePath, fileContent.ToString());
        }

        public static DataTable ConvertCsvToDataTable(string filePath)
        {
            //reading all the lines(rows) from the file.

            DataTable dtData = new DataTable();
            string[] rows = File.ReadAllLines(filePath);
            string[] rowValues = null;
            DataRow dr = dtData.NewRow();

            //Creating columns
            if (rows.Length > 0)
            {
                foreach (string columnName in rows[0].Split(','))
                    dtData.Columns.Add(columnName);
            }

            //Creating row for each line.(except the first line, which contain column names)
            for (int row = 1; row < rows.Length; row++)
            {
                rowValues = rows[row].Split(',');
                dr = dtData.NewRow();
                dr.ItemArray = rowValues;
                dtData.Rows.Add(dr);
            }

            return dtData;
        }
    }
}