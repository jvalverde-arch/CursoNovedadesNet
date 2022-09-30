using CursoNovedades.Net;
using static CursoNovedades.Net.ExpresionSwicth;

ExpresionSwicth swicth = new ExpresionSwicth();

//swicth.ImprimirMedida(20);
//swicth.ImprimirMedida(10);

//swicth.ImprimirMedida(double.NaN);

//swicth.ImprimirMedida(-5);

//swicth.AsignarDiaSwitchTradicional(1);

//swicth.AsignarDiaSwitchTradicional(2);

//swicth.AsignarDiaSwitchTradicional(3);

//swicth.AsignarDiaSwitchTradicional(4);

//swicth.AsignarDiaSwitchTradicional(5);

//swicth.AsignarDiaSwitchTradicional(6);

//swicth.AsignarDiaSwitchTradicional(7);

//swicth.AsignarDiaExpresionSwitchl(1, "diruno");

//swicth.AsignarDiaExpresionSwitchl(3, "nocturno");

//var direction = Direction.Up;
//Console.WriteLine($"La dirección es  {direction}");
//Console.WriteLine($"La orientación cardinal es {ToOrientation(direction)}");


//int num = 1;

//string otraCadena = "";
//otraCadena = num switch
//{
//    1=>"Jorge",
//    2=>"Marco",
//    _=>"Desconocido"

//};

//Tipos por referencia anulables.
//TiposReferenciaNullables tipos = new TiposReferenciaNullables();


////Por valor
//int i = 5;
//Console.WriteLine(tipos.Suma2(i));
//Console.WriteLine(i);


//// Por referencia
//Persona p = new Persona();
//p.Nombre = "Antonio";
//p.Apellidos = "López";
//p.Edad = 27;

//tipos.CambiaNombre(p);
//Console.WriteLine(p.Nombre);
//Console.ReadLine();


//string? nullableString = "Nulos son permitidos";
//string notNullableString = "Nulos no son permitidos";
//nullableString = null;
//notNullableString = null;
//Console.WriteLine(nullableString.Length + notNullableString.Length);



//#nullable enable
//string? nullableString1 = "Nulls are welcome!";
//string notNullableString1 = "Nulls are not welcome!";
//nullableString = null; // Ok, we allow nulls
//notNullableString = null; // Warning!
//Console.WriteLine(nullableString1.Length + notNullableString1.Length); // Warning!

//Ahora volvemos a aplicar la configuración a nivel de proyecto
#nullable restore

ConsumoMicroService service = new ConsumoMicroService();
service.ConsultarProductos();

Console.ReadLine();

