using System;

namespace Toffsoft
{
    public abstract class Toffoid
    {
        public Toffoid()
        {
            LifePoints = 10;
        }

        public bool IsAlive
        {
            get
            {
                return (LifePoints > 0);
            }
        }

        public int LifePoints { get; private set; }

        public Location Location { get; private set; }

        internal virtual void Move()
        {
            Random rnd = new Random(Convert.ToInt32(DateTime.Now.Ticks));
            Location newLocation = null;

            if (Location.ConnectedLocations.Count > 0)
            {
                newLocation = Location.ConnectedLocations[rnd.Next(0, Location.ConnectedLocations.Count - 1)];
            }

            if (newLocation != null)
            {
                Location = newLocation;
            }
        }

        internal virtual void RemoveLifePoint()
        {
            LifePoints--;
        }

        internal virtual void SetLocation(Location location)
        {
            Location = location;
        }

        public static void AttackToffoid(Toffoid target)
        {
            target.RemoveLifePoint();
        }
    }
}
