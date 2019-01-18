using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JulioRivero.Tesis.Entities;
using System.Data.Entity;
//using JulioRivero.Tesis.WebMVC;

namespace JulioRivero.Tesis.EFContext
{
    public class TesisContext:DbContext
    {
       
        public TesisContext():base("name=DefaultConnection")
        {
            // Database.SetInitializer<TesisContext>(new DropCreateDatabaseIfModelChanges<TesisContext>());
            //  Database.SetInitializer<TesisContext>(new CreateDatabaseIfNotExists<TesisContext>());
            Database.SetInitializer<TesisContext>(new UniDBInitializer<TesisContext>());
        }

        public DbSet<Impairment> Impairments { get; set; }
        public DbSet<Deficiency> Deficiencys { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Right> Rights { get; set; }
        public DbSet<Prevention> Preventions { get; set; }
        public DbSet<IntoPrevention> IntoPreventions { get; set; }
        //
        private class UniDBInitializer<T> : CreateDatabaseIfNotExists<TesisContext>
        {
            protected override void Seed(TesisContext context)
            {
                Impairment acquired = new Impairment()
                {

                    Kind = "Discapacidad",
                    Name = "Adquiridas",
                    Description = "Las discapacidades adquiridas son aquellas que se presentan en las personas a lo largo del tiempo o por traumatismos provocados por imprudencia, produciendo de este modo que se adquiera una deficiencia de acuerdo a la gravedad del accidente o tiempo.",
                };
                context.Impairments.Add(acquired);

                //audiovisuales
                Impairment audiovisuales = new Impairment()
                {

                    Kind = "Discapacidad",
                    Name = "Audiovisuales",
                    Description = "La vista, desde el momento del nacimiento, es un canal sensorial social. Según estudios realizados, hasta los doce años la mayoría de las nociones aprendidas se captan a través de las vías visuales, en una proporción del 83%, frente a los estímulos captados por los otros sentidos, que se reparten entre el 17% de los restantes. Los ojos que comienzan captando tan sólo un juego de luces y sombras,                     activan zonas del cerebro que emiten respuestas motrices,                    y esta actividad sensorio - motriz es la clave del desarrollo del niño / a.Lo que el ojo ve,                    quiere tocarlo con la mano y cuando ha tocado aquello,                    quiere ir más lejos.A la primera etapa de concentración visual sigue otra de atención,                    y a estas dos una tercera de reconocimiento visual.Los sentidos funcionan en cinestesia,                    esto es,                    en dos o más modalidades ligadas.Ni aún el primer sentido en desarrollarse,                    el tacto,                    funciona de forma pura. La audición es el sentido que permite al ser humano ponerse en contacto con el medio ambiente,                    a través del funcionamiento del oído el cual trabaja para captar,                    transmitir y procesar información sonora.Esta información incluye todos los sonidos del ambiente,                    los mas bajos,                    los mas altos,                    los mas intensos,                    los menos intensos,                    los mas lejanos,                    los mas cercanos,                    y sobre todo,                    los mas complejos que puede recibir un ser humano,                    como son los sonidos del habla.",
                };
                context.Impairments.Add(audiovisuales);

                Impairment cognitive = new Impairment()
                {

                    Kind = "Discapacidad",
                    Name = "Cognitivas",
                    Description = "Discapacidad cognitiva o intelectual, también conocido como retraso mental, es un término utilizado cuando una persona no tiene la capacidad de aprender a niveles esperados y funcionar normalmente en la vida cotidiana. En los niños, los niveles de discapacidad intelectual varían ampliamente, desde problemas muy leves hasta problemas muy graves. Los niños con discapacidad intelectual puede que tengan dificultad para comunicar a otros lo que quieren o necesitan, así como para valerse por sí mismos. La discapacidad intelectual podría hacer que el niño aprenda y se desarrolle de una forma más lenta que otros niños de la misma edad. Estos niños podrían necesitar más tiempo para aprender a hablar, caminar, vestirse o comer sin ayuda y también podrían tener problemas de aprendizaje en la escuela.",
                };
                context.Impairments.Add(cognitive);

                Impairment congenital = new Impairment()
                {

                    Kind = "Discapacidad",
                    Name = "Congénitas",
                    Description = "Las enfermedades congénitas, son enfermedades estructurales o funcionales presentes en el momento del nacimiento. El desarrollo embrionario y fetal puede ser alterado por diversos factores externos como: radiaciones, calor, sustancias químicas, infecciones y enfermedades maternas. Estos agentes externos se llaman teratógenos (del griego teratos, 'monstruo', y genes, 'nacimiento').  Las anomalías congénitas también pueden ser causadas por una alteración genética  del feto, o por la acción conjunta de un agente teratógeno y una alteración genética. Más del 20 % de los fetos malformados terminan en aborto espontáneo; el resto nacen con una enfermedad congénita.Hasta un 5 % de los recién nacidos presenta algún tipo de anomalía congénita, y éstas son causa del 20 % de las muertes en el periodo post-natal.Un 10 % de las enfermedades congénitas son hereditarias por alteración de un solo gen; otro 5 % son causadas por alteraciones en los cromosomas. Las enfermedades genéticas corresponden a un grupo heterogéneo de afecciones que en su etiología presentan un significativo componente genético.Ello puede ser alguna alteración en un solo gen(monogénicas), en varios genes(multifactoriales) o en muchos genes (cromosomas). La alteración genética puede producir directamente la enfermedad(por ejemplo, el caso de la Hemofilia) o interactuar con factores ambientales(como por ejemplo, la predisposición genética en la etiología de la Hipertensión arterial). Cada vez se hace más difícil separar las afecciones de etiología ambiental de aquellas llamadas \"genéticas puras\". A modo de ejemplo, conviene recordar que para varias enfermedades típicamente ambientales, como infecciones bacterianas, parasitarias, virales, etc, recientemente se ha demostrado una susceptibilidad genética individual. ",
                };
                context.Impairments.Add(congenital);
                
                Impairment hereditary = new Impairment()
                {

                    Kind = "Discapacidad",
                    Name = "Hereditarias",
                    Description = "Derivan de un ADN con alteración en los genes de los (el padre y/o la madre) padres, de manera que las células del embrión son portadoras del ADN defectuoso, siendo transmisibles a las sucesivas generaciones. Por ejemplo: Hemofilia, Anemia falciforme, fibrosis quística, distrofia muscular de Duchesne.",
                };
                context.Impairments.Add(hereditary);

                Impairment fisomotor = new Impairment()
                {

                    Kind = "Discapacidad",
                    Name = "Fisicomotoras",
                    Description = "es importante que entiendas la función del sistema nervioso, porque en la discapacidad motriz intervienen las funciones cerebrales que envían información al cuerpo a través de los nervios, sobre cómo moverse y por qué es necesaria la interpretación adecuada de las sensaciones que llegan a él. Comenzaremos explicándote que el cerebro cumple con tres funciones principales: a) Sensitiva.El cerebro es capaz de sentir determinados cambios o estímulos del interior del organismo, es decir, el medio interno(como un dolor de estómago); también fuera de él, es decir, el medio externo(por ejemplo, una gota de lluvia que cae en la mano o el perfume de una rosa). b) Integradora.La información sensitiva se analiza, se almacenan algunos aspectos y se toman decisiones de la conducta a seguir. c) Motora.Es la respuesta que el cerebro organiza a partir de los estímulos; por ejemplo, contracciones musculares, movimientos o secreciones glandulares como la salivación al ver un alimento. Las causas del daño cerebral que interfiere con la motricidad se clasifican de acuerdo con la etapa en que se presentan:                a) Prenatales o antes del nacimiento.Incluyen malformaciones con las que nacen los bebés (por convulsiones maternas). Ocurren cuando la sangre de la madre es diferente a la sangre del bebé; también por la exposición a la radiación o a sustancias tóxicas, restricción del crecimiento en la etapa de formación del bebé, infecciones o presión alta durante el embarazo o embarazo múltiple(gemelos, triates, etcétera).               b) Perinatales o durante el nacimiento.Ejemplos: nacimiento prematuro (antes de las 32 semanas de embarazo), falta de oxígeno(asfixia o hipoxia neonatal), mala posición del bebé, infecciones en el sistema nervioso central o hemorragia cerebral. c) Posnatales.Se debe principalmente a golpes en la cabeza, convulsiones, toxinas e infecciones virales o bacterianas que afectan el sistema nervioso central.",
                };
                context.Impairments.Add(fisomotor);

                /*  CarPark cpOne = new CarPark()
                  {
                      CreatedOn = DateTime.Parse(DateTime.Today.ToString()),
                      Status = "active",
                      Observation = "created by default",
                      Name = "Parqueo 6 DE AGOSTO",
                      Address = "Qllo. calle 6 de Agostso Nro: 123",
                      CapacityCars = 20,
                  };
                  context.CarParks.Add(cpOne);

                  IList<Parking> parkings = new List<Parking>();

                  for (int i = 0; i < cpOne.CapacityCars; i++)
                  {
                      parkings.Add(new Parking
                      {
                          CreatedOn = DateTime.Parse(DateTime.Today.ToString()),
                          Status = "active",
                          Observation = "created by default",
                          CodeName = (i + 1).ToString(),
                          Free = true
                      });
                  }
                  foreach (Parking student in parkings)
                      context.Parkings.Add(student);*/

                base.Seed(context);
            }
        }

        // public System.Data.Entity.DbSet<JulioRivero.Tesis.WebMVC.Models.IntoPreventionViewModel> IntoPreventionViewModels { get; set; }

        // public System.Data.Entity.DbSet<JulioRivero.Tesis.WebMVC.Models.PreventionViewModel> PreventionViewModels { get; set; }

        //public System.Data.Entity.DbSet<JulioRivero.Tesis.WebMVC.Models.IntoPreventionViewModel> IntoPreventionViewModels { get; set; }

        // public System.Data.Entity.DbSet<JulioRivero.Tesis.WebMVC.Models.PreventionViewModel> PreventionViewModels { get; set; }

        // public System.Data.Entity.DbSet<JulioRivero.Tesis.WebMVC.Models.RightViewModel> RightViewModels { get; set; }

        // public System.Data.Entity.DbSet<JulioRivero.Tesis.WebMVC.Models.RightViewModel> RightViewModels { get; set; }

        // public System.Data.Entity.DbSet<JulioRivero.Tesis.WebMVC.Models.RightViewModel> RightViewModels { get; set; }

        //public System.Data.Entity.DbSet<JulioRivero.Tesis.WebMVC.Models.RoleViewModel> RoleViewModels { get; set; }

        // public System.Data.Entity.DbSet<JulioRivero.Tesis.WebMVC.Models.RoleViewModel> RoleViewModels { get; set; }


        // public System.Data.Entity.DbSet<JulioRivero.Tesis.WebMVC.Models.ImparirmentViewModel> ImparirmentViewModels { get; set; }
    }
}
