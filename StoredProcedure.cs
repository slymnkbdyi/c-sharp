
using System;
   using System.Data;
   using Npgsql; 
 
   class Sample
   {
     static void Main(string[] args)
     {
         // Connect to a PostgreSQL database
         NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres; " + 
             "Password=1905;Database=Lab3;");
         conn.Open();
 
         // Start a transaction as it is required to work with result sets (cursors) in PostgreSQL
         NpgsqlTransaction tran = conn.BeginTransaction();
 
         // Define a command to call add_ogrenci() procedure
         NpgsqlCommand command1 = new NpgsqlCommand("add_ogrenci(9060256,Fatih,Taştemur,01-01-1991,Ankara,50693671313 )", conn);
         command1.CommandType = CommandType.StoredProcedure;
         
          NpgsqlCommand command2 = new NpgsqlCommand("count_ogrenci", conn);
         command2.CommandType = CommandType.StoredProcedure;
 
 
         // Execute the procedure and obtain a result set
         NpgsqlDataReader dr1 = command1.ExecuteReader();
         NpgsqlDataReader dr2 = command2.ExecuteReader();
         
         // Output 
         while (dr1.Read())
            Console.WriteLine("Adding records to a successful");
         
         while (dr2.Read())
             return sayi;
 
         tran.Commit();  
         conn.Close();   
       }
     }

