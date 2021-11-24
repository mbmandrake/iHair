using System;

class Program {
  public static void Main (string[] args) {
    
    cliente c = new cliente("Fernanda", "123", "312312312", "Endereço Cliente", "email", 1, false, false, false, "123123123");
    funcionario f = new funcionario("Matheus", "123", "312312312", "Endereço Funcionário", "email", 2, true, true, true);

    listas l = new listas();
    servico s = new servico("Manicure", 30.00, 10);
    agendamento a = new agendamento("Salão Vilma Simões", s, c, "25/11/2021", "10:00", 1);

    debito cd = new debito();
    credito cc = new credito();
    pix px = new pix();
    

    //Teste Lista de agendamento vazio
    l.verificarAgendamento(c);

    // Adicionando agendamento
    l.addAgendamento(a);

    //Testando lista para cliente
    l.verificarAgendamento(c);

    //Testando lista para funcionário
    l.verificarAgendamento(f);

    //Checando pagamentos
    cd.realizarPagamento(100);
    cc.realizarPagamento(100);
    px.realizarPagamento(100);

  }
}