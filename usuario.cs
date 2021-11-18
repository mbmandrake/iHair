using System;

class usuario {
  private string _nome {get; set;}
  private string _senha {get; set;}
  private string _telefone {get; set;}
  private string _endereco {get; set;}
  private string _email {get; set;}
  private bool _tipoUsuario {get; set;}

  public usuario (string n, string s, string t, string end, string em, bool tipoUsuario){
    _nome = n;
    _senha = s;
    _telefone = t;
    _endereco = end;
    _email = em;
    _tipoUsuario = tipoUsuario;
  }
}