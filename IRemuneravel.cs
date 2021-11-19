interface IRemuneravel {
  //remunerado e funcionarios ficariam um pouco redundante então, algo do tipo bonus para x numeros de serviços, faria mais sentido (provisório)
  bool bonificavel {get;set;}
  public void listarBonificados();
  
}