using System;
using System.Linq;
using System.Xml;

namespace Interpreter
{
    public class Context
    {
        private readonly string _fileName;

        public Context(string fileName)
        {
            _fileName = fileName;
        }

        public IExpression BuildExpression()
        {
            var xmlDocument = new XmlDocument();
            xmlDocument.Load(_fileName);
            return BuildExpression(xmlDocument.DocumentElement);
        }

        public IExpression BuildExpression(XmlElement element)
        {
            if (element.Name == "Constant")
            {
                return new Constant(int.Parse(element.GetAttribute("Value")));
            }
            else
            {
                var expressions =
                    (from object childNode in element.ChildNodes
                     where childNode is XmlElement
                     select BuildExpression((XmlElement)childNode)).ToList();
                return
                    new CalcExpression(
                        (CalcMethod)Enum.Parse(typeof(CalcMethod), element.Name, true),
                        expressions);
            }
        }
    }
}
