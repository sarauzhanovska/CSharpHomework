using System.Reflection.Metadata.Ecma335;

namespace HomeworkExercise.Classes
{
    public class Car
    {

        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver Driver { get; set; }


        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
        }

        public int CalculateSpeed()
        {
            if (Driver != null)
            {
                return Speed * Driver.Skill;
            }
            else
            {
                return 0;
            }
        }

    }
}

