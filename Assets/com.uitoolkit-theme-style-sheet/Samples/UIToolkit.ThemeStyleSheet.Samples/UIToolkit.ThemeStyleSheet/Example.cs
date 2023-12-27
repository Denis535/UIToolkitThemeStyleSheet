#nullable enable
namespace UIToolkit.ThemeStyleSheet {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.UIElements;

    public class Example : MonoBehaviour {

        [SerializeField] private Texture2D background;

        // Awake
        public void Awake() {
            var document = GetComponent<UIDocument>();
            document.rootVisualElement.Add( CreateVisualElement() );
        }
        public void OnDestroy() {
        }

        // Start
        public void Start() {
        }
        public void Update() {
        }

        // Helpers
        private VisualElement CreateVisualElement() {
            using (var root = VisualElementFactory.Widget().Classes( "grow-1" ).Style( i => i.backgroundImage = new StyleBackground( background ) ).AsScope()) {
                using (VisualElementFactory.LargeWidget().AsScope()) {
                    using (VisualElementFactory.Card().AsScope()) {
                        using (VisualElementFactory.Header().AsScope()) {
                            VisualElementFactory.Label( "UIToolkit Theme Style Sheet" ).Classes( "medium" );
                        }
                        using (VisualElementFactory.Content().AsScope()) {

                        }
                        using (VisualElementFactory.Footer().AsScope()) {
                            VisualElementFactory.Button( "Okey" );
                            VisualElementFactory.Button( "Cancel" );
                        }
                    }
                }
                return root.VisualElement;
            }
        }

    }
}
