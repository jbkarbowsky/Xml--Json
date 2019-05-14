using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace SolarW2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                XDocument xml = XDocument.Load("Input/input.xml");

                foreach (XElement element in xml.Descendants("field")) // removing other types than string/int
                {
                    element.Descendants("type").Where(x => !(x.Value.ToString().ToLower() == "string") || (x.Value.ToString().ToLower() == "int"))
                       .Remove();
                }


                foreach(XElement el in xml.Descendants("object"))//removing objects 
                {
                    if(el.Elements().Count() < 2)
                    {
                        el.ElementsAfterSelf().Remove();
                    }
                }



                foreach (XElement el in xml.Descendants()) // removing inproperly objects
                {
                    el.Descendants().Where(xel => !(xel.Name == "field" || xel.Name == "obj_name" || xel.Name == "name"
                        || xel.Name == "type" || xel.Name == "value" || xel.Name == "object"))
                        .Remove();
                }

                

                foreach (XElement element in xml.Descendants("field"))// Removing field, if field don't have name, type and value.
                {
                    if (element.Elements().Count() != 3)
                    {
                        element.RemoveNodes();
                    }
                }

                xml.Descendants().Where(x => string.IsNullOrEmpty(x.Value)).Remove();//removing empty objects


                XmlDocument xmldoc =  ConverterToXmlDocument.ToXmlDocument(xml); //conversion to from xDocument to xmlDocument


                string json = JsonConvert.SerializeXmlNode(xmldoc); // serialize to json

                try
                {
                    File.WriteAllText("Output/output.json", json); // saving results
                }
                catch
                {
                    Console.WriteLine("Something went wrong... check path to save files...");
                    Console.ReadKey();
                }

                


                Console.WriteLine("Done! :)\n output file is in Output directory...");
                Console.ReadKey();



                
            }
            catch(System.Xml.XmlException)
            {
                Console.WriteLine("Something went wrong... Try to add MAIN ROOT in XML file, or check corectness OR \n"+
                                  "check the correctness of elements in the document.An open tag should also be closed with the same tag in the way\n"+
                                   "\n\t<xx> </ xx > ");
                Console.WriteLine("\n\tPress any key to exit...");
                Console.ReadKey();
            }
            catch(System.IO.FileNotFoundException)
            {
                Console.WriteLine("File doesn't exist or path is not correct!\n Press any key to exit...");
                Console.ReadKey();
            }
           

        }
    }
}
