using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;

namespace DiscordBotTemplateNet8.Commands
{
    public class PingCommand : BaseCommandModule
    {
        [Command("ping")]
        [Description("Pings the bot and returns the gateway latency.")] 
        [Aliases("pong")]
        [SuppressMessage("Style", "IDE0022", Justification = "Paragraph.")]
        public async Task PingAsyncCommand(CommandContext ctx)
        {
            // The CommandContext provides access to the DiscordClient, the message, the channel, etc.
            // If the CommandContext is not provided as a parameter, CommandsNext will ignore the method.
            // Additionally, without the CommandContext, it would be impossible to respond to the user.
            await ctx.Channel.SendMessageAsync($"Pong! The gateway latency is {ctx.Client.Ping}ms.");
        }
    }
}