    using WebApp.Models;

    namespace WebApp.Services
    {
        public class ProyectoresEnMemoriaService : IProyectoresService
        {
             private static List<Proyector>_proyectores=LoadData();

            public void AddProyector(Proyector proyector) 
            {
                if(proyector != null)
                {
                    _proyectores.Add(proyector);
                }
            }
            public IEnumerable<Proyector> GetAll()
            {
                return _proyectores;
            }

            private static List<Proyector> LoadData()
            {
                var proyectores = new List<Proyector>();

                proyectores.Add(new Proyector()
                {
                    Id = 1,
                    Marca = "Epson",
                    Modelo = "ligth",
                    NumeroDeSerie = "123456",
                    Situacion = SituacionProyector.Bueno,
                    FechaDeAlta = DateTime.Now,
                    FechDeBaja = DateTime.Now
                });

                proyectores.Add(new Proyector()
                {
                    Id = 2,
                    Marca = "Hp",
                    Modelo = "Ultra",
                    NumeroDeSerie = "456789",
                    Situacion = SituacionProyector.Regular,
                    FechaDeAlta = DateTime.Now,
                    FechDeBaja = DateTime.Now
                });

                proyectores.Add(new Proyector()
                {
                    Id = 3,
                    Marca = "Luna",
                    Modelo = "ligth",
                    NumeroDeSerie = "123456",
                    Situacion = SituacionProyector.Malo,
                    FechaDeAlta = DateTime.Now,
                    FechDeBaja = DateTime.Now
                });

                proyectores.Add(new Proyector()
                {
                    Id = 4,
                    Marca = "Epson",
                    Modelo = "ligth",
                    NumeroDeSerie = "123456",
                    Situacion = SituacionProyector.Bueno,
                    FechaDeAlta = DateTime.Now,
                    FechDeBaja = DateTime.Now
                });

                proyectores.Add(new Proyector()
                {
                    Id = 5,
                    Marca = "Epson",
                    Modelo = "ligth",
                    NumeroDeSerie = "123456",
                    Situacion = SituacionProyector.Regular,
                    FechaDeAlta = DateTime.Now,
                    FechDeBaja = DateTime.Now
                });
                return proyectores;
            }

        }
    }
