using Microsoft.EntityFrameworkCore;
using Presentation.Models;
using System;
using System.Linq;

namespace Presentation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new NorthwindContext())
            {

                //Query Equivalente SQL:        SELECT ProductID,
                //                                     ProductName,
                //                                     SupplierId,
                //                                     CategoryId,
                //                                     QuantityPerUnit,
                //                                     UnitPrice,
                //                                     UnitsInStock,
                //                                     UnitsOnOrder,
                //                                     ReorderLevel,
                //                                     Discontinued
                //                              FROM   Products

                //De esta forma, obtenemos todos los datos en la tabla Products de nuestra base de datos.
                foreach (var product in context.Products)
                {
                    //Cada fila en una tabla de SQL contiene la información de una entidad en particular.
                    //En este contexto, en cada fila de nuestra tabla Products tenemos la información de un producto en particular.
                    //En Entity Framework Core, una tabla de nuestra base de datos se representa a través de un DbSet<TEntity>,
                    //Donde TEntity es una clase de C# que contiene las properties que representan cada una de las columnas de nuestra tabla.
                    //En este ejemplo, context.Products devuelve un DbSet<Product>
                    //La clase Product contiene una de serie de properties que representan las columnas en la tabla Products en la Base de datos.
                    //En este foreach, estaríamos recorriendo cada fila en la tabla Products y mostrando por pantalla el valor que tienen
                    //en las columnas seleccionadas.

                    Console.WriteLine("ProductID: {0} - " +
                                      "ProductName: {1} - " +
                                      "UnitPrice: {2} - " +
                                      "UnitsInStock: {3}",
                                      product.ProductId,
                                      product.ProductName,
                                      product.UnitPrice,
                                      product.UnitsInStock);
                }

                //Muestra en pantalla la query realizada en base de datos al acceder al DbSet<Product>
                Console.WriteLine("\n\n\n" + context.Products.ToQueryString());
            }
        }
    }
}
