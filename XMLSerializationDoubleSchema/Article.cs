using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace XMLSerializationDoubleSchema
{
    [XmlRoot("ArticleRotElement")]
    public class Article
    {
        
        [XmlElement()]
        public string Title {
            get;set;
        }
        public enum choices { Author=0, AuthorFirstname = 1 }

        [XmlChoiceIdentifier("choice")]
        [XmlElement("Author")]
        [XmlElement("AuthorFirstname")]
        public string AuthorName { get; set; }

        public choices AuthorNamechoice { get; set; }

        public string Text { get; set; }
        public int OrgId { get; set; }
    }
}
