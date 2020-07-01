using System;
using System.Collections.Generic;
using Aula26;

namespace Testeluana{
    class Program
    {
        static void Main(string[] args)
        {
            
            Carrinho car = new Carrinho();

            Produto p1 = new Produto(2, "Samsung A51", 3900.99f);
            Produto p2 = new Produto(3, "Lg ", 3900.99f);
            Produto p3 = new Produto(4, "Acer", 3900.99f);
            Produto p4 = new Produto(6, "Motorola", 3900.99f);

            car.Adicionar(p1);
            car.Adicionar(p2);
            car.Adicionar(p3);
            car.Adicionar(p4);

            car.Listar();
            car.MostrarTotal();
            
        }
    }
}