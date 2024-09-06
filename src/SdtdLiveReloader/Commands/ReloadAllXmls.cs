namespace SdtdLiveReloader.Commands
{
    public class ReloadAllXmls : ConsoleCmdAbstract
    {
        public override string getDescription()
        {
            return "Reload all xmls.";
        }

        public override string getHelp()
        {
            return "";
        }

        public override string[] getCommands()
        {
            return new string[]
            {
                "ty-ReloadAllXmls",
                "ty-rax",
            };
        }

        public override void Execute(List<string> args, CommandSenderInfo _senderInfo)
        {
            SdtdConsole.Instance.Output("[LSTY] Reloading..., please wait");

            WorldStaticData.ReloadAllXmlsSync();
            
            SdtdConsole.Instance.Output("[LSTY] All xmls and xui reloaded.");
        }
    }
}