using System;
using System.Collections.Generic;
using System.Text;

namespace infAboutProduct_vesion_0._00._1_pre_alpha
{



    class Product
    {
        protected string Producer;
        protected double Price;
        protected string Model;
        protected string MainProcessor;
        protected string VRam;
        protected bool TradeInAviability;
        
        public Product(string producer, string model, string mainProcessor, string vRam, bool tradeInAviability, double price)
        {
            Producer = producer;
            Model = model;
            Price = price;
            MainProcessor = mainProcessor;
            VRam = vRam;
            TradeInAviability = tradeInAviability;
            
        }
       
        public virtual string GetInfo()
        {
            return string.Format("Producer: {0}, Price: {1}, Model : {2}, MainProcessor : {3}, VRam : {4}",TradeInAviability : {5}, Producer, Price,Model,MainProcessor,TradeInAviability);
        }

        class Table : Product
    {
            protected string Material;
            protected int Legs;
            public Table(int legs,string material,string producer, string model, string mainProcessor, string vRam, bool tradeInAviability, double price) : base(producer,model,mainProcessor,vRam,tradeInAviability,price)
            {
                Material = material;
                Legs = legs;
            }
    }
    class Cellphone : Product
    {
            protected string Features;
            protected string Hdd;
            public Cellphone(string features,string hdd,string producer, string model, string mainProcessor, string vRam, bool tradeInAviability, double price) : base(producer, model, mainProcessor, vRam, tradeInAviability, price)
            {
                Features = features;
                Hdd = hdd;
            }
    }

}
