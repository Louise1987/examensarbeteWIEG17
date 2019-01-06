using EPiServer.Core;

namespace EpiserverSiteCommerce.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
