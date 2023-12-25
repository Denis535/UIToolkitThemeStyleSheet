#nullable enable
namespace UnityEngine.UIElements {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using UnityEngine;

    public static partial class VisualElementFactory {

        public static Func<object?, string?>? StringSelector { get; set; }

        // Label
        public static Label Label(string? text) {
            var result = Create<Label>( null );
            {
                result.text = text;
            }
            return AddToCurrentScope( result );
        }

        // Button
        public static Button Button(string? text) {
            var result = Create<Button>( null );
            {
                result.text = text;
            }
            return AddToCurrentScope( result );
        }
        public static RepeatButton RepeatButton(string? text) {
            var result = Create<RepeatButton>( null );
            {
                result.text = text;
            }
            return AddToCurrentScope( result );
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
            }
            return AddToCurrentScope( result );
        }
        public static TextField TextFieldReadOnly(string? label, string? value, int maxLength, bool isMultiline) {
            var result = Create<TextField>( null );
            {
                result.label = label;
                result.value = value;
                result.maxLength = maxLength;
                result.multiline = isMultiline;
                result.isReadOnly = true;
            }
            return AddToCurrentScope( result );
        }
        public static PopupField<object?> PopupField(string? label, object? value, object?[]? choices) {
            var result = Create<PopupField<object?>>( null );
            {
                result.formatSelectedValueCallback = StringSelector;
                result.formatListItemCallback = StringSelector;
                result.label = label;
                result.value = value;
                result.choices = choices?.ToList();
            }
            return AddToCurrentScope( result );
        }
        public static DropdownField DropdownField(string? label, string? value, string?[]? choices) {
            var result = Create<DropdownField>( null );
            {
                result.formatSelectedValueCallback = StringSelector;
                result.formatListItemCallback = StringSelector;
                result.label = label;
                result.value = value;
                result.choices = choices?.ToList();
            }
            return AddToCurrentScope( result );
        }
        public static Slider Slider(string? label, float value, float min, float max) {
            var result = Create<Slider>( null );
            {
                result.label = label;
                result.value = value;
                result.lowValue = min;
                result.highValue = max;
            }
            return AddToCurrentScope( result );
        }
        public static SliderInt SliderInt(string? label, int value, int min, int max) {
            var result = Create<SliderInt>( null );
            {
                result.label = label;
                result.value = value;
                result.lowValue = min;
                result.highValue = max;
            }
            return AddToCurrentScope( result );
        }
        public static Toggle Toggle(string? label, bool value) {
            var result = Create<Toggle>( null );
            {
                result.label = label;
                result.value = value;
            }
            return AddToCurrentScope( result );
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
        private static T AddToCurrentScope<T>(T visualElement) where T : VisualElement {
            VisualElementScope.Current?.Add( visualElement );
            return visualElement;
        }

    }
}
