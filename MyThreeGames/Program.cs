namespace MyThreeGames
{
    class Program
    {
        public static int numberRoom = 0;
        public static bool hasKey = false;
        public static bool hasModel = false;

        static void Main(string[] args)
        { 
            Introcduction();
            while (true)
            {
                if (numberRoom == 1) ActionStartShip();
                else if (numberRoom == 2) ActionTemple();
                else if (numberRoom == 3) ActionLivingRoom();
                else if (numberRoom == 4) ActionDangerRoom();
                else if (numberRoom == 5) ActionQuestRoom();
                else if (numberRoom == 6) ActionOtherShip();
                
            }
        }

        static void ActionStartShip()
        {

        }

        static void ActionTemple()
        {

        }

        static void ActionLivingRoom()
        {
            
        }

        static void ActionDangerRoom()
        {

        }

        static void ActionQuestRoom()
        {

        }

        static void ActionOtherShip()
        {

        }

        static void Introcduction()
        {
            Console.WriteLine("Ты смутно помнишь где ты... даже кто ты...");
            Console.ReadLine();
            Console.WriteLine("Тело сдавлено, однако твой мозг уже подаёт сигналы к жизни...");
            Console.WriteLine("Он говорит ремень");
            Console.ReadLine();
            Console.WriteLine("Сжимает не всё тело, а именно грудная клетка, машинально ты бьешь куда ниже будра...");
            Console.WriteLine("Щелчок и ты летишь куда-то вниз...");
            Console.ReadLine();
            Console.WriteLine("Небольшой удар о пол твоего корабля, да после такой встряски твой мозг точно начал работать....");
            Console.WriteLine("Со скоростью молнии ты вспоминаешь последние 24 часа, хотя тебе и не хочется вспоминать...");
            Console.ReadLine();
            Console.WriteLine("Вы в составе 3-ей эскадры были отправлены на патрулирование близ Кеплана-7");
            Console.WriteLine("Дежурство как дежурство, последние 2 года все дни были практически одинаковые");
            Console.WriteLine("Разве что менялось это виды космоса... хотя что интересного в нём можно увидеть");
            Console.ReadLine();
            Console.WriteLine("Ваша эскадра стояла на удаления пару десятков тысяч километров над поверхностью планеты");
            Console.WriteLine("Внезапно ты заметил, что зелёный Кеплан стал больше и он увеличивается");
            Console.WriteLine("Нет, он стоит на месте,  это просто вашу эскадру тянет к нему, будто сильным магнитом");
            Console.ReadLine();
            Console.WriteLine("Последние 10 минут, что ты помнишь - это то так тщетно пытался выбраться из этого магнитного поля");
            Console.WriteLine("Однако... теперь ты здесь... и судя по всему приземлился ты не очень...");
            Console.WriteLine("Энергощит защитил шатал от критических повреждений, зато теперь топливо практически на нуле");
            Console.WriteLine("Разбираться с тем, что произошло будем потом, сейчас надо найти топливо");
            Console.WriteLine("В любом случае нужно хотя бы покинуть корабль");
        }

        static int GetIntInRange(int optionsNumber)
        {
            string input = Console.ReadLine();
            int number = -1;
            bool isConvert = int.TryParse(input, out number);
            bool isInRange = number >= 1 && number <= optionsNumber;

            while (!isConvert || !isInRange)
            {
                Console.WriteLine("Неверная опция, попробуй ещё раз");
                input = Console.ReadLine();
                isConvert = int.TryParse(input, out number);
                isInRange = number >= 1 && number <= optionsNumber;
            }
            return number;
        }
    }
}