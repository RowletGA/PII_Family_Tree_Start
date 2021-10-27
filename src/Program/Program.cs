using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Esteban = new Person ("Esteban", 19);
            Person Alfredo = new Person ("Alfredo", 18);
            Person Tomas = new Person ("Tomas", 22);
            Person Gonzalo = new Person ("Gonzalo", 31);
            Person Pedro = new Person ("Pedro", 39);
            Person Carlos = new Person ("Carlos", 68);
            Person Pablo = new Person ("Pablo", 34);
            Person Luffy = new Person ("Luffy", 21);
            // Creo las personas y luego las implenento a su nodo con sus respectivos hijos
            Node n1 = new Node(1,Esteban);
            Node n2 = new Node(2,Alfredo);
            Node n3 = new Node(3,Tomas);
            Node n4 = new Node(4,Gonzalo);
            Node n5 = new Node(5,Pedro);
            Node n6 = new Node(6,Carlos);
            Node n7 = new Node(7,Pablo);
            Node n8 = new Node(8,Luffy);

            n1.AddChildren(n2);
            n1.AddChildren(n3);
            n2.AddChildren(n4);
            n2.AddChildren(n5);
            n3.AddChildren(n6);
            n3.AddChildren(n7);
            n3.AddChildren(n8);

           

            // visitar el árbol aquí
        }
    }
}
