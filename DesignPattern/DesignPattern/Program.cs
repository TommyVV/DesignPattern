using DesignPattern.Bridge.Base;
using DesignPattern.Bridge.Implement;
using DesignPattern.Builder.Implement;
using DesignPattern.Builder.Model;
using DesignPattern.Chain.BaseModel;
using DesignPattern.Chain.Implement;
using DesignPattern.Decorator.Implement;
using DesignPattern.Facade.Implement;
using DesignPattern.Factory;
using DesignPattern.Flyweight.Base;
using DesignPattern.Flyweight.Implement;
using DesignPattern.Iterator.Implement;
using DesignPattern.Iterator.Interface;
using DesignPattern.Memento.Implement;
using DesignPattern.Memento.Modal;
using DesignPattern.Observer.Implement;
using DesignPattern.Proxy.Implement;
using DesignPattern.Proxy.Interface;
using DesignPattern.State;
using DesignPattern.Strategy;
using DesignPattern.Template.Implement;
using DesignPattern.Visitor.Implement;
using DesignPattern.Visitor.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Visitor();
            //var gate = new Composite.Composite();
            //gate.Gate();
            //var gate = new Enter();
            //gate.EnterGate();      
            //Chain();
            var s = new Mediator.Mediator();
            s.Main();
        }

        #region 桥接模式

        private static void Bridge()
        {
            Project webProject = new WebProject("Web项目");
            Bridge.Base.Manager projectManager = new ProjectManager(webProject);
            Bridge.Base.Manager productManager = new ProductManager(webProject);

            projectManager.ManageProject();
            productManager.ManageProject();

            Console.ReadLine();
        }

        #endregion

        #region Flyweight 享元模式

        private static void Flyweight()
        {
            for (int i = 0; i < 2; i++)
            {
                string receiver = $"kehu{i}@qq.com";
                //通过简单工厂维护的对象池获取已经封装好的内部状态的对象。
                var email = EmailTemplateFactory.GetTemplate("阿里云漏洞修复");
                //修改外部状态
                email.Receiver = receiver;
                SendEmail(email);
            }

            Console.ReadLine();
        }

        #region SendEmail 

        private static void SendEmail(Email email)
        {
            Console.WriteLine($"主题为『{email.Subject}』的邮件已发送至：{email.Receiver}");
        }

        #endregion

        #endregion

        #region State - 状态

        private static void State()
        {
            Car tesla = new Car() { Name = "特斯拉 Model S" };
            tesla.Run();
            tesla.SpeedUp();
            tesla.SpeedDown();
            tesla.Stop();
            Console.WriteLine("开始尝试加速");
            tesla.SpeedUp();
            Console.ReadLine();
        }

        #endregion

        #region Visitor --访问者模式

        private static void Visitor()
        {
            Customer customer = new Customer
            {
                Id = 1,
                NickName = "Tommy",
                RealName = "Tommy",
                Address = "上海市",
                Phone = "158****5534",
                Zip = "210012"
            };

            Product productA = new Product { Id = 1, Name = "苹果x", Price = 1899 };
            Product productB = new Product { Id = 2, Name = "苹果x手机防爆膜", Price = 29 };
            Product productC = new Product { Id = 3, Name = "苹果x手机保护套", Price = 69 };

            OrderLine line1 = new OrderLine { Id = 1, Product = productA, Qty = 1 };
            OrderLine line2 = new OrderLine { Id = 1, Product = productB, Qty = 2 };
            OrderLine line3 = new OrderLine { Id = 1, Product = productC, Qty = 3 };

            //先买了个小米5和防爆膜
            SaleOrder order1 = new SaleOrder { Id = 1, Customer = customer, CreatorDate = DateTime.Now, OrderItems = new List<OrderLine> { line1, line2 } };

            //又买了个保护套
            SaleOrder order2 = new SaleOrder { Id = 2, Customer = customer, CreatorDate = DateTime.Now, OrderItems = new List<OrderLine> { line3 } };

            //把保护套都退了
            ReturnOrder returnOrder = new ReturnOrder { Id = 3, Customer = customer, CreatorDate = DateTime.Now, OrderItems = new List<OrderLine> { line3 } };

            OrderCenter orderCenter = new OrderCenter { order1, order2, returnOrder };


            Picker picker = new Picker { Id = 110, Name = "捡货员110" };

            Distributor distributor = new Distributor { Id = 111, Name = "发货货员111" };

            //捡货员访问订单中心
            orderCenter.Accept(picker);

            //发货员访问订单中心
            orderCenter.Accept(distributor);

            Console.ReadLine();
        }

        #endregion

        #region Memento

        public static void Memento()
        {
            Console.WriteLine("======备忘录模式======");

            List<ContactPerson> persons = new List<ContactPerson>()
            {
                new ContactPerson("张三","13800138000"),
                new ContactPerson("李四","13800138001"),
                new ContactPerson("王二","13800138002"),
            };

            Mobile mobile = new Mobile(persons);

            mobile.DisplayPhoneBook();

            //备份通讯录
            Console.WriteLine("===通讯录已备份===");
            Caretaker caretaker = new Caretaker();
            string key = DateTime.Now.ToString(CultureInfo.InvariantCulture);
            caretaker.ContactMementoes.Add(key, mobile.CreateMemento());
            Console.WriteLine($"==={key}：通讯录已备份===");

            //移除第一个联系人
            Console.WriteLine("----移除联系人----");
            mobile.GetPhoneBook().RemoveAt(0);
            mobile.DisplayPhoneBook();

            Thread.Sleep(2000);
            string key2 = DateTime.Now.ToString(CultureInfo.InvariantCulture);
            caretaker.ContactMementoes.Add(key2, mobile.CreateMemento());
            Console.WriteLine($"==={key2}：通讯录已备份===");

            //再移除一个联系人
            Console.WriteLine("----移除联系人----");
            mobile.GetPhoneBook().RemoveAt(0);
            mobile.DisplayPhoneBook();

            //恢复通讯录
            Console.WriteLine($"----恢复到最后一次通讯录备份：{caretaker.ContactMementoes.LastOrDefault().Key}----");
            mobile.RestoreMemento(caretaker.ContactMementoes[key]);
            //mobile.RestoreMemento(caretaker.ContactMementoes.LastOrDefault().Value);

            mobile.DisplayPhoneBook();

            Console.ReadLine();
        }

        #endregion

        #region ObServer

        public static void SimpleObserverTest()
        {
            Console.WriteLine("简单实现的观察者模式：");
            Console.WriteLine("=======================");
            //1、初始化鱼竿
            var fishingRod = new FishingRod();

            //2、声明垂钓者
            var jeff = new FishingMan("Tommy");

            //3、将垂钓者观察鱼竿
            fishingRod.AddSubscriber(jeff);

            //4、循环钓鱼
            while (jeff.FishCount < 100)
            {
                fishingRod.Fishing();
                Console.WriteLine("-------------------");
                //睡眠5s
                Thread.Sleep(5000);
            }
        }

        #endregion

        #region Iterator

        public static void Iterator()
        {
            Console.WriteLine("迭代器模式：");
            IListCollection list = new ConcreteList();
            var iterator = list.GetIterator();
            while (iterator.MoveNext())
            {
                var  i = iterator.GetCurrent();
                Console.WriteLine(i.ToString());
                iterator.Next();
            }
            Console.Read();            
        }

        #endregion

        #region Factory

        public static void Factory()
        {
            var productA = "DesignPattern.Factory.Implement.ConcreateFactoryA";
            var productB = "DesignPattern.Factory.Implement.ConcreateFactoryB";
            var fa = SimpleFactory.Create(productB);
            Console.ReadLine();
        }

        #endregion

        #region Builder

        public static void Builder()
        {
            Director director = new Director();
            HpBulider hpBuilder = new HpBulider();
            DellBulider dellBuilder = new DellBulider();

            //组装一批惠普电脑
            Computer hp = director.Construct(hpBuilder);
            hp.ShowSteps();

            //Console.ReadLine();

            //组装一批戴尔电脑
            Computer dell = director.Construct(dellBuilder);
            dell.ShowSteps();

            Console.ReadLine();            
        }

        #endregion

        #region Template

        public static void Template()
        {
            var hp = new AssembleHpComputer();
            var del = new AssembleDellComputer();
            hp.Assemble();
            del.Assemble();
            Console.ReadLine();
        }

        #endregion

        #region Decorator

        public static void Decorator()
        {
            Console.WriteLine("装饰模式：");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("先看毛坯房：");
            //未经装修的毛坯房
            var withoutDecoratorHouse = new WithoutDecoratorHouse()
            {
                Area = 80.0,
                Specification = "三室一厅一卫",
                Price = 8000
            };

            withoutDecoratorHouse.Show();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("再看样板房：");
            //对毛坯房进行装修
            var decoratorHouse = new ModelHouse(withoutDecoratorHouse);
            decoratorHouse.Show();
            Console.WriteLine("-------------------------------------------------");
            Console.ReadLine();
           
        }

        #endregion

        #region Prototype

       public static void prototype()
        {
            Console.WriteLine("原型模式：");
            Prototype.Model.Email email = new Prototype.Model.Email()
            {
                Sender = "noreply@cmb.com",
                Subject = "招商银行月开鑫基金上线啦，最低年化收益7%，速速抢购！",
                Content = "招商银行月开鑫基金上线啦，最低年化收益7%，速速抢购，手慢无，每人限购1万，详情咨询95555！",
                Footer = "招商银行"
            };

            for (int i = 0; i < 10000; i++)
            {
                string receiver = string.Format("kehu{0}@qq.com", i);
                string name = string.Format("尊敬的客户『{0}』:", i);
                var cloneEmail = email.Clone() as Prototype.Model.Email;
                cloneEmail.Receiver = receiver;
                cloneEmail.Name = name;
                Prototype.Gate.SendEmail(cloneEmail);
            }
            Console.ReadLine();
        }

        #endregion

        #region Proxy

        public static void proxy()
        {
            Console.WriteLine("直接访问Google：");
            Google google = new Google();
            try
            {
                google.Search("特朗普");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine("使用代理访问Google：");
            ISearchEngine searchEngine = new GoogleProxy();
            searchEngine.Search("特朗普");

            Console.ReadLine();
        }

        #endregion

        #region Chain

        public static void Chain()
        {
            PurchaseBill bill = new PurchaseBill()
            {
                BilNo = "CGDD001",
                MaterialName = "惠普电脑",
                Qty = 50,
                Price = 5000,
                BillMaker = new Purchaser("采购员--小张")
            };

            Console.WriteLine($"创建采购申请单：{bill.BilNo};申请购买{bill.Qty}台{bill.MaterialName}");

            bill.BillMaker.HandleBill(bill);

            Console.ReadLine();            
        }

        #endregion
    }
}
