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
    public class AreaServiceMoq
    {
        private static IAreaService _areaService;
        public AreaServiceMoq()
        {
            Mock<IAreaRepository> _areaRepository = new AreaRepositoryMoq()._areaRepository;
            _areaService = new AreaServices(_areaRepository.Object);
        }

        [Fact]
        public async System.Threading.Tasks.Task TestMethodActualizarAreaAsync()
        {
            var result = await _areaService.ActualizarArea(new AreaViewModel
            {
                Code = 5654,
                Id = "9288383",
                Name = "234234"
            });

            result.Should().Be(default(int));
        }

        [Fact]
        public async System.Threading.Tasks.Task TestMethodContarAreasAsync()
        {
            var result = await _areaService.ContarAreas();
            result.Equals(default(int));
        }

        [Fact]
        public async System.Threading.Tasks.Task TestMethodCrearAreaAsync()
        {
            var result = await _areaService.CrearArea(new AreaViewModel
            {
                Id = "fasdfasdf",
                Code = 213,
                Name = "AreaViewModel"
            });

            result.Code.Should().NotBe(null);
        }

        [Fact]
        public async System.Threading.Tasks.Task TestMethodEliminarAreaAsync()
        {
            var result = await _areaService.EliminarArea(new AreaViewModel
            {
                Id = "fasdfasdf",
                Code = 213,
                Name = "AreaViewModel"
            });

            result.CompareTo(default(int));
        }

        [Fact]
        public async System.Threading.Tasks.Task TestMethodObtenerAreasAsync()
        {
            var result = await _areaService.ObtenerAreas();

            result.Should().NotBeNull();
        }
    }
}