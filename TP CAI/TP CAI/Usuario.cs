﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_CAI
{
    public class Usuario
    {
        int id;
        string nombre;
        string apellido;
        string direccion;
        string telefono;
        string email;
        DateTime fechaAlta;
        DateTime fechaNacimiento;
        DateTime? fechaBaja;
        DateTime? fechaUltimaAct;
        string nombreUsuario;
        int tipoUsuario;
        int dni;
        string contraseña;
        string host;




        public Usuario(int id, string nombre, string apellido, string direccion, string telefono, string email, DateTime fechaAlta, DateTime fechaNacimiento, DateTime? fechaBaja, DateTime? fechaUltimaAct, string nombreUsuario, int tipoUsuario, int dni, string contraseña, string host)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.telefono = telefono;
            this.email = email;
            this.fechaAlta = fechaAlta;
            this.fechaNacimiento = fechaNacimiento;
            this.fechaBaja = fechaBaja;
            this.fechaUltimaAct = fechaUltimaAct;
            this.nombreUsuario = nombreUsuario;
            this.tipoUsuario = tipoUsuario;
            this.dni = dni;
            this.contraseña = contraseña;
            this.host = host;
        }


        public int GetId()
        {
            return this.id;
        }
    }
}
