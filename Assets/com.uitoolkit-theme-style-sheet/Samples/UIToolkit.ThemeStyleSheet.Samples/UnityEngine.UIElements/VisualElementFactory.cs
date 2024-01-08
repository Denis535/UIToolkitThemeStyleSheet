#nullable enable
namespace UnityEngine.UIElements {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using UnityEngine;
    using UnityEngine.UIElements.Experimental;

    public static partial class VisualElementFactory {

        public static Func<object?, string?>? StringSelector { get; set; }

        // VisualElement
        public static VisualElement VisualElement() {
            var result = Create<VisualElement>( null );
            return result;
        }

        // Label
        public static Label Label(string? text) {
            var result = Create<Label>( null );
            {
                result.text = text;
            }
            return result;
        }

        // Button
        public static Button Button(string? text) {
            var result = Create<Button>( null );
            {
                result.text = text;
                result.OnClick( evt => {

                } );
            }
            return result;
        }
        public static RepeatButton RepeatButton(string? text) {
            var result = Create<RepeatButton>( null );
            {
                result.text = text;
                result.OnClick( evt => {

                } );
            }
            return result;
        }

        // Field
        public static TextField TextField(string? label, string? value, int maxLength, bool isMultiline) {
            var result = Create<TextField>( null );
            {
                result.label = label;
                result.value = value;
                result.maxLength = maxLength;
                result.multiline = isMultiline;
                result.isReadOnly = false;
                result.OnChange( evt => {

                } );
            }
            return result;
        }
        public static TextField ReadOnlyTextField(string? label, string? value, int maxLength, bool isMultiline) {
            var result = Create<TextField>( null );
            {
                result.label = label;
                result.value = value;
                result.maxLength = maxLength;
                result.multiline = isMultiline;
                result.isReadOnly = true;
                result.OnChange( evt => {

                } );
            }
            return result;
        }
        public static PopupField<object?> PopupField(string? label, object? value, object?[]? choices) {
            var result = Create<PopupField<object?>>( null );
            {
                result.formatSelectedValueCallback = StringSelector;
                result.formatListItemCallback = StringSelector;
                result.label = label;
                result.value = value;
                result.choices = choices?.ToList();
                result.OnChange( evt => {

                } );
            }
            return result;
        }
        public static DropdownField DropdownField(string? label, string? value, string?[]? choices) {
            var result = Create<DropdownField>( null );
            {
                result.formatSelectedValueCallback = StringSelector;
                result.formatListItemCallback = StringSelector;
                result.label = label;
                result.value = value;
                result.choices = choices?.ToList();
                result.OnChange( evt => {

                } );
            }
            return result;
        }
        public static Slider SliderField(string? label, float value, float min, float max) {
            var result = Create<Slider>( null );
            {
                result.label = label;
                result.value = value;
                result.lowValue = min;
                result.highValue = max;
                result.OnChange( evt => {

                } );
            }
            return result;
        }
        public static SliderInt IntSliderField(string? label, int value, int min, int max) {
            var result = Create<SliderInt>( null );
            {
                result.label = label;
                result.value = value;
                result.lowValue = min;
                result.highValue = max;
                result.OnChange( evt => {

                } );
            }
            return result;
        }
        public static Toggle ToggleField(string? label, bool value) {
            var result = Create<Toggle>( null );
            {
                result.label = label;
                result.value = value;
                result.OnChange( evt => {

                } );
            }
            return result;
        }

        // Helpers
        private static T Create<T>(string? name, params string?[] classes) where T : VisualElement, new() {
            var result = new T();
            result.name = name;
            result.AddToClassList( "visual-element" );
            foreach (var @class in classes) {
                result.AddToClassList( @class );
            }
            return result;
        }
        // Helpers
        private static void PlayWidgetAppearanceAnimation(Widget view) {
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

    }
}
