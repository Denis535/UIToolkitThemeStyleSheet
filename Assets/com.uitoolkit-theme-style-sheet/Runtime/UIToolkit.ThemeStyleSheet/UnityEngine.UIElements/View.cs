#nullable enable
namespace UnityEngine.UIElements {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine.Scripting;

    public class View : VisualElement {
        [Preserve]
        public new class UxmlFactory : UxmlFactory<View, UxmlTraits> { }

        public View() {
            AddToClassList( "view" );
        }

    }
}
