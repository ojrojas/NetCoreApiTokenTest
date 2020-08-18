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
    public class SubAreaRepositoryMoq
    {
        public Mock<ISubAreaRepository> _subareaRepository;

        public SubAreaRepositoryMoq()
        {
            _subareaRepository = new Mock<ISubAreaRepository>();
            ConfiguracionSubAreaRepositoryMoq();
        }

        private void ConfiguracionSubAreaRepositoryMoq()
        {
            //ActualizarSubAreaAsync
            _subareaRepository.Setup((x) => x.ActualizarSubAreaAsync(
                It.IsAny<SubArea>())).ReturnsAsync(default(int));
            //ContarSubAreasAsync
            _subareaRepository.Setup((x) => x.ContarSubAreasAsync()).ReturnsAsync(SubAreaStub.listaSubAreaViewModel.Count);
            //CrearSubAreaAsync
            _subareaRepository.Setup((x) => x.CrearSubAreaAsync(
                It.IsAny<SubArea>())).ReturnsAsync(SubAreaStub.SubareaViewModel1);
            //EliminarSubAreaAsync
            _subareaRepository.Setup((x) => x.EliminarSubAreaAsync(
                It.IsAny<SubArea>())).ReturnsAsync(default(int));
            //ObtenerSubAreaAsync
            _subareaRepository.Setup((x) => x.ObtenerSubAreaAsync(
                It.IsAny<SubArea>())).ReturnsAsync(SubAreaStub.SubareaViewModel1);
            //ObtenerSubAreasAsync
            _subareaRepository.Setup((x) => x.ObtenerSubAreasAsync(
                It.IsAny<PaginacionViewModel>())).ReturnsAsync(
                    new List<SubAreaViewModel>());
        }
    }


}