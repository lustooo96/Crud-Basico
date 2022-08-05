﻿using CrudBasico.Dominio.Modelos;

namespace CrudBasico.Dominio.Interfaces
{

    public interface IUsuarioRepositorio : IRepositorio<Usuario>
    {
        Usuario BuscarUsuarioPorId(string id);
        Usuario? BuscarUsuarioComEmailRepetido(string email);
    }
}
    