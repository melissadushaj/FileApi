using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("files")]
public class FilesController : ControllerBase
{
    private static readonly List<FileRecord> _files = new();

    [HttpGet]
    public ActionResult<List<FileRecord>> GetAll()
    {
        return Ok(_files);
    }
}