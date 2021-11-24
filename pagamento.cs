using System;

class pagamento {
  public virtual void realizarPagamento(double valor){
    Console.WriteLine("Pagamento realizado com sucesso!");
    Console.WriteLine("Valor R$ {0}", valor);
  }
}