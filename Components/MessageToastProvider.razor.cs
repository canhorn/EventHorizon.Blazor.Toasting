namespace EventHorizon.Blazor.Toasting.Components
{
    using System.Collections.Generic;
    using EventHorizon.Blazor.Toasting.Components.Model;
    using Microsoft.AspNetCore.Components;

    public class MessageToastProviderModel
        : ComponentBase
    {
        [Parameter]
        public RenderFragment ChildContent { get; set; }

        public IDictionary<string, MessageModel> MessageList { get; set; } = new Dictionary<string, MessageModel>();

        public void ShowMessage(
            MessageModel message
        )
        {
            MessageList[message.Id] = message;

            InvokeAsync(StateHasChanged);
        }

        public void HandleRemoveMessage(
            string messageId
        )
        {
            MessageList.Remove(
                messageId
            );
        }
    }
}
