//class for crud operation
// c- create a profile in database
// r- read detail from database
// u- update database with new data
// d- remove data from database


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
    public class CrudOpp : ControllerBase // ControllerBase for Crud operation
    {
        private readonly IInstructions proData;
        private readonly IMapper mapper;

        
        public CrudOpp(IInstructions property, IMapper map)
        {
            proData = property;
            mapper=map;
        }
       
        // to get the last purchases in database
        [HttpGet]
        public ActionResult<IEnumerable<PurchaseReadDtos>> GetLastFivePurchase()
        {
            
            var purDatas=proData.GetLastFivePurchase();
            if(purDatas!=null){
                return Ok(mapper.Map<IEnumerable<PurchaseReadDtos>>(purDatas));
            }
            return NotFound();
        }
        // get the data from database by id
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
        
        // create profile in database using httppost
        [HttpPost]
        public ActionResult<ProfilesReadDto> CreateProfile(ProfileCreateDtos createProfile)
        {
            var profileData = mapper.Map<Profiles>(createProfile);
            proData.CreateProfile(profileData);
            proData.SaveChanges();

            var profilesReadDto = mapper.Map<ProfilesReadDto>(profileData);
            return Ok(profilesReadDto);
        }
        // delete profile by using id
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

    }
}
