using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;

namespace DiscordBotTemplateNet8.Commands
{
    public class Basic : BaseCommandModule
    {
        [Command("hello")]
        [Description("Says hello")]
        [Aliases("hi")]
        public async Task HelloCommand(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("Hello!");
        }

        [Command("bye")]
        [Description("Says bye")]
        public async Task ByeCommand(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("Bye Bye!");
        }
    }
}
