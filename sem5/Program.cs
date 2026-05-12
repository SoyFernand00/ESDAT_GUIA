using sem5;
/*
Pilaar p=new Pilaar();

if (p.Empty())
{
       Console.WriteLine("La pila esta vacia");
}

p.Push(1);
p.Push(2);
p.Push(3);
    Console.WriteLine(p.Top().ToString());
    Console.WriteLine(p.ToString());*/


Pilalis p = new Pilalis();

p.AgregaFinal(1);
p.AgregaFinal(2);
p.AgregaFinal(3);

if (p.Empty())
{
       Console.WriteLine("La pila esta vacia");
}else p.Mostrar();
Console.WriteLine(p.Pop().ToString());
Console.WriteLine(p.Top().ToString());
Console.WriteLine(p.Size());
p.Mostrar();
