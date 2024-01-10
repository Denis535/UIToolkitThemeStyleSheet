#nullable enable
namespace UIToolkit.ThemeStyleSheet.Samples {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using UnityEditor;
    using UnityEngine;
    using UnityEngine.UIElements;
    using UnityEngine.UIElements.Experimental;

    public partial class VisualElementFactory : MonoBehaviour {

        // Assets
        [SerializeField] private AudioClip window = default!;
        [SerializeField] private AudioClip infoWindow = default!;
        [SerializeField] private AudioClip warningWindow = default!;
        [SerializeField] private AudioClip errorWindow = default!;
        [SerializeField] private AudioClip focus = default!;
        [SerializeField] private AudioClip click = default!;
        [SerializeField] private AudioClip select = default!;
        [SerializeField] private AudioClip submitSelect = default!;
        [SerializeField] private AudioClip cancelSelect = default!;
        [SerializeField] private AudioClip invalidSelect = default!;
        [SerializeField] private AudioClip tik = default!;

        // AudioSource
        private AudioSource AudioSource { get; set; } = default!;

        // Awake
        public void Awake() {
            AudioSource = GetComponent<AudioSource>();
        }
        public void OnDestroy() {
        }

        // VisualElement
        public VisualElement VisualElement() {
            var result = Create<VisualElement>( null );
            return result;
        }

        // Label
        public Label Label(string? text) {
            var result = Create<Label>( null );
            result.text = text;
            return result;
        }

        // Button
        public Button Button(string? text) {
            var result = Create<Button>( null );
            result.text = text;
            result.OnFocus( PlayFocus );
            result.OnClick( PlayClick );
            return result;
        }
        public RepeatButton RepeatButton(string? text) {
            var result = Create<RepeatButton>( null );
            result.text = text;
            result.OnFocus( PlayFocus );
            result.OnClick( PlayClick );
            return result;
        }

        // Field
        public TextField TextField(string? label, string? value, int maxLength, bool isMultiline = false, bool isReadOnly = false) {
            var result = Create<TextField>( null );
            result.label = label;
            result.value = value;
            result.maxLength = maxLength;
            result.multiline = isMultiline;
            result.isReadOnly = isReadOnly;
            result.OnFocus( PlayFocus );
            result.OnChange( PlayChange );
            return result;
        }
        public PopupField<object?> PopupField(string? label, object? value, object?[]? choices) {
            var result = Create<PopupField<object?>>( null );
            //result.formatSelectedValueCallback = StringSelector;
            //result.formatListItemCallback = StringSelector;
            result.label = label;
            result.value = value;
            result.choices = choices?.ToList();
            result.OnFocus( PlayFocus );
            result.OnChange( PlayChange );
            return result;
        }
        public DropdownField DropdownField(string? label, string? value, string?[]? choices) {
            var result = Create<DropdownField>( null );
            //result.formatSelectedValueCallback = StringSelector;
            //result.formatListItemCallback = StringSelector;
            result.label = label;
            result.value = value;
            result.choices = choices?.ToList();
            result.OnFocus( PlayFocus );
            result.OnChange( PlayChange );
            return result;
        }
        public Slider SliderField(string? label, float value, float min, float max) {
            var result = Create<Slider>( null );
            result.label = label;
            result.value = value;
            result.lowValue = min;
            result.highValue = max;
            result.OnFocus( PlayFocus );
            result.OnChange( PlayChange );
            return result;
        }
        public SliderInt IntSliderField(string? label, int value, int min, int max) {
            var result = Create<SliderInt>( null );
            result.label = label;
            result.value = value;
            result.lowValue = min;
            result.highValue = max;
            result.OnFocus( PlayFocus );
            result.OnChange( PlayChange );
            return result;
        }
        public Toggle ToggleField(string? label, bool value) {
            var result = Create<Toggle>( null );
            result.label = label;
            result.value = value;
            result.OnFocus( PlayFocus );
            result.OnChange( PlayChange );
            return result;
        }

        // Helpers
        private void PlayAttach(AttachToPanelEvent evt) {
            var target = (Widget) evt.target;
            if (target.name == "dialog-widget") {
                AudioSource.PlayOneShot( window );
            } else
            if (target.name == "info-dialog-widget") {
                AudioSource.PlayOneShot( infoWindow );
            } else
            if (target.name == "warning-dialog-widget") {
                AudioSource.PlayOneShot( warningWindow );
            } else
            if (target.name == "error-dialog-widget") {
                AudioSource.PlayOneShot( errorWindow );
            }
        }
        private void PlayAttach(Widget view) {
            var animation = ValueAnimation<float>.Create( view, Mathf.LerpUnclamped );
            animation.valueUpdated = (view, t) => {
                var tx = Easing.OutBack( Easing.InPower( t, 2 ), 4 );
                var ty = Easing.OutBack( Easing.OutPower( t, 2 ), 4 );
                var x = Mathf.LerpUnclamped( 0.8f, 1f, tx );
                var y = Mathf.LerpUnclamped( 0.8f, 1f, ty );
                view.transform.scale = new Vector3( x, y, 1 );
            };
            animation.from = 0;
            animation.to = 1;
            animation.durationMs = 500;
            animation.Start();
        }
        private void PlayFocus(FocusEvent evt) {
            if (evt.direction != FocusChangeDirection.none && evt.direction != FocusChangeDirection.unspecified) {
                AudioSource.PlayOneShot( focus );
            }
        }
        private void PlayClick(ClickEvent evt) {
            if (evt.target is TextElement target) {
                if (!target.IsValid()) {
                    AudioSource.PlayOneShot( invalidSelect );
                } else
                if (IsSubmit( target )) {
                    AudioSource.PlayOneShot( submitSelect );
                } else
                if (IsCancel( target )) {
                    AudioSource.PlayOneShot( cancelSelect );
                } else {
                    AudioSource.PlayOneShot( select );
                }
            } else {
                AudioSource.PlayOneShot( click );
            }
        }
        private void PlayChange<T>(ChangeEvent<T> evt) {
            if (evt is ChangeEvent<int> evt_int) {
                if (evt_int.newValue != evt_int.previousValue) {
                    AudioSource.PlayOneShot( tik );
                }
            } else
            if (evt is ChangeEvent<float> evt_float) {
                if (Mathf.FloorToInt( evt_float.newValue * 200 ) != Mathf.FloorToInt( evt_float.previousValue * 200 )) {
                    AudioSource.PlayOneShot( tik );
                }
            } else {
                AudioSource.PlayOneShot( tik );
            }
        }
        // Helpers
        private static T Create<T>(string? name, string? @class = null) where T : VisualElement, new() {
            var result = new T();
            result.name = name;
            result.AddToClassList( "visual-element" );
            result.AddToClassList( @class );
            return result;
        }
        // Helpers
        private static bool IsSubmit(VisualElement element) {
            return element.name is "submit" or "submission" or "confirm" or "confirmation" or "okey" or "ok" or "yes";
        }
        private static bool IsCancel(VisualElement element) {
            return element.name is "cancel" or "cancellation" or "back" or "no";
        }
        private static bool IsQuit(VisualElement element) {
            return element.name is "quit";
        }

    }
}
