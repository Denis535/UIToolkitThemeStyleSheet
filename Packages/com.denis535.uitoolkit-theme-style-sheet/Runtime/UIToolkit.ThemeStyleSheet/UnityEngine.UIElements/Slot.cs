#nullable enable
namespace UnityEngine.UIElements {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine.Scripting;

    public class Slot : VisualElement {
        [Preserve]
        public new class UxmlFactory : UxmlFactory<Slot, UxmlTraits> { }

        public Slot() {
            AddToClassList( "slot" );
        }

    }
}
