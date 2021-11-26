using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Bienvenidos a ITFS 11 venta de ropa deportiva en la cuidad de Buenos Aires ");
    
    while(true){

    int NUM = 0;
    string RESUL = null;
    string cadena;
    Program ob=new Program ();
    Console.Write("DIGITE opcion que desea, ingreso como : \n ADMINISTRADOR (1), USUARIO (2) :   ");
    cadena = Console.ReadLine();
    NUM = int.Parse(cadena);
    RESUL = ob.opcion(NUM);
    Console.WriteLine();   
    
    Console.WriteLine("Desea Continuar? Y/N");
  string respuesta = Console.ReadLine();

  if(respuesta == "N")
    break;

}

  }
            private string opcion(int DIA)
                    {
                    string R = null;
                    switch (DIA)
                    {
                    case 1:                   
                    
                        Console.Write("Carga de datos de los clubes : \n");
                        Program pv = new Program();
                         pv.Cargar();

                        break;
                    case 2:
                      
                        Console.Write("INGRESO COMO USUARIO : \n");
                        int NUM = 0;
                        string RESUL = null;
                        string cadena;
                        Program ob=new Program ();
                        Console.Write("DIGITE opcion que desea,: \n Cantidad de clubes registrados(1) \n Añadir un Club (2) \n Clubes ordenados por ID (3) \n Clubes ordenados por nombre (4) \n Informacion del club por ID (5) \n Clubes ordenados por cantidad de socios (6) \n Reporte de clubes con cierta actividad deportiva(7) \n Clubes con página web ordenado por Comuna (8) \n Club con mayor cantidad de socios  (9)\n :::  ");
                        cadena = Console.ReadLine();
                        NUM = int.Parse(cadena);
                        RESUL = ob.opcion1(NUM);
                        Console.WriteLine();
                        
                        break;
                    default:
                    R = "FUERA DE RANGO";
                        break;
                    
                    }
                    return (R);
                    }

            
              private string[] nombres; 
              private int[] id1;  
              private string[] tipo; 
              private string[] sede;
              private int[] cantSocio;
              private string[] barrio;
              private int[] comuna;
              private string[] domicilio;
              private int[] telefono;
              private string[] email;
              private string[] web;
              private string[] actividad;


            public void Cargar()
        {
            
            nombres = new string[5];
            id1 = new int[5];
            tipo = new string [5];
            sede = new string [5];
            cantSocio = new int [5];
            barrio= new string [5];
            comuna = new int [5];
            domicilio = new string [5];
            telefono = new int [5];
            email = new string [5];
            web = new string [5];
            actividad= new string [5];


            for (int f = 0; f< nombres.Length; f++)
            {
                Console.Write("Ingrese el nombre del Club "+(f+1)+" : ");
                nombres[f] = Console.ReadLine();
                Console.Write("Ingrese el ID del club "+(f+1)+" : ");
                string linea;
                linea = Console.ReadLine();
                id1[f] = int.Parse(linea);
                Console.Write("Ingrese el tipo de Institucion (Club o Club de Barrio) del club  "+(f+1)+" : ");//
                tipo[f] = Console.ReadLine();
                Console.Write("Ingrese  SEDE (Central – Única – Anexo - Polideportivo) del club  "+(f+1)+" : ");//
                sede[f] = Console.ReadLine();
                Console.Write("Ingrese Cantidad de socios del club "+(f+1)+" : ");
                 linea = Console.ReadLine();
                cantSocio[f] = int.Parse(linea);
                Console.Write("Ingrese  Barrio  del club "+(f+1)+" : ");//
                barrio[f] = Console.ReadLine();
                Console.Write("Ingrese Comuna (Identificado por un número entero) del club "+(f+1)+" : ");
                 linea = Console.ReadLine();
                comuna[f] = int.Parse(linea);
                Console.Write("Ingrese Domicilio del club "+(f+1)+" : ");//
                domicilio[f] = Console.ReadLine();
                Console.Write("Ingrese telefono del club "+(f+1)+" : ");
                 linea = Console.ReadLine();
                 telefono[f] = int.Parse(linea);
                 Console.Write("Ingrese E-mail del club "+(f+1)+" : ");//
                email[f] = Console.ReadLine();
                Console.Write("Ingrese Pagina Web del club "+(f+1)+" : ");//
                web[f] = Console.ReadLine();
                Console.Write("Ingrese Actividades (Fútbol – Básquet – Natación – Voley – Tenis – Artes Marciales).del club "+(f+1)+" : ");//
                actividad [f] = Console.ReadLine();

            }
        }
            
               private string opcion1(int DIA)
                    {
                    string R = null;
                    switch (DIA)
                    {
                      case 1:
                      int [] id3 = {
                                1001,
                                1042,
                                1553,
                                1123,
                                0004,
                                2345,
                             };
                          
                      
                          Console.Write(" las Cantidad de clubes registrados es : ");

                          int longitudConLength = id3.Length;
                          Console.WriteLine( longitudConLength);
                          
                          break;
                       case 2:
                       
                                                                    
                         string[] Club1 = {
                                "Boca",
                                "River",
                                "Racing",
                                "Independiente",
                                "Velez",
                                "San Lorenzo",
                         };
                          
                           Console.Write(" Añadir un Club   : ");
                           break;

                       case 3:
                    
                    
                        Console.Write(" Clubes ordenados por ID : ");
                        
                        int [] id2 = {
                                1001,
                                1042,
                                1553,
                                1123,
                                0004,
                                2345,
                             };
                        string [] nombres1 ={
                              "Boca ",
                               "River ",
                               "Racing ",
                               "Independiente ",
                               "Velez ",
                               "San Lorenzo ",
                            
                        };

                                 int t;
                                for (int a = 1; a < id2.Length; a++){
                                    for (int b =id2.Length - 1; b >= a; b--)
                                    {
                                        if (id2[b-1] > id2[b])
                                        {
                                            t = id2[b - 1];
                                            id2[b - 1] = id2[b];
                                            id2[b] = t;
                                        }
                                    }
                                  } 


                                    Console.WriteLine("\n");
                                    for (int f = 0; f < id2.Length; f++)
                                    {
                                        Console.Write(id2[f]+"   "+ nombres1[f ]+" \n " );
                                    }
                                    Console.ReadKey();
                                    
                        break;
                         case 4:
                    
                    
                        Console.Write(" Clubes ordenados por nombre  : \n");
                        //
                        string[] Club = {
                                "Boca",
                                "River",
                                "Racing",
                                "Independiente",
                                "Velez",
                                "San Lorenzo",
                              };
                              // 
                              Comparison<string> comparador = new Comparison<string>((cadena1, cadena2) => cadena1.CompareTo(cadena2));
                              // 
                              Array.Sort<string>(Club, comparador);
                              // 
                              foreach(string C in Club){
                                Console.WriteLine(C);
                              }
                              
                        //
                        break;
                         case 5:
                    
                    
                        Console.Write(" Informacion del club por ID : ");
                        //
                        break;
                         case 6:
                    
                    
                        Console.Write(" Clubes ordenados por cantidad de socios : \n");
                        int [] cant = {
                                190012,
                                39042,
                                88553,
                                99123,
                                55004,
                                77345,
                              };
                        string [] nombres2 ={
                               "Boca ",
                               "River ",
                               "Racing ",
                               "Independiente ",
                               "Velez ",
                               "San Lorenzo ",  
                        };   
                                 int c;
                                for (int a = 1; a < cant.Length; a++){
                                    for (int b =cant.Length - 1; b >= a; b--)
                                    {
                                        if (cant[b-1] > cant[b])
                                        {
                                            c = cant[b - 1];
                                            cant[b - 1] = cant[b];
                                            cant[b] = c;
                                        }
                                    }

                                  } 

                                    Console.WriteLine(" \n");
                                    for (int f = 0; f < cant.Length; f++)
                                    {
                                        Console.Write(cant[f]+"  " + nombres2[f ]+" \n ");
                                    }
                                    Console.ReadKey();
                        
                        break;
                         case 7:                    
                    
                        Console.Write(" Reporte de clubes con cierta actividad deportiva :");
                        
                        break;
                         case 8:                    
                    
                        Console.Write(" Clubes con página web ordenado por Comuna : ");
                        
                        break;
                         case 9:
                         //9.	Como usuario quiero tener un reporte que diga el Id y nombre, del Club que mayor cantidad de socios tiene.
                          // cantSocio

                    
                        Console.Write(" Club con mayor cantidad de socios : ");
                        
                        break;



                        
                    default:
                    R = "FUERA DE RANGO";
                        break;
                    
                    }
                    return (R);
                    }
        

}