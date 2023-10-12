using System.IO.Compression;
using System.ComponentModel.Design;
using System.Security.Cryptography;
using System;
using Dapper;
using System.Data;
using System.Linq;
using System.Threading;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;


public static class BD
{
    private static string _connectionString = "Server=localhost;DataBase=BDSeries;Trusted_Connection=True;";

    public static Serie ObtenerSerie(int id){
        string sql = "SELECT * FROM Series WHERE IdSerie = @id";
        using (SqlConnection db = new SqlConnection(_connectionString)){
            return db.QueryFirstOrDefault<Serie>(sql, new {id});
        }
    }

    public static List<Serie> ObtenerSeries(){
        string sql = "SELECT * FROM Series";
        using (SqlConnection db = new SqlConnection(_connectionString)){
            return db.Query<Serie>(sql).ToList();
        }
    }

    public static List<Temporada> ObtenerTemporadas(int idSerie){
        string sql = "SELECT * FROM Temporadas WHERE IdSerie = @idSerie";
        using (SqlConnection db = new SqlConnection(_connectionString)){
            return db.Query<Temporada>(sql, new {idSerie}).ToList();
        }
    }

    public static List<Actor> ObtenerActores(int idSerie){
        string sql = "SELECT * FROM Actores WHERE IdSerie = @idSerie";
        using (SqlConnection db = new SqlConnection(_connectionString)){
            return db.Query<Actor>(sql, new {idSerie}).ToList();
        }
    }
}