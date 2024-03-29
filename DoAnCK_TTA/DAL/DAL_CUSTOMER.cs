﻿using DoAnCK_TTA.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCK_TTA.DAL
{
    public class DAL_CUSTOMER : DB_Connect
    {
        public int ThemKhachHang(DTO_CUSTOMER kv)
        {
            int active;
            if (kv.Active)
                active = 1;
            else
                active = 0;

            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT into  CUSTOMER   VALUES ( '" + kv.Customer_ID + "' ,  '" + kv.OrderID + "' ,  N'" + kv.CustomerName + "' ,  N'" + kv.Customer_Type_ID + "' ,  N'" + kv.Customer_Group_ID + "' ,  N'" + kv.CustomerAddress + "' ,  '" + kv.Birthday + "' ,  '" + kv.Barcode + "' ,  '" + kv.Tax + "',  '" + kv.Tel + "',  '" + kv.Fax + "' ,  '" + kv.Email + "',  '" + kv.Mobile + "' ,  '" + kv.Website + "',  '" + kv.Contact + "',  '" + kv.Position + "',  '" + kv.NickYM + "',  '" + kv.NickSky + "' ,  '" + kv.Area + "',  '" + kv.District + "' ,  '" + kv.Contry + "' ,  '" + kv.City + "',  '" + kv.BankAccount + "' ,  '" + kv.BankName + "' , 0 ,  0 ,  '" + kv.IsDebt + "' ,  '" + kv.IsDebtDetail + "',  '" + kv.IsProvider + "' ,  '" + kv.Description + "' ,  " + active + ")";
            try
            {
                OpenConnection();
                cmd.ExecuteNonQuery();
                CloseConnection();
                return 1;
            }
            catch
            {
                return 0;
            }

        }
        public int XoaKhachHang(string ID)
        {

            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete CUSTOMER  where Customer_ID= N'" + ID + "'";
            try
            {
                OpenConnection();
                cmd.ExecuteNonQuery();
                CloseConnection();
                return 1;
            }
            catch
            {
                return 0;
            }

        }
        public int CapNhatKhachHang(DTO_CUSTOMER kv)
        {
            int active;
            if (kv.Active)
                active = 1;
            else
                active = 0;

            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete CUSTOMER  where Customer_ID= N'" + kv.Customer_ID + "'   INSERT into  CUSTOMER   VALUES ( '" + kv.Customer_ID + "' ,  '" + kv.OrderID + "' ,  N'" + kv.CustomerName + "' ,  N'" + kv.Customer_Type_ID + "' ,  N'" + kv.Customer_Group_ID + "' ,  N'" + kv.CustomerAddress + "' ,  '" + kv.Birthday + "' ,  '" + kv.Barcode + "' ,  '" + kv.Tax + "',  '" + kv.Tel + "',  '" + kv.Fax + "' ,  '" + kv.Email + "',  '" + kv.Mobile + "' ,  '" + kv.Website + "',  '" + kv.Contact + "',  '" + kv.Position + "',  '" + kv.NickYM + "',  '" + kv.NickSky + "' ,  '" + kv.Area + "',  '" + kv.District + "' ,  '" + kv.Contry + "' ,  '" + kv.City + "',  '" + kv.BankAccount + "' ,  '" + kv.BankName + "' , 0 ,  0 ,  '" + kv.IsDebt + "' ,  '" + kv.IsDebtDetail + "',  '" + kv.IsProvider + "' ,  '" + kv.Description + "' ,  " + active + ")"; 
            try
            {
                OpenConnection();
                cmd.ExecuteNonQuery();
                CloseConnection();
                return 1;
            }
            catch
            {
                return 0;
            }

        }
        public DataTable LayDanhSachKhachHang()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT c.*,g.Customer_Group_Name FROM CUSTOMER c left join CUSTOMER_GROUP g on c.Customer_Group_ID=g.Customer_Group_ID ";
            try
            {
                OpenConnection();
                da.SelectCommand = cmd;
                da.Fill(dt);
                CloseConnection();
                return dt;
            }
            catch
            {
                return dt;
            }
        }
        public DataTable LayThongTinKhachHang(string id)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM CUSTOMER where Customer_ID = '" + id + "' ";
            try
            {
                OpenConnection();
                da.SelectCommand = cmd;
                da.Fill(dt);
                CloseConnection();
                return dt;
            }
            catch
            {
                return dt;
            }
        }
    }
}
