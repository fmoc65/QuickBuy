﻿using System.Collections.Generic;

namespace QuickBuy.Domain.Entidades
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
                AdicionarCritica("Atenção - Não foi adicionado um e-mail");

            if (string.IsNullOrEmpty(Senha))
                AdicionarCritica("Atenção - Não foi informado a senha!");
        }
    }
}
