using EPiServer.Core;

namespace EpiserverSiteECommerce.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
