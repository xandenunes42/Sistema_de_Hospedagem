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
            if(Hospedes.Count < 5)
            {
                Hospedes.Add(hospede);
            }
            else
            {
                
            }

        }   

        public void ListarHospedes()
        {
            foreach(var i in Hospedes)
            {
                Console.WriteLine($"Nome: {i.Nome} {i.Sobrenome}");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suites.Add(suite);

            Console.WriteLine($"Suite cadastrada! {suite.TipoSuite}");
        }

        public void ListarSuites()
        {
            foreach(var i in Suites)
            {
                Console.WriteLine($"Suite: {i.TipoSuite}\nPreco: {i.ValorDiaria}");
            }
        }

        public void ContadorHospedes()
        {
            Console.WriteLine($"Total de hospedes: {Hospedes.Count()} ");
        }

        public decimal ValorFinal(int diasReservados, Suite suite)
        {
            decimal result;

            if(diasReservados > 10)
            {
            
            decimal desconto = 0.10M;

            result = diasReservados * (suite.ValorDiaria - (suite.ValorDiaria * desconto));
            
            return result;
            }
            else
            {
                result = diasReservados * suite.ValorDiaria;

                return result;
            }
        }


    }
}