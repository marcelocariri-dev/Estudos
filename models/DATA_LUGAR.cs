using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace EXEMPLOF.models
{
    public class DATA_LUGAR
    { public DATA_LUGAR () {

    }

        public DATA_LUGAR(string datastring)
        {
            DataString = datastring;
        
    }

        //simulando desconstrutor

        public void desconstruct(out string datastring)
        {
            datastring = DataString; //  aqui ele pega o valor da PROP e joga para a variável do parametro com out
                                     // ficaria no programa assim: chamando o construtor normal - Data_Lugar data = new Data_Lugar("08/02/2012 8:00")
                                     // depois pode chama o desconstrutor para ele fazer o get desses valores (string datastring) = data;
                                      // console.writeline(datastring)  

        }       

        public DateTime DATA { get; set; }
        string DataString { get; set; } = "";

        public void Retorno()
        {
            DATA = DateTime.Now;

            Console.WriteLine(DATA.ToString("dd/MM/yyyy HH:mm"));

        }


        public void SomenteData()
        {
            DATA = DateTime.Now;

            Console.WriteLine(DATA.ToShortDateString());

        }

        public void Conversão()
        {
            string DataStrings = DataString;
            try
            {
                DateTime.TryParseExact(DataStrings, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);
                Console.WriteLine($" Resultado da dataconversão {data}");
            }
            catch (Exception ex)
            {
                throw new Exception($"data invalida {ex.Message}", ex);
            }
        }
    }
}