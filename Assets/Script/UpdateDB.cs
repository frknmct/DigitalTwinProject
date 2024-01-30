using System.Collections;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Unity.VisualScripting;
using UnityEngine;

public class UpdateDB : MonoBehaviour
{
    private string connectionString;
    private MySqlConnection MS_Connection;
    private MySqlCommand MS_Command;
    private string query;
    private string query1;
    
    public void UpdateInfo(int updatedId, int updatedStep)
    {
        Connection();
        query = "UPDATE baseproduct SET ID '"+ updatedId+"',Step '"+ updatedStep +"';";
        MS_Command = new MySqlCommand(query, MS_Connection);
        //MS_Command.ExecuteNonQuery();
        MS_Connection.Close();
    }
    
    public void UpdateMachineInfo(int machineId, int updatedPieceCount)
    {
        Debug.Log("update geliyooo");
        Connection();
        //uery1 = "UPDATE basemachine SET  PieceCount '"+ updatedPieceCount + "'where ID = "+ machineId + " ';";
        //query1 = "UPDATE `basemachine` SET `PieceCount`='"+updatedPieceCount+"' WHERE `ID`='"+machineId+"'";
        query1 = "UPDATE `basemachine` SET `PieceCount`='4545' WHERE `ID`='1046'";
        Debug.Log(query1);
        
        MS_Command = new MySqlCommand(query1, MS_Connection);
        //MS_Command.ExecuteNonQuery();
        MS_Connection.Close();
    }
    public void Connection()
    {
        connectionString = "Server = localhost;port=3306; Database = otomasyonsistem1;Uid=root;SslMode=none ";
        MS_Connection = new MySqlConnection(connectionString);
        MS_Connection.Open();
    }
    
    
    
}
