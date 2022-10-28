//Elizar Garcia
//10-25-22
//MiniCh#3AskingQuestionsEndpoint.
// we will be gett the users name and time they woke up to show up on postman
//Peer Review: code looks very nice easy to read and no errors and the code has beem completed i approve.


using Microsoft.AspNetCore.Mvc;

namespace GarciaEAskingQuestionsEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class QuestionsController : ControllerBase
{
    [HttpGet]
    [Route("asking/{name}/{time}")]

    public string talk (string name, string time)
    {
        return $"Hey {name}, did you really wake up at {time}?";

    }
    
}
