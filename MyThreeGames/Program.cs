using System;
namespace MyThreeGames
{
    class Program
    {
        public static int numberRoom = 1;
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
            Console.Clear();
            Console.WriteLine("Ты находишься внутри своего C- 6 Stalking");
            Console.WriteLine("Тебе нужно топливо и очевидно, что искать его нужно не тут");
            Console.WriteLine("Доступные действия:");
            Console.WriteLine("1. Выйти из корабля");
            int option;
            if (hasModel)
            {
                Console.WriteLine("2. Свалить с этой планеты");
                option = GetIntInRange(2);
            }
            else
            {
                option = GetIntInRange(1);
            }

            if (option == 1)
            {
                Console.WriteLine("Ты выходишь из корабля");
                numberRoom = 2;
                Console.ReadLine();
            }

            else if (option == 2)
            {
                Conclusion();
            }
        }

        static void ActionTemple()
        {
            Console.Clear();
            Console.WriteLine("Ты находишься в просторного каменного зала");
            Console.WriteLine("(*Довольно странно, что упал ты именно внутрь какого то зала");
            Console.WriteLine("Перед тобой дверь из-за которой выглядывает свет");
            Console.WriteLine("Справа от неё другая дверь, выглядит так как,будто её давно не кто не пользовался ");
            Console.WriteLine("Доступные действия:");
            Console.WriteLine("1. Вернуться на корабль");
            Console.WriteLine("2. Зайти в дверь со светом внутри");
            Console.WriteLine("3. Подойти к двери справа");
            int option = GetIntInRange(3);

            if (option == 1)
            {
                Console.WriteLine("Идём обратно на корабль");
                numberRoom = 1;
                Console.ReadLine();
            }

            else if (option == 2)
            {
                Console.WriteLine("Ты идёшь к двери со светом и проходишь во внутрь");
                numberRoom = 3;
                Console.ReadLine();
            }

            else
            {
                OpenOldDoor();
            }
        }

        static void OpenOldDoor()
        {
            Console.WriteLine("Ты подошел к двери справа, из неё будто бы веет холодом");
            Console.WriteLine("На двери висит замочек (Замочная скважина треугольной формы)");

            if (!hasKey)
            {
                Console.WriteLine("Пытаешься открыть дверь, но это тщетно, замок у её руки очевидно против этого");
                Console.WriteLine("Найти бы ключ от замка...");
                Console.WriteLine("Возможно нужно смотреть другие помещения");
                Console.WriteLine("Возвращаемся в цент зала");
            }

            else
            {
                Console.WriteLine("Не долго думал ты достаешь ключ, найденный ранее");
                Console.WriteLine("Замок со скрипом  поддается открытию. ты проходишь внутрь");
                numberRoom = 4;
            }
            Console.ReadLine();
        }

        static void ActionLivingRoom()
        {
            Console.Clear();
            Console.WriteLine("Открыть дверь ты попал в маленькое помещения, будто чулан");
            Console.WriteLine("Хотя здесь точно недавно кто-то был, ведь горит каменный камин");
            Console.WriteLine("Здесь будто недавно кто-то был...");
            Console.WriteLine("* а раз кто-то здесь был,то здесь наверняка есть что-то интересное");
            int option;
            Console.WriteLine("Доступные действия:");
            Console.WriteLine("1. Вернуться обратно в зал");

            if (!hasKey)
            {
                Console.WriteLine("2. Обыскать помещение");
                option = GetIntInRange(2);
            }
            else
            {
                option = GetIntInRange(1);
            }

            if (option == 1)
            {
                Console.WriteLine("Возвращаемся обратно...");
                numberRoom = 2;
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("В течение нескольких (возможно десятков) минут ты обследуешь все помещение");
                Console.WriteLine("Кроме какой-то мебели и тряпок ничего интересного нет, хотя...");
                Console.WriteLine("Рядом с камином ты видишь что-то блистящее, и не задумываясь двигаясь к нему");
                Console.WriteLine("Поздравляю, ты нашел ключ... только от чего он?");
                hasKey = true;
                Console.ReadLine();
            }
        }

        static void ActionDangerRoom()
        {
            Console.Clear();
            Console.WriteLine("Как только ты вошел в комнату, ты сразу почувствовал себя неуютно");
            Console.WriteLine("Отсюда хочется поскорее сбежать, все твое нутро тебе говорит об это");
            Console.WriteLine("В этом помещении очень темно, однако ты будто бы видишь вдалеке слева луч света");
            Console.WriteLine("Доступные действия:");
            Console.WriteLine("1. Вернуться обратно");
            Console.WriteLine("2. Добежать до света");
            Console.WriteLine("3. Обследовать темные углы этого помещения");
            int option = GetIntInRange(3);

            if (option == 1)
            {
                Console.WriteLine("Возвращаемся обратно...");
                numberRoom = 2;
                Console.ReadLine();
            }

            else if (option == 2)
            {
                Console.WriteLine("Подойдя ближе к свету, ты понял, что этот свет исходит из двери");
                Console.WriteLine("В этот темном зале тебе было не по себе, недолго думая ты заходишь во внутрь");
                numberRoom = 5;
                Console.ReadLine();
            }

            else
            {
                Death();
            }
        }

        static void Death()
        {
            Console.WriteLine("Дойдя до темных частей тебя охватывает дрожь по всему телу");
            Console.WriteLine("В этой темной бездне точно что-то сокрыто и оно будто движется к тебе");
            Console.WriteLine("Ты пытаешься бежать обратно, но страх так силен, что ты едва сумел развернуться");
            Console.WriteLine("Хотя это уже не имеет значения, что-то быстро летит к тебе сзади");
            Console.WriteLine("Ты понимаешь, что это конец...");
            Console.WriteLine("Лучше бы послушал свою интуицию...");
            Console.ReadLine();
            Environment.Exit(0);
        }

        static void ActionQuestRoom()
        {
            Console.Clear();
            Console.WriteLine("А в этом зале довольно уютно");
            Console.WriteLine("Зал небольшой, спереди находиться какая-то дверь со странным замком");
            Console.WriteLine("На стенах что-то написано краской серебряного цвета");
            Console.WriteLine("Доступные действия:");
            Console.WriteLine("1. Вернуться обратно в страшный зал");
            Console.WriteLine("2. Подойти к двери с замком");
            int option = GetIntInRange(2);


            if (option == 1)
            {
                Console.WriteLine("Возвращаюсь обратно");
                numberRoom = 4;
                Console.ReadLine();
            }

            else
            {
                CompleteQuest();
            }
        }

        static void CompleteQuest()
        {
            Console.WriteLine("Подойти к двери ты обнаружил, что на ней висит кодовый замок");
            Console.WriteLine("Чтобы открыть его нужно ввести слово из 9 букв, хм... что это за слово...");
            Console.WriteLine("Недолго подумав ты решаешь разглядеть надписи на стенках, на них написано:");
            Console.WriteLine("+==============================================================");
            Console.WriteLine("Есть я у мужа, у зверя, у мёртвого камня, у облака.");
            Console.WriteLine("В душу не лезу, ловлю изменения облика.");
            Console.WriteLine("Дева, взглянув на меня, приосанится");
            Console.WriteLine("Старец нахмурится, дитятко расхулиганится.");
            Console.WriteLine("Кто я? (*последняя строка написано прямо под дверью)");

            Console.Write("Теперь нужно ввести слово: ");
            string answer = Console.ReadLine();

            while (answer.ToLower() != "отражение")
            {
                Console.Write("Не угадал ты а ну ка давай как ещё: ");
                answer = Console.ReadLine();
            }
            Console.WriteLine("Комната открылась давай мистер мозг проходи в нутрь.");
            numberRoom = 6;
            Console.ReadLine();
        }

        static void ActionOtherShip()
        {
            Console.Clear();
            Console.WriteLine("Зайдя во внутрь ты видишь разрушенный зал, сквозь потолок льется свет");
            Console.WriteLine("Дыра сверху была проделана кораблем твоего командира....");
            Console.WriteLine("Корабль вонзился в пол, состояние его плачевное....");
            Console.WriteLine("Однако дверь открыта, ты заходишь внутрь, к сожалению там никого нету");
            Console.WriteLine("Разбираться с этим нет времени, нужно найти  модуль питания, если он уцелел");
            int option;
            Console.WriteLine("Доступные действия:");
            Console.WriteLine("1. Вернуться обратно в комноту с загадкой");

            if (!hasModel)
            {
                Console.WriteLine("2. Осмотреть энергомодуль корабля");
                option = GetIntInRange(2);
            }

            else
            {
                option = GetIntInRange(1);
            }
            ChooseOptionInOtherShip(option);
        }

        static void ChooseOptionInOtherShip(int option)
        {
            if (option == 1)
            {
                Console.WriteLine("Возвращаемся обратно...");
                numberRoom = 5;
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Подойдя к энергетическому модулю ты с радостью обнаруживаешь,");
                Console.WriteLine("что индекатор показывает десятую часть заряда. Этого должно хватит для полёта");
                Console.WriteLine("Этот корабль в негодном состоянии, придется возвращаться на свой");
                Console.WriteLine("Ты аккуратно извлекаешь  энергомодуль, теперь можно отправляться обратно");
                hasModel = true;
                Console.ReadLine();
            }
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

        static void Conclusion()
        {
            Console.WriteLine("\nУра мы взлетели и датчики показывают что с топливом теперь всё порядок");
            Console.WriteLine("И мы спокойно летим на встречу новым приключениям....");
            Console.WriteLine("Надо прилечь отдохнуть........");
            Console.WriteLine("===========================================================");
            Console.WriteLine("Разработчик: \tРоман Хоменко");
            Console.WriteLine("\t\tКонец!");

            Console.ReadLine();
            Environment.Exit(0);
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