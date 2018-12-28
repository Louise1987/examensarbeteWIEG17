using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace EpiserverSiteECommerce.Models.Pages
{
    [ContentType(DisplayName = "ProdukttPage1", GUID = "2deebf7f-39ef-43a6-9989-294dcefd75b7", Description = "")]
    public class ProdukttPage1 : PageData
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