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
                //details  like ACV
                

                
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

                //preventions
                Prevention pregnancy = new Prevention()
                {

                    Kind = "Prevencion",
                    Name = "Embarazo",
                    Description = "Inicio ( esta info va en la parte de inicio de la pagina) La gente se preocupa muy poco por las discapacidades,                    excepto cuando alguien muy querido se convierte en una persona con discapacidad.Entonces su primera preocupación es ayudar a esa persona.Después de que hemos ayudado a una familia a hacer algo por su niño con discapacidad,                    podemos interesarla en hacer algo para prevenir las discapacidades en otros miembros de la familia o la comunidad.Para prevenir las discapacidades que resultan de la pobreza hacen falta grandes cambios en nuestra sociedad.Se necesita que haya una más justa distribución de la tierra,                    los recursos,                    la información y el poder.Estos cambios sólo sucederán cuando los pobres tengan el valor de organizarse,                    trabajar juntos y pelear por sus derechos.Las personas con discapacidad y sus familias pueden llegar a ser líderes en este proceso.Sólo a través de una sociedad más justa podremos encontrar las maneras de prevenir,                    ampliamente y a largo plazo,                   las discapacidades causadas por la pobreza. Inicio prevención(solo cuando se abre la pestaña de prevención aparecerá esta info como segundo inicio) ¿QUIEN DEBE SER RESPONSABLE DE LA PREVENCIÓN DE DISCAPACIDADES ? Note que muchas de las medidas preventivas que hemos discutido,                    al igual que las medidas sociales más generales,                    dependen de una mayor conciencia y participación comunitaria,                    y de nuevas maneras de ver las cosas.Los cambios no suceden por sí mismos.Para realizarlos es necesario un proceso de educación,                    organización y lucha guiado por las personas con el mayor interés y preocupación.La mayoría de las personas que no tienen discapacidad no se preocupan ni por las discapacidades,                    ni por su prevención.Muchas veces piensan, “¡No,                    eso nunca me podría pasar!”—hasta que por desgracia les sucede algo.Usualmente,                    quienes se preocupan más por las discapacidades son las mismas personas con discapacidad y sus familiares.Basándose en su interés,                    ellos pueden llegar a ser líderes y educadores,                    y ayudar a prevenir las discapacidades en su comunidad. Inicio de prevención de deficiencias y discapacidad en etapa de embarazo El embarazo es el período que transcurre entre la implantación del cigoto en el útero,                    hasta el momento del parto,                    en cuanto a los significativos cambios fisiológicos,                    metabólicos e incluso morfológicos que se producen en la mujer encaminados a proteger,                    nutrir y permitir el desarrollo del feto,                    como la interrupción de los ciclos menstruales,                    o el aumento del tamaño de las mamas para preparar la lactancia.El término gestación hace referencia a los procesos fisiológicos de crecimiento y desarrollo del feto en el interior del útero materno. Durante esta etapa la madre debe evitar el consumo de medicamentos,                    alimentos y bebidas nocivas para el desarrollo del feto,                    causas por las cuales nacen infantes con discapacidad o son propensos a adquirirlas en el transcurso de sus primeros años de vida.",
                };
                context.Preventions.Add(pregnancy);

                Prevention accident = new Prevention()
                {

                    Kind = "Prevencion",
                    Name = "Accidente",
                    Description = "Prevención contra accidentes Es un acontecimiento fortuito,                    generalmente desgraciado o dañino,                    independiente de la voluntad humana,                    provocado por una fuerza exterior que actúa rápidamente y que se manifiesta por la aparición de lesiones orgánicas o trastornos mentales.El accidente supone una falta de previsión. Los accidentes se ubican entre las cinco primeras causas de muerte en niños y ancianos de 20 países de América Latina y el Caribe,                    incluyendo a Cuba.",
                };
                context.Preventions.Add(accident);

                Prevention violence = new Prevention()
                {

                    Kind = "Prevencion",
                    Name = "Violencia",
                    Description = "La Organización Mundial de la Salud define la violencia como: El uso intencional de la fuerza o el poder físico, de hecho, o como amenaza, contra uno mismo, otra persona o un grupo o comunidad, que cause o tenga muchas probabilidades de causar lesiones, muerte, daños psicológicos, trastornos del desarrollo o privaciones. Tipos de violencia La clasificación de la OMS, divide la violencia en tres categorías generales, según las características de los que cometen el acto de violencia: – la violencia autoinfligida (comportamiento suicida y autolesiones), – la violencia interpersonal (violencia familiar, que incluye menores, pareja y ancianos; así como violencia entre personas sin parentesco), – la violencia colectiva (social, política y económica). La naturaleza de los actos de violencia puede ser: física, sexual, psíquica, lo anteriores incluyen privaciones o descuido. La violencia se presenta en distintos ámbitos,                     por ejemplo,                     la violencia en el trabajo,                    que incluye no sólo el maltrato físico sino también psíquico.Muchos trabajadores son sometidos al maltrato,                    al acoso sexual,                    a amenazas,                    a la intimidación y otras formas de violencia psíquica.En investigaciones efectuadas en el Reino Unido se ha comprobado que 53 % de los empleados han sufrido intimidación en el trabajo,                    y 78 % han presenciado dicho comportamiento.Los actos repetidos de violencia desde la intimidación,                    el acoso sexual y las amenazas hasta la humillación y el menosprecio de los trabajadores pueden convertirse en casos muy graves por efecto acumulativo.En Suecia,                    se calcula que tal comportamiento ha sido un factor en 10 % a 15 % de los suicidios. Otro caso es el de la violencia juvenil,                    que daña profundamente no solo a las víctimas,                    sino también a sus familias,                    amigos y comunidades.Sus efectos se ven no solo en los casos de muerte,                    enfermedad y discapacidad,                    sino también en la calidad de vida.La violencia que afecta a los jóvenes incrementa enormemente los costos de los servicios de salud y asistencia social,                    reduce la productividad,                    disminuye el valor de la propiedad,                    desorganiza una serie de servicios esenciales y en general socava la estructura de la sociedad.Se presenta la violencia juvenil en personas cuyas edades van desde los 10 y los 29 años.No obstante,                    las tasas altas de agresión y victimización a menudo se extienden hasta el grupo de 30 a 35 años de edad y este grupo de jóvenes adultos de más edad también debe ser tenido en cuenta al tratar de comprender y evitar la violencia juvenil.En 2000,                    se produjeron a nivel mundial unos 199 000 homicidios de jóvenes(9, 2 por 100 000 habitantes).En otras palabras,                    un promedio de 565 niños,                    adolescentes y adultos jóvenes de 10 a 29 años de edad mueren cada día como resultado de la violencia interpersonal.Las tasas de homicidios varían considerablemente según la región y fluctúan entre 0,                    9 por 100 000 en los países de ingreso alto de Europa y partes de Asia y el Pacífico a 17,                    6 por 100 000 en África y 36,                    4 por 100 000 en América Latina.En México,                    donde las agresiones con armas de fuego provocan más o menos el 50 % de los homicidios de jóvenes,                    las tasas permanecieron altas,                    aumentando de 14,                    7 por 100 000 a 15,                    6 por 100 000.Entre los principales factores de la personalidad y del comportamiento que pueden predecir la violencia juvenil están la hiperactividad,                    la impulsividad,                    el control deficiente del comportamiento y los problemas de atención.Curiosamente la nerviosidad y la ansiedad están relacionadas negativamente con la violencia.",
                };
                context.Preventions.Add(violence);

                Right oms = new Right()
                {
                    Title = "Derechos OMS",
                    Description = "Describe los derechos segun la OMS -Organizacion Mundial de la Salud",
                    FilePdf = "20190122180032-derechos-pcd-onu.pdf",
                };
                context.Rights.Add(oms);

                Right nationalLaw = new Right()
                {
                    Title = "Derechos segun la Ley 223 pcd",
                    Description = "La Ley Nacional 223 para personas con discapacidad",
                    FilePdf = "20190122180327-ley-223-general-para-personas-con-discapacidad.pdf",
                };
                context.Rights.Add(nationalLaw);

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
