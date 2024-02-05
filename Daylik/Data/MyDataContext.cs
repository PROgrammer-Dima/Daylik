using Daylik.Models;

namespace Daylik.Data
{
    public class MyDataContext
    {
        public List<NoteModel> Notes { get; set; }

        public MyDataContext() 
        {
            Notes = new List<NoteModel>();
        }
    }
}
