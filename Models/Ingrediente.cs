using System;
using System.Collections.Generic;

namespace TP09_Blaser_Garber.Models
{
    public class Ingrediente
    {
        private int _IdIngrediente;
        private string _nombre;
        private string _urlFoto;

        public int IdIngrediente{
            get{
                return _IdIngrediente;
            }
        }

        public string Nombre{
            get{
                return _nombre;
            }
        }

        public string UrlFoto{
            get{
                return _urlFoto;
            }
        }

        public Ingrediente(int IdIngrediente, string Nombre, string UrlFoto){
            _IdIngrediente=IdIngrediente;
            _nombre=Nombre;
            _urlFoto=UrlFoto;
        }

    }
}