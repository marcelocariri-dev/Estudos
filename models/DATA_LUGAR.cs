using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace EXEMPLOF.models
{
    public class DATA_LUGAR
    {
        public DATA_LUGAR()
        {

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
        //using System.Globalization; // Importe este namespace
        //CultureInfo.CurrentCulture vpega a cultura a atual
        //Console.WriteLine("Informações sobre a cultura atual:");

        // CurrentCulture: Afeta a formatação de números, datas, moedas, etc.
        // É o que influencia como double.Parse() interpreta a string.
      //  CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
      //  Console.WriteLine($"  CurrentCulture.Name: {currentCulture.Name} (Ex: pt-BR, en-US)");
      //  Console.WriteLine($"  CurrentCulture.DisplayName: {currentCulture.DisplayName}");
      //  Console.WriteLine($"  CurrentCulture.NumberFormat.NumberDecimalSeparator: '{currentCulture.NumberFormat.NumberDecimalSeparator}'");
      //  Console.WriteLine($"  CurrentCulture.NumberFormat.NumberGroupSeparator: '{currentCulture.NumberFormat.NumberGroupSeparator}'");
      //  Console.WriteLine($"  CurrentCulture.DateTimeFormat.ShortDatePattern: {currentCulture.DateTimeFormat.ShortDatePattern}");
       // Console.WriteLine($"  CurrentCulture.DateTimeFormat.LongTimePattern: {currentCulture.DateTimeFormat.LongTimePattern}");
       // Console.WriteLine($"  CurrentCulture.TwoLetterISOLanguageName: {currentCulture.TwoLetterISOLanguageName}");
       // Console.WriteLine($"  CurrentCulture.IsNeutralCulture: {currentCulture.IsNeutralCulture}");
       // Console.WriteLine($"  CurrentCulture.Parent.Name: {currentCulture.Parent.Name}");
       // Console.WriteLine();

        // CurrentUICulture: Afeta os recursos de UI, como strings de mensagens e rótulos
        // em diferentes idiomas.
       // CultureInfo currentUICulture = Thread.CurrentThread.CurrentUICulture;
      //  Console.WriteLine("Informações sobre a cultura da UI atual:");
       // Console.WriteLine($"  CurrentUICulture.Name: {currentUICulture.Name}");
      //  Console.WriteLine($"  CurrentUICulture.DisplayName: {currentUICulture.DisplayName}");
      //  Console.WriteLine();

    }
}