using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Capstone.Models;
using System.Data.SqlClient;

namespace Capstone.DAO
{
    public class PreferencesSqlDAO : IPreferencesDAO
    {
        private readonly string connectionString;

        public PreferencesSqlDAO(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        public List<Preferences> GetPreferencesbyUser(int userId)
        {
            List<Preferences> allPreferencesByUser = new List<Preferences>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT user_preferences.preference_id, preference_type FROM preferences JOIN user_preferences ON preferences.preference_id = user_preferences.preference_id JOIN users ON user_preferences.user_id = users.user_id WHERE users.user_id = @user_id; ", conn);
                cmd.Parameters.AddWithValue("@user_id", userId);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Preferences preferences = new Preferences();
                    preferences = GetPreferencesFromReader(reader);
                    allPreferencesByUser.Add(preferences);
                }
            }

            return allPreferencesByUser;
        }
        /////////////////////////////
        private Preferences GetPreferencesFromReader(SqlDataReader reader)
        {
            Preferences p = new Preferences();
            Category c = new Category();

            p.PreferenceId = Convert.ToInt32(reader["preference_id"]);
            c.alias = Convert.ToString(reader["preference_type"]);
            c.title = null;
            p.PreferenceType = c;

            return p;
        }
    }
}
