﻿using Crud_Basico.Dominio.Interfaces;
using Crud_Basico.Dominio.Modelos;

namespace Crud_Basico.Infra.Repositorios
{
    class RepositorioUsuario : Repositorio<Usuario>, IUsuarioRepositorio
    {
        public RepositorioUsuario()
        {
        }

        public override void Atualizar(Usuario usuario)
        {
            if (usuario == null) throw new Exception("Usuario não foi informado");
            var usuarioSelecionado = Lista.FirstOrDefault(listaUsuario => listaUsuario.IdUsuario == usuario.IdUsuario);
            usuarioSelecionado!.Nome = usuario.Nome;
            usuarioSelecionado.Senha = usuario.Senha;
            usuarioSelecionado.Email = usuario.Email;
            usuarioSelecionado.DataNascimento = usuario.DataNascimento;
        }

        public override void Remover(int id)
        {
            if (id == decimal.Zero) throw new Exception("O id não foi informado");
            Lista.RemoveAll(usuario => usuario.IdUsuario == id);
        }

    }
}