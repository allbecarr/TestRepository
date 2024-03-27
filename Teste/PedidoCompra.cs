class PedidoCompra
{
      public int numero {get; set;}
      public string produto {get; set;}
      public int qtde {get; set;}
      public double preco {get; set;}
      public double desconto {get; set;}
      public double total {get; set;}
       public void CalcularPedido(int q, double p, double d)
      {
             this.qtde = q;//3
             this.preco = p;//20,00
             this.desconto = d;//5,00
             this.total = q * p - d;//3*20=60-5=55
      }
}