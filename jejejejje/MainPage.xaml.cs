using jejejejje.Interfaces;
using jejejejje.Modelos;
using jejejejje.Repositories;

namespace jejejejje
{
    public partial class MainPage : ContentPage
    {
        IEstudianteUdlaRepository _estudianteUdlaRepository;

        EstudianteUdla estudiante = new EstudianteUdla();

        public MainPage()
        {
            _estudianteUdlaRepository = new EstudianteUdlaPorArchivosRepository();
            InitializeComponent();

            estudiante = _estudianteUdlaRepository.DevuelveEstudiantesUdla(1);

            BindingContext = estudiante;


        }


/* Cambio no fusionado mediante combinación del proyecto 'jejejejje (net8.0-windows10.0.19041.0)'
Antes:
        private void GuardarEstudiante_Clicked(object sender, EventArgs e)
        {
Después:
        private async Task GuardarEstudiante_ClickedAsync(object sender, EventArgs e)
        {
*/
        private async void GuardarEstudiante_Clicked(object sender, EventArgs e)
        {
            EstudianteUdla estudiante = new EstudianteUdla
            {
                Id = 1,
                Nombre = "Daniel",
                Carrera = "Ingenieria Software"
            };

            bool guardar_estudiante = _estudianteUdlaRepository.CrearEstudianteUdla(estudiante);

            if(guardar_estudiante)
            {
                await DisplayAlert("Alerta", "Positivo", "OK");

            }
            else
            {
                await DisplayAlert("Alerta", "Negado", "OK");

            }
        }
    }

}
