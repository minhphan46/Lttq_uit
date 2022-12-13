using Bai05.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai05.Provider
{
    internal class DataProvider
    {
        public DataProvider() { }
        private static string connectionString = @"Data Source=DESKTOP-A8KH375;Initial Catalog=Bai05_TH4;Integrated Security=True";
        private SqlConnection sqlConnection = new SqlConnection(connectionString);
        private static DataProvider instance = new DataProvider();

        private List<Khoa> _listKhoa = new List<Khoa>();
        private List<SinhVien> _listsinhVien = new List<SinhVien>();

        public static DataProvider Instance
        {
            get { return instance; }
            set { instance = value; }
        }
        public List<Khoa> ListKhoa
        {
            get { return _listKhoa; }
            set { _listKhoa = value; }
        }
        public List<SinhVien> ListsinhVien
        {
            get { return _listsinhVien; }
            set { _listsinhVien = value; }
        }

        public void FetchKhoas()
        {
            if (sqlConnection.State != ConnectionState.Open)
                sqlConnection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * From NGANHHOC";
            command.Connection = sqlConnection;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ListKhoa.Add(new Khoa(reader.GetString(0), reader.GetString(1)));
            }
            command.Dispose();
            reader.Close();
        }
        public void FetchSinhViens()
        {
            if (sqlConnection.State != ConnectionState.Open)
                sqlConnection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * From SINHVIEN";
            command.Connection = sqlConnection;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                long mssv = reader.GetInt32(0);
                string hoTen = reader.GetString(1);
                string maNganh = reader.GetString(2);
                double diemTB = reader.GetDouble(3);
                Khoa KhoaFind = ListKhoa.Find(khoa => khoa.MaNganh == maNganh);
                ListsinhVien.Add(new SinhVien(mssv, hoTen, KhoaFind, diemTB));
            }
            command.Dispose();
            reader.Close();
        }
        public void addSinhVien(SinhVien sinhVien)
        {
            ListsinhVien.Add(sinhVien);
            if (sqlConnection.State != ConnectionState.Open)
                sqlConnection.Open();
            string strCmd = $"INSERT INTO SINHVIEN values ({sinhVien.MSSV}, N'{sinhVien.HoTen}','{sinhVien.Khoa.MaNganh}', @diemTb);";
            SqlCommand cmd = new SqlCommand(strCmd, sqlConnection);
            cmd.Parameters.Add("@diemTb", SqlDbType.Float).Value = Convert.ToDouble(sinhVien.DiemTB);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }

    }
}
