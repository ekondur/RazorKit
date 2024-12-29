using RazorKit.SweetAlert2.Models;
using System;
using System.Collections.Generic;

namespace RazorKit.SweetAlert2.Builders
{
    /// <summary>
    /// Swal Builder
    /// </summary>
    public class SwalBuilder
    {
        internal Swal Swal { get; private set; }

        internal SwalBuilder()
        {
            Swal = new Swal();
        }

        /// <summary>
        /// The title of the popup, as HTML.
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public SwalBuilder Title (string title)
        {
            Swal.Title = title;
            return this;
        }

        /// <summary>
        /// The title of the popup, as text. Useful to avoid HTML injection.
        /// </summary>
        /// <param name="titleText"></param>
        /// <returns></returns>
        public SwalBuilder TitleText(string titleText)
        {
            Swal.TitleText = titleText;
            return this;
        }

        /// <summary>
        /// A HTML description for the popup.
        /// If text and html parameters are provided in the same time, html will be used.
        /// </summary>
        /// <param name="html"></param>
        /// <returns></returns>
        public SwalBuilder Html(string html)
        {
            Swal.Html = html;
            return this;
        }

        /// <summary>
        /// A description for the popup. If text and html parameters are provided in the same time,html will be used.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public SwalBuilder Text(string text)
        {
            Swal.Text = text;
            return this;
        }

        /// <summary>
        /// The icon of the popup. SweetAlert2 comes with 5 built-in icon which will show a corresponding icon animation.
        /// </summary>
        /// <param name="icon"></param>
        /// <returns></returns>
        public SwalBuilder Icon(SwalIcon icon)
        {
            Swal.Icon = icon;
            return this;
        }

        /// <summary>
        /// Use this to change the color of the icon.
        /// </summary>
        /// <param name="iconColor"></param>
        /// <returns></returns>
        public SwalBuilder IconColor(string iconColor)
        {
            Swal.IconColor = iconColor;
            return this;
        }

        /// <summary>
        /// The custom HTML content for an icon.
        /// </summary>
        /// <param name="iconHtml"></param>
        /// <returns></returns>
        public SwalBuilder IconHtml(string iconHtml)
        {
            Swal.IconHtml = iconHtml;
            return this;
        }

        /// <summary>
        /// If set to false, the popup animation will be disabled.
        /// </summary>
        /// <param name="animation"></param>
        /// <returns></returns>
        public SwalBuilder Animation(bool animation)
        {
            Swal.Animation = animation;
            return this;
        }

        /// <summary>
        /// CSS classes for animations when showing a popup (fade in).
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public SwalBuilder ShowClass(Action<SwalClassBuilder> action)
        {
            Swal.ShowClass = new SwalClass();
            var builder = new SwalClassBuilder(Swal.ShowClass);
            action(builder);
            return this;
        }

        /// <summary>
        /// CSS classes for animations when hiding a popup (fade out).
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public SwalBuilder HideClass(Action<SwalClassBuilder> action)
        {
            Swal.HideClass = new SwalClass();
            var builder = new SwalClassBuilder(Swal.HideClass);
            action(builder);
            return this;
        }

        /// <summary>
        /// The footer of the popup. Can be either plain text or HTML.
        /// </summary>
        /// <param name="footer"></param>
        /// <returns></returns>
        public SwalBuilder Footer(string footer)
        {
            Swal.Footer = footer;
            return this;
        }

        /// <summary>
        /// Whether or not SweetAlert2 should show a full screen click-to-dismiss backdrop. 
        /// Can be either a boolean or a string which will be assigned to the CSS background property.
        /// </summary>
        /// <param name="backdrop"></param>
        /// <returns></returns>
        public SwalBuilder Backdrop(bool backdrop)
        {
            Swal.Backdrop = backdrop;
            return this;
        }

        /// <summary>
        /// Whether or not SweetAlert2 should show a full screen click-to-dismiss backdrop. 
        /// Can be either a boolean or a string which will be assigned to the CSS background property.
        /// </summary>
        /// <param name="backdrop"></param>
        /// <returns></returns>
        public SwalBuilder Backdrop(string backdrop)
        {
            Swal.Backdrop = backdrop;
            return this;
        }

        /// <summary>
        /// Whether or not an alert should be treated as a toast notification. 
        /// This option is normally coupled with the position parameter and a timer. Toasts are NEVER autofocused.
        /// </summary>
        /// <param name="toast"></param>
        /// <returns></returns>
        public SwalBuilder Toast(bool toast)
        {
            Swal.Toast = toast;
            return this;
        }

        /// <summary>
        /// The container element for adding popup into.
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public SwalBuilder Target(string target)
        {
            Swal.Target = target;
            return this;
        }

        /// <summary>
        /// Input field type.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public SwalBuilder Input(SwalInput input)
        {
            Swal.Input = input;
            return this;
        }

        /// <summary>
        /// Popup window width, including paddings (box-sizing: border-box). Can be in any CSS unit (px, em/rem, %).
        /// </summary>
        /// <param name="width"></param>
        /// <returns></returns>
        public SwalBuilder Width(string width)
        {
            Swal.Width = width;
            return this;
        }

        /// <summary>
        /// Popup window padding. Can be in any CSS unit (px, em/rem, %).
        /// </summary>
        /// <param name="padding"></param>
        /// <returns></returns>
        public SwalBuilder Padding(string padding)
        {
            Swal.Padding = padding;
            return this;
        }

        /// <summary>
        /// Color for title, content and footer (CSS color property). The default color is '#545454'.
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public SwalBuilder Color(string color)
        {
            Swal.Color = color;
            return this;
        }

        /// <summary>
        /// Popup window background (CSS background property). The default background is '#fff'.
        /// </summary>
        /// <param name="background"></param>
        /// <returns></returns>
        public SwalBuilder Background(string background)
        {
            Swal.Background = background;
            return this;
        }

        /// <summary>
        /// Popup window position.
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public SwalBuilder Position(SwalPosition position)
        {
            Swal.Position = position;
            return this;
        }

        /// <summary>
        /// Paired with window position, sets the direction the popup should grow in, can be set to false.
        /// </summary>
        /// <param name="grow"></param>
        /// <returns></returns>
        public SwalBuilder Grow(bool grow)
        {
            Swal.Grow = grow;
            return this;
        }

        /// <summary>
        /// Paired with window position, sets the direction the popup should grow in, can be set to 'row', 'column', 'fullscreen'.
        /// </summary>
        /// <param name="grow"></param>
        /// <returns></returns>
        public SwalBuilder Grow(string grow)
        {
            Swal.Grow = grow;
            return this;
        }

        /// <summary>
        /// A custom CSS class for the popup.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public SwalBuilder CustomClass(Action<CustomClassBuilder> action)
        {
            Swal.CustomClass = new CustomClass();
            var builder = new CustomClassBuilder(Swal.CustomClass);
            action(builder);
            return this;
        }

        /// <summary>
        /// Auto close timer of the popup. Set in ms (milliseconds). 
        /// </summary>
        /// <param name="timer"></param>
        /// <returns></returns>
        public SwalBuilder Timer(int timer)
        {
            Swal.Timer = timer; 
            return this;
        }

        /// <summary>
        /// If set to true, the timer will have a progress bar at the bottom of a popup. Mostly, this feature is useful with toasts.
        /// </summary>
        /// <param name="timerProgressBar"></param>
        /// <returns></returns>
        public SwalBuilder TimerProgressBar(bool timerProgressBar)
        {
            Swal.TimerProgressBar = timerProgressBar;
            return this;
        }

        /// <summary>
        /// By default, SweetAlert2 sets html's and body's CSS height to auto !important. 
        /// If this behavior isn't compatible with your project's layout, set heightAuto to false.
        /// </summary>
        /// <param name="heightAuto"></param>
        /// <returns></returns>
        public SwalBuilder HeightAuto(bool heightAuto)
        {
            Swal.HeightAuto = heightAuto;
            return this;
        }

        /// <summary>
        /// If set to false, the user can't dismiss the popup by clicking outside it.
        /// You can also pass a custom function returning a boolean value, e.g. if you want to disable outside clicks for the loading state of a popup.
        /// </summary>
        /// <param name="allowOutsideClick"></param>
        /// <returns></returns>
        public SwalBuilder AllowOutsideClick(bool allowOutsideClick)
        {
            Swal.AllowOutsideClick = allowOutsideClick;
            return this;
        }

        /// <summary>
        /// If set to false, the user can't dismiss the popup by pressing the Esc key. You can also pass a custom function returning a boolean value, 
        /// e.g. if you want to disable the Esc key for the loading state of a popup.
        /// </summary>
        /// <param name="allowEscapeKey"></param>
        /// <returns></returns>
        public SwalBuilder AllowEscapeKey(bool allowEscapeKey)
        {
            Swal.AllowEscapeKey = allowEscapeKey;
            return this;
        }

        /// <summary>
        /// If set to false, SweetAlert2 will allow keydown events propagation to the document.
        /// </summary>
        /// <param name="stopKeydownPropagation"></param>
        /// <returns></returns>
        public SwalBuilder StopKeydownPropagation(bool stopKeydownPropagation)
        {
            Swal.StopKeydownPropagation = stopKeydownPropagation;
            return this;
        }

        /// <summary>
        /// Useful for those who are using SweetAlert2 along with Bootstrap modals. 
        /// By default keydownListenerCapture is false which means when a user hits Esc, both SweetAlert2 and Bootstrap modals will be closed. 
        /// Set keydownListenerCapture to true to fix that behavior.
        /// </summary>
        /// <param name="keydownListenerCapture"></param>
        /// <returns></returns>
        public SwalBuilder KeydownListenerCapture(bool keydownListenerCapture)
        {
            Swal.KeydownListenerCapture = keydownListenerCapture;
            return this;
        }

        /// <summary>
        /// If set to false, a "Confirm"-button will not be shown.
        /// </summary>
        /// <param name="showConfirmButton"></param>
        /// <returns></returns>
        public SwalBuilder ShowConfirmButton(bool showConfirmButton)
        {
            Swal.ShowConfirmButton = showConfirmButton;
            return this;
        }

        /// <summary>
        /// If set to true, a "Deny"-button will be shown. It can be useful when you want a popup with 3 buttons.
        /// </summary>
        /// <param name="showDenyButton"></param>
        /// <returns></returns>
        public SwalBuilder ShowDenyButton(bool showDenyButton)
        {
            Swal.ShowDenyButton = showDenyButton;
            return this;
        }

        /// <summary>
        /// If set to true, a "Cancel"-button will be shown, which the user can click on to dismiss the modal.
        /// </summary>
        /// <param name="showCancelButton"></param>
        /// <returns></returns>
        public SwalBuilder ShowCancelButton(bool showCancelButton)
        {
            Swal.ShowCancelButton = showCancelButton;
            return this;
        }

        /// <summary>
        /// Use this to change the text on the "Confirm"-button.
        /// </summary>
        /// <param name="confirmButtonText"></param>
        /// <returns></returns>
        public SwalBuilder ConfirmButtonText(string confirmButtonText)
        {
            Swal.ConfirmButtonText = confirmButtonText;
            return this;
        }

        /// <summary>
        /// Use this to change the text on the "Deny"-button.
        /// </summary>
        /// <param name="denyButtonText"></param>
        /// <returns></returns>
        public SwalBuilder DenyButtonText(string denyButtonText)
        {
            Swal.DenyButtonText = denyButtonText;
            return this;
        }

        /// <summary>
        /// Use this to change the text on the "Cancel"-button.
        /// </summary>
        /// <param name="cancelButtonText"></param>
        /// <returns></returns>
        public SwalBuilder CancelButtonText(string cancelButtonText)
        {
            Swal.CancelButtonText = cancelButtonText;
            return this;
        }

        /// <summary>
        /// Use this to change the background color of the "Confirm"-button. The default color is #3085d6
        /// </summary>
        /// <param name="confirmButtonColor"></param>
        /// <returns></returns>
        public SwalBuilder ConfirmButtonColor(string confirmButtonColor)
        {
            Swal.ConfirmButtonColor = confirmButtonColor;
            return this;
        }

        /// <summary>
        /// Use this to change the background color of the "Deny"-button. The default color is #dd6b55
        /// </summary>
        /// <param name="denyButtonColor"></param>
        /// <returns></returns>
        public SwalBuilder DenyButtonColor(string denyButtonColor)
        {
            Swal.DenyButtonColor = denyButtonColor;
            return this;
        }

        /// <summary>
        /// Use this to change the background color of the "Cancel"-button. The default color is #aaa
        /// </summary>
        /// <param name="cancelButtonColor"></param>
        /// <returns></returns>
        public SwalBuilder CancelButtonColor(string cancelButtonColor)
        {
            Swal.CancelButtonColor = cancelButtonColor;
            return this;
        }

        /// <summary>
        /// Use this to change the aria-label for the "Confirm"-button.
        /// </summary>
        /// <param name="confirmButtonAriaLabel"></param>
        /// <returns></returns>
        public SwalBuilder ConfirmButtonAriaLabel(string confirmButtonAriaLabel)
        {
            Swal.ConfirmButtonAriaLabel = confirmButtonAriaLabel;
            return this;
        }

        /// <summary>
        /// Use this to change the aria-label for the "Deny"-button.
        /// </summary>
        /// <param name="denyButtonAriaLabel"></param>
        /// <returns></returns>
        public SwalBuilder DenyButtonAriaLabel(string denyButtonAriaLabel)
        {
            Swal.DenyButtonAriaLabel = denyButtonAriaLabel;
            return this;
        }

        /// <summary>
        /// Use this to change the aria-label for the "Cancel"-button.
        /// </summary>
        /// <param name="cancelButtonAriaLabel"></param>
        /// <returns></returns>
        public SwalBuilder CancelButtonAriaLabel(string cancelButtonAriaLabel)
        {
            Swal.CancelButtonAriaLabel = cancelButtonAriaLabel;
            return this;
        }

        /// <summary>
        /// Apply default styling to buttons. If you want to use your own classes (e.g. Bootstrap classes) set this parameter to false.
        /// </summary>
        /// <param name="buttonStyling"></param>
        /// <returns></returns>
        public SwalBuilder ButtonsStyling(bool buttonStyling)
        {
            Swal.ButtonsStyling = buttonStyling;
            return this;
        }

        /// <summary>
        /// Set to true if you want to invert default buttons positions ("Confirm"-button on the right side).
        /// </summary>
        /// <param name="reverseButtons"></param>
        /// <returns></returns>
        public SwalBuilder ReverseButtons(bool reverseButtons)
        {
            Swal.ReverseButtons = reverseButtons;
            return this;
        }

        /// <summary>
        /// Set to false if you want to focus the first element in tab order instead of "Confirm"-button by default.
        /// </summary>
        /// <param name="focusConfirm"></param>
        /// <returns></returns>
        public SwalBuilder FocusConfirm(bool focusConfirm)
        {
            Swal.FocusConfirm = focusConfirm;
            return this;
        }

        /// <summary>
        /// Set to false if you don't want to return the focus to the element that invoked the modal after the modal is closed.
        /// </summary>
        /// <param name="returnFocus"></param>
        /// <returns></returns>
        public SwalBuilder ReturnFocus(bool returnFocus)
        {
            Swal.ReturnFocus = returnFocus;
            return this;
        }

        /// <summary>
        /// Set to true if you want to focus the "Deny"-button by default.
        /// </summary>
        /// <param name="focusDeny"></param>
        /// <returns></returns>
        public SwalBuilder FocusDeny(bool focusDeny)
        {
            Swal.FocusDeny = focusDeny;
            return this;
        }

        /// <summary>
        /// Set to true if you want to focus the "Cancel"-button by default.
        /// </summary>
        /// <param name="focusCancel"></param>
        /// <returns></returns>
        public SwalBuilder FocusCancel(bool focusCancel)
        {
            Swal.FocusCancel = focusCancel;
            return this;
        }

        /// <summary>
        /// Set to true to show close button in top right corner of the popup.
        /// </summary>
        /// <param name="showCloseButton"></param>
        /// <returns></returns>
        public SwalBuilder ShowCloseButton(bool showCloseButton)
        {
            Swal.ShowCloseButton = showCloseButton;
            return this;
        }

        /// <summary>
        /// Use this to change the content of the close button.
        /// </summary>
        /// <param name="closeButtonHtml"></param>
        /// <returns></returns>
        public SwalBuilder CloseButtonHtml(string closeButtonHtml)
        {
            Swal.CloseButtonHtml = closeButtonHtml;
            return this;
        }

        /// <summary>
        /// Use this to change the aria-label for the close button.
        /// </summary>
        /// <param name="closeButtonAriaLabel"></param>
        /// <returns></returns>
        public SwalBuilder CloseButtonAriaLabel(string closeButtonAriaLabel)
        {
            Swal.CloseButtonAriaLabel = closeButtonAriaLabel;
            return this;
        }

        /// <summary>
        /// Use this to change the HTML content of the loader.
        /// </summary>
        /// <param name="loaderHtml"></param>
        /// <returns></returns>
        public SwalBuilder LoaderHtml(string loaderHtml)
        {
            Swal.LoaderHtml = loaderHtml;
            return this;
        }

        /// <summary>
        /// Set to true to disable buttons and show the loader instead of the Confirm button. Use it in combination with the preConfirm parameter.
        /// </summary>
        /// <param name="showLoaderOnConfirm"></param>
        /// <returns></returns>
        public SwalBuilder ShowLoaderOnConfirm(bool showLoaderOnConfirm)
        {
            Swal.ShowLoaderOnConfirm = showLoaderOnConfirm;
            return this;
        }

        /// <summary>
        /// Set to true to disable buttons and show the loader instead of the Deny button. Use it in combination with the preDeny parameter.
        /// </summary>
        /// <param name="showLoaderOnDeny"></param>
        /// <returns></returns>
        public SwalBuilder ShowLoaderOnDeny(bool showLoaderOnDeny)
        {
            Swal.ShowLoaderOnDeny = showLoaderOnDeny;
            return this;
        }

        /// <summary>
        /// If you want to return the input value as result.value when denying the popup, set to true. Otherwise, the denying will set result.value to false.
        /// </summary>
        /// <param name="returnInputValueOnDeny"></param>
        /// <returns></returns>
        public SwalBuilder ReturnInputValueOnDeny(bool returnInputValueOnDeny)
        {
            Swal.ReturnInputValueOnDeny = returnInputValueOnDeny;
            return this;
        }

        /// <summary>
        /// Add a customized icon for the popup. Should contain a string with the path or URL to the image.
        /// </summary>
        /// <param name="imageUrl"></param>
        /// <returns></returns>
        public SwalBuilder ImageUrl(string imageUrl)
        {
            Swal.ImageUrl = imageUrl;
            return this;
        }

        /// <summary>
        /// If imageUrl is set, you can specify imageWidth to describes image width. Can be in any CSS unit (px, em/rem, %).
        /// </summary>
        /// <param name="imageWidth"></param>
        /// <returns></returns>
        public SwalBuilder ImageWidth(string imageWidth)
        {
            Swal.ImageWidth = imageWidth;
            return this;
        }

        /// <summary>
        /// Custom image height. Can be in any CSS unit (px, em/rem, %).
        /// </summary>
        /// <param name="imageHeight"></param>
        /// <returns></returns>
        public SwalBuilder ImageHeight(string imageHeight)
        {
            Swal.ImageHeight = imageHeight;
            return this;
        }

        /// <summary>
        /// An alternative text for the custom image icon.
        /// </summary>
        /// <param name="imageAlt"></param>
        /// <returns></returns>
        public SwalBuilder ImageAlt(string imageAlt)
        {
            Swal.ImageAlt = imageAlt;
            return this;
        }

        /// <summary>
        /// Input field label.
        /// </summary>
        /// <param name="inputLabel"></param>
        /// <returns></returns>
        public SwalBuilder InputLabel(string inputLabel)
        {
            Swal.InputLabel = inputLabel;
            return this;
        }

        /// <summary>
        /// Input field placeholder.
        /// </summary>
        /// <param name="inputPlaceholder"></param>
        /// <returns></returns>
        public SwalBuilder InputPlaceholder(string inputPlaceholder)
        {
            Swal.InputPlaceholder = inputPlaceholder;
            return this;
        }

        /// <summary>
        /// Input field initial value.
        /// If the input type is select, inputValue will represent the selected option tag.
        /// If the input type is checkbox, inputValue will represent the checked state.
        /// If the input type is email, number, tel, text, email, number, tel or textarea, a Promise can be accepted as inputValue.
        /// </summary>
        /// <param name="inputValue"></param>
        /// <returns></returns>
        public SwalBuilder InputValue(string inputValue)
        {
            Swal.InputValue = inputValue;
            return this;
        }

        /// <summary>
        /// If input parameter is set to "select" or "radio", you can provide options. 
        /// Can be a Map or a plain object, with keys that represent option values and values that represent option text. 
        /// You can also provide plain object or Map as values that will represented a group of options, being the label of this 'optgroup' the key. 
        /// Finally, you can also provide a Promise that resolves with one of those types.
        /// </summary>
        /// <param name="inputOptions"></param>
        /// <returns></returns>
        public SwalBuilder InputOptions(object inputOptions)
        {
            Swal.InputOptions = inputOptions;
            return this;
        }

        /// <summary>
        /// Automatically focus the input when popup is shown. Set this parameter to false to disable auto-focusing.
        /// </summary>
        /// <param name="inputAutoFocus"></param>
        /// <returns></returns>
        public SwalBuilder InputAutoFocus(bool inputAutoFocus)
        {
            Swal.InputAutoFocus = inputAutoFocus;
            return this;
        }

        /// <summary>
        /// Automatically remove whitespaces from both ends of a result string. Set this parameter to false to disable auto-trimming.
        /// </summary>
        /// <param name="inputAutoTrim"></param>
        /// <returns></returns>
        public SwalBuilder InputAutoTrim(bool inputAutoTrim)
        {
            Swal.InputAutoTrim = inputAutoTrim;
            return this;
        }

        /// <summary>
        /// A custom validation message for default validators (email, url).
        /// </summary>
        /// <param name="validationMessage"></param>
        /// <returns></returns>
        public SwalBuilder ValidationMessage(string validationMessage)
        {
            Swal.ValidationMessage = validationMessage;
            return this;
        }

        /// <summary>
        /// Progress steps, useful for queues.
        /// </summary>
        /// <param name="progressSteps"></param>
        /// <returns></returns>
        public SwalBuilder ProgressSteps(params string[] progressSteps)
        {
            Swal.ProgressSteps = progressSteps;
            return this;
        }

        /// <summary>
        /// Current active progress step.
        /// </summary>
        /// <param name="currentProgressStep"></param>
        /// <returns></returns>
        public SwalBuilder CurrentProgressStep(string currentProgressStep)
        {
            Swal.CurrentProgressStep = currentProgressStep;
            return this;
        }

        /// <summary>
        /// Distance between progress steps. Can be in any CSS unit (px, em/rem, %).
        /// </summary>
        /// <param name="progressStepsDistance"></param>
        /// <returns></returns>
        public SwalBuilder ProgressStepsDistance(string progressStepsDistance)
        {
            Swal.ProgressStepsDistance = progressStepsDistance;
            return this;
        }

        /// <summary>
        /// Function to execute before confirming, may be async (Promise-returning) or sync.
        /// </summary>
        /// <param name="preConfirm"></param>
        /// <returns></returns>
        public SwalBuilder PreConfirm(string preConfirm)
        {
            Swal.PreConfirm = preConfirm;
            return this;
        }

        /// <summary>
        /// Function to execute before denying, may be async (Promise-returning) or sync.
        /// </summary>
        /// <param name="preDeny"></param>
        /// <returns></returns>
        public SwalBuilder PreDeny(string preDeny)
        {
            Swal.PreDeny = preDeny;
            return this;
        }

        /// <summary>
        /// Validator for input field, may be async (Promise-returning) or sync.
        /// </summary>
        /// <param name="inputValidator"></param>
        /// <returns></returns>
        public SwalBuilder InputValidator(string inputValidator)
        {
            Swal.InputValidator = inputValidator;
            return this;
        }

        /// <summary>
        /// Popup lifecycle hook. Synchronously runs after the popup DOM has been updated (i.e. just before the popup is repainted on the screen). 
        /// didRender is called before willOpen.  Provides popup DOM element as the argument.
        /// Typically, this will happen after Swal.fire() or Swal.update().
        /// If you want to perform changes in the popup's DOM, that survive Swal.update(), prefer didRender over willOpen.
        /// In previous versions, this hook was named onRender.
        /// </summary>
        /// <param name="didRender"></param>
        /// <returns></returns>
        public SwalBuilder DidRender(string didRender)
        {
            Swal.DidRender = didRender;
            return this;
        }

        /// <summary>
        /// Popup lifecycle hook. Synchronously runs before the popup is shown on screen. 
        /// Provides popup DOM element as the argument. In previous versions, this hook was named onBeforeOpen.
        /// </summary>
        /// <param name="willOpen"></param>
        /// <returns></returns>
        public SwalBuilder WillOpen(string willOpen)
        {
            Swal.WillOpen = willOpen;
            return this;
        }

        /// <summary>
        /// Popup lifecycle hook. Asynchronously runs after the popup has been shown on screen. 
        /// Provides popup DOM element as the argument. In previous versions, this hook was named onOpen.
        /// </summary>
        /// <param name="didOpen"></param>
        /// <returns></returns>
        public SwalBuilder DidOpen(string didOpen)
        {
            Swal.DidOpen = didOpen;
            return this;
        }

        /// <summary>
        /// Popup lifecycle hook. Synchronously runs when the popup closes by user interaction (and not due to another popup being fired). 
        /// Provides popup DOM element as the argument. In previous versions, this hook was named onClose.
        /// </summary>
        /// <param name="willClose"></param>
        /// <returns></returns>
        public SwalBuilder WillClose(string willClose)
        {
            Swal.WillClose = willClose;
            return this;
        }

        /// <summary>
        /// Popup lifecycle hook. Asynchronously runs after the popup has been disposed by user interaction (and not due to another popup being fired). 
        /// In previous versions, this hook was named onAfterClose.
        /// </summary>
        /// <param name="didClose"></param>
        /// <returns></returns>
        public SwalBuilder DidClose(string didClose)
        {
            Swal.DidClose = didClose;
            return this;
        }

        /// <summary>
        /// Popup lifecycle hook. Synchronously runs after popup has been destroyed either by user interaction or by another popup.
        /// If you have cleanup operations that you need to reliably execute each time a popup is closed, prefer didDestroy over didClose.
        /// In previous versions, this hook was named onDestroy.
        /// </summary>
        /// <param name="didDestroy"></param>
        /// <returns></returns>
        public SwalBuilder DidDestroy(string didDestroy)
        {
            Swal.DidDestroy = didDestroy;
            return this;
        }

        /// <summary>
        /// HTML input attributes (e.g. min, max, autocomplete, accept), that are added to the input field. 
        /// Object keys will represent attributes names, object values will represent attributes values.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public SwalBuilder InputAttributes(Action<AttributesBuilder> action)
        {
            Swal.InputAttributes = new Dictionary<string, string>();
            var builder = new AttributesBuilder(Swal.InputAttributes);
            action(builder);
            return this;
        }
    }
}
