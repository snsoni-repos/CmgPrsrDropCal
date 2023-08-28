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

        public Indata ReadDataFromTextFile(string filePath)
        {
            Indata mIndata = new Indata();
           
            try
            {
                //SS:---- Read the JSON content from the file
                string json = File.ReadAllText(filePath);

                //SS:----- Deserialize the JSON content to the object

                if (json.Length > 0)
                {
                    mIndata = JsonConvert.DeserializeObject<Indata>(json);

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
        public bool WriteDataToTextFile(string filePath,Outdata mOutdata) {

            
            bool isWriteOk = true;

            try
            {


                //SS:------ Serialize the object to JSON
                string contentToWrite = JsonConvert.SerializeObject(mOutdata, Newtonsoft.Json.Formatting.Indented);



                //SS:-------- Check if the file exists
                if (File.Exists(filePath))
                {
                    //SS:------ File exists, replace its content
                    File.WriteAllText(filePath, contentToWrite);
                    Console.WriteLine("File content replaced.");
                }
                else
                {
                    //SS:-- File doesn't exist, create it and write content
                    File.WriteAllText(filePath, contentToWrite);
                    Console.WriteLine("File created and content written.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                isWriteOk = false;
                mOutdata.ErrorMessage += ex.Message.ToString();
            }


            return isWriteOk; 
        
        }


    }
}
