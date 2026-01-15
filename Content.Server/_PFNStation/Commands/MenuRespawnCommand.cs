//modified ghostrespawn code from frontier station, will be replaced later once i get off my ass and
//implement a cryosleep system

using Content.Server.GameTicking;
using Content.Shared.Administration;
using Robust.Shared.Console;

namespace Content.Server._PFNStation.Commands
{
    [AnyCommand]
    sealed class MenuRespawnCommand : IConsoleCommand
    {
        [Dependency] protected readonly EntityManager _entityManager = default!;

        public string Command => "menurespawn";
        public string Description => "Respawns the player that called this command, sends them back to the lobby if it's enabled.";
        public string Help => "";

        public void Execute(IConsoleShell shell, string argStr, string[] args)
        {
            if (shell.Player is null)
            {
                shell.WriteLine("You cannot run this from the console!");
                return;
            }
            var gameTicker = _entityManager.EntitySysManager.GetEntitySystem<GameTicker>();
            _entityManager.DeleteEntity(shell.Player.AttachedEntity); //so we don't get Evil Clones.
            gameTicker.Respawn(shell.Player);
        }
    }
}
