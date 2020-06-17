using Moq;
using NetCoreApiTokenTest.MockRepository.Stubs;
using RappiApi.Models;
using RappiApi.Models.ViewModels;
using RappiApi.Repository;
using RappiApi.Repository.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;



namespace NetCoreApiTokenTest.MockRepository
{
    public class EmpleadoRepositoryMoq
    {
        public Mock<IEmpleadoRepository> _empleadoRepository;

        public EmpleadoRepositoryMoq()
        {
            _empleadoRepository = new Mock<IEmpleadoRepository>();
            ConfiguracionEmpleadoRepositoryMoq();
        }

        private void ConfiguracionEmpleadoRepositoryMoq()
        {
            //ActualizarEmpleadoAsync
            _empleadoRepository.Setup((x) => x.ActualizarEmpleadoAsync(
                It.IsAny<Empleado>())).ReturnsAsync(default(int));
            //ContarEmpleadosAsync
            _empleadoRepository.Setup((x) => x.ContarEmpleadosAsync()).ReturnsAsync(EmpleadoStub.listaEmpleadoViewModel.Count);
            //CrearEmpleadoAsync
            _empleadoRepository.Setup((x) => x.CrearEmpleadoAsync(
                It.IsAny<Empleado>())).ReturnsAsync(EmpleadoStub.empleadoViewModel1);
            //EliminarEmpleadoAsync
            _empleadoRepository.Setup((x) => x.EliminarEmpleadoAsync(
                It.IsAny<Empleado>())).ReturnsAsync(default(int));
            //ObtenerEmpleadoAsync
            _empleadoRepository.Setup((x) => x.ObtenerEmpleadoAsync(
                It.IsAny<Empleado>())).ReturnsAsync(EmpleadoStub.empleadoViewModel1);
            //ObtenerEmpleadosAsync
            _empleadoRepository.Setup((x) => x.ObtenerEmpleadosAsync(
                It.IsAny<PaginacionViewModel>())).ReturnsAsync(
                    new List<EmpleadoViewModel>());
        }
    }


}