using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApI_Friends_CRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FriendsController : ControllerBase
    {
        static List<string> myFriends = new List<string>() { "Mohan", "Sakshi", "akshay", "Maitree" };

        #region Get Methods
        [HttpGet]
        [Route("/list")]
        public IActionResult GetAllFriends()
        {
            return Ok(myFriends);
        }

        [HttpGet]
        [Route("/index/{idx}")]
        public IActionResult GetFriendByIndex(int idx)
        {
            if (myFriends.Count < idx)
            {
                return NotFound("Sorry No Friend found at this position");
            }

            string friend = myFriends[idx];
            return Ok(friend);
        }

        [HttpGet]
        [Route("/characters/{chars}")]
        public IActionResult GetFriendByCharacters(string chars)
        {
            //this is equal to select * from myFriends where myFriends like 'chars%'
            var friends = from f in myFriends
                          where f.StartsWith(chars)
                          select f;
            return Ok(friends);
        }

        [HttpGet]
        [Route("friends/count")]
        public IActionResult GetCountofFriends()
        {
            var total = myFriends.Count;
            return Ok(total);
        }
        #endregion

        //#region 
        //public IActionResult GetAllFriends()
        //{
        //    return Ok(myFriends);
        //}

        //public IActionResult GetFriendsByIndex(int indx)
        //{
        //    string friend = myFriends[indx];
        //    return Ok(friend);
        //}

        //public IActionResult GetFriendByCharacters(string chars)
        //{
        //    var friends = from f in myFriends
        //                  where f.StartsWith(chars)
        //                  select f;
        //    // this is equals to select * from myfriends where myFriends like 'chars%'
        //    return Ok(friends);
        //}
        //#endregion

        //#region
        //[HttpPost]
        //[Route("")]
        //public IActionResult AddFriend(string newFrindName)
        //{
        //    myFriends.Add(newFrindName);
        //    return Ok(newFrindName + "Added to your friend list");
        //}
        //#endregion

        //#region Delete
        //public IActionResult DeleteFriend(int indx)
        //{
        //    string friendname = myFriends[indx];
        //    myFriends.RemoveAt(indx);
        //    return Accepted(friendname + "friend has been removed from your friends list");
        //}
        //#endregion

        //[HttpPut]
        //[Route("/edit/{idx}/{newValue}")]
        //public IActionResult updateFriend(int idx, string newValue)
        //{
        //    string oldname = myFriends[idx];
        //    myFriends[idx] = newValue;
        //    return Ok("friends has been updated from " + oldname +" to " + newValue );
        //}


        //------------------------------------------------------------------------------------//

        //static List<string> ProductList = new List<string>() { "Laptop", "Mouse", "CPU", "Keyboard" };

        //#region  -- GET
        //[HttpGet]
        //[Route("/get/GetAllProducts()")]
        //public IActionResult GetAllProducts()
        //{
        //    return Ok(ProductList);
        //}

        //[HttpGet]
        //[Route("/get/{indx}")]
        //public IActionResult GetProductsByIndex(int indx)
        //{
        //    string product = ProductList[indx];
        //    return Ok(product);
        //}

        //[HttpGet]
        //[Route("/get/bychars/{chars}")]
        //public IActionResult GetProductByCharacters(string chars)
        //{
        //    var products = from p in ProductList
        //                   where p.StartsWith(chars)
        //                  select p;
        //    return Ok(products);
        //}
        //#endregion -- Get

    }
}
