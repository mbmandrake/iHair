using System;
using System.Collections.Generic;

class listas {

  private List<agendamento> listaAgendamentos = new List<agendamento>();
 
  public void addAgendamento (agendamento a){
    listaAgendamentos.Add(a);
  }

  public void verificarAgendamento(usuario u){
    
    if (listaAgendamentos.Count == 0)
      Console.WriteLine("Sem agendamentos até o momento");
    else {
      if (u.TipoUsuario == 1){
        foreach (agendamento a in listaAgendamentos){
          Console.WriteLine("\nEstabelecimento: {0}", a.Estabelecimento);
          Console.WriteLine("Serviço: {0}", a.ServicoSolicitado.Nome);
          Console.WriteLine("Data Agendamento: {0}", a.DataAgendamento);
          Console.WriteLine("Hora Agendamento: {0}", a.HoraAgendamento);
        }
      }
      else{
        foreach (agendamento a in listaAgendamentos){
          Console.WriteLine("\nCliente: {0}", a.Solicitante.Nome);
          Console.WriteLine("Endereço: {0}", a.Solicitante.Endereco);
          Console.WriteLine("Serviço: {0}", a.ServicoSolicitado.Nome);
          Console.WriteLine("Data Agendamento: {0}", a.DataAgendamento);
          Console.WriteLine("Hora Agendamento: {0}", a.HoraAgendamento);
          Console.WriteLine("Valor do Serviço: R$ {0}", a.ServicoSolicitado.Valor);
        }
      }
    }
    
  }
  
}

