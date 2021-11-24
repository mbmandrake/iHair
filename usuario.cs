using System;

class usuario {
  private string _nome {get; set;}
  private string _senha {get; set;}
  private string _telefone {get; set;}
  private string _endereco {get; set;}
  private string _email {get; set;}
  private int _tipoUsuario {get; set;}

  public string Nome {
    get {return _nome;}
    set {_nome = value;}
  }

  public string Senha {
    get {return _senha;}
    set {_senha = value;}
  }

  public string Telefone {
    get {return _telefone;}
    set {_telefone = value;}
  }

  public string Endereco {
    get {return _endereco;}
    set {_endereco = value;}
  }

  public string Email {
    get {return _email;}
  }

  public int TipoUsuario {
    get {return _tipoUsuario;}
  }

  public usuario (string n, string s, string t, string end, string em, int tipoUsuario) {
    _nome = n;
    _senha = s;
    _telefone = t;
    _endereco = end;
    _email = em;
    _tipoUsuario = tipoUsuario;
  }

  public void editUsuario (usuario u) {
    _nome = u.Nome;
    _senha = u.Senha;
    _telefone = u.Telefone;
    _endereco = u.Endereco;
    _email = u.Email;
    _tipoUsuario = u.TipoUsuario;
  }

}