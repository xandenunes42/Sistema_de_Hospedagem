using Models.Hospedes;
using Models.Suites;
using Models.Reserva;


Pessoa pessoa1 = new Pessoa(nome: "Alexandre", sobrenome: "Nunes");
Pessoa pessoa2 = new Pessoa(nome: "Alexandre", sobrenome: "Nunes");
Pessoa pessoa3 = new Pessoa(nome: "Alexandre", sobrenome: "Nunes");
Pessoa pessoa4 = new Pessoa(nome: "Alexandre", sobrenome: "Nunes");
Pessoa pessoa5 = new Pessoa(nome: "Alexandre", sobrenome: "Nunes");
Pessoa pessoa6 = new Pessoa(nome: "Alexandre", sobrenome: "Nunes");
Pessoa pessoa7 = new Pessoa("Alexandre","Oliveira");

Suite suite1 = new Suite("Suite Premium", 5, 100.00M);

var reserva = new Reserva();

reserva.CadastrarHospede(pessoa1);
reserva.CadastrarHospede(pessoa2);
reserva.CadastrarHospede(pessoa3);
reserva.CadastrarHospede(pessoa4);
reserva.CadastrarHospede(pessoa5);
reserva.CadastrarHospede(pessoa6);
reserva.CadastrarHospede(pessoa7);

reserva.CadastrarSuite(suite1);

reserva.ListarHospedes();

reserva.ContadorHospedes();

Console.WriteLine($"Valor final: {reserva.ValorFinal(12, suite1)}");

int opcao = 1;

/*switch(opcao)
{
    case 1:
    {
        reserva.CadastrarHospede(pessoa1);
        break;
    }
    case 2:
    {
        reserva.CadastrarSuite(suite1);
        break;
    }
}
*/



