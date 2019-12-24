using System;
using System.Collections.Generic;

namespace ex1
{
    // Model objects

    public class Cookie
    {
        // Unique Id for cookie
        public int Id { get; set; }
        public Cookie Fill()
        {
            Utils.Log($"Filling cookie {this.Id}...", this.FlowLogs);
            
            Utils.Process();
            return this;
        }
        
        public Cookie Cool()
        {
            Utils.Log($"Cooling cookie {this.Id}...", this.FlowLogs);
            Utils.Process();
            return this;
        }

        public Cookie Freeze()
        {
            Utils.Log($"Freezing cookie {this.Id}...", this.FlowLogs);
            Utils.Process();
            return this;
        }

        public HelloWorldCookie Pack()
        {
            Utils.Log($"Hello World cookie {this.Id} packed!!!!", this.FlowLogs);
            Utils.Process();
            return new HelloWorldCookie() { Id = this.Id, FlowLogs = this.FlowLogs};
        }

        public List<string> FlowLogs { get; set; }

        public Cookie()
        {
            this.FlowLogs = new List<string>();
        }


    }

    public class CookieDough
    {
        // Unique Id for cookie dough
        public int Id { get; set; }

        public CookieDough SheetOrLaminate()
        {
            Utils.Log($"Sheeting or Laminating cookie dough {this.Id}...", this.FlowLogs);
            Utils.Process();
            return this;
        }

        public CookieDough PlaceInForm()
        {
            Utils.Log($"Placing cookie dough in form[Forming] {this.Id}...", this.FlowLogs);
            Utils.Process();
            return this;
        }

        public Cookie Bake()
        {
            Utils.Log($"Baking cookie dough {this.Id}...", this.FlowLogs);
            Utils.Process();
            return new Cookie() { Id = this.Id, FlowLogs = this.FlowLogs};
        }

        public List<string> FlowLogs { get; private set; }

        public CookieDough()
        {
            this.FlowLogs = new List<string>();
        }

    }

    public class CookieDoughIngredients
    {
        static int id = 0;
        public static CookieDough Mix()
        {
            var cd = new CookieDough() { Id = ++id };
            Utils.Log($"Mixing cookie dough {id}...", cd.FlowLogs);
            Utils.Process();
            return cd;
        }


    }

    public class HelloWorldCookie
    {
        // Unique Id 
        public int Id { get; set; }

        public List<string> FlowLogs { get; set; }

        public HelloWorldCookie()
        {
            this.FlowLogs = new List<string>();
        }
    }
}
