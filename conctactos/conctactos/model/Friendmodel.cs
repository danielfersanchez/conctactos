using conctactos.viewmodel;
using System;
using System.Collections.Generic;
using System.Text;

namespace conctactos.model
{
    class Friendmodel : Notificacble
    {
        #region atributos
        public int Id;
        private string Nombre;
        private string telefono;
        private string Correo;
        #endregion
        #region propiedades
        public string correo
        {
            get { return Correo; }
            set
            {
                SetValue(ref Correo,value);
                Correo = value; }
        }


        public string Telefono
        {
            get { return telefono; }
            set {
                SetValue(ref telefono, value);
                telefono = value; }
        }

        public string nombre
        {
            get { return Nombre; }
            set {
                SetValue(ref Nombre, value);
                Nombre = value; }
        }

        public int id
        {
            get { return Id; }
            set
            {
                SetValue(ref Id, value);
                Id = value;
            }
        }
        #endregion
    }
}
