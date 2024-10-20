using Models.Hospedes;
using Models.Suites;
using Models.Reserva;


Pessoa pessoa1 = new Pessoa(nome: "Alexandre", sobrenome: "Nunes");
Pessoa pessoa2 = new Pessoa("Maria","Antonia");

Suite suite1 = new Suite("Suite Premium", 5, 100.50M);

var reserva = new Reserva();

reserva.CadastrarHospede(pessoa1);
reserva.CadastrarHospede(pessoa2);
reserva.CadastrarSuite(suite1);

reserva.ListarHospedes();

reserva.ContadorHospedes();

Console.WriteLine($"Valor final: {reserva.ValorFinal(4, suite1)}");




