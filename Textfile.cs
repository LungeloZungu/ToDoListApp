﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO; 

namespace ToDoListApp
{
    class Textfile
    {

        public static  void WriteToFile()
        {

            try
            {
                using (StreamWriter write = new StreamWriter("List.txt"))
                {
                    foreach (string line in ToDoListList.Task)
                    {
                        write.WriteLine(line);

                       
                        write.Close();
                    }
                }       
                
            }
               catch  (Exception ex)
                {
                Console.WriteLine(ex.Message);
                }

        }
    }
}
