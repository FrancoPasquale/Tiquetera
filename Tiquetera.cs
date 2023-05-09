using System.Collections.Generic;
class Tiquetera
{
    private static Dictionary<int,Clientes> DicClientes = new Dictionary<int, Clientes>();
    private static int UltimoIDEntrada = 0;
    public static int DevolverUltimoID()
    {
        return UltimoIDEntrada;
    }
    public static int AgregarCliente(Clientes item)
    {
        UltimoIDEntrada++;
       DicClientes.Add(UltimoIDEntrada, item);

       return UltimoIDEntrada;
    }
    public static Clientes BuscarCliente(int IDEntrada)
    {
        if(DicClientes.ContainsKey(IDEntrada))
        {
            return DicClientes[IDEntrada];
        }else return null;
    }

   public static bool CambiarEntrada(int IDEntrada, int tipo, int total)
    {
        bool  puede = false;
      if(DicClientes.ContainsKey(IDEntrada))
        {
         puede = true;
           DicClientes[IDEntrada].TipoEntrada =tipo;
        DicClientes[IDEntrada].TotalAbonado = total;    
        }else System.Console.WriteLine("este id no compro entrada, ponga el id correcto");
        
        
        return puede;
    }
    

    List<string> EstadisticasTiquetera = new List<string> ();
     if (DicClientes.Count() != 0)
        {
            int[] Entradas = { 0, 0, 0, 0, 0 };
            int[] porcentajeEntradas = new int[5];
            int recaudado = 0;
            string Porcentajes = "";
            foreach (Cliente Cliente in DicClientes.Values)
            {
                Entradas[Cliente.TipoEntrada]++;
            }
            for (int i = 1; i < Entradas.Length; i++)
            {
                Porcentajes[i] = Entradas[i] * 100 / DicClientes.Count;
                Porcentajes + ("   Porcentaje Opcion " + i + " %" + porcentajeEntradas[i]);
                totalRecaudado +Entradas[i] * preciosEntradas[i];
            }
            EstadisticasTicketera.Add(Porcentajes);
            EstadisticasTicketera.Add("Cantidad de clientes: " + DicClientes.Count);
            EstadisticasTicketera.Add("Total recaudado: $" + recaudado);
        }
        else EstadisticasTicketera.Add("Aún no se anotó nadie");
        return EstadisticasTicketera;
}