interface IRemuneravel {
  //remunerado e funcionarios ficariam um pouco redundante então, algo do tipo bonus para x numeros de serviços, faria mais sentido (provisório)
  bool bonificavel {get;set;}
  bool locomocao {get; set;}
  bool alimentacao {get; set;}

  void editBonificavel (bool op);
  void editlocomocao (bool op);
  void editalimentacao (bool op);
}