using System.Collections.Generic;
int menu;
do{
    System.Console.WriteLine("1. Nueva inscripcion \n2.Obtener estadisticas del evento \n3.Buscar cliente \n4.Cambiar entrada de un cliente./n5.Salir");
    menu = int.Parse(Console.ReadLine());
    switch(menu){
        case 1:
        CargarCliente();
        break;
        case 2:
        ObtenerEstadisticas();
      
        break;
        case 3:
        
        break;
        case 4:
        CambiarEntrada();
        break;
    }
}while(menu!=5);
Clientes CargarCliente()
{
 int dni = Funciones.IngresarEntero("ingrese su dni");
 string nom = Funciones.IngresarTexto("ingrese su nombre");
 string ape = Funciones.IngresarTexto("ingrese su apellido");
 int TE = Funciones.IngresarEntero("elija que entrada quiere comprar \n opcion 1: Dia 1, valor a abonar $15000 \n opcion 2: Dia 2, valora a abonar $30000 \n opcion3: Dia 3, valor a abonar 10000 \n opcion4: Full Pass, valor a abonar 40000");
 while (TE<=0 || TE>4)
 {
   TE = Funciones.IngresarEntero("elija que entrada quiere comprar \n opcion 1: Dia 1, valor a abonar $15000 \n opcion 2: Dia 2, valora a abonar $30000 \n opcion3: Dia 3, valor a abonar 10000 \n opcion4: Full Pass, valor a abonar 40000");
 }  
 int TA = 0;
 if (TE == 1)
 {
  TA = 15000;
 }else if (TE == 2){
   TA = 30000;
  }
  else if (TE == 3){
   TA = 10000;
  }
  else if (TE == 4){
   TA = 40000;
  }
  else Console.WriteLine("Ese tipo de entrada no existe");
 DateTime FI = Funciones.IngresarFecha("Cuando fue que usted se inscribio");
 Clientes  cliente = new Clientes ( dni,  ape,  nom,  TE,  TA , FI );

 return cliente;
}

void ObtenerEstadisticas()
{
    foreach (string msj in Tiquetera.EstadisticasTiquetera(TA))
    {
        Console.WriteLine(msj);
    }
}
void CambiarEntrada()
{
    int iDCliente = Funciones.IngresarEntero("Ingrese el ID del cliente que desea buscar");
    int TipoEntrada = Funciones.IngresarEntero("Ingrese el tipo de entrada que desea; debe ser más cara que la adquirida");
    bool puede = Tiquetera.CambiarEntrada(iDCliente, TipoEntrada);
    if (puede == true) Console.WriteLine("Cambio hecho");
    else Console.WriteLine("no es posible el cambio que desea.");
}

void BuscarCliente()
{
    int iDCliente = Funciones.IngresarEntero("Ingrese el ID del cliente que desea buscar");
   Clientes cliliente = Tiquetera.BuscarCliente(iDCliente);
    if (cliliente == null) Console.WriteLine("Ese ID todavía no está creado");
    else
    {
        Console.WriteLine("DNI: " + cliliente.DNI);
        Console.WriteLine("Nombre: " + cliliente.Nombre);
        Console.WriteLine("Apellido: " + cliliente.Apellido);
        Console.WriteLine("Fecha de inscripción: " + cliliente.FechaInscripcion);
        Console.WriteLine("Tipo entrada: " + cliliente.TipoEntrada);
        Console.WriteLine("Total abonado: " + cliliente.TotalAbonado);
    }
}