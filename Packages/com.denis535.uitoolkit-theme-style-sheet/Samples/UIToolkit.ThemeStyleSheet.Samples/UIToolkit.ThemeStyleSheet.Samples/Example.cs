#nullable enable
namespace UIToolkit.ThemeStyleSheet.Samples {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.UIElements;

    public class Example : MonoBehaviour {

        private int toolbarIndex = 0;

        // Document
        private UIDocument Document { get; set; } = default!;
        // Factory
        private VisualElementFactory Factory { get; set; } = default!;

        // Awake
        public void Awake() {
            Document = GetComponent<UIDocument>();
            Factory = GetComponent<VisualElementFactory>();
        }
        public void OnDestroy() {
        }

        // Start
        public void Start() {
        }
        public void Update() {
        }

        // OnGUI
        public void OnGUI() {
            var prevToolbarIndex = toolbarIndex;
            toolbarIndex = GUILayout.Toolbar(
                toolbarIndex,
                new[] {
                    // None
                    "None",
                    // Widget
                    "Widget",
                    "Left Widget",
                    "Small Widget",
                    "Medium Widget",
                    "Large Widget",
                    // Widget
                    "Dialog Widget",
                    "Info Dialog Widget",
                    "Warning Dialog Widget",
                    "Error Dialog Widget",
                    // View
                    "Tab View",
                    "Scroll View",
                    // Scope
                    "Scope",
                    "Group",
                    "Box",
                    // Misc
                    "Misc"
                },
                null,
                GUI.ToolbarButtonSize.FitToContents );
            // None
            if (toolbarIndex == 0 && toolbarIndex != prevToolbarIndex) {
                Document.rootVisualElement.Clear();
            }
            // Widget
            if (toolbarIndex == 1 && toolbarIndex != prevToolbarIndex) {
                Document.rootVisualElement.Clear();
                Document.rootVisualElement.Add( VisualElementFactory2.Widget( Factory ) );
            }
            if (toolbarIndex == 2 && toolbarIndex != prevToolbarIndex) {
                Document.rootVisualElement.Clear();
                Document.rootVisualElement.Add( VisualElementFactory2.LeftWidget( Factory ) );
            }
            if (toolbarIndex == 3 && toolbarIndex != prevToolbarIndex) {
                Document.rootVisualElement.Clear();
                Document.rootVisualElement.Add( VisualElementFactory2.SmallWidget( Factory ) );
            }
            if (toolbarIndex == 4 && toolbarIndex != prevToolbarIndex) {
                Document.rootVisualElement.Clear();
                Document.rootVisualElement.Add( VisualElementFactory2.MediumWidget( Factory ) );
            }
            if (toolbarIndex == 5 && toolbarIndex != prevToolbarIndex) {
                Document.rootVisualElement.Clear();
                Document.rootVisualElement.Add( VisualElementFactory2.LargeWidget( Factory ) );
            }
            // Widget
            if (toolbarIndex == 6 && toolbarIndex != prevToolbarIndex) {
                Document.rootVisualElement.Clear();
                Document.rootVisualElement.Add( VisualElementFactory2.DialogWidget( Factory ) );
            }
            if (toolbarIndex == 7 && toolbarIndex != prevToolbarIndex) {
                Document.rootVisualElement.Clear();
                Document.rootVisualElement.Add( VisualElementFactory2.InfoDialogWidget( Factory ) );
            }
            if (toolbarIndex == 8 && toolbarIndex != prevToolbarIndex) {
                Document.rootVisualElement.Clear();
                Document.rootVisualElement.Add( VisualElementFactory2.WarningDialogWidget( Factory ) );
            }
            if (toolbarIndex == 9 && toolbarIndex != prevToolbarIndex) {
                Document.rootVisualElement.Clear();
                Document.rootVisualElement.Add( VisualElementFactory2.ErrorDialogWidget( Factory ) );
            }
            // TabView
            if (toolbarIndex == 10 && toolbarIndex != prevToolbarIndex) {
                Document.rootVisualElement.Clear();
                Document.rootVisualElement.Add( VisualElementFactory2.TabView( Factory ) );
            }
            // ScrollView
            if (toolbarIndex == 11 && toolbarIndex != prevToolbarIndex) {
                Document.rootVisualElement.Clear();
                Document.rootVisualElement.Add( VisualElementFactory2.ScrollView( Factory ) );
            }
            // Scope
            if (toolbarIndex == 12 && toolbarIndex != prevToolbarIndex) {
                Document.rootVisualElement.Clear();
                Document.rootVisualElement.Add( VisualElementFactory2.Scope( Factory ) );
            }
            if (toolbarIndex == 13 && toolbarIndex != prevToolbarIndex) {
                Document.rootVisualElement.Clear();
                Document.rootVisualElement.Add( VisualElementFactory2.Group( Factory ) );
            }
            if (toolbarIndex == 14 && toolbarIndex != prevToolbarIndex) {
                Document.rootVisualElement.Clear();
                Document.rootVisualElement.Add( VisualElementFactory2.Box( Factory ) );
            }
            // Misc
            if (toolbarIndex == 15 && toolbarIndex != prevToolbarIndex) {
                Document.rootVisualElement.Clear();
                Document.rootVisualElement.Add( VisualElementFactory2.Misc( Factory ) );
            }
        }

    }
}
