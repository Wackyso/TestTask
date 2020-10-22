using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using TaskTrJunNET.Class;
using TaskTrJunNET.Interface;
using TaskTrJunNET.Model;

namespace TaskTrJunNET.UI
{
     class UserInterface
    {
        
        private static int GetAnswer(int v)
        {
            
            int a = 0;
            bool res;
            do
            {
                res = int.TryParse(Console.ReadLine(), out a);
                res = a<=v && a>=1;

            } while (!res);
            return a;
        }


        public static void Window(Firm firm)
        {
            Console.WriteLine("1) Управление кадрами");
            Console.WriteLine("2) Заставить работать кого-то из персонала");
            Console.WriteLine("3) Информация по кадрам фирмы");
            int v = 3;
            int a=0;
            a = GetAnswer(v);

            if (a == 1) MemberControl(firm);
            else if (a == 2) GiveWork(firm);
            else Information(firm);
            
        }

        static void MemberControl(Firm firm)
        {
            Console.WriteLine("1) Нанять работника");
            Console.WriteLine("2) Уволить работника");
            Console.WriteLine("3) Назад");
            int v = 3;
            int a = 0;
            a = GetAnswer(v);
            if (a == 3) Window(firm);
            if (a == 1)
            {
                Post post = Post();
                string firstname = Firstname();
                string secondname = Secondname();
                string thirdname = Thirdname();
                if (post == Class.Post.ComonWorker) UIModel.NewCommonEmploy(firm, firstname, secondname, thirdname, post, new CommonWorkerWork());
                if (post == Class.Post.Manager) UIModel.NewEmployManager(firm, firstname, secondname, thirdname, post, new ManagerWork(),new ManagerSpecialWork());
                if (post == Class.Post.TaskMaster) UIModel.NewEmployTaskMaster(firm, firstname, secondname, thirdname, post, new TaskMasterWork(), new TaskMasterSpecialWork());
                Window(firm);
            }

            if (a == 2) 
            {
                UIModel.RemoveWorker(firm, SearchWorker(firm));
                Window(firm);
            }
        }

        static void GiveWork(Firm firm)
        {
            Console.WriteLine("1) Дать работнику задание выпускать продукцию ТМ Сизиф");
            Console.WriteLine("2) Посоветовать менеджеру собирать заказы ");
            Console.WriteLine("3) Посоветовать менеджеру внось загрузить работника (введите менеджера затем работника)");
            Console.WriteLine("4) Послать бригадира за материалом");
            Console.WriteLine("5) Послать бригадира проверять работу некого работника (введите бригадира затем работника)");
            Console.WriteLine("6) Назад");
            int v = 6;
            int a = 0;
            a = GetAnswer(v);
            if (a == 6) Window(firm);
            if (a == 1) UIModel.TryWork(SearchWorker(firm,Class.Post.ComonWorker));
            if (a == 2) UIModel.TryWork(SearchWorker(firm, Class.Post.Manager));
            if (a == 3) UIModel.TryWork(SearchWorker(firm, Class.Post.Manager), SearchWorker(firm, Class.Post.ComonWorker));
            if (a == 4) UIModel.TryWork(SearchWorker(firm, Class.Post.TaskMaster));
            if (a == 5) UIModel.TryWork(SearchWorker(firm, Class.Post.TaskMaster), SearchWorker(firm, Class.Post.ComonWorker));
            Window(firm);
        }

        static void Information(Firm firm)
        {
            Console.WriteLine("1) Уточнить зарегестрирвоан ли в фирме все еще сотрудник");
            Console.WriteLine("2) Вывести на экарн сотрудников определенной должности");
            Console.WriteLine("3) Вывести количество сотрудников определеной должности");
            Console.WriteLine("4) Собрать всех сотрудников на одном экране");
            Console.WriteLine("5) Назад");
            int v = 5;
            int a = 0;
            a = GetAnswer(v);

            if (a == 1) UIModel.GetKnoledge(firm,SearchWorker(firm));
            if (a == 2) UIModel.GetByPost(firm,Post());
            if (a == 3) UIModel.GetCountByPost(firm,Post());
            if (a == 4) UIModel.GetAll(firm);

            if (a == 5) Window(firm);
            Window(firm);
        }

        static Post Post()
        {
            Console.WriteLine("1) Обычный работник");
            Console.WriteLine("2) Менеджер");
            Console.WriteLine("3) Бригадир");

            int v = 3;
            int a = 0;
            a = GetAnswer(v);
            Post post;
            if (a == 1) post = Class.Post.ComonWorker;
            else if (a == 2) post = Class.Post.Manager;
            else post = Class.Post.TaskMaster;
            return post;

        }
        static string Firstname()
        {
            Console.WriteLine("Введите имя работника");
            string name= Console.ReadLine();
            return name;
        }
        static string Secondname()
        {
            Console.WriteLine("Введите фамилию работника");
            string name = Console.ReadLine();
            return name;
        }
        static string Thirdname()
        {
            Console.WriteLine("Введите отчество работника");
            string name = Console.ReadLine();
            return name;
        }

        static IWorker SearchWorker(Firm firm)
        {
            Post post = Post();
            string firstname = Firstname();
            string secondname = Secondname();
            string thirdname = Thirdname();

            ISearch searsh = new Search();
            IWorker worker = searsh.GetWorker(firm, post, firstname, secondname, thirdname);
            return worker;
        }

        static IWorker SearchWorker(Firm firm, Post post)
        {
            string firstname = Firstname();
            string secondname = Secondname();
            string thirdname = Thirdname();

            ISearch searsh = new Search();
            IWorker worker = searsh.GetWorker(firm, post, firstname, secondname, thirdname);
            return worker;
        }

    }
}
