using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using jejejejje.Interfaces;
using jejejejje.Modelos;
using Newtonsoft.Json;

namespace jejejejje.Repositories
{
    public class EstudianteUdlaPorAPIsRepository : IEstudianteUdlaRepository
    {
        private static string NombreBD = "EstudianteUDLA.db3";
        private SQLiteConnection _connection;

        public EstudianteUdlaSQLiteRepositoty()
        {
            Init();
        }

        public void Init()
        {
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, NombreBD);
            _connection = new SQLiteConnection(dbPath);
            _connection.CreateTable<EstudianteUdla>();

        }


        public bool ActualizarEstudianteUdla(EstudianteUdla estudiante)
        {
            throw new NotImplementedException();
        }

        public bool CrearEstudianteUdla(EstudianteUdla estudiante)
        {
            try
            {
                int insert = _connection.Insert(estudiante);
                if (insert > 0)
                {
                    return true;
                }
                return false;
            }
            catch
            {
                throw;
            }

        }

        public EstudianteUdla DevuelveEstudiantesUdla(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EstudianteUdla> DevuelveListaEstudiantes()
        {
            var listadoEstudiantes = _connection.Table<EstudianteUdla>().ToList();
            return listadoEstudiantes;
        }

        public bool EliminarEstudianteUdla(int id)
        {
            int eliminar = _connection.Delete(id);
            if (eliminar > 0)
            {
                return true;
            }
            return false;
        }
    }
}
