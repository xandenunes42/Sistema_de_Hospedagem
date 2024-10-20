using Models.Hospedes;
using Models.Suites;

namespace Models.Reserva
{
    public class Reserva
    {
        List<Pessoa> Hospedes {get; set;}
        List<Suite> Suites {get; set;}
        public int DiasReservados {get; set;}

        public Reserva()
        {
            Hospedes = new List<Pessoa>();
            Suites = new List<Suite>();
        }


        public void CadastrarHospede(Pessoa hospede)
        {
            Hospedes.Add(hospede);

            Console.WriteLine($"Cadastro efetuado: Nome: {hospede.Nome}");

        }   

        public void ListarHospedes()
        {
            foreach(var i in Hospedes)
            {
                Console.WriteLine($"Nome: {i.Nome} {i.Sobrenome}");
            }
        }


    }
}