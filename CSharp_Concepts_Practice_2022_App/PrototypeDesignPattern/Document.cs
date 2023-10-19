using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern
{
    public class Document : ICloneable
    {
        public string FileName { get; set; }
        public string Title { get; set; }

        public string BodyText { get; set; }

        public Document Child { get; set; }

        public object Clone()
        {
            return GetCopy();
        }

        public Document GetCopy()
        {
            Document doc =  new Document();
            doc.Child = new Document();
            doc.Child.Title = Child.Title;
            doc.Child.FileName = Child.FileName;
            return doc;
            
        }

    }
}
