using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using Mono.Data.Sqlite;
using Unity.VisualScripting;



public class BaseDeDatos : MonoBehaviour
{
    public static BaseDeDatos Instance;
    private IDataReader reader;

    private void Awake()
    {
        if(Instance != null && Instance != this)
        {
           Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    IDbConnection conn;

    string dbName = "entifarm.db";

    public List<plant> plants = new List<plant>();

    // Start is called before the first frame update
    void Start()
    {
        conn = new SqliteConnection(string.Format("URI=file:{0}", dbName));
        conn.Open();

        plants = GetPlants();

        PrintDebug();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public List<plant> GetPlants()
    {
        IDbCommand cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT * FROM plants";
        IDataReader reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            plant plant = new plant();

            plant.id_plant = reader.GetInt32(0);
            plant.plantname = reader.GetString(1);
            plant.time = reader.GetFloat(2);
            plant.quantity = reader.GetInt32(3);
            plant.sell = reader.GetFloat(4);
            plant.buy = reader.GetFloat(5);
            //plant.season = reader.GetInt32(6);

            plants.Add(plant);
        }
        return plants;
    }


    public void PrintDebug ()
    {
        if (plants.Count == 0)
        {
            Debug.Log("ERROR: No plants");
            return;
        }

        for (int i = 0; i < plants.Count; i++)
        {
            Debug.Log(plants[i].id_plant);
            Debug.Log(plants[i].plantname);
            Debug.Log(plants[i].time);
            Debug.Log(plants[i].quantity);
            Debug.Log(plants[i].sell);
            Debug.Log(plants[i].buy);
            Debug.Log(plants[i].season);
        }
    }

    public void NewUser(string username, string password)
    {
        IDbCommand cmd = conn.CreateCommand();
        cmd.CommandText = "INSERT Into users(user, password) Values (\"" + username + "\", \"" + password + "\");";
        reader = cmd.ExecuteReader();
        reader.Close();


    }

    public List<users> userList = new List<users>();
    public List<users> GetUsers()
    {
        IDbCommand cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT * from users;";
        reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            users Users = new users();
            Users.id_user = reader.GetInt32(0);
            Users.name = reader.GetString(1);
            Users.password = reader.GetString(2);
            Users.password.ToString();
            Debug.Log(Users.password);

            userList.Add(Users);
        }



        return userList;
    }


}

public class users
{
    public int id_user = 0;
    public string name = "";
    public string password = "";
}

