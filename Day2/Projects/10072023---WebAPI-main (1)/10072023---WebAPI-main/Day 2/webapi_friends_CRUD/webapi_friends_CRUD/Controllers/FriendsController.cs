using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace webapi_friends_CRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FriendsController : ControllerBase
    {
        static List<string> myFriends = new List<string>() { "Mohan", "Sakshi", "Akshay", "Maitree","Monisha","Mahesh","Maharshee" };

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

        #region Post
        [HttpPost]
        [Route("friends/add")]
        public IActionResult AddFriend(string newFriendName)
        {
            myFriends.Add(newFriendName);
            return Created("",newFriendName + " Added to your friends list");
        }
        #endregion

        #region Delete
        [HttpDelete]
        [Route("/delete/{idx}")]
        public IActionResult DeleteFriend(int idx)
        {
            string friendname = myFriends[idx];
            myFriends.RemoveAt(idx);
            return Accepted(friendname + " Friend has been removed from your friends list");
        }

        [HttpDelete]
        [Route("/delete/byname/{name}")]
        public IActionResult DeleteFriend(string name)
        {
            myFriends.Remove(name);
            return Accepted(name + " has been removed from your friends list");
        }

        #endregion


        [HttpPut]
        [Route("/edit/{idx}/{newValue}")]
        public IActionResult updateFriend(int idx, string newValue)
        {
            string oldname = myFriends[idx];
            myFriends[idx] = newValue;
            return Ok("Friend Name has been updated from " + oldname + " to " + newValue);
        }


    }
}









