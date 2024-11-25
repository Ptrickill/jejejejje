using jejejejje.Interfaces;
using jejejejje.Modelos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace jejejejje.Repositories
{
    public class EstudianteUdlaPorArchivosRepository : IEstudianteUdlaRepository
    {
        private string _fileName = Path.Combine(FileSystem.AppDataDirectory, "Estudiantes.txt");
        public bool ActualizarEstudianteUdla(EstudianteUdla estudiante)
        {
            throw new NotImplementedException();
        }

        public bool CrearEstudianteUdla(EstudianteUdla estudiante)
        {
            try
            {
                string json_data = JsonConvert.SerializeObject(estudiante);
                File.WriteAllText(_fileName, json_data);
                return true;
            }
            catch (Exception)
            {
                throw;
            }


        }

        public EstudianteUdla DevuelveEstudiantesUdla(int id)
        {
            EstudianteUdla estudiante = new EstudianteUdla();

            if (File.Exists(_fileName))
            {
                string json_data = File.ReadAllText(_fileName);
                estudiante = JsonConvert.DeserializeObject<EstudianteUdla>(json_data);
            }

            return estudiante;

        }

        public IEnumerable<EstudianteUdla> DevuelveListaEstudiantes()
        {
            throw new NotImplementedException();
        }

        public bool EliminarEstudianteUdla(int id)
        {
            throw new NotImplementedException();
        }
    }
}
