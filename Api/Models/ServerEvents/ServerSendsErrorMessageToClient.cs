using lib;

namespace Api.Models.ServerEvents;

public class ServerSendsErrorMessageToClient : BaseDto
{
    public string? errorMessage { get; set; }
    public string? receivedMessage { get; set; }
}