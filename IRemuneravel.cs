interface IRemuneravel {
  bool bonificavel {get;set;}
  bool locomocao {get; set;}
  bool alimentacao {get; set;}

  void editBonificavel (bool op);
  void editlocomocao (bool op);
  void editalimentacao (bool op);
}