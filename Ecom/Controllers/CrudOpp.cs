using Ecom.Instrct;
using Ecom.Ppty;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Ecom.Dtos;

namespace Ecom.Controllers
{
    [Route("api/Ecom")]
    [ApiController]
    public class CrudOpp : ControllerBase
    {
        private readonly IInstructions proData;
        private readonly IMapper mapper;

        
        public CrudOpp(IInstructions property, IMapper map)
        {
            proData = property;
            mapper=map;
        }
       

        [HttpGet]
        public ActionResult<IEnumerable<PurchaseReadDtos>> GetLastFivePurchase()
        {
            
            var purDatas=proData.GetLastFivePurchase();
            if(purDatas!=null){
                return Ok(mapper.Map<IEnumerable<PurchaseReadDtos>>(purDatas));
            }
            return NotFound();
        }
        [HttpGet("{id123}")]
        public ActionResult<WishListReadDto> GetWishlistByUserId(int id)
        {
            var wishData = proData.GetWishlistByUserId(id);
            if(wishData!=null)
            {
                return Ok(wishData);
            }
            return NotFound();
        }
        [HttpPost]
        public ActionResult<ProfilesReadDto> CreateProfile(ProfileCreateDtos createProfile)
        {
            var profileData = mapper.Map<Profiles>(createProfile);
            proData.CreateProfile(profileData);
            proData.SaveChanges();

            var profilesReadDto = mapper.Map<ProfilesReadDto>(profileData);
            return Ok(profilesReadDto);
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteProfile(int id)
        {
            var userProfile = proData.GetProfileByUserId(id);
            if (userProfile == null)
            {
                return NotFound();
            }
            proData.DeleteProfile(userProfile);
            proData.SaveChanges();
            return NoContent();
        }
        







        /*public ActionResult<IEnumerable<EcomReadDtos>> GetAllProducts()
        {

           {
               var prodDatas = proData.GetAllProducts();
               return Ok(mapper.Map<IEnumerable<EcomReadDtos>>(prodDatas));
           }

       }*/
        /*[HttpGet]
        public ActionResult<IEnumerable<ProfilesReadDto>> GetProfiles()
        {
            var proDatas = proData.GetProfiles();
            if (proDatas != null) {
                return Ok(mapper.Map<IEnumerable<ProfilesReadDto>>(proDatas));
            }
            return NotFound();
        }*/
        /*[HttpGet("{profiles}/{id}")]
        public ActionResult<ProfilesReadDto> GetProfileByUserId(int id)
        {
            var proDatas = proData.GetProfileByUserId(id);
            if (proDatas != null)
            {
                return Ok(mapper.Map<ProfilesReadDto>(proDatas));
            }
            return NotFound();
        }*/



        /*[HttpGet("{profiles}/{id}/{wishList}")]

        public ActionResult<IEnumerable<Ecomm>> GetWishList(int id, string wishlist)
        {
            if (wishlist == "Wishlists" || wishlist == "WISHLISTS" || wishlist == "wishlists")
            {
                var proDatas = proData.GetWishList();
                return Ok(proDatas);

            }
            else
            {
                return BadRequest("Ivalid type");
            }

        }*/
        /*[HttpGet("{userId}/{purchase}")]
        public ActionResult<IEnumerable<Ecomm>> GetPurchase(int userid, string purchase)
        {
            var proDatas = proData.GetPurchase();
            return Ok(proDatas);
        }*/

        /* [HttpPut("{id}")]
         public ActionResult UpdateProfile(int id, ProfileUpdateDtos profileUpdateDtos)
         {
             var consumerProfile = proData.GetProfileByUserId(id);
             if (consumerProfile == null)
             {
                 return NotFound();
             }
             mapper.Map(profileUpdateDtos, consumerProfile);
             proData.UpdateProfile(consumerProfile);
             proData.SaveChanges();
             return NoContent();
         }*/



    }
}
