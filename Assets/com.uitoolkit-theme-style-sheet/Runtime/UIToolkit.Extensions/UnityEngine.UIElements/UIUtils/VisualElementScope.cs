#nullable enable
namespace UnityEngine.UIElements {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class VisualElementScope : IDisposable {

        private static readonly Stack<VisualElement> stack = new Stack<VisualElement>();
        public static VisualElement? Current => stack.Count > 0 ? stack.Peek() : null;

        public VisualElementScope(VisualElement visualElement) {
            stack.Push( visualElement );
        }
        public void Dispose() {
            stack.Pop();
        }

    }
    public static class VisualElementScopeExtensions {

        public static VisualElementScope AsScope<T>(this T visualElement) where T : VisualElement {
            return new VisualElementScope( visualElement );
        }
        public static VisualElementScope AsScope<T>(this T visualElement, out T @out) where T : VisualElement {
            return new VisualElementScope( @out = visualElement );
        }

    }
}
