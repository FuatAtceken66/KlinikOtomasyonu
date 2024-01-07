using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Data.Common;
using System.Diagnostics;

namespace KlinikOtomasyonu.DAL
{
    public class SQLLib
    {
        public static SqlConnection con;
        private static SqlDataAdapter da;
        private static SqlCommand com;
        public SQLLib() { 
            con = new SqlConnection("server=.\\KERIMLOCAL;database=SOHATS;User Id=sa;Password=sapass;TrustServerCertificate=True");
            da = new SqlDataAdapter();
            com = new SqlCommand();
        }
       

        public  DataTable SQLDataTable(string query)
        {
            con.Open();
            DataTable dt = new DataTable();
            com.Connection = con;
            com.CommandTimeout = 120;
            com.CommandText = query;
            da.SelectCommand = com;
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public  object SQLExecCommand(string query)
        {
            con.Open();
            object obj;
            com.Connection = con;
            com.CommandTimeout = 120;
            com.CommandText = query;
            obj = com.ExecuteScalar();
            con.Close();
            return obj;
        }
        public  string SQLSelectValue(string query)
        {
            string value = "";
            try
            {
                con.Open();
                com.Connection = con;
                com.CommandTimeout = 120;
                com.CommandText = query;
                DbDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    value = dr[0].ToString();
                }
                return value;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return "";
            }
            finally
            {
                con.Close();

            }

        }

        private static readonly IDictionary<Type, ICollection<PropertyInfo>> _Properties =
        new Dictionary<Type, ICollection<PropertyInfo>>();

        /// <summary>
        /// Converts a DataTable to a list with generic objects
        /// </summary>
        /// <typeparam name="T">Generic object</typeparam>
        /// <param name="table">DataTable</param>
        /// <returns>List with generic objects</returns>
        public  IEnumerable<T> DataTableToList<T>(DataTable table) where T : class, new()
        {
            try
            {
                var objType = typeof(T);
                ICollection<PropertyInfo> properties;

                lock (_Properties)
                {
                    if (!_Properties.TryGetValue(objType, out properties))
                    {
                        properties = objType.GetProperties().Where(property => property.CanWrite).ToList();
                        _Properties.Add(objType, properties);
                    }
                }

                var list = new List<T>(table.Rows.Count);

                foreach (var row in table.AsEnumerable())
                {
                    var obj = new T();

                    foreach (var prop in properties)
                    {
                        try
                        {
                            var propType = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;
                            var safeValue = row[prop.Name] == null ? null : Convert.ChangeType(row[prop.Name], propType);

                            prop.SetValue(obj, safeValue, null);
                        }
                        catch
                        {
                            continue;
                        }
                    }

                    list.Add(obj);
                }

                return list;
            }
            catch
            {
                return Enumerable.Empty<T>();
            }
        }
    }
}
