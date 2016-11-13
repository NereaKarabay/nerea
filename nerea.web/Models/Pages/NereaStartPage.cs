using System.ComponentModel.DataAnnotations;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace nerea.web.Models.Pages
{
    [ContentType(
        GUID = "ADACD6F7-730A-4D84-87FF-2201B20324C0",
        GroupName = Global.GroupNames.Specialized,
        Description = "Startsida")]
    [SiteImageUrl]
    public class NereaStartPage : SitePageData
    {
        [CultureSpecific]
        [Display(
            Name = "Rubrik",
            Description = "Rubrik",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string Header { get; set; }
    }
}