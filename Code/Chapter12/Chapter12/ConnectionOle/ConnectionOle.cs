﻿using System;
using System.Data;
using System.Data.OleDb;

namespace Chapter12
{
    class ConnectionOleDb
    {
        static void Main()
        {
            // Create connection
            OleDbConnection conn = new OleDbConnection(@"
            provider = sqloledb;
            data source = .\sqlexpress;
            integrated security = sspi;
         ");

            try
            {
                // Open connection
                conn.Open();
                Console.WriteLine("Connection opened.");

                // Display connection properties
                Console.WriteLine("Connection Properties:");
                Console.WriteLine(
                   "\tConnection String: {0}",
                   conn.ConnectionString);
                Console.WriteLine(
                   "\tDatabase: {0}",
                   conn.Database);
                Console.WriteLine(
                   "\tDataSource: {0}",
                   conn.DataSource);
                Console.WriteLine(
                   "\tServerVersion: {0}",
                   conn.ServerVersion);
                Console.WriteLine(
                   "\tState: {0}",
                   conn.State);
            }
            catch (OleDbException e)
            {
                // Display error
                Console.WriteLine("Error: " + e);
            }
            finally
            {
                // Close connection
                conn.Close();
                Console.WriteLine("Connection closed.");
            } Console.ReadLine();
        }
    }
}

