﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
using System.Diagnostics;

namespace aspnet_core_dotnet_core.Pages
{
// Second change
    public class AboutModel : PageModel
    {
        public string sqlCS;

        public AboutModel(AppConfig appconfig)
        {
            sqlCS = appconfig.sqlCS;
        }

        public void OnGet()
        {
        
        // First change
            try
            {
                using (SqlConnection sqlconnection = new SqlConnection(sqlCS))
                {
                    sqlconnection.Open();

                    var sql = "INSERT INTO accessLogs (PageName) VALUES ('About'); ";
                    var command = new SqlCommand(sql, sqlconnection);
                    int rowsAffected = command.ExecuteNonQuery();

                    sqlconnection.Close();
                }
            }
            catch (SqlException e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }
    }
}
