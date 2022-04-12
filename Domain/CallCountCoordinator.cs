namespace AgifyAPI.Domain
{
    public static class CallCountCoordinator
    {

        public static int CallsRemaining { get; set; }
        static CallCountCoordinator()
        {
            //var callsRemaining = Persistence.PersistenceCoordinator.ReadCountFromTextFile();

            //if(callsRemaining == string.Empty)
            //{

            //}
            //else
            //{
            //    CallsRemaining = Convert.ToInt32(callsRemaining);
            //}

            CallsRemaining = 1000;
        }
    }
}
