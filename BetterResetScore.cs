using CounterStrikeSharp.API;
using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Core.Attributes.Registration;
using CounterStrikeSharp.API.Modules.Commands;
using CounterStrikeSharp.API.Modules.Utils;
namespace BetterResetScore;
public class BetterResetScore : BasePlugin
{
    public override string ModuleAuthor => "jackson tougher";
    public override string ModuleName => "BetterResetScore";
    public override string ModuleVersion => "v1.0.0";

    public override void Load(bool hotReload)
    {
        Console.WriteLine("BetterResetScore loaded!");
    }

    [ConsoleCommand("rs", "ResetScore")]
    public void OnResetScoreCommand(CCSPlayerController? player, CommandInfo command)
    {
        player.ActionTrackingServices!.MatchStats.Kills = 0;
        player.ActionTrackingServices!.MatchStats.Deaths = 0;
        player.ActionTrackingServices!.MatchStats.Damage = 0;
        player.ActionTrackingServices!.MatchStats.Assists = 0;
        player.Score = 0;
        player.MVPs = 0;

        player.PrintToChat($" {ChatColors.Gold}[ResetScore] {ChatColors.Olive}Your {ChatColors.Red}score {ChatColors.Olive}has been reset !");
    }
    [ConsoleCommand("rd", "ResetDeaths")]
    public void OnResetDeathsCommand(CCSPlayerController? player, CommandInfo command)
    {
        player.ActionTrackingServices!.MatchStats.Deaths = 0;

        player.PrintToChat($" {ChatColors.Gold}[ResetScore] {ChatColors.Olive}Your {ChatColors.Red}deaths {ChatColors.Olive}has been reset !");
    }
}