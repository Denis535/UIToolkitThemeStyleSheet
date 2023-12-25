#nullable enable
namespace UnityEngine.UIElements {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class VisualElementScope : IDisposable {

        private static readonly Stack<VisualElement> stack = new Stack<VisualElement>();
        public static VisualElement? Current => stack.Count > 0 ? stack.Peek() : null;

        public VisualElement VisualElement { get; private set; }

        public VisualElementScope(VisualElement visualElement) {
            stack.Push( visualElement );
            VisualElement = visualElement;
        }
        public void Dispose() {
            stack.Pop();
        }

        public static implicit operator VisualElement(VisualElementScope scope) {
            return scope.VisualElement;
        }

    }
    public class VisualElementScope<T> : VisualElementScope where T : VisualElement {

        public new T VisualElement => (T) base.VisualElement;

        public VisualElementScope(T visualElement) : base( visualElement ) {
        }

        public static implicit operator T(VisualElementScope<T> scope) {
            return scope.VisualElement;
        }

    }
    public static class VisualElementScopeExtensions {

        public static VisualElementScope<T> AsScope<T>(this T visualElement) where T : VisualElement {
            return new VisualElementScope<T>( visualElement );
        }
        public static VisualElementScope<T> AsScope<T>(this T visualElement, out T @out) where T : VisualElement {
            return new VisualElementScope<T>( @out = visualElement );
        }

    }
}
