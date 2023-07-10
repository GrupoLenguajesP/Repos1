using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Ejercicio_Insert.Models;
using System.Threading.Tasks;

namespace Ejercicio_Insert.Data
{
    public class SQLData
    {

        SQLiteAsyncConnection db;

        public SQLData(string dbPath)
        {
            db = new SQLiteAsyncConnection(dbPath);
            db.CreateTableAsync<Alumno>().Wait();
        }


        public Task<int> GuardarAlumno(Alumno alum)
        {
            if (alum.IdAlumno == 0)
            {
                return db.InsertAsync(alum);
            }
            else
            {
                return null;
            }
        }

        public Task<List<Alumno>> GetAlumnos()
        {
            return db.Table<Alumno>().ToListAsync();
        }

        public Task<Alumno>GetAlumnoByID(int idAlumno)
        {
            return db.Table<Alumno>().Where(a => a.IdAlumno == idAlumno).FirstOrDefaultAsync();
        }


    }
}
