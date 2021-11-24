class funcionario : usuario, IRemuneravel {

  public bool bonificavel {get;set;}
  public bool locomocao {get; set;}
  public bool alimentacao {get; set;}

  public funcionario (string n, string s, string t, string end, string em, int tipoUsuario, bool b, bool l, bool a ) : 
  base (n, s, t, end, em, tipoUsuario) {
    bonificavel = b;
  }

  public void editBonificavel (bool op){
    bonificavel = op;
  }

  public void editlocomocao (bool op){
    locomocao = op;
  }

  public void editalimentacao (bool op){
    alimentacao = op;
  }

}