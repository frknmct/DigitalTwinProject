using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using MySql.Data.MySqlClient;

public class NewUpdateDB : MonoBehaviour
{
    //private string connectionString = "Server = localhost;port=3306; Database = otomasyonsistem1;Uid=root;SslMode=none";
    private MySqlConnection connection;

    private void Start()
    {
        ConnectToDatabase();
    }

    private void ConnectToDatabase()
    {
        connection = new MySqlConnection(connectionString);

        try
        {
            connection.Open();
            Debug.Log("Connected to database!");
        }
        catch (MySqlException e)
        {
            Debug.LogError("Error connecting to database: " + e.Message);
        }
    }

    private void OnDestroy()
    {
        if (connection != null && connection.State == ConnectionState.Open)
        {
            connection.Close();
            Debug.Log("Disconnected from database!");
        }
    }

    public void UpdateData(int id, int newData)
    {
        string query = "UPDATE basemachine SET PieceCount = @newData WHERE id = @id";

        using (MySqlCommand cmd = new MySqlCommand(query, connection))
        {
            cmd.Parameters.AddWithValue("@newData", newData);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                int rowsAffected = cmd.ExecuteNonQuery();
                Debug.Log("Rows affected: " + rowsAffected);
            }
            catch (MySqlException e)
            {
                Debug.LogError("Error updating data: " + e.Message);
            }
        }
    }
    
    
}
