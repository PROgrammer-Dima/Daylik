using Daylik.Models;
using Daylik.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Daylik.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        private INotesService _notesService;
        public NotesController(INotesService notesService)
        {
           _notesService = notesService;
        }
        [HttpPost]
        public NoteModel Create(NoteModel model)
        {
            return _notesService.Create(model);
        }
        [HttpPatch]
        public NoteModel Update(NoteModel model)
        {
            return _notesService.Update(model);
        }
        [HttpGet("{id}")]
        public NoteModel Get(int id)
        {
            return _notesService.Get(id);
        }
        [HttpGet]
        public IEnumerable<NoteModel> GetAll()
        {
            return _notesService.GetAll();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _notesService.Delete(id);
            return Ok();
        }
    }
}
