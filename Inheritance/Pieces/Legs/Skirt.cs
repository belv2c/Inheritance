using System;

namespace Inheritance.Pieces.Legs
{
    class Skirt : LegBase
    {
        public string Material { get; set; }
        public Length Length { get; set; }

        public override void Walk(int numberOfSteps)
        {
            if (Length == Length.StreetCorner)
            {
                Console.WriteLine($"The {Size} legs walked {numberOfSteps} steps .");
                return;
            }

            base.Walk(numberOfSteps);

        }
    }
}
