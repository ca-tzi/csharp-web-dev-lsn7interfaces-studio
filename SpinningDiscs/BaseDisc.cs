using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs

{
    public interface IDisc
    {
        void Spin();

        public void read();

    }
    public abstract class BaseDisc
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<string> Contents { get; set; }
        public string Type { get; set; }

        public int RemainingCapacity => Capacity - CapacityUsed; 
        public int CapacityUsed { get; set; }


        
        public BaseDisc(string name, int capacity,  string type)
        {
            Name = name;
            Capacity = capacity;
            //Contents = contents;
            Type = type;
        }

        public int CapacityLeft(int data)
        {
            if (Capacity < data)
            {
                return Capacity;
            }
            else
            {
                return data;
            }
        }
        public int SpaceLeft()
        {
            return Capacity - CapacityUsed;
        }
        public override string ToString()
        {
            return $"Disk name: {Name} {Environment.NewLine} Max Capacity: {Capacity} {Environment.NewLine}";
        }
        
        public string WriteData(int size)
        {
            if (size > RemainingCapacity)
        {
            return "Nor enough space";
        }
        CapacityUsed += size;
        
        return "Data Written";


        }
    
    }
}


//indicate remaining capacity 