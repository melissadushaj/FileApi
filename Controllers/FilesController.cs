using Microsoft.AspNetCore.Mvc;

 // Attribute indicates that controller responds to web API requests
[ApiController] 
// Attribute "this controller handles requests whose route starts with 'files'"
[Route("files")] 

// Important that static is here otherwise ASP.NET will create a brand new -
// FileController for every request.
// Also : ControllerBase means "inherit from ControllerBase" which is the -
// same as extends in Java.
public class FilesController : ControllerBase
{
    // Underscore in _files is convention for private fields.
    // new() is shorthand for new List<FileRecord>().
    private static readonly List<FileRecord> _files = new();

    // Attribute that says this method responds to HTTP GET requests.
    [HttpGet]
    public ActionResult<List<FileRecord>> GetAll()
    {
        // Is one of the helper methods from ControllerBase that - 
        // returns a 200 OK response with the given data.
        return Ok(_files);
    }
}