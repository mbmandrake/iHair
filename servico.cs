using System;

class servico {
  private string _nome {get; set;}
  private double _valor {get; set;}
  private int _tempoMedio {get; set;}

  public servico (string n, double v, int tM){
    _nome = n;
    _valor = v;
    _tempoMedio = tM;
  }
}