﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Yempo_Console
{
    public class ConsumePersonById
    {
        public void GetPersonById(int id) //Get All Events Records  
        {
            using (WebClient client = new WebClient()) //WebClient  
            {
                client.Headers.Add("Content-Type:application/json"); //Content-Type  
                client.Headers.Add("Accept:application/json");
                var result = client.DownloadString("https://localhost:7208/api/Person/"+id); //URI  
                Console.WriteLine(Environment.NewLine + result);
            }
        }
    }
}
