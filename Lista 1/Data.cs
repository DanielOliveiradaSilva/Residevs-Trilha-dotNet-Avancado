using System.Data.SqlTypes;

namespace AulaDotentModuloAvancado
{
    public class Data
    {
        public int dia;
        public int mes;
        public int ano;
        private int hora;
        private int minuto;
        private int segundo;

        public const int FORMATO_12H = 12;
        public const int FORMATO_24H = 24;
        public Data(int dia, int mes, int ano)
        {
            this.dia = dia;
            this.mes = mes;
            this.ano = ano;
        }

        public Data(int dia, int mes, int ano, int hora, int minutos, int segundo) : this(dia, mes, ano)
        {
            this.SetHora(hora);
            this.minuto = minutos;
            this.segundo = segundo;

        }

        private void SetHora(int hora)
        {
            if (hora < 0 || hora > 23)
            {
                throw new ArgumentOutOfRangeException("A hora deve estar entre 0 e 23.");
            }
            this.hora = hora;
        }
        public void Imprimir(int formatoHora)
        {
            string data = $"{dia}/{mes}/{ano}";

            if (hora != 0 || minuto != 0 || segundo != 0)
            {
                if (formatoHora == FORMATO_12H)
                {
                    Console.WriteLine($"{data} {hora % 12}:{minuto:D2}:{segundo:D2} {(hora < 12 ? "AM" : "PM")}");
                }
                else if (formatoHora == FORMATO_24H)
                {
                    Console.WriteLine($"{data} {hora:D2}:{minuto:D2}:{segundo:D2}");
                }
            }

        }

    }
}
