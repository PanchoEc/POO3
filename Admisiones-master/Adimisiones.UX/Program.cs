using Admisiones.Logic;

var carrerOne = new CarrerPresential() { 
    Name="Desarrollo de Software",
    Description="Ebcargada del desarrollo",
    ValorSemestre=510.00m,
    TipoCarrera=TipoCarreras.Online,   
};

var carrerDos = new CarrerPresential()
{
    Name = "Desarrollo de Aplicaciones Web",
    Description = "Ebcargada del desarrollo",
    ValorSemestre = 510.00m,
    TipoCarrera = TipoCarreras.Presencial,
};

var carrerTree = new CarrerPresential()
{
    Name = "Ventas",
    Description = "E",
    ValorSemestre = 510.00m,
    TipoCarrera = TipoCarreras.Online,
};

List<Carrer> carreras = new List<Carrer>() { carrerOne};
carreras.Add(carrerDos);
carreras.Add(carrerTree);

var carr_oresen = carreras.FindAll(carr => carr.TipoCarrera == TipoCarreras.Presencial );

//carreras.RemoveAll(carr => carr.Name == "Desarrollo de Aplicaciones Web");

foreach (var item in carr_oresen)
{
    Console.WriteLine(item);
}





