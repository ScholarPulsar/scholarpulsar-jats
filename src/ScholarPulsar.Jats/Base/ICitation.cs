using ScholarPulsar.Jats.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarPulsar.Jats.Base
{
    public interface ICitation
    {
        string PublicationFormat
        {
            get;
            set;
        }

        string PublicationType
        {
            get;
            set;
        }

        string PublisherType
        {
            get;
            set;
        }

        string UseType
        {
            get;
            set;
        }

        string SpecificUse
        {
            get; set;
        }

        string Base
        {
            get; set;
        }

        string Language
        {
            get; set;
        }

        string Href
        {
            get; set;
        }

        ArticleTitle ArticleTitle
        {
            get; set;
        }

        TranslatedTitle TranslatedTitle
        {
            get; set;
        }

        List<ContributorNamingElement> NamingElements
        {
            get;
            set;
        }

        CommentInCitation Comment
        {
            get; set;
        }

        EditionStatement Edition
        {
            get; set;
        }

        ElectronicLocationIdentifier ELocationId
        {
            get; set;
        }

        FirstPage FirstPage
        {
            get; set;
        }

        LastPage LastPage
        {
            get; set;
        }

        PageRanges PageRanges
        {
            get; set;
        }

        Source Source
        {
            get; set;
        }

        Year Year
        {
            get; set;
        }

        Month Month
        {
            get;set;
        }

        Day Day
        {
            get;set;
        }

        VolumeNumber Volume
        {
            get; set;
        }

        IssueNumber Issue
        {
            get; set;
        }

        List<PublisherName> PublisherNames
        {
            get; set;
        }

        List<PublisherLocation> PublisherLocations
        {
            get; set;
        }

        SupplementInformation Supplement
        {
            get; set;
        }

        List<PublicationIdentifier> PubIds
        {
            get; set;
        }

        ConferenceDate ConferenceDate
        {
            get;set;
        }

        ConferenceName ConferenceName
        {
            get; set;
        }

        ConferenceLocation ConferenceLocation
        {
            get; set;
        }
    }
}
