using System;
using System.Collections;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using UnityEngine;

public class Write : MonoBehaviour
{
    private string connectionString;
    private MySqlConnection MS_Connection;
    private MySqlCommand MS_Command;
    private string query;
    private string query1;
    private string query2;
    
    
    public void SendInfo(int id,int step,string time,string exitTime)
    {
        Connection();
        query = "insert into baseproduct(ID, Step, EnterTime, ExitTime) values ('" + id + "','" + step + "','" + time + "','" + exitTime + "');";
        MS_Command = new MySqlCommand(query, MS_Connection);
        MS_Command.ExecuteNonQuery();
        MS_Connection.Close();
    }
    public void SendMachineInfo(int id,int pieceCount,string material)
    {
        Connection();
        query1 = "insert into basemachine(ID, PieceCount,Material) values ('" + id + "','" + pieceCount + "','" + material + "');";
        MS_Command = new MySqlCommand(query1, MS_Connection);
        MS_Command.ExecuteNonQuery();
        MS_Connection.Close();
    }
    public void SendPieceInfo(int id,int pieceCount)
    {
        Connection();
        query2 = "insert into project(DataId, FinishedPieceCount) values ('" + id + "','" + pieceCount + "');";
        MS_Command = new MySqlCommand(query2, MS_Connection);
        MS_Command.ExecuteNonQuery();
        MS_Connection.Close();
    }

    public void Connection()
    {
        //connectionString = "";
        MS_Connection = new MySqlConnection(connectionString);
        MS_Connection.Open();
    }
}
