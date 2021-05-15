using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duck
{
  class Program
  {
    class Ducks //класс уток
    {
      public string name;
      public int lake;
      public bool swim { get; set; } = false;
      public bool fly { get; set; } = false;
      public bool run { get; set; } = false;
      public bool fish { get; set; } = false;
      public bool home { get; set; } = false;
      
      public int caught;
      public string characht;
      public int num;

      public void GetInfo()
      {
        Console.WriteLine($"Порода: {name}");
        Console.WriteLine($"Номер: {num}");
        
        if (swim == true)
        {
          Console.WriteLine("Умеет плавать");
        }
        
        if (fly == true)
        {
          Console.WriteLine("Умеет летать");
        }
        
        if (run == true)
        {
          Console.WriteLine("Умеет бегать");
        }

        if (fish == true)
        {
          Console.WriteLine("Умеет рыбачить");
        }

        if (home == true)
        {
          Console.WriteLine("Знает, где живет");
        }
        else
        {
          Console.WriteLine("Не знает, где живет");
        }

        Console.WriteLine($"Характеристики: {characht}");
        Console.WriteLine($"Поймали: {caught} раз");

      }
    }   
    
    public static Random rnd = new Random();
    
    public static int chern = rnd.Next(1, 146);
    public static int nir = rnd.Next(1, 147 - chern);
    public static int krya = rnd.Next(1, 148 - chern - nir);
    public static int chern2 = rnd.Next(1, 149 - chern - nir - krya);
    public static int kamen = rnd.Next(1, 150 - chern - nir - krya - chern2);
    public static int chir = 151 - chern - nir - krya - chern2 - kamen;



    public static void Main(string[] args)
    {

      Ducks[] duck = new Ducks[151];
        for (int i = 0; i <= chern; i++)
      {
        duck[i] = new Ducks();
        duck[i].swim = true;
        duck[i].name = "Чернетти";
        duck[i].lake = 1;
        duck[i].characht = "Имя: Бобби, Вес: 3.5кг, Форма клюва: плоская, Возраст: 10 лет";
        duck[i].caught = 0;
        duck[i].num = i + 1;
      }
        for (int i = chern; i <= chern + nir; i++)
      {
        duck[i] = new Ducks();
        duck[i].swim = true;
        duck[i].home = true;
        duck[i].name = "Нырки";
        duck[i].lake = 1;
        duck[i].characht = "Имя: Робби, Вес: 3.2кг, Форма клюва: круглая, Возраст: 9 лет";
        duck[i].caught = 0;
        duck[i].num = i + 1;
      }
        for (int i = chern + nir; i <= chern + nir + krya; i++)
      {
        duck[i] = new Ducks();
        duck[i].run = true;
        duck[i].name = "Кряква";
        duck[i].lake = 1;
        duck[i].characht = "Имя: Добби, Вес: 3.6кг, Форма клюва: острая, Возраст: 5 лет";
        duck[i].caught = 0;
        duck[i].num = i + 1;
      }
        for (int i = chern + nir + krya; i <= chern + nir + krya + chern2; i++)
      {
        duck[i] = new Ducks();
        duck[i].swim = true;
        duck[i].home = true;
        duck[i].name = "Чернетти";
        duck[i].lake = 2;
        duck[i].characht = "Имя: Тобби, Вес: 2.9кг, Форма клюва: кривая, Возраст: 12 лет";
        duck[i].caught = 0;
        duck[i].num = i + 1;
      }
        for (int i = chern + nir + krya + chern2; i <= chern + nir + krya + chern2 + kamen; i++)
      {
        duck[i] = new Ducks();
        duck[i].fly = true;
        duck[i].home = true;
        duck[i].name = "Каменушки";
        duck[i].lake = 2;
        duck[i].characht = "Имя: Робби, Вес: 4кг, Форма клюва: сплюснутая, Возраст: 7 лет";
        duck[i].caught = 0;
        duck[i].num = i + 1;
      }
        for (int i = chern + nir + krya + chern2 + kamen; i < 151; i++)
      {
        duck[i] = new Ducks();
        duck[i].fish = true;
        duck[i].name = "Чирок";
        duck[i].lake = 2;
        duck[i].characht = "Имя: Коллин, Вес: 3.8кг, Форма клюва: закругленная, Возраст: 9 лет";
        duck[i].caught = 0;
        duck[i].num = i + 1;
      }

      int lake1 = 0;
      int swimming1 = 0;
      int flying1 = 0;
      int running1 = 0;
      int fishing1 = 0;

      int lake2 = 0;
      int swimming2 = 0;
      int flying2 = 0;
      int running2 = 0;
      int fishing2 = 0;
      

      Console.WriteLine($"Чернетти: {chern}");
      Console.WriteLine($"Нырки: {nir}");
      Console.WriteLine($"Кряква: {krya}");
      Console.WriteLine($"Чернетти: {chern2}");
      Console.WriteLine($"Каменушки: {kamen}");
      Console.WriteLine($"Чирок: {chir}");

      Console.WriteLine("Выберите номер утки, чтобы узнать о ней. Если хотите начать сезон охоты, введите 152");
      int var = Convert.ToInt32(Console.ReadLine());

      while (var != 152)
      {
        var = var - 1;
        duck[var].GetInfo();
        var = Convert.ToInt32(Console.ReadLine());+
      } //утки рассказывают о себе
      if (var == 152)
      {
        int daynum = 1;
        for (int day = 1; day <= 7; day++)
        {
          
          Console.WriteLine($"День {daynum}");
          daynum = daynum + 1;

          for (int k = 0; k < 151; k++)
          {
            if (duck[k].lake == 1)
            {
              lake1 = lake1 + 1;
              if (duck[k].swim == true)
              {
                swimming1 = swimming1 + 1;
              }
              if (duck[k].fly == true)
              {
                flying1 = flying1 + 1;
              }
              if (duck[k].run == true)
              {
                running1 = running1 + 1;
              }
              if (duck[k].fish == true)
              {
                fishing1 = fishing1 + 1;
              }

            } //подсчет уток
            if (duck[k].lake == 2)
            {
              lake2 = lake2 + 1;
              if (duck[k].swim == true)
              {
                swimming2 = swimming2 + 1;
              }
              if (duck[k].fly == true)
              {
                flying2 = flying2 + 1;
              }
              if (duck[k].run == true)
              {
                running2 = running2 + 1;
              }
              if (duck[k].fish == true)
              {
                fishing2 = fishing2 + 1;
              }
            }
          }
          Console.WriteLine($"На первом озере - {lake1}"); //вывод озер
          Console.WriteLine($"Плавающих - {swimming1}");
          Console.WriteLine($"Летающих - {flying1}");
          Console.WriteLine($"Бегающих - {running1}");
          Console.WriteLine($"Рыбачащих - {fishing1}");
          Console.WriteLine("----------------------------------"); //разделитель
          Console.WriteLine($"На втором озере - {lake2}");
          Console.WriteLine($"Плавающих - {swimming2}");
          Console.WriteLine($"Летающих - {flying2}");
          Console.WriteLine($"Бегающих - {running2}");
          Console.WriteLine($"Рыбачащих - {fishing2}");
          Console.WriteLine("----------------------------------"); //разделитель


          int hunt = rnd.Next(1, 8); //охотники первой фермы
          int hunt2 = rnd.Next(3, 5);
          Console.WriteLine($"Охотники 1-й фермы поймали {hunt + hunt2}");

          for (int i = 1; i <= hunt; i++)
          {
            int popal = rnd.Next(1, 151);
            if (duck[popal].lake == 3 && duck[popal].lake == 4)
            {
              while (duck[popal].lake == 3 && duck[popal].lake == 4)
              {
                popal = rnd.Next(1, 151);
              }
            }
            duck[popal].lake = 3;
            duck[popal].caught = duck[popal].caught + 1;
          }

          for (int i = 1; i <= hunt2; i++)
          {
            int popal2 = rnd.Next(1, 151);
            if (duck[popal2].lake == 3 && duck[popal2].lake == 4)
            {
              while (duck[popal2].lake == 3 && duck[popal2].lake == 4)
              {
                popal2 = rnd.Next(1, 151);
              }
            }
            duck[popal2].lake = 3;
            duck[popal2].caught = duck[popal2].caught + 1;
          }


          int hunt3 = rnd.Next(1, 7); //охотники второй фермы
          int hunt4 = rnd.Next(3, 9);
          Console.WriteLine($"Охотники 2-й фермы поймали {hunt3 + hunt4}");

          for (int i = 1; i <= hunt; i++)
          {
            int popal3 = rnd.Next(1, 151);
            if (duck[popal3].lake == 3 && duck[popal3].lake == 4)
            {
              while (duck[popal3].lake == 3 && duck[popal3].lake == 4)
              {
                popal3 = rnd.Next(1, 151);
              }
            }
            duck[popal3].lake = 4;
            duck[popal3].caught = duck[popal3].caught + 1;
          }

          for (int i = 1; i <= hunt2; i++)
          {
            int popal4 = rnd.Next(1, 151);
            if (duck[popal4].lake == 3 && duck[popal4].lake == 4)
            {
              while (duck[popal4].lake == 3 && duck[popal4].lake == 4)
              {
                popal4 = rnd.Next(1, 151);
              }
            }
            duck[popal4].lake = 4;
            duck[popal4].caught = duck[popal4].caught + 1;
          }

          for (int i = 0; i < 151; i++) //побег с фермы
          {
            if (duck[i].lake == 3)
            {
              if (duck[i].fly == true && duck[i].home == true && duck[i].caught < 2)
              {
                duck[i].lake = rnd.Next(1, 2);
              }
            }
            if (duck[i].lake == 4)
            {
              if (duck[i].swim == true && duck[i].home == false && duck[i].caught < 2)
              {
                duck[i].lake = rnd.Next(1, 2);
              }
            }
          }

          int farm1 = 0;
          int farm2 = 0;

          for (int i = 0; i < 151; i++)
          {
            if (duck[i].lake == 3)
            {
              farm1 = farm1 + 1;
            }

            if (duck[i].lake == 4)
            {
              farm2 = farm2 + 1;
            }
          } //подсчет кол-ва на фермах
          Console.WriteLine("----------------------------------"); //разделитель
          Console.WriteLine($"На ферме 1 - {farm1}");
          Console.WriteLine($"На ферме 2 - {farm2}");
          Console.WriteLine("----------------------------------"); //разделитель
          Console.WriteLine("Нажмите любую кнопку, чтобы продолжить");

          lake1 = 0;
          lake2 = 0;
          swimming1 = 0;
          swimming2 = 0;
          flying1 = 0;
          flying2 = 0;
          running1 = 0;
          running2 = 0;
          fishing1 = 0;
          fishing2 = 0;

          Console.ReadKey();

        }
      }

    }
  }
}
