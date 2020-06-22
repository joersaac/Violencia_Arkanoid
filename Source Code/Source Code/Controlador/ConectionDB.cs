using System.Data;
using Npgsql;

namespace Source_Code
{
    public static class ConectionDB
    {
        //Insertar los datos necesarios para la conexión con la base de datos
        private static string sConnection =
            "Server=127.0.0.1;Port=5432;User Id=postgres;Password=0df3f9c8;Database=Proyecto";


        //Función cuando se ejecuta una Consulta
        public static DataTable ExecuteQuery(string query)
        {
            NpgsqlConnection connection = new NpgsqlConnection(sConnection);
            DataSet ds = new DataSet();

            connection.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
            da.Fill(ds);

            connection.Close();

            return ds.Tables[0];
        }

        //Función cuando se ejecuta una acción
        public static void ExecuteNonQuery(string act)
        {
            NpgsqlConnection connection = new NpgsqlConnection(sConnection);

            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand(act, connection);

            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}