using System;

namespace Generador{
    public class Token{
        private string Contenido = "";
        private tipos Clasificacion;
        public enum tipos{
            identificador
        }
        public void setContenido(string Contenido){
            this.Contenido = Contenido;
        }
        public void setClasificacion(tipos Clasificacion){
            this.Clasificacion = Clasificacion;
        }
        public string getContenido(){
            return this.Contenido;
        }
        public tipos getClasificacion(){
            return this.Clasificacion;
        }
    }
}