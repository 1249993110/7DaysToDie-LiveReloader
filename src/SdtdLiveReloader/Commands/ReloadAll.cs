namespace SdtdLiveReloader.Commands
{
    public class ReloadAll : ConsoleCmdAbstract
    {
        public override string getDescription()
        {
            return "Reload all xmls, xui and localization.";
        }

        public override string getHelp()
        {
            return "";
        }

        public override string[] getCommands()
        {
            return new string[]
            {
                "ty-ReloadAll",
                "ty-ra",
            };
        }

        public override void Execute(List<string> args, CommandSenderInfo _senderInfo)
        {
            SdtdConsole.Instance.Output("[LSTY] Reloading..., please wait");

            Localization.ReloadBaseLocalization();
            ThreadManager.RunCoroutineSync(ModManager.LoadLocalizations(false));
            WorldStaticData.ReloadAllXmlsSync();
            SdtdConsole.Instance.ExecuteSync("xui reload", null);
            
            SdtdConsole.Instance.Output("[LSTY] All xmls and xui reloaded.");
        }
    }
}