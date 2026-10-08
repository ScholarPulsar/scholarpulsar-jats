using ScholarPulsar.Jats.Base;
using ScholarPulsar.Jats.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.Core
{
    public static class JATSHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="obj"></param>
        public static void InitAttribute(XmlReader reader, object obj)
        {
            var count = reader.AttributeCount;
            if (count > 0)
            {
                var props = obj.GetType().GetProperties().Where(
                prop => Attribute.IsDefined(prop, typeof(XmlAttributeAttribute)));
                foreach (var prop in props)
                {
                    var attr = prop.GetCustomAttributes(typeof(XmlAttributeAttribute), true)[0] as XmlAttributeAttribute;
                    ScholarPulsar.Jats.Helpers.Object.SetPropertyValue(obj, prop, reader.GetAttribute(attr.AttributeName));
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="localName"></param>
        /// <param name="xml"></param>
        /// <returns></returns>
        public static ParagraphElement GetElement(string localName, string xml)
        {
            ParagraphElement element = null;
            switch (localName)
            {
                case "sec":
                    element = ScholarPulsar.Jats.Helpers.Xml.XmlStrToObject<Section>(xml);
                    break;
                case "p":
                    element = ScholarPulsar.Jats.Helpers.Xml.XmlStrToObject<Paragraph>(xml);
                    break;
                case "fig":
                    element = ScholarPulsar.Jats.Helpers.Xml.XmlStrToObject<Figure>(xml);
                    break;
                case "fig-group":
                    element = ScholarPulsar.Jats.Helpers.Xml.XmlStrToObject<FigureGroup>(xml);
                    break;
                case "table-wrap":
                    element = ScholarPulsar.Jats.Helpers.Xml.XmlStrToObject<TableWrapper>(xml);
                    break;
                case "table-wrap-group":
                    element = ScholarPulsar.Jats.Helpers.Xml.XmlStrToObject<TableWrapperGroup>(xml);
                    break;
                default:
                    break;
            }
            return element;
        }
    }
}
