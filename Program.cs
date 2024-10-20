using Models.Hospedes;
using Models.Suites;
using Models.Reserva;


Pessoa pessoa1 = new Pessoa(nome: "Alexandre", sobrenome: "Nunes");
Pessoa pessoa2 = new Pessoa("Andressa","Nunes");

Suite suite1 = new Suite("Suite Premium", 5, 100.00M);

var reserva = new Reserva();

reserva.CadastrarHospede(pessoa1);
reserva.CadastrarHospede(pessoa2);

reserva.ListarHospedes();


