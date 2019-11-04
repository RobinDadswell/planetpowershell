using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;
namespace Firehose.Web.Authors
{
    public class RobinDadswell : IAmACommunityMember
    {
        public string FirstName => "Robin";
        public string LastName => "Dadswell";
        public string ShortBioOrTagLine => "Office 365 Consultant with a love of all things Tech!";
        public string StateOrRegion => "Kent, England";
        public string EmailAddress => "";
        public string TwitterHandle => "robinmhdadswell";
        public string GitHubHandle => "RobinDadswell";
        public string GravatarHash => "3c8f0daf97e11b18477126f441efd5bb";
        public GeoPosition Position => new GeoPosition(51.3848415, 0.5507671);
        public Uri WebSite => new Uri("https://robindadswell.github.io");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://robindadswell.github.io/feed/powershell.xml"); } }
        public string FeedLanguageCode => "en";
    }
}
