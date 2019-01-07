using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace EpiserverSiteCommerce.Models.Pages
{
    [ContentType(DisplayName = "StandardPageForth", GUID = "edd1128c-3dbd-42ab-814d-6a8e9d91ac79", Description = "")]
    public class StandardPageForth : PageData
    {
        [CultureSpecific]
        [Display(
        Name = "Heading",
        Description = "The page heading",
        GroupName = SystemTabNames.Content,
        Order = 0)]
        public virtual String Heading { get; set; }


        [CultureSpecific]
        [Display(
        Name = "Main body",
        Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
        GroupName = SystemTabNames.Content,
        Order = 1)]
        public virtual XhtmlString MainBody { get; set; }

    }
}