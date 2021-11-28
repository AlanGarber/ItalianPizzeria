using System;
using System.Collections.Generic;

namespace TP09_Blaser_Garber.Models
{
    public class Pizza
    {
        private int _IdPizza;
        private string _nombre;
        private double _precio;
        private string _urlFoto;
        private List <Ingrediente> _listaIngredientes=new List<Ingrediente>();
        private string _tamano;
        

        public int IdPizza{
            get{
                return _IdPizza;
            }
        }

        public string Nombre{
            get{
                return _nombre;
            }
        }

        public double Precio{
            get{
                return _precio;
            }
        }

        public string UrlFoto{
            get{
                return _urlFoto;
            }
        }

        public string Tamano{
            get{
                return _tamano;
            }
        }

        public Pizza(string Nombre ,double Precio, string UrlFoto, string Tamano){
            _IdPizza=Pizzeria.DevolverId();
            _nombre=Nombre;
            _precio=Precio;
            _urlFoto=UrlFoto;
            _tamano=Tamano;
        }

        public List <Ingrediente> ListarIngredientes(){
            return _listaIngredientes;
        }

        public void AgregarIngredientes(List <Ingrediente> Lista){
            _listaIngredientes=Lista;
        }
    }
}