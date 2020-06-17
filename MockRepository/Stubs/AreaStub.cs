using System.Collections.Generic;
using RappiApi.Models;
using RappiApi.Models.ViewModels;

namespace NetCoreApiTokenTest.MockRepository.Stubs
{
    public static class AreaStub
    {
        public static Area area1 = new Area()
        {
            Codigo = 120,
            Nombre = "Area1",
            Id = "adshfkjasdhfjkads"
        };

        public static Area area2 = new Area()
        {
            Codigo = 120,
            Nombre = "Area1",
            Id = "adshfkjasdhfjkads"
        };

        public static List<AreaViewModel> listaAreaViewModel = new List<AreaViewModel>()
        {
          new AreaViewModel{  Id= "dsfw3",
          Code = 213,
          Name ="AreaViewModel1" },
          new AreaViewModel{  Id= "234gdfsd",
          Code = 213,
          Name ="AreaViewModel2"},
          new AreaViewModel{  Id= "rtdtryh",
          Code = 213,
          Name ="AreaViewModel3"},
          new AreaViewModel{  Id= "2345rtfh54",
          Code = 213,
          Name ="AreaViewModel4"}
        };

        public static AreaViewModel areaViewModel1 = new AreaViewModel()
        {
            Id = "fasdfasdf",
            Code = 213,
            Name = "AreaViewModel"
        };
    }
}