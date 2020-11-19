using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System.Data.Common;
//using Npgsql;
using UnityEngine.UI;

public class EnteringScript : MonoBehaviour
{
    //public Text textBoxLogin;

    //public Text textBoxPasswd;

    //private string enteredLogin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Login()
    {
        /*enteredLogin = textBoxLogin.text;
        string connectionString = "Serverlocalhost;Port=5433;UserId=postgres;Password=Wolfara1;Database=Player;"; //настройки подключения
        NpgsqlConnection connection = new NpgsqlConnection(connectionString); //Подключение
        connection.Open(); //Открытие порта для соединения
        string commandStr = $"select * from PlayerData where Login = {enteredLogin}";
        NpgsqlCommand command = new NpgsqlCommand(commandStr, connection); //отправка SQL запроса
        NpgsqlDataReader reader = command.ExecuteReader();
        if(reader.HasRows)
        {
            foreach(DbDataRecord record in reader)
            {
                Debug.Log(record["Login"]+" "+record["Password"]);
            }
        }
        connection.Close();*/
        
        
    }
}
