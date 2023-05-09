
class Clientes
{
public int DNI {get; private set;}
public string Apellido {get;private set;}
public string Nombre {get; private set;}
public DateTime FechaInscripcion {get;set;}
public int TipoEntrada { get; set;}
public int TotalAbonado {get;set;}

public Clientes (int dni, string ape, string nom, int TE, int TA ,DateTime FI = new DateTime)
{
 DNI=dni;
 Apellido=ape;
 Nombre=nom;
 TipoEntrada=TE;
 TotalAbonado=TA;
 FechaInscripcion=FI;

}





}