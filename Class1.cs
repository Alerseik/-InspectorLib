using System;


namespace InspectorLib
{
    public class FunctionInsp
    {
        
      

        String[] Fif = { "Иванов И.И. Зиронов Т.А., Миронов А.В., Васильев В.И." };
        String Fif2 = "Главный инспектор-Васильев Василий Иванович";

        //1
        public void GetInspector()
        {
            Console.WriteLine("1 ");
            Console.WriteLine($"Главный инспектор – {Fif2}");
        }
        // 2
       
      public  void GetСarInspection()
        {
            Console.WriteLine("2 ");
            Console.WriteLine(" Автоинспекция г. Чита");
        }
        //3 задание
        public string SetInspector()
        {
          
            string pop1;
            Console.WriteLine($"Введите имя нового главного инспектора из списка");
            Console.WriteLine($"Список инспекторов: 1-Иванов Иван Иванович 2-Зиронов Татар Александрович 3-Миронов Ааврал Васильевич 4-Васильев Василий Иванович");

            pop1 = Console.ReadLine();
            Console.WriteLine("Главный инспектор-" + pop1);
            return pop1;
        }
        //5
        public void GetWorker()
        {
            Console.WriteLine("5 ");
            Console.WriteLine("5 ");
            Console.WriteLine($"Сотрудники:");
            for(int i=0; i<Fif.Length;i++ )
            {
                Console.WriteLine($"{Fif[i]}");
            }

        }
        //6
        public void AddWorker()
        {
            string pop;
            Console.WriteLine("6 ");
            Console.WriteLine("Введите Сотрудника ");
            pop = Console.ReadLine();
            Console.WriteLine("Иванов И.И. Зиронов Т.А., Миронов А.В., Васильев В.И.," + pop);


           
           

        }
        //4
      public  void GenerateNumber()
        {
            Console.WriteLine("4 ");
            Random rand = new Random();

            int stringlen = rand.Next(1, 1);
            int randValue;
            string symbol = "";
            char letter;

            for (int i = 0; i < stringlen; i++)
            {

                // Генерация случайного числа.
                randValue = rand.Next(0, 26);

                //Генерация случайного символа путем преобразования
                //Случайное число в символ.
                letter = Convert.ToChar(randValue + 65);

                //Добавление буквы к строке.
                symbol = symbol + letter;
            }

            Random sluchainaya_velichina = new Random(); //Обращение к классу случайных величин
            int Number = sluchainaya_velichina.Next(1, 100); //Переменная Number принимает значение от 1 до 6

            Random sluchainaya_velichina1 = new Random();
            int code = sluchainaya_velichina1.Next(1, 75);

            Console.Write("Госномер:" + symbol + "-" + Number + "-" + code);//Вывод результата

        }

    }
  
}
    


