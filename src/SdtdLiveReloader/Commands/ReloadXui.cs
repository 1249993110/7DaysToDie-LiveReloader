namespace SdtdLiveReloader.Commands
{
    public class ReloadXui : ConsoleCmdAbstract
    {
        public override string getDescription()
        {
            return "Reload xui.";
        }

        public override string getHelp()
        {
            return "";
        }

        public override string[] getCommands()
        {
            return new string[]
            {
                "ty-ReloadXui",
                "ty-rxui",
            };
        }

        public override void Execute(List<string> args, CommandSenderInfo _senderInfo)
        {
            SdtdConsole.Instance.Output("[LSTY] Reloading..., please wait");

            SdtdConsole.Instance.ExecuteSync("xui reload", null);
            
            SdtdConsole.Instance.Output("[LSTY] All xmls and xui reloaded.");
        }
    }
}