using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public static class SongDBQuery
    {
        private static List<Song> lstSongs;
        public static bool Save(Song s)
        {
            string con = "Data Source=UP954795\\MSSQLSER;Initial Catalog=Song;Integrated Security=True;Pooling=False";
            string sq = "insert into Song(Title,DateProduced,Edited) values (@title,@dateproduced,@edited)";

            try
            {
                using (SqlConnection n = new SqlConnection(con))
                {
                    n.Open();
                    bool iscorrect = false;

                    using (SqlCommand cmd = new SqlCommand(sq, n))
                    {
                        cmd.Parameters.Add("@title", SqlDbType.NChar).Value = s.SongName;
                        cmd.Parameters.Add("@dateproduced", SqlDbType.NChar).Value = s.DateProduced;
                        if(s.Edited.GetType().IsInstanceOfType(iscorrect))
                             cmd.Parameters.Add("@edited", SqlDbType.Int).Value = s.Edited ? 1:0;
                        else
                            cmd.Parameters.Add("@edited", SqlDbType.Int).Value = s.Edited;
                        cmd.ExecuteNonQuery();
                    }
                    n.Close();

                }
                return true;
            }
            catch
            {
                return false;
            }
             
            
        
            
           
                
            
        }
        public static List<Song> GetSongs()
        {
            lstSongs = new List<Song>();
            SqlConnection sql = new SqlConnection("Data Source=up954795\\mssqlser;Initial Catalog=Song;Integrated Security=True;Pooling=False");
            sql.Open();

            SqlCommand cm = new SqlCommand("select * from Song", sql);

            try
            {
                SqlDataReader read;
                read = cm.ExecuteReader();
                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        lstSongs.Add(new Song()
                        {
                            SongName = read["Title"].ToString(),
                            DateProduced = read["DateProduced"].ToString(),
                            Edited = Convert.ToBoolean(int.Parse(read["Edited"].ToString()))
                        });

                    }

                    return lstSongs;
                }
                else
                {
                    return lstSongs;
                }

            }
            catch
            {
                return null;

            }
           
        }
    }
}
