using Daylik.Data;
using Daylik.Models;
using Daylik.Services.Interface;

namespace Daylik.Services
{
    public class NoteService : INotesService
    {
        private MyDataContext _dataContext;
        public NoteService(MyDataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public NoteModel Create(NoteModel model)
        {
            var lastNote = _dataContext.Notes.LastOrDefault();
            int newId = lastNote is null ? 1 : lastNote.Id + 1;

            model.Id = newId;
            _dataContext.Notes.Add(model);
             
            return model;
        }

        public void Delete(int id)
        {
            var modelToDelete = _dataContext.Notes.FirstOrDefault(x => x.Id == id);
            
            _dataContext.Notes.Remove(modelToDelete);
        }

        public NoteModel Get(int id)
        {
            return _dataContext.Notes.FirstOrDefault(x => x.Id == id);
        }

        public List<NoteModel> GetAll()
        {
            return _dataContext.Notes;
        }

        public NoteModel Update(NoteModel model)
        {
            var modelToUpdate = _dataContext.Notes.FirstOrDefault(x => x.Id == model.Id);
            modelToUpdate.Task = model.Task;
            modelToUpdate.Description = model.Description;

            return modelToUpdate;
        }
    }
}
