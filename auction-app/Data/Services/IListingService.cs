using auction_app.Models;

namespace auction_app.Data.Services
{
    public interface IListingService
    {
        IQueryable<Listing> GetAll();
    }
}
