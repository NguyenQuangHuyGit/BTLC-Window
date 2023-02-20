using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

//Họ tên: Nguyễn Quang Huy
//Lớp: 62TH2
//MSV: 2051063734

namespace btlWinform
{
    internal class connection
    {
        public SqlConnection conn = new SqlConnection("Data Source = LAPTOP-P1SE5R8K;"+
                                                      "Initial Catalog = QL_MayTinh;"+
                                                      "Integrated Security = True");
        public void myOpen() { conn.Open(); }
        public void myClose() { conn.Close(); }
        public DataTable createTable(string s)
        {
            SqlDataAdapter daSP = new SqlDataAdapter(s,conn);
            DataTable dtSP = new DataTable();
            daSP.Fill(dtSP);
            return dtSP;
        }
        public void AddProduct(string maSP, string nameSP, double price, string brand, int count, int sale)
        {
            string sql = "insert into SanPham values('"+maSP+"',N'"+nameSP+"',"+price+",'"+brand+"',"+count+",0,"+sale+")";
            SqlCommand cmd = new SqlCommand(sql,conn);
            cmd.ExecuteNonQuery();
        }
        public void DelProduct(string maSP, string nameSP, double price, string brand, int count, int sale)
        {
            string sql = "delete from SanPham where maSP='" + maSP + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
        public void EditProduct(string maSP, string nameSP, double price, string brand, int count, int sale)
        {
            string sql = "update SanPham set tenSP=N'"+nameSP+"',giaSP="+price+",hangSP='"+brand+"',soLuongCon="+count+",giamGia="+sale+"where maSP='"+maSP+"'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
        public void EditBill(string maSP,int count)
        {
            string sql = "update SanPham set soLuongCon = " + count + " where maSP='" + maSP + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
        public void EditBillSell(string maSP,int sell)
        {
            string sql = "update SanPham set slBan +="+sell+" where maSP='" + maSP + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
        public void AddBill(string maHD, string tenKH, string SDT, double total, DateTime date)
        {
            string sql = "insert into HoaDon values('"+maHD+"',N'"+tenKH+"','"+SDT+"',"+total+",'"+date.ToShortDateString()+"')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
        public void AddBillDetail(string maHD,string maSP,int soLuong)
        {
            string sql = "insert into ChiTietHD values('"+maHD+"','"+maSP+"',"+soLuong+")";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
    }
}
