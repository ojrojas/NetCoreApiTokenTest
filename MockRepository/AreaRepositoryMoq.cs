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
    public class AreaRepositoryMoq
    {
        public Mock<IAreaRepository> _areaRepository;

        public AreaRepositoryMoq()
        {
            _areaRepository = new Mock<IAreaRepository>();
            ConfiguracionAreaRepositoryMoq();
        }

        private void ConfiguracionAreaRepositoryMoq()
        {
            //ActualizarAreaAsync
            _areaRepository.Setup((x) => x.ActualizarAreaAsync(
                It.IsAny<Area>())).ReturnsAsync(default(int));
            //ContarAreasAsync
            _areaRepository.Setup((x) => x.ContarAreasAsync()).ReturnsAsync(AreaStub.listaAreaViewModel.Count);
            //CrearAreaAsync
            _areaRepository.Setup((x) => x.CrearAreaAsync(
                It.IsAny<Area>())).ReturnsAsync(AreaStub.areaViewModel1);
            //EliminarAreaAsync
            _areaRepository.Setup((x) => x.EliminarAreaAsync(
                It.IsAny<Area>())).ReturnsAsync(default(int));
            //ObtenerAreaAsync
            _areaRepository.Setup((x) => x.ObtenerAreaAsync(
                It.IsAny<Area>())).ReturnsAsync(AreaStub.areaViewModel1);
            //ObtenerAreasAsync
            _areaRepository.Setup((x) => x.ObtenerAreasAsync(
                It.IsAny<PaginacionViewModel>())).ReturnsAsync(
                    new List<AreaViewModel>());
        }
    }


}