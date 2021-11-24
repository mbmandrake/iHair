using System;

class servico {
  
  private string _nome {get; set;}
  private double _valor {get; set;}
  private int _tempoMedio {get; set;}

  public string Nome {
    get {return _nome;}
    set {_nome = value;}
  }

  public double Valor {
    get {return _valor;}
    set {_valor = value;}
  }

  public int TempoMedio {
    get {return _tempoMedio;}
    set {_tempoMedio = value;}
  }

  public servico (string n, double v, int tM){
    _nome = n;
    _valor = v;
    _tempoMedio = tM;
  }
}