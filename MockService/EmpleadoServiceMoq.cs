using System.Collections.Generic;
using FluentAssertions;
using Moq;
using NetCoreApiTokenTest.MockRepository;
using NetCoreApiTokenTest.MockRepository.Stubs;
using RappiApi.Models;
using RappiApi.Models.ViewModels;
using RappiApi.Repository.Interfaces;
using RappiApi.Services;
using RappiApi.Services.Interfaces;
using Xunit;

namespace NetCoreApiTokenTest.MockService
{
    public class EmpleadoServiceMoq
    {
        private static IEmpleadoService _empleadoService;
        public EmpleadoServiceMoq()
        {
            Mock<IEmpleadoRepository> _empleadoRepository = new EmpleadoRepositoryMoq()._empleadoRepository;
            _empleadoService = new EmpleadoService(_empleadoRepository.Object);
        }

        [Fact]
        public async System.Threading.Tasks.Task TestMethodActualizarEmpleadoAsync()
        {
            var result = await _empleadoService.ActualizarEmpleado(new Empleado
            {
                Id = "23ksklde",
                NumeroIDentitificacion="82773838",
                Nombre ="fulano", 
                SegundoNombre ="detal",
                Apellido = "de tal detal",
                SegundoApellido ="",
                SubAreaId ="293993"

            });

            result.Should().Be(default(int));
        }

        [Fact]
        public async System.Threading.Tasks.Task TestMethodContarEmpleadosAsync()
        {
            var result = await _empleadoService.ContarEmpleados();
            result.Equals(default(int));
        }

        [Fact]
        public async System.Threading.Tasks.Task TestMethodCrearEmpleadoAsync()
        {
            var result = await _empleadoService.CrearEmpleado(new Empleado
            {
                 Id = "23ksklde",
                NumeroIDentitificacion="827738ds38",
                Nombre ="fuldfasdano", 
                SegundoNombre ="detdeeal",
                Apellido = "de tal dadfetal",
                SegundoApellido ="",
                SubAreaId ="293233993"
            });

            result.IdentificationNumber.Should().NotBe(null);
        }

        [Fact]
        public async System.Threading.Tasks.Task TestMethodEliminarEmpleadoAsync()
        {
            var result = await _empleadoService.EliminarEmpleado(new Empleado
            {
                 Id = "23ksklde",
                NumeroIDentitificacion="827738ds38",
                Nombre ="fuldfasdano", 
                SegundoNombre ="detdeeal",
                Apellido = "de tal dadfetal",
                SegundoApellido ="",
                SubAreaId ="293233993"
            });

            result.CompareTo(default(int));
        }

        [Fact]
        public async System.Threading.Tasks.Task TestMethodObtenerEmpleadosAsync()
        {
            var result = await _empleadoService.ObtenerEmpleados(new PaginacionViewModel {
                Pagina = 0,
                TamanoPagina = 0
            });

            result.Should().NotBeNull();
        }
    }
}