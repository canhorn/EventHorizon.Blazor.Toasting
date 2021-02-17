namespace EventHorizon.Blazor.Toasting.Components
{
    using EventHorizon.Blazor.Toasting.Components.Model;
    using Microsoft.AspNetCore.Components;

    public class MessageFullDetailsModel
        : ComponentBase
    {
        [Parameter]
        public MessageModel Message { get; set; }

        public string MessageLevelText { get; set; } = string.Empty;
        public string MessageLevelStyle { get; set; } = string.Empty;

        protected override void OnInitialized()
        {
            SetupStyle();
        }

        protected override void OnParametersSet()
        {
            SetupStyle();
        }

        private void SetupStyle()
        {
            MessageLevelStyle = string.Empty;
            MessageLevelText = string.Empty;
            if (Message.Level == MessageLevel.Success)
            {
                MessageLevelText = "Success Message";
                MessageLevelStyle = "--success";
            }
            else if (Message.Level == MessageLevel.Warning)
            {
                MessageLevelText = "Warning Message";
                MessageLevelStyle = "--warning";
            }
            else if (Message.Level == MessageLevel.Error)
            {
                MessageLevelText = "Error Message";
                MessageLevelStyle = "--error";
            }
        }
    }
}
