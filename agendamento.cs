class agendamento {
  
  private string _estabelecimento {get; set;}
  private servico _servicoSolicitado {get; set;}
  private cliente _solicitante {get; set;}
  private string _dataAgendamento {get; set;}
  private string _horaAgendamento {get; set;}
  private int _formaPagamento {get; set;}

  public string Estabelecimento {
    get {return _estabelecimento;}
  }

  public servico ServicoSolicitado {
    get {return _servicoSolicitado;}
  }

  public cliente Solicitante {
    get {return _solicitante;}
  }

  public string DataAgendamento {
    get {return _dataAgendamento;}
  }

  public string HoraAgendamento {
    get {return _horaAgendamento;}
  }

  public agendamento (string e, servico s, cliente c, string dA, string hA, int fP){
    _estabelecimento = e;
    _servicoSolicitado = s;
    _solicitante = c;
    _dataAgendamento = dA;
    _horaAgendamento = hA;
    _formaPagamento = fP;
  }
  
}