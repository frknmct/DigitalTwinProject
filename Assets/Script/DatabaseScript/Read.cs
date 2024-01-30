using System;
using System.Collections;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Read : MonoBehaviour
{
    private string connectionString;
    private string query;
    private MySqlConnection MS_Connection;
    private MySqlCommand MS_Command;
    private MySqlDataReader MS_Reader;
    public TextMeshProUGUI textCanvas1;
    
    public void viewInfo()
    {
        query = "SELECT * FROM baseproduct";
        
        //connectionString = "";

        MS_Connection = new MySqlConnection(connectionString);
        MS_Connection.Open();

        MS_Command = new MySqlCommand(query,MS_Connection);

        MS_Reader = MS_Command.ExecuteReader();
        while (MS_Reader.Read())
        {
            textCanvas1.text = " " + MS_Reader[0] + " " + MS_Reader[1];
        }
        MS_Reader.Close();

    }
    
    
}
