using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai09
{
    internal class GetData
    {
        private static string connectionString = @"Data Source=DESKTOP-A8KH375;Initial Catalog=Bai09;Integrated Security=True";
        private GetData() { }
        private static GetData instance = new GetData();

        public List<SinhVien> sinhViens = new List<SinhVien>();
        public List<MonHoc> monHocs = new List<MonHoc>();
        public List<NganhHoc> nganhHocs = new List<NganhHoc>();

        public static GetData Instance
        {
            get { return instance; }
            set { instance = value; }
        }

        private SqlConnection sqlConnection = new SqlConnection(connectionString);

        public void GetNganhHocs()
        {
            if (sqlConnection.State != ConnectionState.Open)
                sqlConnection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM NGANHHOC";
            command.Connection = sqlConnection;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                nganhHocs.Add(new NganhHoc(reader.GetString(0), reader.GetString(1)));
            }
            reader.Close();
        }

        public void GetMonHocs()
        {
            if (sqlConnection.State != ConnectionState.Open)
                sqlConnection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT  * FROM MONHOC";
            command.Connection = sqlConnection;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                monHocs.Add(new MonHoc(reader.GetString(0), reader.GetString(1)));
            }
            reader.Close();
        }
        public void GetSinhViens()
        {
            if (sqlConnection.State != ConnectionState.Open)
                sqlConnection.Open();
            string command = "SELECT * FROM SINHVIEN";

            using (SqlCommand cmd = new SqlCommand(command, sqlConnection))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader != null)
                    {
                        while (reader.Read())
                        {
                            long MSSV = reader.GetInt32(0);
                            string maNganh = reader.GetString(1);
                            string hoTen = reader.GetString(2);
                            string gioiTinh = reader.GetString(3);

                            NganhHoc nganhHoc = nganhHocs.Find(nh => nh.maNganh == maNganh);
                            sinhViens.Add(new SinhVien(MSSV, hoTen, gioiTinh[0], nganhHoc));
                        }
                    }
                }
            }
            sinhViens.ForEach(sv =>
            {
                string mhCmd = $"Select MONHOC.MaMH, TenMH From MONHOC, DANGKYMH\r\nWhere DANGKYMH.MaSV ='{sv.maSoSinhVien}' AND MONHOC.MaMH = DANGKYMH.MaMH";
                using (SqlCommand cmd = new SqlCommand(mhCmd, sqlConnection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            while (reader.Read())
                            {
                                sv.listMonHoc.Add(new MonHoc(reader.GetString(0), reader.GetString(1)));
                            }
                        }
                    }
                }
            });
        }
        public void addSinhVien(SinhVien sinhVien)
        {
            sinhViens.Add(sinhVien);
            if (sqlConnection.State != ConnectionState.Open)
                sqlConnection.Open();
            String strCmd = $"INSERT INTO SINHVIEN values ({sinhVien.maSoSinhVien},'{sinhVien.nganhHoc.maNganh}', N'{sinhVien.hoTen}', '{sinhVien.gioiTinh}');";
            SqlCommand cmd = new SqlCommand(strCmd, sqlConnection);
            cmd.ExecuteNonQuery();
            sinhVien.listMonHoc.ForEach(mh =>
            {
                String addMhCmd = $"INSERT INTO DANGKYMH values ({sinhVien.maSoSinhVien}, '{mh.maMon}');";
                SqlCommand mhCmd = new SqlCommand(addMhCmd, sqlConnection);
                mhCmd.ExecuteNonQuery();
            });
        }

        public void UpdateSinhVien(SinhVien sinhVien)
        {
            int find = sinhViens.FindIndex(val => val.maSoSinhVien == sinhVien.maSoSinhVien);
            sinhViens[find] = sinhVien;
            String svCmd =
                "UPDATE SINHVIEN " +
                $"SET HoTen = N'{sinhVien.hoTen}', " +
                $"MaNganh = '{sinhVien.nganhHoc.maNganh}', " +
                $"GioiTinh = '{sinhVien.gioiTinh}' " +
                $"WHERE MaSV = {sinhVien.maSoSinhVien}";
            SqlCommand cmd = new SqlCommand(svCmd, sqlConnection);
            cmd.ExecuteNonQuery();
            String delOldMh = "Delete from DANGKYMH " +
                              $"Where MaSV = {sinhVien.maSoSinhVien}";
            cmd = new SqlCommand(delOldMh, sqlConnection);
            cmd.ExecuteNonQuery();
            sinhVien.listMonHoc.ForEach(mh =>
            {
                String addMhCmd = $"INSERT INTO DANGKYMH values ({sinhVien.maSoSinhVien}, '{mh.maMon}');";
                cmd = new SqlCommand(addMhCmd, sqlConnection);
                cmd.ExecuteNonQuery();
            });
            cmd.Dispose();
        }
        public void DeleteSinhVien(SinhVien sinhVien)
        {
            sinhViens.Remove(sinhVien);
            if (sqlConnection.State != ConnectionState.Open)
                sqlConnection.Open();
            String strCmd = $"Delete from DANGKYMH " +
                            $"Where MaSV = {sinhVien.maSoSinhVien}; " +
                            $"Delete from SINHVIEN " +
                            $"Where MaSV = {sinhVien.maSoSinhVien};";
            SqlCommand cmd = new SqlCommand(strCmd, sqlConnection);
            cmd.ExecuteNonQuery();
        }
    }
}
