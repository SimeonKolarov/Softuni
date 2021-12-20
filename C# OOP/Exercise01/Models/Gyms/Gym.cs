using Gym.Models.Athletes.Contracts;
using Gym.Models.Equipment.Contracts;
using Gym.Models.Gyms.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gym.Models.Gyms
{
    public abstract class Gym : IGym
    {
        private List<IEquipment> equipments;
        private List<IAthlete> athletes; 
        private string name;
        

        protected Gym(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            this.equipments = new List<IEquipment>();
            this.athletes = new List<IAthlete>();
        }

        public string Name { get => this.name;
            private set 
            {
              if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Gym name cannot be null or empty.");
                }

                this.name = value;
            }
        }

        public int Capacity { get; private set; }

        public double EquipmentWeight => this.equipments.Sum(x => x.Weight);

        public ICollection<IEquipment> Equipment => this.equipments;

        public ICollection<IAthlete> Athletes => this.athletes;

        public void AddAthlete(IAthlete athlete)
        {
            if (this.Capacity == this.athletes.Count)
            {
                throw new InvalidOperationException("Not enough space in the gym.");
            }

            this.athletes.Add(athlete);
        }

        public void AddEquipment(IEquipment equipment)
        {
            this.equipments.Add(equipment);
            
        }

        public void Exercise()
        {
            foreach (var athlete in this.athletes)
            {
                athlete.Exercise();
            }
        }

        public string GymInfo()
        {
            return $"{this.Name} is a {this.GetType().Name}:{Environment.NewLine} Athletes: {(this.athletes.Count == 0 ? "none" : String.Join(", ", this.athletes))}{Environment.NewLine}Equipment total count: {this.equipments.Count}{Environment.NewLine}Equipment total weight: {this.equipments.Sum(x => x.Weight):f2}";
        }

        public bool RemoveAthlete(IAthlete athlete)
        {
           return this.athletes.Remove(athlete);
        }
    }
}
