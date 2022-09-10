using ENTREGABLE2.Classes;

MonoplazaCircuito Mono = new MonoplazaCircuito();

Circuito circo = new Circuito(Mono);

int vueltas = 0;

circo.AgregarMonoplaza();
circo.Realizarprueba(vueltas);
circo.SacarMonoplaza();
