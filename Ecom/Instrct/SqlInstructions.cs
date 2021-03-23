using System;
using System.Collections.Generic;
using System.Linq;
using Ecom.Ppty;

namespace Ecom.Instrct
{
    public class SqlInstructions : IInstructions
    {

        public string date = DateTime.Now.ToString("MM/dd/yyyy");

        private readonly EcommContext contexts;
        public SqlInstructions(EcommContext context)
        {
            contexts = context;

        }
        public void DeleteProfile(Profiles profile)
        {
            if(profile==null)
            {
                throw new ArgumentNullException(nameof(profile));
            }
            contexts.ProfileData.Remove(profile);
        }
        public void CreateProfile(Profiles profile)
        {
            contexts.ProfileData.Add(profile);
        }
        public IEnumerable<Ecomm> GetAllProducts()
        {
            var data= contexts.EcomPro.ToList();
            return data;

        }
        public IEnumerable<ProductPurchase> GetLastFivePurchase()
        {

            return contexts.PurchaseData.ToList();
        }
        public Profiles GetProfileByUserId(int UserId)
        {
            return contexts.ProfileData.FirstOrDefault(p => p.UserId == UserId);
        }
        public IEnumerable<Profiles> GetProfiles()
        {
            return contexts.ProfileData.ToList();
        }
        public IEnumerable<Ecomm> GetPurchase()
        {
            return contexts.EcomPro.ToList();
        }
        public IEnumerable<ProductWishlist> GetWishList()
        {
            return contexts.WishData.ToList();
        }
        public bool SaveChanges()
        {
            return (contexts.SaveChanges()>=0);
        }
        public void UpdateProfile(Profiles profile)
        {
            
        }

        public ProductWishlist GetWishlistByUserId(int UserId)
        {
            return contexts.WishData.FirstOrDefault(p => p.UserId == UserId);
        }
    }
}
