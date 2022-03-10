using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Dispensador
{
    public partial class Form1 : Form
    {
        Dispensador dispensador;
        public int agua = 10;
        public int hit = 10;
        public int cocacola = 10;
        public int pepsi = 10;
        public int colombiana = 10;
        public int mrtea = 10;
        public int detodito = 10;
        public int chocoramo = 10;
        public int papas = 10;
        public int mani = 10;
        public int doritos = 10;
        public int chocolatina = 10;
        public int sdispensador = 180000;
        public int saldo, cantidad, codigo;
        public Form1()
        {
            dispensador = new Dispensador();
            InitializeComponent();
        }

        private void btnMil_Click(object sender, EventArgs e)
        {
            this.dispensador.recargar(1000);
            txbSaldo.Text = this.dispensador.saldot.ToString();
        }

        private void btnDosmil_Click(object sender, EventArgs e)
        {
            this.dispensador.recargar(2000);
            txbSaldo.Text = this.dispensador.saldot.ToString();
        }

        private void btnCincomil_Click(object sender, EventArgs e)
        {
            this.dispensador.recargar(5000);
            txbSaldo.Text = this.dispensador.saldot.ToString();
        }

        private void btnDiezmil_Click(object sender, EventArgs e)
        {
            this.dispensador.recargar(10000);
            txbSaldo.Text = this.dispensador.saldot.ToString();
        }

        private void btnAgua_Click(object sender, EventArgs e)
        {
            codigo = 1;
            saldo = Convert.ToInt32(txbSaldo.Text);
            cantidad = Convert.ToInt32(txbCantidad.Text);
            if(saldo==0)
            {
                MessageBox.Show("Ingrese primero el dinero.");
            }
            else
            {
                if (cantidad > 0)
                {
                    if (saldo >= cantidad * 2000)
                    {
                        if(agua>=cantidad)
                        {
                            MessageBox.Show("Acepte el pedido para dispensar.");
                        }
                        else
                        {
                            MessageBox.Show("No contamos con esa cantidad de productos, su cambio es: $"+saldo);
                            this.txbSaldo.Text = "0";
                            this.txbCantidad.Text = "1";
                            this.dispensador.saldot = 0;
                        }                        
                    }
                    else
                    {
                        MessageBox.Show("El saldo no es suficiente para adquirir el producto, su cambio es: $" + saldo);
                        this.txbSaldo.Text = "0";
                        this.txbCantidad.Text = "1";
                        this.dispensador.saldot = 0;
                    }
                }
                else
                {
                    MessageBox.Show("No se pueden dispensar 0 productos.");
                }
            }
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            codigo = 2;
            saldo = Convert.ToInt32(txbSaldo.Text);
            cantidad = Convert.ToInt32(txbCantidad.Text);
            if (saldo == 0)
            {
                MessageBox.Show("Ingrese primero el dinero.");
            }
            else
            {
                if (cantidad > 0)
                {
                    if (saldo >= cantidad * 2000)
                    {
                        if (hit >= cantidad)
                        {
                            MessageBox.Show("Acepte el pedido para dispensar.");
                        }
                        else
                        {
                            MessageBox.Show("No contamos con esa cantidad de productos, su cambio es: $" + saldo);
                            this.txbSaldo.Text = "0";
                            this.txbCantidad.Text = "1";
                            this.dispensador.saldot = 0;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El saldo no es suficiente para adquirir el producto, su cambio es: $" + saldo);
                        this.txbSaldo.Text = "0";
                        this.txbCantidad.Text = "1";
                        this.dispensador.saldot = 0;
                    }
                }
                else
                {
                    MessageBox.Show("No se pueden dispensar 0 productos.");
                }
            }
        }

        private void btnCocaCola_Click(object sender, EventArgs e)
        {
            codigo = 3;
            saldo = Convert.ToInt32(txbSaldo.Text);
            cantidad = Convert.ToInt32(txbCantidad.Text);
            if (saldo == 0)
            {
                MessageBox.Show("Ingrese primero el dinero.");
            }
            else
            {
                if (cantidad > 0)
                {
                    if (saldo >= cantidad * 3000)
                    {
                        if (cocacola >= cantidad)
                        {
                            MessageBox.Show("Acepte el pedido para dispensar.");
                        }
                        else
                        {
                            MessageBox.Show("No contamos con esa cantidad de productos, su cambio es: $" + saldo);
                            this.txbSaldo.Text = "0";
                            this.txbCantidad.Text = "1";
                            this.dispensador.saldot = 0;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El saldo no es suficiente para adquirir el producto, su cambio es: $" + saldo);
                        this.txbSaldo.Text = "0";
                        this.txbCantidad.Text = "1";
                        this.dispensador.saldot = 0;
                    }
                }
                else
                {
                    MessageBox.Show("No se pueden dispensar 0 productos.");
                }
            }
        }

        private void btnPepsi_Click(object sender, EventArgs e)
        {
            codigo = 4;
            saldo = Convert.ToInt32(txbSaldo.Text);
            cantidad = Convert.ToInt32(txbCantidad.Text);
            if (saldo == 0)
            {
                MessageBox.Show("Ingrese primero el dinero.");
            }
            else
            {
                if (cantidad > 0)
                {
                    if (saldo >= cantidad * 2000)
                    {
                        if (pepsi >= cantidad)
                        {
                            MessageBox.Show("Acepte el pedido para dispensar.");
                        }
                        else
                        {
                            MessageBox.Show("No contamos con esa cantidad de productos, su cambio es: $" + saldo);
                            this.txbSaldo.Text = "0";
                            this.txbCantidad.Text = "1";
                            this.dispensador.saldot = 0;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El saldo no es suficiente para adquirir el producto, su cambio es: $" + saldo);
                        this.txbSaldo.Text = "0";
                        this.txbCantidad.Text = "1";
                        this.dispensador.saldot = 0;
                    }
                }
                else
                {
                    MessageBox.Show("No se pueden dispensar 0 productos.");
                }
            }
        }

        private void btnColombiana_Click(object sender, EventArgs e)
        {
            codigo = 5;
            saldo = Convert.ToInt32(txbSaldo.Text);
            cantidad = Convert.ToInt32(txbCantidad.Text);
            if (saldo == 0)
            {
                MessageBox.Show("Ingrese primero el dinero.");
            }
            else
            {
                if (cantidad > 0)
                {
                    if (saldo >= cantidad * 2000)
                    {
                        if (colombiana >= cantidad)
                        {
                            MessageBox.Show("Acepte el pedido para dispensar.");
                        }
                        else
                        {
                            MessageBox.Show("No contamos con esa cantidad de productos, su cambio es: $" + saldo);
                            this.txbSaldo.Text = "0";
                            this.txbCantidad.Text = "1";
                            this.dispensador.saldot = 0;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El saldo no es suficiente para adquirir el producto, su cambio es: $" + saldo);
                        this.txbSaldo.Text = "0";
                        this.txbCantidad.Text = "1";
                        this.dispensador.saldot = 0;
                    }
                }
                else
                {
                    MessageBox.Show("No se pueden dispensar 0 productos.");
                }
            }
        }

        private void btnMrTea_Click(object sender, EventArgs e)
        {
            codigo = 6;
            saldo = Convert.ToInt32(txbSaldo.Text);
            cantidad = Convert.ToInt32(txbCantidad.Text);
            if (saldo == 0)
            {
                MessageBox.Show("Ingrese primero el dinero.");
            }
            else
            {
                if (cantidad > 0)
                {
                    if (saldo >= cantidad * 3000)
                    {
                        if (mrtea >= cantidad)
                        {
                            MessageBox.Show("Acepte el pedido para dispensar.");
                        }
                        else
                        {
                            MessageBox.Show("No contamos con esa cantidad de productos, su cambio es: $" + saldo);
                            this.txbSaldo.Text = "0";
                            this.txbCantidad.Text = "1";
                            this.dispensador.saldot = 0;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El saldo no es suficiente para adquirir el producto, su cambio es: $" + saldo);
                        this.txbSaldo.Text = "0";
                        this.txbCantidad.Text = "1";
                        this.dispensador.saldot = 0;
                    }
                }
                else
                {
                    MessageBox.Show("No se pueden dispensar 0 productos.");
                }
            }
        }

        private void btnDeTodito_Click(object sender, EventArgs e)
        {
            codigo = 7;
            saldo = Convert.ToInt32(txbSaldo.Text);
            cantidad = Convert.ToInt32(txbCantidad.Text);
            if (saldo == 0)
            {
                MessageBox.Show("Ingrese primero el dinero.");
            }
            else
            {
                if (cantidad > 0)
                {
                    if (saldo >= cantidad * 3000)
                    {
                        if (detodito >= cantidad)
                        {
                            MessageBox.Show("Acepte el pedido para dispensar.");
                        }
                        else
                        {
                            MessageBox.Show("No contamos con esa cantidad de productos, su cambio es: $" + saldo);
                            this.txbSaldo.Text = "0";
                            this.txbCantidad.Text = "1";
                            this.dispensador.saldot = 0;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El saldo no es suficiente para adquirir el producto, su cambio es: $" + saldo);
                        this.txbSaldo.Text = "0";
                        this.txbCantidad.Text = "1";
                        this.dispensador.saldot = 0;
                    }
                }
                else
                {
                    MessageBox.Show("No se pueden dispensar 0 productos.");
                }
            }
        }

        private void btnChocoramo_Click(object sender, EventArgs e)
        {
            codigo = 8;
            saldo = Convert.ToInt32(txbSaldo.Text);
            cantidad = Convert.ToInt32(txbCantidad.Text);
            if (saldo == 0)
            {
                MessageBox.Show("Ingrese primero el dinero.");
            }
            else
            {
                if (cantidad > 0)
                {
                    if (saldo >= cantidad * 2000)
                    {
                        if (chocoramo >= cantidad)
                        {
                            MessageBox.Show("Acepte el pedido para dispensar.");
                        }
                        else
                        {
                            MessageBox.Show("No contamos con esa cantidad de productos, su cambio es: $" + saldo);
                            this.txbSaldo.Text = "0";
                            this.txbCantidad.Text = "1";
                            this.dispensador.saldot = 0;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El saldo no es suficiente para adquirir el producto, su cambio es: $" + saldo);
                        this.txbSaldo.Text = "0";
                        this.txbCantidad.Text = "1";
                        this.dispensador.saldot = 0;
                    }
                }
                else
                {
                    MessageBox.Show("No se pueden dispensar 0 productos.");
                }
            }
        }

        private void btnPapas_Click(object sender, EventArgs e)
        {
            codigo = 9;
            saldo = Convert.ToInt32(txbSaldo.Text);
            cantidad = Convert.ToInt32(txbCantidad.Text);
            if (saldo == 0)
            {
                MessageBox.Show("Ingrese primero el dinero.");
            }
            else
            {
                if (cantidad > 0)
                {
                    if (saldo >= cantidad * 2000)
                    {
                        if (papas >= cantidad)
                        {
                            MessageBox.Show("Acepte el pedido para dispensar.");
                        }
                        else
                        {
                            MessageBox.Show("No contamos con esa cantidad de productos, su cambio es: $" + saldo);
                            this.txbSaldo.Text = "0";
                            this.txbCantidad.Text = "1";
                            this.dispensador.saldot = 0;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El saldo no es suficiente para adquirir el producto, su cambio es: $" + saldo);
                        this.txbSaldo.Text = "0";
                        this.txbCantidad.Text = "1";
                        this.dispensador.saldot = 0;
                    }
                }
                else
                {
                    MessageBox.Show("No se pueden dispensar 0 productos.");
                }
            }
        }

        private void btnMani_Click(object sender, EventArgs e)
        {
            codigo = 10;
            saldo = Convert.ToInt32(txbSaldo.Text);
            cantidad = Convert.ToInt32(txbCantidad.Text);
            if (saldo == 0)
            {
                MessageBox.Show("Ingrese primero el dinero.");
            }
            else
            {
                if (cantidad > 0)
                {
                    if (saldo >= cantidad * 1000)
                    {
                        if (mani >= cantidad)
                        {
                            MessageBox.Show("Acepte el pedido para dispensar.");
                        }
                        else
                        {
                            MessageBox.Show("No contamos con esa cantidad de productos, su cambio es: $" + saldo);
                            this.txbSaldo.Text = "0";
                            this.txbCantidad.Text = "1";
                            this.dispensador.saldot = 0;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El saldo no es suficiente para adquirir el producto, su cambio es: $" + saldo);
                        this.txbSaldo.Text = "0";
                        this.txbCantidad.Text = "1";
                        this.dispensador.saldot = 0;
                    }
                }
                else
                {
                    MessageBox.Show("No se pueden dispensar 0 productos.");
                }
            }
        }

        private void btnDoritos_Click(object sender, EventArgs e)
        {
            codigo = 11;
            saldo = Convert.ToInt32(txbSaldo.Text);
            cantidad = Convert.ToInt32(txbCantidad.Text);
            if (saldo == 0)
            {
                MessageBox.Show("Ingrese primero el dinero.");
            }
            else
            {
                if (cantidad > 0)
                {
                    if (saldo >= cantidad * 2000)
                    {
                        if (doritos >= cantidad)
                        {
                            MessageBox.Show("Acepte el pedido para dispensar.");
                        }
                        else
                        {
                            MessageBox.Show("No contamos con esa cantidad de productos, su cambio es: $" + saldo);
                            this.txbSaldo.Text = "0";
                            this.txbCantidad.Text = "1";
                            this.dispensador.saldot = 0;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El saldo no es suficiente para adquirir el producto, su cambio es: $" + saldo);
                        this.txbSaldo.Text = "0";
                        this.txbCantidad.Text = "1";
                        this.dispensador.saldot = 0;
                    }
                }
                else
                {
                    MessageBox.Show("No se pueden dispensar 0 productos.");
                }
            }
        }

        private void btnChocolatina_Click(object sender, EventArgs e)
        {
            codigo = 12;
            saldo = Convert.ToInt32(txbSaldo.Text);
            cantidad = Convert.ToInt32(txbCantidad.Text);
            if (saldo == 0)
            {
                MessageBox.Show("Ingrese primero el dinero.");
            }
            else
            {
                if (cantidad > 0)
                {
                    if (saldo >= cantidad * 4000)
                    {
                        if (chocolatina >= cantidad)
                        {
                            MessageBox.Show("Acepte el pedido para dispensar.");
                        }
                        else
                        {
                            MessageBox.Show("No contamos con esa cantidad de productos, su cambio es: $" + saldo);
                            this.txbSaldo.Text = "0";
                            this.txbCantidad.Text = "1";
                            this.dispensador.saldot = 0;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El saldo no es suficiente para adquirir el producto, su cambio es: $" + saldo);
                        this.txbSaldo.Text = "0";
                        this.txbCantidad.Text = "1";
                        this.dispensador.saldot = 0;
                    }
                }
                else
                {
                    MessageBox.Show("No se pueden dispensar 0 productos.");
                }
            }
        }

        private void btnAceptarPedido_Click(object sender, EventArgs e)
        {
            int cambio;
            cambio = this.dispensador.saldot;
            if(codigo==0 || this.dispensador.saldot==0)
            {
                MessageBox.Show("Primero elija el producto.");
            }
            else
            {
                if (codigo == 1)
                {
                    agua = agua - cantidad;
                    sdispensador = sdispensador + (2000 * cantidad);
                    cambio = cambio - (2000 * cantidad);
                    MessageBox.Show("Muchas gracias por su compra, su cambio es: $" + cambio);
                    this.txbSaldo.Text = "0";
                    this.txbCantidad.Text = "1";
                    this.dispensador.saldot = 0;
                    codigo = 0;
                }
                else if (codigo == 2)
                {
                    hit = hit - cantidad;
                    sdispensador = sdispensador + (2000 * cantidad);
                    cambio = cambio - (2000 * cantidad);
                    MessageBox.Show("Muchas gracias por su compra, su cambio es: $" + cambio);
                    this.txbSaldo.Text = "0";
                    this.txbCantidad.Text = "1";
                    this.dispensador.saldot = 0;
                    codigo = 0;
                }
                else if (codigo == 3)
                {
                    cocacola = cocacola - cantidad;
                    sdispensador = sdispensador + (3000 * cantidad);
                    cambio = cambio - (3000 * cantidad);
                    MessageBox.Show("Muchas gracias por su compra, su cambio es: $" + cambio);
                    this.txbSaldo.Text = "0";
                    this.txbCantidad.Text = "1";
                    this.dispensador.saldot = 0;
                    codigo = 0;
                }
                else if (codigo == 4)
                {
                    pepsi = pepsi - cantidad;
                    sdispensador = sdispensador + (2000 * cantidad);
                    cambio = cambio - (2000 * cantidad);
                    MessageBox.Show("Muchas gracias por su compra, su cambio es: $" + cambio);
                    this.txbSaldo.Text = "0";
                    this.txbCantidad.Text = "1";
                    this.dispensador.saldot = 0;
                    codigo = 0;
                }
                else if (codigo == 5)
                {
                    colombiana = colombiana - cantidad;
                    sdispensador = sdispensador + (2000 * cantidad);
                    cambio = cambio - (2000 * cantidad);
                    MessageBox.Show("Muchas gracias por su compra, su cambio es: $" + cambio);
                    this.txbSaldo.Text = "0";
                    this.txbCantidad.Text = "1";
                    this.dispensador.saldot = 0;
                    codigo = 0;
                }
                else if (codigo == 6)
                {
                    mrtea = mrtea - cantidad;
                    sdispensador = sdispensador + (3000 * cantidad);
                    cambio = cambio - (3000 * cantidad);
                    MessageBox.Show("Muchas gracias por su compra, su cambio es: $" + cambio);
                    this.txbSaldo.Text = "0";
                    this.txbCantidad.Text = "1";
                    this.dispensador.saldot = 0;
                    codigo = 0;
                }
                else if (codigo == 7)
                {
                    detodito = detodito - cantidad;
                    sdispensador = sdispensador + (3000 * cantidad);
                    cambio = cambio - (3000 * cantidad);
                    MessageBox.Show("Muchas gracias por su compra, su cambio es: $" + cambio);
                    this.txbSaldo.Text = "0";
                    this.txbCantidad.Text = "1";
                    this.dispensador.saldot = 0;
                    codigo = 0;
                }
                else if (codigo == 8)
                {
                    chocoramo = chocoramo - cantidad;
                    sdispensador = sdispensador + (2000 * cantidad);
                    cambio = cambio - (2000 * cantidad);
                    MessageBox.Show("Muchas gracias por su compra, su cambio es: $" + cambio);
                    this.txbSaldo.Text = "0";
                    this.txbCantidad.Text = "1";
                    this.dispensador.saldot = 0;
                    codigo = 0;
                }
                else if (codigo == 9)
                {
                    papas = papas - cantidad;
                    sdispensador = sdispensador + (2000 * cantidad);
                    cambio = cambio - (2000 * cantidad);
                    MessageBox.Show("Muchas gracias por su compra, su cambio es: $" + cambio);
                    this.txbSaldo.Text = "0";
                    this.txbCantidad.Text = "1";
                    this.dispensador.saldot = 0;
                    codigo = 0;
                }
                else if (codigo == 10)
                {
                    mani = mani - cantidad;
                    sdispensador = sdispensador + (1000 * cantidad);
                    cambio = cambio - (1000 * cantidad);
                    MessageBox.Show("Muchas gracias por su compra, su cambio es: $" + cambio);
                    this.txbSaldo.Text = "0";
                    this.txbCantidad.Text = "1";
                    this.dispensador.saldot = 0;
                    codigo = 0;
                }
                else if (codigo == 11)
                {
                    doritos = doritos - cantidad;
                    sdispensador = sdispensador + (2000 * cantidad);
                    cambio = cambio - (2000 * cantidad);
                    MessageBox.Show("Muchas gracias por su compra, su cambio es: $" + cambio);
                    this.txbSaldo.Text = "0";
                    this.txbCantidad.Text = "1";
                    this.dispensador.saldot = 0;
                    codigo = 0;
                }
                else if (codigo == 12)
                {
                    chocolatina = chocolatina - cantidad;
                    sdispensador = sdispensador + (4000 * cantidad);
                    cambio = cambio - (4000 * cantidad);
                    MessageBox.Show("Muchas gracias por su compra, su cambio es: $" + cambio);
                    this.txbSaldo.Text = "0";
                    this.txbCantidad.Text = "1";
                    this.dispensador.saldot = 0;
                    codigo = 0;
                }
            }
        }
        private void btnCancelarPedido_Click(object sender, EventArgs e)
        {
            int cambio;
            cambio = this.dispensador.saldot;
            if(this.dispensador.saldot==0)
            {
                MessageBox.Show("No tiene pedidos en curso.");
            }
            else
            {
                MessageBox.Show("Ha cancelado el pedido, su cambio es: $" + cambio);
                this.txbSaldo.Text = "0";
                this.txbCantidad.Text = "1";
                this.dispensador.saldot = 0;
                codigo = 0;
            }
        }
    }
}
