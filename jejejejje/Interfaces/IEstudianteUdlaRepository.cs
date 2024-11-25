using jejejejje.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jejejejje.Interfaces
{
    public interface IEstudianteUdlaRepository
    {
        IEnumerable<EstudianteUdla> DevuelveListaEstudiantes();
        EstudianteUdla DevuelveEstudiantesUdla(int id);
        bool CrearEstudianteUdla(EstudianteUdla estudiante);
        bool ActualizarEstudianteUdla(EstudianteUdla estudiante);
        bool EliminarEstudianteUdla(int id);


    }
}
