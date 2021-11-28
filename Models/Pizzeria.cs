using System;
using System.Collections.Generic;

namespace TP09_Blaser_Garber.Models
{
    public static class Pizzeria
    {
        private static int _UltimoId=0;
        private static List <Ingrediente> _listaIngredientesPizzeria=new List<Ingrediente>();
        private static List<Pizza> _listaPizzas=new List<Pizza>();

        public static int DevolverId(){
            _UltimoId++;
            return _UltimoId;
        }
        public static List<Ingrediente> ListarIngredientes(){
            _listaIngredientesPizzeria.Clear();
            Ingrediente ing = new Ingrediente(1,"Salsa de tomate", "SalsaDeTomate.jpg");
            _listaIngredientesPizzeria.Add(ing);
            ing = new Ingrediente(2,"Muzzarella", "Muzzarella.jpg");
            _listaIngredientesPizzeria.Add(ing);
            ing = new Ingrediente(3,"Huevo", "Huevo.jpg");
            _listaIngredientesPizzeria.Add(ing);
            ing = new Ingrediente(4,"Jamon", "Jamon.jpg");
            _listaIngredientesPizzeria.Add(ing);
            ing = new Ingrediente(5,"Morron", "Morron.jpg");
            _listaIngredientesPizzeria.Add(ing);
            ing = new Ingrediente(6,"Pepperoni", "Pepperoni.jpg");
            _listaIngredientesPizzeria.Add(ing);
            ing = new Ingrediente(7,"Oregano", "Oregano.jpg");
            _listaIngredientesPizzeria.Add(ing);
            ing = new Ingrediente(8,"Ajo", "Oregano.jpg");
            _listaIngredientesPizzeria.Add(ing);
            ing = new Ingrediente(9,"Tomate", "Tomate.jpg");
            _listaIngredientesPizzeria.Add(ing);
            return _listaIngredientesPizzeria;
        }

        public static List<Ingrediente> DevolverIngredientes(List<int> Lista){
            List<Ingrediente> ahya = new List<Ingrediente>();
            foreach(int Id in Lista){
                foreach(Ingrediente ing in _listaIngredientesPizzeria){
                    if(Id==ing.IdIngrediente){
                        ahya.Add(ing);
                    }
                }
            }
            return ahya;
        }
        public static List<Pizza> ListarPizzas(){
            return _listaPizzas;
        }

        public static void AgregarPizza(Pizza UnaPizza){
            _listaPizzas.Add(UnaPizza);
        }
        public static bool EliminarPizza(Pizza UnaPizza){
            if(_listaPizzas.Contains(UnaPizza)){
                _listaPizzas.Remove(UnaPizza);
                return true;
            }
            return false;
        }
    }
}