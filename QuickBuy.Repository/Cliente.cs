﻿using QuickBuy.Domain.Entidades;
using QuickBuy.Repository.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repository
{
    public class Cliente
    {
        public Cliente()
        {
            var usuarioRepositorio = new UsuarioRepositorio();
            //var produto = new Produto();
            var usuario = new Usuario();

            usuarioRepositorio.Adicionar(usuario);
        }
    }
}
