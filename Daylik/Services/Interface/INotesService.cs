using Daylik.Models;
using Microsoft.AspNetCore.Mvc;

namespace Daylik.Services.Interface
{
    public interface INotesService
    {
        NoteModel Create(NoteModel model);

        NoteModel Update(NoteModel model);

        NoteModel Get(int id);

        List<NoteModel> GetAll();

        void Delete(int id);

    }
}
