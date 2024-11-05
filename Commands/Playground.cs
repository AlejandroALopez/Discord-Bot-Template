using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;

namespace DiscordBotTemplateNet8.Commands
{
    public class Playground : BaseCommandModule
    {
        [Command("whoami")]
        [Description("Says who you are")]
        [RequireGuild]
        public async Task WhoAmIAsync(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync($"You are {ctx.Member!.Mention}.");
        }
    }
}