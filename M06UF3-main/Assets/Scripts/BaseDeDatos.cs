using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using Mono.Data.Sqlite;
using Unity.VisualScripting;
class Plant
{
    public int id_plant = 0;
    public string name = "";
    public float time = 0.0f;
    public int quantity = 0;
    public float sell = 0.00f;
    public float buy = 0.00f;
    public int season = 0;
}
public class BaseDeDatos : MonoBehaviour
{
    // ACCEDER BASE DE DATOS
    IDbConnection connection;
    private string dbName = "entifarm.db";
    private string query;
    private IDbCommand command;
    private IDataReader reader;
    private void Start()
    {
        // ACCEDER BASE DE DATOS
        connection = new SqliteConnection(string.Format("URI=file:{0}", dbName));
        connection.Open();
    }
    private void Update()
    {
        GetPlants();
    }

    ArrayList GetPlants()
    {
        ArrayList plants = new ArrayList();
        query = "SELECT * FROM plants;";
        command = connection.CreateCommand();
        command.CommandText = query;
        reader = command.ExecuteReader();
        if (reader == null)
        {
            return plants;
        }

        while (reader.Read())
        {
            Plant p = new Plant();
            p.id_plant = reader.GetInt32(0); // ID
            p.name = reader.GetString(1); // NAME
            p.time = reader.GetFloat(2); // TIME
            p.quantity = reader.GetInt32(3); // QUANTITY
            p.sell = reader.GetFloat(4); // SELL
            p.buy = reader.GetFloat(5); // BUY
                                        //p.season = reader.GetInt32(6); // SEASON
            plants.Add(p);
        }
        return plants;
    }
}