using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static CmgPrsrDropCal.PrsrDrop;

namespace CmgPrsrDropCal
{
    public class dal
    {

        public Indata ReadDataFromTextFile()
        {
            Indata mIndata = new Indata();
            string filePath = "D:\\Sandip\\Career\\Career\\CMG\\indata\\InData.txt";

            try
            {
                // Read the JSON content from the file
                string json = File.ReadAllText(filePath);

                // Deserialize the JSON content to the object

                if (json.Length > 0)
                {
                    mIndata = JsonConvert.DeserializeObject<Indata>(json);

                    // Use the deserialized object
                    // Console.WriteLine("Name: " + result.Name);
                    //Console.WriteLine("Value: " + result.Value);
                }
                else
                {
                    mIndata = null; 
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                mIndata = null;
            }

            return mIndata;

        }
        public bool WriteDataToTextFile(Outdata mOutdata) {

            string filePath = "D:\\Sandip\\Career\\Career\\CMG\\indata\\outData.txt";
            bool isWriteOk = true;

            try
            {


               // string contentToWrite = "Hello, this is some content to write to the file.";

                // Serialize the object to JSON
                string contentToWrite = JsonConvert.SerializeObject(mOutdata, Newtonsoft.Json.Formatting.Indented);



                // Check if the file exists
                if (File.Exists(filePath))
                {
                    // File exists, replace its content
                    File.WriteAllText(filePath, contentToWrite);
                    Console.WriteLine("File content replaced.");
                }
                else
                {
                    // File doesn't exist, create it and write content
                    File.WriteAllText(filePath, contentToWrite);
                    Console.WriteLine("File created and content written.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                isWriteOk = false;
            }


            return isWriteOk; 
        
        }


    }
}
