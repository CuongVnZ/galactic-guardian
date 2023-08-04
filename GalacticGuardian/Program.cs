namespace Galactic_Guardian
{
    public enum Direction
    {
        UP,
        DOWN,
        LEFT,
        RIGHT
    }

    internal static class Program
    {

        public static MainMenu MainMenu;
        public static GalacticGuardian GameScreen;
        public static GameOver GameOver;
        public static Instruction Instruction = new Instruction();
        public static Ranking Ranking = new Ranking();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            MainMenu = new MainMenu();
            Application.Run(MainMenu);
        }
    }
}