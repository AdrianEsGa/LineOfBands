using LineOfBands.Common;
using LineOfBands.Database.Entities;
using System;
using System.Data.SqlClient;

namespace LineOfBands.Database.Repositories
{
    public static class MoldRepository
    {
        public static Mold GetByCode(int code)
        {

            const string strSql = "SELECT Id, Code, Reference FROM Molds WHERE Code=@Code";
            var mold = new Mold();

            try
            {
                using (var connection = SqlServer.OpenConnection())
                {
                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Parameters.AddWithValue("@Code", code);

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                mold.Id = Convert.ToInt32(reader["Id"]);
                                mold.Code = Convert.ToInt32(reader["Code"]);
                                mold.Reference = reader["Reference"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return mold;

        }


        internal static Mold GetById(int id)
        {
            const string strSql = "SELECT Id, Code, Reference FROM Molds WHERE Id = @Id";
            var mold = new Mold();

            try
            {
                using (var connection = SqlServer.OpenConnection())
                {
                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);

                        using (var reader = command.ExecuteReader())
                        {                         
                            while (reader.Read())
                            {
                                mold.Id = Convert.ToInt32(reader["Id"]);
                                mold.Code = Convert.ToInt32(reader["Code"]);
                                mold.Reference = reader["Reference"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return mold;
        }


        public static void SaveOrUpdate(Mold pallet)
        {

        }

        public static void Remove(Mold pallet)
        {

        }
    }
}
