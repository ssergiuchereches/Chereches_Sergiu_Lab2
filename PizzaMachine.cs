using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Threading;
namespace Chereches_Sergiu_Lab2
{
    class PizzaMachine : Component
    {
        public PizzaType Ingredients { get; internal set; }
        public bool Enabled { get; internal set; }
        public PizzaMachine.PizzaCompleteDelegate PizzaComplete { get; internal set; }

        internal void MakePizzas(PizzaType margherita)
        {
            throw new NotImplementedException();
        }

        internal class PizzaCompleteDelegate
        {
            private Action pizzaCompleteHandler;

            public PizzaCompleteDelegate(Action pizzaCompleteHandler)
            {
                this.pizzaCompleteHandler = pizzaCompleteHandler;
            }
        }
    }
    enum PizzaType
    {
        Margherita,
        Pepperoni,
        Veggie,
        Quattro_Stagioni,
        Canibale
    }
    class Pizza
    {
        private PizzaType mIngredients; // camp
        public PizzaType Ingredients // proprietate
        {
            get // metoda get
            {
                return mIngredients;
            }
            set // metoda set
            {
                mIngredients = value;
            }
        }
        private float mPrice = .50F;
        private float Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }
        private readonly DateTime mTimeOFCreation;
        public DateTime TimeOFCreation
        {
            get
            {
                return mTimeOFCreation;
            }
        }
        public Pizza(PizzaType aIngredients) // constructor
        {
            mTimeOFCreation = DateTime.Now;
            mIngredients = aIngredients;

        }//

        class PizzaMachine : Component
        {

            private PizzaType mIngredients;
            public PizzaType Ingredients
            {
                get
                {
                    return mIngredients;
                }
                set
                {
                    mIngredients = value;
                }
            }

            private System.Collections.ArrayList mPizzas = new System.Collections.ArrayList();
            public Pizza this[int Index]
            {
                get
                {
                    return (Pizza)mPizzas[Index];
                }
                set
                {
                    mPizzas[Index] = value;
                }
            }




            DispatcherTimer pizzaBakeTimer;
            public delegate void PizzaCompleteDelegate();
            public event PizzaCompleteDelegate PizzaComplete;

            private void InitializeComponent()
            {
                this.pizzaBakeTimer = new DispatcherTimer();
                this.pizzaBakeTimer.Tick += new System.EventHandler(this .pizzaBakeTimer_Tick);

            }
            public PizzaMachine()
            {
                InitializeComponent();
            }
            private void pizzaBakeTimer_Tick(object sender, EventArgs e)
            {
                Pizza aPizza = new Pizza(this.Ingredients);
                mPizzas.Add(aPizza);
                PizzaComplete();
            }
            public bool Enabled
            {
                set
                {
                    pizzaBakeTimer.IsEnabled = value;

                }
            }
            public int Interval
            {
                set
                {
                    pizzaBakeTimer.Interval = new TimeSpan(0, 0, value);
                }
            }
            public void MakePizzas(PizzaType dIngredients)
            {
                Ingredients = dIngredients;
                switch (Ingredients)
                {
                    case PizzaType.Canibale: Interval = 3; break;
                    case PizzaType.Margherita: Interval = 2; break;
                    case PizzaType.Pepperoni: Interval = 5; break;
                    case PizzaType.Quattro_Stagioni: Interval = 4; break;
                    case PizzaType.Veggie: Interval = 4; break;
                }
                pizzaBakeTimer.Start();
            
                }
        }
            
            
    }
        




}
   

        
    

       
    
   
 
    
    

  

 