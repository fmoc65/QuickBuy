using System;


namespace QuickBuy.Domain.Entidades
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public override void Validate()
        {
            if (ProdutoId == 0)
                AdicionarCritica("Atenção - Não foi identificada qual a referencia do produto");

            if (Quantidade == 0)
                AdicionarCritica("Atenção - Quantidade deve ser maior que zero!");
        }
    }
}
