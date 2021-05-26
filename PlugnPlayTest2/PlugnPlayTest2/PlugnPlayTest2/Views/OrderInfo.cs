using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PlugnPlayTest2.Views
{
    public class OrderInfo : INotifyPropertyChanged
    {
        private string categoria;
        private string nombreproducto;
        private int cantidad;
        private string informacion;
        private int ventas;
        private int clave;

        public int Clave
        {
            get { return clave; }
            set
            {
                this.clave = value;
                RaisePropertyChanged("Clave");
            }
        }
        public string Categoria 
        {
            get { return categoria; }
            set
            {
                this.categoria = value;
                RaisePropertyChanged("Categoria");
            }
        }
        public string NombreProducto
        {
            get { return nombreproducto; }
            set
            {
                this.nombreproducto = value;
                RaisePropertyChanged("NombreProducto");
            }
        }
        public int Cantidad
        {
            get { return cantidad; }
            set
            {
                this.cantidad = value;
                RaisePropertyChanged("Cantidad");
            }
        }
        public int Ventas
        {
            get { return ventas; }
            set
            {
                this.ventas = value;
                RaisePropertyChanged("Ventas");
            }
        }
        public string Informacion
        {
            get { return informacion; }
            set
            {
                this.informacion = value;
                RaisePropertyChanged("Informacion");
            }
        }


        public OrderInfo(int clave, string categoria, string nombreproducto, int cantidad, int ventas, string informacion)
        {
            this.Clave = clave;
            this.Categoria = categoria;
            this.NombreProducto = nombreproducto;
            this.Cantidad = cantidad;
            this.Ventas = ventas;
            this.Informacion = informacion;
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}
