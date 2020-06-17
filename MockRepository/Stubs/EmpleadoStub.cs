using System.Collections.Generic;
using RappiApi.Models;
using RappiApi.Models.ViewModels;

namespace NetCoreApiTokenTest.MockRepository.Stubs
{
    public static class EmpleadoStub
    {
        public static Empleado empleado1 = new Empleado()
        {
            Id = "adshfkjasdhfjkads",
            TipoIdentificacion = 1,
            NumeroIDentitificacion = "32423423",
            Nombre = "Dionisio",
            SegundoNombre = "Funalo ",
            Apellido = "Detal",
            SegundoApellido = "",
            SubAreaId = "asdfasdfasdfasdf"

        };

        public static Empleado empleado2 = new Empleado()
        {
            Id = "adshfkja238d8d73s",
            TipoIdentificacion = 2,
            NumeroIDentitificacion = "125544887",
            Nombre = "Perensejo",
            SegundoNombre = "Teovaldo ",
            Apellido = "Detal",
            SegundoApellido = "",
            SubAreaId = "asddfadfw333"

        };

        public static List<EmpleadoViewModel> listaEmpleadoViewModel = new List<EmpleadoViewModel>()
        {
          new EmpleadoViewModel{
               Id = "adshfkja238d8345d73s",
            TypeIdentification = 2,
            IdentificationNumber = "125345544887",
            Name = "Perensejo",
            SecondName = "Teovaldo ",
            SurName = "Detal",
            SecondSurname ="",
            SubAreaId = "asddfadfw2345333"
          },
          new EmpleadoViewModel{
              Id = "adshfkja238d8dertwer73s",
            TypeIdentification = 2,
            IdentificationNumber = "125543544887",
            Name = "Perensejo",
            SecondName = "Teovaldo ",
            SurName = "Detal",
            SecondSurname ="",
            SubAreaId = "asddfadf444w333"
            },
          new EmpleadoViewModel{
                Id = "adshfkja238d8drtrt73s",
            TypeIdentification = 2,
            IdentificationNumber = "23452677",
            Name = "Perensejo",
            SecondName = "Teovaldo ",
            SurName = "Detal",
            SecondSurname ="",
            SubAreaId = "asddfad23345fw333"
          }
        };

        public static EmpleadoViewModel empleadoViewModel1 = new EmpleadoViewModel()
        {
             Id = "adshfkja238d8drtrt73s",
            TypeIdentification = 2,
            IdentificationNumber = "23452677",
            Name = "Perensejo",
            SecondName = "Teovaldo ",
            SurName = "Detal",
            SecondSurname ="",
            SubAreaId = "asddfad23345fw333"
        };
    }
}