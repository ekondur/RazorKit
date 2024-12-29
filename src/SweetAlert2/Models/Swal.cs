using Newtonsoft.Json;
using RazorKit.SweetAlert2.Converters;
using System.Collections.Generic;

namespace RazorKit.SweetAlert2.Models
{
    internal class Swal
    {
        public string Title { get; set; }
        public string TitleText { get; set; }
        public string Html { get; set; }
        public string Text { get; set; }
        public SwalIcon Icon { get; set; }
        public string IconColor { get; set; }
        public string IconHtml { get; set; }
        public bool? Animation { get; set; }
        public SwalClass ShowClass { get; set; }
        public SwalClass HideClass { get; set; }
        public string Footer { get; set; }
        public object Backdrop { get; set; }
        public bool? Toast { get; set; }
        public string Target { get; set; }
        public SwalInput Input { get; set; }
        public string Width { get; set; }
        public string Padding { get; set; }
        public string Color { get; set; }
        public string Background { get; set; }
        public SwalPosition Position { get; set; }
        public object Grow { get; set; }
        public CustomClass CustomClass { get; set; }
        public int? Timer { get; set; }
        public bool? TimerProgressBar { get; set; }
        public bool? HeightAuto { get; set; }
        public bool? AllowOutsideClick { get; set; }
        public bool? AllowEscapeKey { get; set; }
        public bool? StopKeydownPropagation { get; set; }
        public bool? KeydownListenerCapture { get; set; }
        public bool? ShowConfirmButton { get; set; }
        public bool? ShowDenyButton { get; set; }
        public bool? ShowCancelButton { get; set; }
        public string ConfirmButtonText { get; set; }
        public string DenyButtonText { get; set; }
        public string CancelButtonText { get; set; }
        public string ConfirmButtonColor { get; set; }
        public string DenyButtonColor { get; set; }
        public string CancelButtonColor { get; set; }
        public string ConfirmButtonAriaLabel { get; set; }
        public string DenyButtonAriaLabel { get; set; }
        public string CancelButtonAriaLabel { get; set; }
        public bool? ButtonsStyling { get; set; }
        public bool? ReverseButtons { get; set; }
        public bool? FocusConfirm { get; set; }
        public bool? ReturnFocus { get; set; }
        public bool? FocusDeny { get; set; }
        public bool? FocusCancel { get; set; }
        public bool? ShowCloseButton { get; set; }
        public string CloseButtonHtml { get; set; }
        public string CloseButtonAriaLabel { get; set; }
        public string LoaderHtml { get; set; }
        public bool? ShowLoaderOnConfirm { get; set; }
        public bool? ShowLoaderOnDeny { get; set; }
        public bool? ReturnInputValueOnDeny { get; set; }
        public string ImageUrl { get; set; }
        public string ImageWidth { get; set; }
        public string ImageHeight { get; set; }
        public string ImageAlt { get; set; }
        public string InputLabel { get; set; }
        public string InputPlaceholder { get; set; }
        public string InputValue { get; set; }
        public object InputOptions { get; set; }
        public bool? InputAutoFocus { get; set; }
        public bool? InputAutoTrim { get; set; }
        public Dictionary<string, string> InputAttributes { get; set; }
        public string ValidationMessage { get; set; }
        public string[] ProgressSteps { get; set; }
        public string CurrentProgressStep { get; set; }
        public string ProgressStepsDistance { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string PreConfirm { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string PreDeny { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string InputValidator { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string DidRender { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string WillOpen { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string DidOpen { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string WillClose { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string DidClose { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string DidDestroy { get; set; }
    }
}
