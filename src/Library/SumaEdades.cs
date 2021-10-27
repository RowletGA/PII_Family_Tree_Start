using System;
namespace Library
{
    public class SumaEdades : Visitor
    {
        public int sumaEdades = 0;
        public int SumAge
        {
            get
            {
                return this.sumaEdades;
            }
            set
            {
                this.sumaEdades = value;

            }
        }
        public override void Visit(Node nodo)
        {
           this.sumaEdades += nodo.Person.Edad;
           foreach(Node item in nodo.Children )
           {
               this.Visit(item);
           }
        }
        }
}
