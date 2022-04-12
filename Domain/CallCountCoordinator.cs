namespace AgifyAPI.Domain
{
    public static class CallCountCoordinator
    {

        public static int CallsRemaining { get; set; }
        static CallCountCoordinator()
        {
            CallsRemaining = 1000;
        }
    }
}
