using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using WikiKart.Models;

namespace WikiKart.Database
{
    public class NoteDatabase
    {
        readonly SQLiteAsyncConnection _databaseNote;

        public NoteDatabase(string dbPathNote)
        {
            _databaseNote = new SQLiteAsyncConnection(dbPathNote);
            _databaseNote.CreateTableAsync<Note>().Wait();
        }

        public Task<int> SaveNoteAsync(Note note)
        {
            if (note.ID != 0)
            {
                return _databaseNote.UpdateAsync(note);
            }
            else
            {
                return _databaseNote.InsertAsync(note);
            }
        }

        public Task<int> DeleteNoteAsync(Note note)
        {
            return _databaseNote.DeleteAsync(note);
        }

        public Task<List<Note>> GetNotesAsync()
        {
            return _databaseNote.Table<Note>().ToListAsync();
        }

        public Task<Note> GetNoteAsync(int id)
        {
            return _databaseNote.Table<Note>()
                            .Where(i => i.ID == id)
                            .FirstOrDefaultAsync();
        }
    }
}