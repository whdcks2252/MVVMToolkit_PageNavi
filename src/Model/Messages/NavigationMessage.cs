using CommunityToolkit.Mvvm.Messaging.Messages;

namespace Model.Messages
{
    public class NavigationMessage : ValueChangedMessage<string>
    {
        public NavigationMessage(string value) : base(value)
        {
        }
    }
}
