namespace SapphireRidgeWebApp.Services;
using SapphireRidgeWebApp.Interfaces;

public class WelcomeService : IWelcomeService
{
    DateTime _serviceCreated;
    Guid _serviceId;

    public WelcomeService()
    {
        _serviceCreated = DateTime.Now;
        _serviceId = Guid.NewGuid();
    }

    public string GetWelcomeMessage()
    {
        return $"Welcome to Sapphire Ridge! The current time is {_serviceCreated}. This service instance has an ID of {_serviceId}.";
    }
}
