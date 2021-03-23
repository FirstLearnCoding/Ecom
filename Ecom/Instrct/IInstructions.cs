using Ecom.Ppty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecom.Instrct
{
    public interface IInstructions
    {
        bool SaveChanges();
        IEnumerable<Profiles> GetProfiles();
        IEnumerable<Ecomm> GetAllProducts();
        IEnumerable<ProductWishlist> GetWishList();
        IEnumerable<Ecomm> GetPurchase();
        IEnumerable<ProductPurchase> GetLastFivePurchase();

        ProductWishlist GetWishlistByUserId(int UserId);
        Profiles GetProfileByUserId(int Id);
        void CreateProfile(Profiles profile);
        void UpdateProfile(Profiles profile);
        void DeleteProfile(Profiles profile);
    }
}
