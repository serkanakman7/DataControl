using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace ozkan
{
    public class cTablo
    {
        cGenel gnl = new cGenel();
        public List<cPersonelBilgileri> PublicTable()
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * From PersonelBilgileri ", con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

           // cPersonelBilgileri personelBilgileri = new cPersonelBilgileri();

            SqlDataReader dr = cmd.ExecuteReader();

            List<cPersonelBilgileri> pb = new List<cPersonelBilgileri>();

            while (dr.Read())
            {

                cPersonelBilgileri personelBilgileri = new cPersonelBilgileri();
                personelBilgileri.Id = Convert.ToInt32(dr["Id"]);
                personelBilgileri.Name = dr["Name"].ToString();
                personelBilgileri.SurName = Convert.ToString(dr["SurName"]);

                pb.Add(personelBilgileri);
            }

            dr.Close();
            con.Dispose();
            con.Close();

            return pb;

        }

        public bool Add(cPersonelBilgileri tablo)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into PersonelBilgileri(Name,SurName) Values (@Name,@SurName) ", con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = tablo.Name ;
            cmd.Parameters.Add("@SurName",SqlDbType.NVarChar).Value = tablo.SurName;

            result = Convert.ToBoolean(cmd.ExecuteNonQuery());

            con.Dispose();
            con.Close();

            return result;
        }

        public bool Update(cPersonelBilgileri tablo,int Id)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update PersonelBilgileri Set Name=@Name ,SurName=@SurName where Id=@Id", con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = tablo.Name;
            cmd.Parameters.Add("@SurName", SqlDbType.NVarChar).Value = tablo.SurName;

            result = Convert.ToBoolean(cmd.ExecuteNonQuery());

            con.Dispose();
            con.Close();

            return result;
        }
    }
}
