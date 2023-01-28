using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace ozkan
{
    class cGuncel
    {
        cGenel gnl = new cGenel();

        #region Fields
        private int _Id;
        private int _PersonelId;
        private string _Name;
        private string _SurName;
        #endregion
        #region Properites
        public int Id { get => _Id; set => _Id = value; }
        public string Name { get => _Name; set => _Name = value; }
        public string SurName { get => _SurName; set => _SurName = value; }
        public int PersonelId { get => _PersonelId; set => _PersonelId = value; }
        #endregion

        public bool GTEkle(cGuncel data)
        {
            bool result = false;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into Guncel(PersonelId,Name,SurName) Values (@PersonelId,@Name,@SurName)", con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            cmd.Parameters.Add("@PersonelId", SqlDbType.Int).Value = data._PersonelId;
            cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = data._Name;
            cmd.Parameters.Add("@SurName", SqlDbType.NVarChar).Value = data._SurName;
            result = Convert.ToBoolean(cmd.ExecuteNonQuery());

            con.Dispose();
            con.Close();

            return result;
        }

        public bool Temizle()
        {
            bool result = false;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Truncate Table Guncel", con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            result = Convert.ToBoolean(cmd.ExecuteScalar());

            con.Dispose();
            con.Close();

            return result;
        }

        public void VeriGetir(cGuncel veri)
        {

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * from Guncel ", con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                veri._Id = Convert.ToInt32(dr["Id"]);
                veri._PersonelId = Convert.ToInt32(dr["PersonelId"]);
                veri._Name = dr["Name"].ToString();
                veri._SurName = dr["SurName"].ToString();
            }

            dr.Close();
            con.Dispose();
            con.Close();

        }


    }
}
