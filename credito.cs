using System;

class credito : pagamento {
  public override void realizarPagamento(double valor){
    valor += valor * 0.1;
    Console.WriteLine("\nPagamento realizado com sucesso!");
    Console.WriteLine("Valor R$ {0}", Math.Round(valor, 2, MidpointRounding.AwayFromZero));
  }
}