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
        public string _urlEndpoint = "https://freetestapi.com/v1/students";
        public bool ActualizarEstudianteUdla(EstudianteUdla estudiante)
        {
            throw new NotImplementedException();
        }

        public bool CrearEstudianteUdla(EstudianteUdla estudiante)
        {
            throw new NotImplementedException();
        }

        public EstudianteUdla DevuelveEstudiantesUdla(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EstudianteUdla> DevuelveListaEstudiantes()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                var response = httpClient.GetAsync(_urlEndpoint).Result;
                var json_data = response.Content.ReadAsStringAsync().Result;

                List<EstudianteApi> estudianteAPI = JsonConvert.DeserializeObject<List<EstudianteApi>>(json_data);
            }
        }

        public bool EliminarEstudianteUdla(int id)
        {
            throw new NotImplementedException();
        }
    }
}
