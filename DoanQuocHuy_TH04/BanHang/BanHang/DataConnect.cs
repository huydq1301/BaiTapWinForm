using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanHang
{
    class DataConnect
    {

        //Khai báo biến toàn cục, bạn phải thay đổi chuối kết nối phù hợp
        string strConnect = "Data Source=DESKTOP-HU50TNN\\SQLEXPRESS;" +
                "Initial Catalog=BanHang;Integrated Security=True";
        SqlConnection sqlConnect=null;
        //Phương thức mở kết nối
         void OpenConnect()
        {
            sqlConnect = new SqlConnection(strConnect);
            if (sqlConnect.State != ConnectionState.Open)
                sqlConnect.Open();
        }
        //Phương thức đóng kết nối
         void CloseConnect()
        {
            if (sqlConnect.State != ConnectionState.Closed)
            {
                sqlConnect.Close();
                sqlConnect.Dispose();
            }
        }
        //Phương thức thực thi câu lệnh Select trả về một DataTable
        public DataTable DataReader(string sqlSelect)
        {
            OpenConnect();
            DataSet DS = new DataSet();
            SqlDataAdapter sqlData = new SqlDataAdapter(sqlSelect, sqlConnect);
            sqlData.Fill(DS);
            return DS.Tables[0];
            CloseConnect();
            sqlData.Dispose();
        }
        //Phương thức thực hiện câu lệnh dạng insert,update,delete
        public void DataChange(string sqlSelect)
        {
            OpenConnect();
            SqlCommand sqlcommand = new SqlCommand(sqlSelect, sqlConnect);
            sqlcommand.ExecuteNonQuery();
            CloseConnect();
            sqlcommand.Dispose();
        }

    }
}
