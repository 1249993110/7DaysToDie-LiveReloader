namespace SdtdLiveReloader.Commands
{
    public class ReloadLocalization : ConsoleCmdAbstract
    {
        public override string getDescription()
        {
            return "Reload all Localization.txt.";
        }

        public override string getHelp()
        {
            return "";
        }

        public override string[] getCommands()
        {
            return new string[]
            {
                "ty-ReloadLocalization",
                "ty-rl",
            };
        }

        public override void Execute(List<string> args, CommandSenderInfo _senderInfo)
        {
            SdtdConsole.Instance.Output("[LSTY] Reloading..., please wait");

            Localization.ReloadBaseLocalization();
            ThreadManager.RunCoroutineSync(ModManager.LoadLocalizations(false));

            SdtdConsole.Instance.Output("[LSTY] Localization reloaded");
        }
    }
}