using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ExamTwoCodeQuestions.Data
{
    /// <summary>
    /// A class representing the Cobbler dish
    /// </summary>
    public class Cobbler : IOrderItem, INotifyPropertyChanged
    {

        /// <summary>
        /// The property changed event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        private FruitFilling fruit;
        /// <summary>
        /// The fruit used in the cobbler
        /// </summary>
        public FruitFilling Fruit
        {
            get
            {
                return fruit;
            }
            set
            {
                fruit = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Fruit"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool withIceCream = true;
        /// <summary>
        /// If the cobbler is served with ice cream
        /// </summary>
        public bool WithIceCream
        {
            get
            {
                return withIceCream;                
            }
            set
            {
                withIceCream = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("WithIceCream"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Gets if the fruit filling is blueberry
        /// </summary>
        public virtual bool IsBlueberry
        {
            get
            {
                if (Fruit == FruitFilling.Blueberry)
                {
                    return true;
                }
                return false;
            }
            set
            {
                if (value)
                {
                    Fruit = FruitFilling.Blueberry;                   
                }
            }

        }

        /// <summary>
        /// Gets if the fruit filling is cherry
        /// </summary>
        public virtual bool IsCherry
        {
            get
            {
                if (Fruit == FruitFilling.Cherry)
                {
                    return true;
                }
                return false;
            }
            set
            {
                if (value)
                {
                    Fruit = FruitFilling.Cherry;                    
                }
            }

        }

        /// <summary>
        /// Gets if the fruit filling is peach
        /// </summary>
        public virtual bool IsPeach
        {
            get
            {
                if (Fruit == FruitFilling.Peach)
                {
                    return true;
                }
                return false;
            }
            set
            {
                if (value)
                {
                    Fruit = FruitFilling.Peach;
                }
            }

        }

        /// <summary>
        /// Gets the price of the Cobbler
        /// </summary>
        public double Price
        {
            get
            {
                if (WithIceCream) return 5.32;
                else return 4.25;
            }
        }

        /// <summary>
        /// Gets any special instructions for preparing this dessert
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                if(WithIceCream) { return new List<string>(); }
                else { return new List<string>() { "Hold Ice Cream" }; }
            }
        }
    }
}
