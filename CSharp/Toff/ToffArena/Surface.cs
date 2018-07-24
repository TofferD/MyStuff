namespace Toffsoft
{
    public class Surface
    {
        public bool HasAnimal
        {
            get
            {
                if (Toffoid != null && Toffoid.GetType().IsSubclassOf(typeof(ToffAnimal)))
                {
                    return true;
                }

                return false;
            }
        }

        public bool HasPlant
        {
            get
            {
                if (Toffoid != null && Toffoid.GetType().IsSubclassOf(typeof(ToffPlant)))
                {
                    return true;
                }

                return false;
            }
        }

        private Toffoid Toffoid { get; set; }
    }
}
