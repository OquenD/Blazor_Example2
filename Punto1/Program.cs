﻿using ENTREGABLE2.Classes;


//Creacion de Monoplazas
MonoplazaFerrari MonoFerrari = new MonoplazaFerrari();
MonoFerrari.scuderia="Ferrari";
MonoplazaMclaren MonoMclaren = new MonoplazaMclaren();
MonoMclaren.scuderia="Mclaren";
MonoplazaRedbull MonoRedBull = new MonoplazaRedbull();
MonoRedBull.scuderia="Redbull";


//Instancia de cada MonoPlaza en Circuito
Circuito circuitoFerrari = new Circuito(MonoFerrari);
Circuito circuitoMclaren = new Circuito(MonoMclaren);
Circuito circuitoRedBull = new Circuito(MonoRedBull);

//Nombre del circuito
Console.WriteLine("Ingrese el nombre del circuito");
circuitoFerrari.nombre = Console.ReadLine();
circuitoMclaren.nombre= circuitoFerrari.nombre;
circuitoRedBull.nombre=circuitoFerrari.nombre;

//Numero de vueltas
Console.WriteLine("Ingrese el numero de vueltas");
int numVueltas = int.Parse(Console.ReadLine());



Dictionary<string, float> mejorTiempo = new Dictionary<string, float>();

//Acciones de Ferrari
circuitoFerrari.AgregarMonoplaza();
Console.WriteLine(circuitoFerrari.Realizarprueba(numVueltas,MonoFerrari.scuderia));
mejorTiempo.Add("Ferrari", circuitoFerrari.Mostrar_Mejor_Tiempo());
circuitoFerrari.SacarMonoplaza();

// Console.WriteLine(circuitoFerrari.Mostrar_Mejor_Tiempo());



/*
//Acciones de Mclaren
circuitoMclaren.AgregarMonoplaza();
circuitoMclaren.Realizarprueba(numVueltas,MonoMclaren.scuderia);
mejorTiempo.Add("Mclaren", circuitoMclaren.Mostrar_Mejor_Tiempo());
circuitoMclaren.SacarMonoplaza();


//Acciones de Redbull
circuitoRedBull.AgregarMonoplaza();
circuitoRedBull.Realizarprueba(numVueltas, MonoRedBull.scuderia);
mejorTiempo.Add("Redbull", circuitoRedBull.Mostrar_Mejor_Tiempo());
circuitoRedBull.SacarMonoplaza();


foreach (KeyValuePair<string, float> pos in mejorTiempo.OrderBy(key => key.Value))  
    {  
        Console.WriteLine("Resultados");
        Console.WriteLine("Key: {0}, Value: {1}", pos.Key, pos.Value);  
    } */