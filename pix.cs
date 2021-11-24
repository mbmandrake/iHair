using System;

class pix : pagamento {
  public override void realizarPagamento(double valor){
    Console.WriteLine("\nPagamento realizado com sucesso!");
    Console.WriteLine("Valor R$ {0}", Math.Round(valor, 2, MidpointRounding.AwayFromZero));
  }
}