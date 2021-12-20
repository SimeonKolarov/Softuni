using Gym.Core.Contracts;
using Gym.Models.Athletes;
using Gym.Models.Athletes.Contracts;
using Gym.Models.Equipment;
using Gym.Models.Equipment.Contracts;
using Gym.Models.Gyms;
using Gym.Models.Gyms.Contracts;
using Gym.Repositories;
using Gym.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gym.Core
{
    public class Controller : IController
    {

        private IRepository<IEquipment> equipmentRepository;
        private List<IGym> gymRepository;
        double weightEquipment = 0;

        public Controller()
        {
            this.equipmentRepository = new EquipmentRepository();
            this.gymRepository = new List<IGym>();
        }

        public string AddAthlete(string gymName, string athleteType, string athleteName, string motivation, int numberOfMedals)
        {
            var gym = this.gymRepository.FirstOrDefault(x => x.Name == gymName);

            IAthlete athlete = null;

            if (athleteType == "Boxer")
            {
                athlete = new Boxer(athleteName, motivation, numberOfMedals);

                if (gym.GetType().Name == "BoxingGym")
                {
                    gym.AddAthlete(athlete);
                    return $"Successfully added {athleteType} to {gymName}.";
                }

                else
                {
                    return $"The gym is not appropriate.";
                }
            }

            else if (athleteType == "Weightlifter")
            {
                athlete = new Weightlifter(athleteName, motivation, numberOfMedals);
                
                if (gym.GetType().Name == "WeightliftingGym")
                {
                    gym.AddAthlete(athlete);
                    return $"Successfully added {athleteType} to {gymName}.";
                }

                else
                {
                    return $"The gym is not appropriate.";
                }
            }

            else
            {
                throw new InvalidOperationException("Invalid athlete type.");
            }
        }

        public string AddEquipment(string equipmentType)
        {
            IEquipment equipment = null;

            if (equipmentType == "BoxingGloves")
            {
                equipment = new BoxingGloves();
                this.equipmentRepository.Add(equipment);
                return $"Successfully added {equipmentType}.";
            }

            else if (equipmentType == "Kettlebell")
            {
                equipment = new Kettlebell();
                this.equipmentRepository.Add(equipment);
                return $"Successfully added {equipmentType}.";
            }

            else
            {
                throw new InvalidOperationException("Invalid equipment type.");
            }
        }

        public string AddGym(string gymType, string gymName)
        {
            IGym gym = null;

            if (gymType == "BoxingGym")
            {
                gym = new BoxingGym(gymName);
                this.gymRepository.Add(gym);
                return $"Successfully added {gymType}.";
            }

            else if (gymType == "WeightliftingGym")
            {
                gym = new WeightliftingGym(gymName);
                this.gymRepository.Add(gym);
                return $"Successfully added {gymType}.";
            }

            else
            {
                throw new InvalidOperationException("Invalid gym type.");
            }
        }

        public string EquipmentWeight(string gymName)
        {
            var gym = this.gymRepository.FirstOrDefault(x => x.Name == gymName);

            foreach (var eq in gym.Equipment)
            {
                weightEquipment += eq.Weight;
            }

            return $"The total weight of the equipment in the gym {gymName} is {weightEquipment:f2} grams.";


        }

        public string InsertEquipment(string gymName, string equipmentType)
        {
            var equipment = this.equipmentRepository.FindByType(equipmentType);

           if (equipment == null)
            {
                throw new InvalidOperationException($"There isn’t equipment of type {equipmentType}.");
            }

           var gym = this.gymRepository.FirstOrDefault(x => x.Name == gymName);

            gym.Equipment.Add(equipment);
            this.equipmentRepository.Remove(equipment);

            return $"Successfully added {equipmentType} to {gymName}.";
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var gym in this.gymRepository)
            {
                sb.AppendLine($"{gym.Name} is a {gym.GetType().Name}:");

                if (gym.Athletes.Count == 0)
                {
                    sb.Append("No athletes");
                }

                else
                {
                    sb.Append("Athletes:");
                    foreach (var ath in gym.Athletes)
                    {
                        sb.Append($"{ath.FullName}");
                        sb.Append(", ");
                    }
                    sb.Remove(sb.Length - 2, 1);
                }

                sb.AppendLine(Environment.NewLine + $"Equipment total count: {gym.Equipment.Count}");
                sb.AppendLine($"Equipment total weight: {gym.Equipment.Sum(x => x.Weight):f2} grams.");
            }

            return sb.ToString().TrimEnd();
        }

        public string TrainAthletes(string gymName)
        {
            var gym = this.gymRepository.FirstOrDefault(x => x.Name == gymName);

            foreach (var ath in gym.Athletes)
            {
                ath.Exercise();
                
            }

            return $"Exercise athletes: {gym.Athletes.Count}.";
        }
    }
}
