 /*
Thread myThread = new Thread(new ThreadStart(WriteToFileThread));
myThread.Start();
Console.WriteLine("Program end reached..");
*/
 private static void WriteToFileThread()
        {
            try
            {
                try
                {
                    File.Create("TestThreadFile.TXT").Close();
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }

                for (int i = 0; i < 10000; i++)
                {
                    StringBuilder sb = new StringBuilder();
                    string content = sb.Append(i.ToString()).Append(Environment.NewLine).ToString();
                    
                    File.AppendAllText("TestThreadFile.TXT", content);


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
