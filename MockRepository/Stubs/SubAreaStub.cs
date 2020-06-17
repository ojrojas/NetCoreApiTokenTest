using System.Collections.Generic;
using RappiApi.Models;
using RappiApi.Models.ViewModels;

namespace NetCoreApiTokenTest.MockRepository.Stubs
{
    public static class SubAreaStub
    {
        public static SubArea subarea1 = new SubArea()
        {
            Codigo = 120,
            Nombre = "subArea1",
            Id = "adshfkjasdhfjkads",
            AreaId = "asdlkklsoidk"
        };

        public static SubArea Subarea2 = new SubArea()
        {
            Codigo = 120,
            Nombre = "subArea1",
            Id = "adshfkjasdhfjkads",
            AreaId="902093kjk3"
        };

        public static List<SubAreaViewModel> listaSubAreaViewModel = new List<SubAreaViewModel>()
        {
          new SubAreaViewModel{  Id= "dsfw3",
          Code = 213, AreaId = "ioiosoasdf",
          Name ="SubAreaViewModel1" },
          new SubAreaViewModel{  Id= "234gdfsd",
          Code = 213, AreaId = "aedaedfa",
          Name ="SubAreaViewModel2"},
          new SubAreaViewModel{  Id= "rtdtryh",
          Code = 213, AreaId = "098a8sd9",
          Name ="SubAreaViewModel3"},
          new SubAreaViewModel{  Id= "2345rtfh54",
          Code = 213, AreaId = "8283jde8",
          Name ="SubAreaViewModel4"}
        };

        public static SubAreaViewModel SubareaViewModel1 = new SubAreaViewModel()
        {
            Id = "fasdfasdf",
            Code = 213,
            Name = "SubAreaViewModel",
            AreaId = "kaksdlkdioios"
        };
    }
}