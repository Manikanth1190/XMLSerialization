using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace XMLSerializationDoubleSchema
{
    class Program
    {
        static void Main(string[] args)
        {
            Article obj = new Article() { AuthorName = "Mani", OrgId = 98, Text = "sdfsdfd", Title = "New Article" };

            obj.AuthorNamechoice = Article.choices.AuthorFirstname;

            System.Xml.Serialization.XmlSerializer s = new System.Xml.Serialization.XmlSerializer(typeof(Article));
            StringBuilder sb = new StringBuilder();
            
            XmlWriter xw = XmlWriter.Create(sb);

            s.Serialize(xw, obj);
            
            Console.Write(sb.ToString());
            Console.Read();
        }
    }
}
