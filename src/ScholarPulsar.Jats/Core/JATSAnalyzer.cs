using ScholarPulsar.Jats.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ScholarPulsar.Jats.Core
{
    public class JATSAnalyzer
    {
        private string nlmDtdPath;

        public JATSAnalyzer()
        {
        }
        public JATSAnalyzer(string nlmDtdPath)
        {
            this.nlmDtdPath = nlmDtdPath;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="xml"></param>
        /// <returns></returns>
        public ArticleSet GetArtilceSet(string xml)
        {
            xml = xml.Replace("xlink:href", "href");
            XmlSerializer ser = new XmlSerializer(typeof(ArticleSet));
            using (TextReader reader = new StringReader(xml))
            {
                ArticleSet obj = ser.Deserialize(reader) as ArticleSet;
                return obj;
            }
        }

        public T GetEntity<T>(string xml)
        {
            T obj = default(T);
            XmlSerializer ser = new XmlSerializer(typeof(T));
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.DtdProcessing = DtdProcessing.Parse;
            using (TextReader reader = new StringReader(xml))
            {
                XmlReader doc = XmlReader.Create(reader, settings);
                obj = (T)ser.Deserialize(doc);
            }
            return obj;
        }

        public Article GetArticle(string xml)
        {
            XmlSerializer ser = new XmlSerializer(typeof(Article));
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.DtdProcessing = DtdProcessing.Parse;
            using (TextReader reader = new StringReader(xml))
            {
                XmlReader doc = XmlReader.Create(reader, settings);
                Article obj = ser.Deserialize(doc) as Article;
                return obj;
            }
        }

        public PubMedEntities.PubmedArticleSet GetPubMedArticle(string xml)
        {
            PubMedEntities.PubmedArticleSet article = null;
            XmlSerializer ser = new XmlSerializer(typeof(PubMedEntities.PubmedArticleSet));
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.DtdProcessing = DtdProcessing.Ignore;
            using (TextReader reader = new StringReader(xml))
            {
                XmlReader doc = XmlReader.Create(reader, settings);
                article = ser.Deserialize(doc) as PubMedEntities.PubmedArticleSet;
            }
            return article;

        }

        public NLMCatalogEntities.NLMCatalogRecordSet GetNLMCatalogRecordSet(string xml)
        {
            NLMCatalogEntities.NLMCatalogRecordSet recordSet = null;
            XmlSerializer ser = new XmlSerializer(typeof(NLMCatalogEntities.NLMCatalogRecordSet));
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.DtdProcessing = DtdProcessing.Ignore;
            using (TextReader reader = new StringReader(xml))
            {
                XmlReader doc = XmlReader.Create(reader, settings);
                recordSet = ser.Deserialize(doc) as NLMCatalogEntities.NLMCatalogRecordSet;
            }
            return recordSet;

        }
    }
}
