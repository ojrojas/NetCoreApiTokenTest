using System.Collections.Generic;
using FluentAssertions;
using Moq;
using NetCoreApiTokenTest.MockRepository;
using NetCoreApiTokenTest.MockRepository.Stubs;
using RappiApi.Models.ViewModels;
using RappiApi.Repository.Interfaces;
using RappiApi.Services;
using RappiApi.Services.Interfaces;
using Xunit;

namespace NetCoreApiTokenTest.MockService
{
    public class SubAreaServiceMoq
    {
        private static ISubAreaService _subareaService;
        public SubAreaServiceMoq()
        {
            Mock<ISubAreaRepository> _subareaRepository = new SubAreaRepositoryMoq()._subareaRepository;
            _subareaService = new SubAreaService(_subareaRepository.Object);
        }

        [Fact]
        public async System.Threading.Tasks.Task TestMethodActualizarsubAreaAsync()
        {
            var result = await _subareaService.ActualizarSubArea(new SubAreaViewModel
            {
                Code = 5654,
                Id = "9288383",
                Name = "234234"
            });

            result.Should().Be(default(int));
        }

        [Fact]
        public async System.Threading.Tasks.Task TestMethodContarsubAreasAsync()
        {
            var result = await _subareaService.ContarSubAreas();
            result.Equals(default(int));
        }

        [Fact]
        public async System.Threading.Tasks.Task TestMethodCrearsubAreaAsync()
        {
            var result = await _subareaService.CrearSubArea(new SubAreaViewModel
            {
                Id = "fasdfasdf",
                Code = 213,
                Name = "SubAreaViewModel"
            });

            result.Code.Should().NotBe(null);
        }

        [Fact]
        public async System.Threading.Tasks.Task TestMethodEliminarsubAreaAsync()
        {
            var result = await _subareaService.EliminarSubArea(new SubAreaViewModel
            {
                Id = "fasdfasdf",
                Code = 213,
                Name = "SubAreaViewModel"
            });

            result.CompareTo(default(int));
        }

        [Fact]
        public async System.Threading.Tasks.Task TestMethodObtenersubAreasAsync()
        {
            var result = await _subareaService.ObtenerSubAreas(new PaginacionViewModel {Pagina = 0, TamanoPagina= 0});

            result.Should().NotBeNull();
        }
    }
}