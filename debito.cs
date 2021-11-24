using System;

class debito : pagamento {
  public override void realizarPagamento(double valor){
    valor += valor * 0.05;
    Console.WriteLine("\nPagamento realizado com sucesso!");
    Console.WriteLine("Valor R$ {0}", Math.Round(valor, 2, MidpointRounding.AwayFromZero));
  }
}