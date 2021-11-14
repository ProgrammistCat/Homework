using System;

namespace Homework
{
    
    /*
     * ООП - объектно-ориентированный подход
     * ФП - функциональный подход
     *
     * Класс - описание объекта, (создание своего типа данных)
     * Объект - 
     *
     *
     * Programmer
     * Software engineer
     *
     * Инкапсуляция
     * Операторы доступа - public private protected
     *
     * 
     *
     * 
     */
    
    
    /*
     *
     * Класс - описание объекта, его собственный тип данных.
     * Объект - некая сущность, переменная типа данных класса. Если класс - имя прилагательное,
     то объект - само существительное.
     * Методы - функции, которые находятся в классе и могут выполнять какие-либо действия над данными (свойствами) класса.
     * Свойства (в чем отличие от Поле) - поле - то же свойство (переменная), только для объекта,
     а ещё его вызывают через класс, в котором оно содержится.
     * Операторы доступа - показатели того, будет ли виден (доступен)
     данный элемент (например, класс) из других элементов.
     * Инкапсуляция - сокрытие данных.
     * Отношения классы (виды, отличия, пример) -
     1.Наследование: класс-сын наследует функционал класса-родителя,
     а его объекты считаются объектами класса-родителя тоже. Геометрическая фигура-квадрат (квадрат IS A геометрическая фигура).
     
     2.Реализация: мы создаём метод в одном классе и вызываем его же в другом. 
     Так же мы придумываем аргументы в голове, после чего используем (реализуем) их в споре.
     
     3.Ассоциация: отношение, при котором объекты одного типа неким образом связаны с объектами 
     другого типа (используют их и/или содержат). Например, ученик(Коля Смирнов)-класс(7 "Б"). При отношении 
     ассоциации указывается кратность связей, это может быть, как на примере с учеником, 1 ко многим (напр.30).
     Композиция и агрегация - случаи ассоциации.
     
     4.Композиция: определяет отношение HAS A, то есть отношение "имеет". Связь классов крепкая, 
     один из них полностью подчиняется другому. Lunchbox(главный)-sandwich(зависимый).
     
     5.Агрегация: похоже на композицию, только реализуется слабая связь (равноправие). Зависимый класс - абстрактный или интерфейс.
     
     
     * Полиморфизм - перегрузка (когда на одно имя создано несколько методов, работающих с разными типами данных).
     * Статичные методы и свойства - методы и свойства, вызывающиеся не через объект, а через класс. (static)
     * абстрактные классы - классы, для которых нельзя (нет смысла) создавать объекты.
     * конструктор и зачем он нужен - специальный метод, который называется так же, как и класс
     и вызывается при создании нового объекта класса. В конструктор помещают начальные значения переменных экземпляра класса, 
     какие-то данные "по умолчанию".
     *
     * 
     */
    
    
    public class Drob
    {
        public Drob()
        {
            First = 0;
            Second = 0;
            Celoe = 0;
        }
        
        public Drob(int first, int second, int celoe)
        {
            First = first;
            Second = second;
            Celoe = celoe;
        }



        public int Sum(int a, int b)
        {
            return a + b;
        }


        public double Sum(double a, double b)
        {
            return a + b;
        }
        
        public string Sum(double a, string b)
        {
            return a + b;
        }


        public void A()
        {
            var abc = Sum(1.1, 1.1);


        }
        
        
        
        
        public int First { get; set; }
        public int Second { get; set; }
        public int Celoe { get; set; }

        public double DesyatDrob()
        {
            if (Celoe >= 1)
            {
                First += Celoe * Second;
            } 
            
            double result = First / Second; 
            
            return result;
        }

        public static Drob Normalize(Drob entity)
        {
            
            
            
            Drob result = new Drob();

            return result;
        } 


        public static Drob Sum(Drob first, Drob second)
        {
            Drob result = new Drob(0, 0, 0);

            int denominator = first.Second * second.Second;
            first.First *= second.Second;
            second.First *= first.Second;
            int numerator = first.First + second.First;
            int whole = first.Celoe + second.Celoe;

            first.Second = denominator;
            second.Second = denominator;

            result.First = numerator;
            result.Second = denominator;
            result.Celoe = whole;
            int choice = 0;

            if (numerator > denominator)
            {
                if (numerator % denominator == 0)
                {
                    result.Celoe += numerator / denominator;
                    result.First = 0;
                    choice = 1;
                }
                else
                {
                    result.First = numerator % denominator;
                    result.Celoe += (numerator - result.First) / denominator ;
                    choice = 2; 
                }
            } else if (numerator == denominator)
            {
                result.Celoe += 1;
                result.First = 0;
                choice = 1;
            }

            if (choice == 1)
            {
                Console.WriteLine(result.Celoe);
            }
            else
            {
                Console.WriteLine(
                    result.Celoe + " " + result.First + "/" + result.Second
                );
            }  
            
            return result;
        }
    }
}