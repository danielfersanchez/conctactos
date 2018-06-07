using conctactos.viewmodel;
using System;
using System.Collections.Generic;
using System.Text;

namespace conctactos.model
{
    class Friend : Notificacble
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
                SetValue(ref correo, value);
                Correo = value; }
        }


        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        #endregion
    }
}
