using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace EpiserverSiteCommerce.Models.Pages
{
    [ContentType(DisplayName = "StandardPageThird", GUID = "4283fff7-1d94-4ecf-a8a4-fcc71e3d1171", Description = "")]
    public class StandardPageThird : PageData
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