using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ExampleSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Buoc 1: Khai bao chuoi ket noi
            string strConnect = "Data Source=DESKTOP-HU50TNN\\SQLEXPRESS;" +
                "Initial Catalog=QLBH;Integrated Security=True";
            //b2: Da ket noi
            SqlConnection sqlConnect=new SqlConnection(strConnect);
            if(sqlConnect.State!=ConnectionState.Open)
            {
                sqlConnect.Open();
            }
            //b3: Khai bao sql
            string sqlInsert= "insert into tblChatLieu values('"+txtMaCL.Text+"',N'"+txtTenCL.Text+"')";
            //b4:Thuc hien lenh sql bang sqlCommand
            SqlCommand sqlcommand = new SqlCommand(sqlInsert);
            sqlcommand.Connection = sqlConnect;
            sqlcommand.ExecuteNonQuery();//thuc thi lenh sql
            //b5:dong ket noi huy doi tuong
            if(sqlConnect.State!=ConnectionState.Closed)
            {
                sqlConnect.Close();
                sqlConnect.Dispose();
                sqlcommand.Dispose();
            }
           

        }
    }
}
