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
                Document.rootVisualElement.Add( Widget( Factory ) );
            }
            if (toolbarIndex == 2 && toolbarIndex != prevToolbarIndex) {
                Document.rootVisualElement.Clear();
                Document.rootVisualElement.Add( LeftWidget( Factory ) );
            }
            if (toolbarIndex == 3 && toolbarIndex != prevToolbarIndex) {
                Document.rootVisualElement.Clear();
                Document.rootVisualElement.Add( SmallWidget( Factory ) );
            }
            if (toolbarIndex == 4 && toolbarIndex != prevToolbarIndex) {
                Document.rootVisualElement.Clear();
                Document.rootVisualElement.Add( MediumWidget( Factory ) );
            }
            if (toolbarIndex == 5 && toolbarIndex != prevToolbarIndex) {
                Document.rootVisualElement.Clear();
                Document.rootVisualElement.Add( LargeWidget( Factory ) );
            }
            // Widget
            if (toolbarIndex == 6 && toolbarIndex != prevToolbarIndex) {
                Document.rootVisualElement.Clear();
                Document.rootVisualElement.Add( DialogWidget( Factory ) );
            }
            if (toolbarIndex == 7 && toolbarIndex != prevToolbarIndex) {
                Document.rootVisualElement.Clear();
                Document.rootVisualElement.Add( InfoDialogWidget( Factory ) );
            }
            if (toolbarIndex == 8 && toolbarIndex != prevToolbarIndex) {
                Document.rootVisualElement.Clear();
                Document.rootVisualElement.Add( WarningDialogWidget( Factory ) );
            }
            if (toolbarIndex == 9 && toolbarIndex != prevToolbarIndex) {
                Document.rootVisualElement.Clear();
                Document.rootVisualElement.Add( ErrorDialogWidget( Factory ) );
            }
            // TabView
            if (toolbarIndex == 10 && toolbarIndex != prevToolbarIndex) {
                Document.rootVisualElement.Clear();
                Document.rootVisualElement.Add( TabView( Factory ) );
            }
            // ScrollView
            if (toolbarIndex == 11 && toolbarIndex != prevToolbarIndex) {
                Document.rootVisualElement.Clear();
                Document.rootVisualElement.Add( ScrollView( Factory ) );
            }
            // Scope
            if (toolbarIndex == 12 && toolbarIndex != prevToolbarIndex) {
                Document.rootVisualElement.Clear();
                Document.rootVisualElement.Add( Scope( Factory ) );
            }
            if (toolbarIndex == 13 && toolbarIndex != prevToolbarIndex) {
                Document.rootVisualElement.Clear();
                Document.rootVisualElement.Add( Group( Factory ) );
            }
            if (toolbarIndex == 14 && toolbarIndex != prevToolbarIndex) {
                Document.rootVisualElement.Clear();
                Document.rootVisualElement.Add( Box( Factory ) );
            }
            // Misc
            if (toolbarIndex == 15 && toolbarIndex != prevToolbarIndex) {
                Document.rootVisualElement.Clear();
                Document.rootVisualElement.Add( Misc( Factory ) );
            }
        }

        // Helpers
        private static VisualElement Widget(VisualElementFactory factory) {
            using (var root = factory.Widget().AsScope()) {
                using (factory.Card().AsScope()) {
                    using (factory.Header().AsScope()) {
                        VisualElementScope.Add( factory.Label( "Widget" ) );
                    }
                    using (factory.Content().AsScope()) {
                        VisualElementScope.Add( factory.Label( "Widget" ) );
                    }
                    using (factory.Footer().AsScope()) {
                        VisualElementScope.Add( factory.Submit( "Submit" ), factory.Cancel( "Cancel" ) );
                    }
                }
                return root.VisualElement;
            }
        }
        private static VisualElement LeftWidget(VisualElementFactory factory) {
            using (var root = factory.LeftWidget().AsScope()) {
                using (factory.Card().AsScope()) {
                    using (factory.Header().AsScope()) {
                        VisualElementScope.Add( factory.Label( "Left Widget" ) );
                    }
                    using (factory.Content().AsScope()) {
                        VisualElementScope.Add( factory.Select( "Item 1" ), factory.Select( "Item 2" ), factory.Select( "Item 3" ) );
                    }
                    using (factory.Footer().AsScope()) {
                        VisualElementScope.Add( factory.Submit( "Submit" ), factory.Cancel( "Cancel" ) );
                    }
                }
                return root.VisualElement;
            }
        }
        private static VisualElement SmallWidget(VisualElementFactory factory) {
            using (var root = factory.SmallWidget().AsScope()) {
                using (factory.Card().AsScope()) {
                    using (factory.Header().AsScope()) {
                        VisualElementScope.Add( factory.Label( "Small Widget" ) );
                    }
                    using (factory.Content().AsScope()) {
                        VisualElementScope.Add( factory.Label( "Small Widget" ) );
                    }
                    using (factory.Footer().AsScope()) {
                        VisualElementScope.Add( factory.Submit( "Submit" ), factory.Cancel( "Cancel" ) );
                    }
                }
                return root.VisualElement;
            }
        }
        private static VisualElement MediumWidget(VisualElementFactory factory) {
            using (var root = factory.MediumWidget().AsScope()) {
                using (factory.Card().AsScope()) {
                    using (factory.Header().AsScope()) {
                        VisualElementScope.Add( factory.Label( "Medium Widget" ) );
                    }
                    using (factory.Content().AsScope()) {
                        VisualElementScope.Add( factory.Label( "Medium Widget" ) );
                    }
                    using (factory.Footer().AsScope()) {
                        VisualElementScope.Add( factory.Submit( "Submit" ), factory.Cancel( "Cancel" ) );
                    }
                }
                return root.VisualElement;
            }
        }
        private static VisualElement LargeWidget(VisualElementFactory factory) {
            using (var root = factory.LargeWidget().AsScope()) {
                using (factory.Card().AsScope()) {
                    using (factory.Header().AsScope()) {
                        VisualElementScope.Add( factory.Label( "Large Widget" ) );
                    }
                    using (factory.Content().AsScope()) {
                        VisualElementScope.Add( factory.Label( "Large Widget" ) );
                    }
                    using (factory.Footer().AsScope()) {
                        VisualElementScope.Add( factory.Submit( "Submit" ), factory.Cancel( "Cancel" ) );
                    }
                }
                return root.VisualElement;
            }
        }
        private static VisualElement DialogWidget(VisualElementFactory factory) {
            using (var root = factory.DialogWidget().AsScope()) {
                using (factory.DialogCard().AsScope()) {
                    using (factory.Header().AsScope()) {
                        VisualElementScope.Add( factory.Label( "Dialog Widget" ) );
                    }
                    using (factory.Content().AsScope()) {
                        VisualElementScope.Add(
                            factory.ColumnGroup()
                                .Classes( "dark", "medium", "grow-1", "justify-content-center", "align-items-center" )
                                .Children( factory.Label( "Dialog Widget" ) )
                        );
                    }
                    using (factory.Footer().AsScope()) {
                        VisualElementScope.Add( factory.Submit( "Submit" ), factory.Cancel( "Cancel" ) );
                    }
                }
                return root.VisualElement;
            }
        }
        private static VisualElement InfoDialogWidget(VisualElementFactory factory) {
            using (var root = factory.InfoDialogWidget().AsScope()) {
                using (factory.InfoDialogCard().AsScope()) {
                    using (factory.Header().AsScope()) {
                        VisualElementScope.Add( factory.Label( "Info Dialog Widget" ) );
                    }
                    using (factory.Content().AsScope()) {
                        VisualElementScope.Add(
                            factory.ColumnGroup()
                                .Classes( "dark", "medium", "grow-1", "justify-content-center", "align-items-center" )
                                .Children( factory.Label( "Info Dialog Widget" ) )
                        );
                    }
                    using (factory.Footer().AsScope()) {
                        VisualElementScope.Add( factory.Submit( "Submit" ), factory.Cancel( "Cancel" ) );
                    }
                }
                return root.VisualElement;
            }
        }
        private static VisualElement WarningDialogWidget(VisualElementFactory factory) {
            using (var root = factory.WarningDialogWidget().AsScope()) {
                using (factory.WarningDialogCard().AsScope()) {
                    using (factory.Header().AsScope()) {
                        VisualElementScope.Add( factory.Label( "Warning Dialog Widget" ) );
                    }
                    using (factory.Content().AsScope()) {
                        VisualElementScope.Add(
                            factory.ColumnGroup()
                                .Classes( "dark", "medium", "grow-1", "justify-content-center", "align-items-center" )
                                .Children( factory.Label( "Warning Dialog Widget" ) )
                        );
                    }
                    using (factory.Footer().AsScope()) {
                        VisualElementScope.Add( factory.Submit( "Submit" ), factory.Cancel( "Cancel" ) );
                    }
                }
                return root.VisualElement;
            }
        }
        private static VisualElement ErrorDialogWidget(VisualElementFactory factory) {
            using (var root = factory.ErrorDialogWidget().AsScope()) {
                using (factory.ErrorDialogCard().AsScope()) {
                    using (factory.Header().AsScope()) {
                        VisualElementScope.Add( factory.Label( "Error Dialog Widget" ) );
                    }
                    using (factory.Content().AsScope()) {
                        VisualElementScope.Add(
                            factory.ColumnGroup()
                                .Classes( "dark", "medium", "grow-1", "justify-content-center", "align-items-center" )
                                .Children( factory.Label( "Error Dialog Widget" ) )
                        );
                    }
                    using (factory.Footer().AsScope()) {
                        VisualElementScope.Add( factory.Submit( "Submit" ), factory.Cancel( "Cancel" ) );
                    }
                }
                return root.VisualElement;
            }
        }
        // Helpers
        private static VisualElement TabView(VisualElementFactory factory) {
            using (var root = factory.LargeWidget().AsScope()) {
                using (factory.Card().AsScope()) {
                    using (factory.Header().AsScope()) {
                        VisualElementScope.Add( factory.Label( "Tab View" ) );
                    }
                    using (factory.Content().AsScope()) {
                        VisualElementScope.Add(
                            factory.TabView().Classes( "gray", "medium", "grow-1" ).Children(
                                factory.Tab( "Tab 1" ).Children(
                                    factory.VisualElement()
                                        .Classes( "color-light", "background-color-dark", "margin-0px", "grow-1", "justify-content-center", "align-items-center" )
                                        .Children( factory.Label( "Tab 1" ) )
                                ),
                                factory.Tab( "Tab 2" ).Children(
                                    factory.VisualElement()
                                        .Classes( "color-light", "background-color-dark", "margin-0px", "grow-1", "justify-content-center", "align-items-center" )
                                        .Children( factory.Label( "Tab 2" ) )
                                ),
                                factory.Tab( "Tab 3" ).Children(
                                    factory.VisualElement()
                                        .Classes( "color-light", "background-color-dark", "margin-0px", "grow-1", "justify-content-center", "align-items-center" )
                                        .Children( factory.Label( "Tab 3" ) )
                                )
                            )
                        );
                    }
                    using (factory.Footer().AsScope()) {
                        VisualElementScope.Add( factory.Submit( "Submit" ), factory.Cancel( "Cancel" ) );
                    }
                }
                return root.VisualElement;
            }
        }
        private static VisualElement ScrollView(VisualElementFactory factory) {
            using (var root = factory.LargeWidget().AsScope()) {
                using (factory.Card().AsScope()) {
                    using (factory.Header().AsScope()) {
                        VisualElementScope.Add( factory.Label( "Scroll View" ) );
                    }
                    using (factory.Content().AsScope()) {
                        VisualElementScope.Add(
                            factory.ScrollView().Classes( "gray", "medium", "grow-1" ).Children(
                                factory.VisualElement()
                                    .Classes( "color-light", "background-color-dark", "width-150pc", "height-150pc", "margin-0px", "shrink-0", "justify-content-center", "align-items-center" )
                                    .Children( factory.Label( "Scroll View" ) )
                            )
                        );
                    }
                    using (factory.Footer().AsScope()) {
                        VisualElementScope.Add( factory.Submit( "Submit" ), factory.Cancel( "Cancel" ) );
                    }
                }
                return root.VisualElement;
            }
        }
        // Helpers
        private static VisualElement Scope(VisualElementFactory factory) {
            using (var root = factory.LargeWidget().AsScope()) {
                using (factory.Card().AsScope()) {
                    using (factory.Header().AsScope()) {
                        VisualElementScope.Add( factory.Label( "Scope" ) );
                    }
                    using (factory.Content().AsScope()) {
                        VisualElementScope.Add(
                            factory.RowScope().Children(
                                factory.ColumnScope().Classes( "light2", "medium", "width-200px", "height-200px" ),
                                factory.ColumnScope().Classes( "light", "medium", "width-200px", "height-200px" ),
                                factory.ColumnScope().Classes( "gray", "medium", "width-200px", "height-200px" ),
                                factory.ColumnScope().Classes( "dark", "medium", "width-200px", "height-200px" ),
                                factory.ColumnScope().Classes( "dark2", "medium", "width-200px", "height-200px" )
                            ),
                            factory.RowScope().Children(
                                factory.ColumnScope().Classes( "dark2", "medium", "width-200px", "height-200px" ),
                                factory.ColumnScope().Classes( "dark", "medium", "width-200px", "height-200px" ),
                                factory.ColumnScope().Classes( "gray", "medium", "width-200px", "height-200px" ),
                                factory.ColumnScope().Classes( "light", "medium", "width-200px", "height-200px" ),
                                factory.ColumnScope().Classes( "light2", "medium", "width-200px", "height-200px" )
                            ),
                            factory.RowScope().Children(
                                factory.ColumnScope().Classes( null, "medium", "width-200px", "height-200px" )
                            )
                        );
                    }
                    using (factory.Footer().AsScope()) {
                        VisualElementScope.Add( factory.Submit( "Submit" ), factory.Cancel( "Cancel" ) );
                    }
                }
                return root.VisualElement;
            }
        }
        private static VisualElement Group(VisualElementFactory factory) {
            using (var root = factory.LargeWidget().AsScope()) {
                using (factory.Card().AsScope()) {
                    using (factory.Header().AsScope()) {
                        VisualElementScope.Add( factory.Label( "Group" ) );
                    }
                    using (factory.Content().AsScope()) {
                        VisualElementScope.Add(
                            factory.RowScope().Children(
                                factory.ColumnGroup().Classes( "light2", "medium", "width-200px", "height-200px" ),
                                factory.ColumnGroup().Classes( "light", "medium", "width-200px", "height-200px" ),
                                factory.ColumnGroup().Classes( "gray", "medium", "width-200px", "height-200px" ),
                                factory.ColumnGroup().Classes( "dark", "medium", "width-200px", "height-200px" ),
                                factory.ColumnGroup().Classes( "dark2", "medium", "width-200px", "height-200px" )
                            ),
                            factory.RowScope().Children(
                                factory.ColumnGroup().Classes( "dark2", "medium", "width-200px", "height-200px" ),
                                factory.ColumnGroup().Classes( "dark", "medium", "width-200px", "height-200px" ),
                                factory.ColumnGroup().Classes( "gray", "medium", "width-200px", "height-200px" ),
                                factory.ColumnGroup().Classes( "light", "medium", "width-200px", "height-200px" ),
                                factory.ColumnGroup().Classes( "light2", "medium", "width-200px", "height-200px" )
                            ),
                            factory.RowScope().Children(
                                factory.ColumnGroup().Classes( null, "medium", "width-200px", "height-200px" )
                            )
                        );
                    }
                    using (factory.Footer().AsScope()) {
                        VisualElementScope.Add( factory.Submit( "Submit" ), factory.Cancel( "Cancel" ) );
                    }
                }
                return root.VisualElement;
            }
        }
        private static VisualElement Box(VisualElementFactory factory) {
            using (var root = factory.LargeWidget().AsScope()) {
                using (factory.Card().AsScope()) {
                    using (factory.Header().AsScope()) {
                        VisualElementScope.Add( factory.Label( "Box" ) );
                    }
                    using (factory.Content().AsScope()) {
                        VisualElementScope.Add(
                            factory.RowScope().Children(
                                factory.Box().Classes( "light2", "medium", "width-200px", "height-200px" ),
                                factory.Box().Classes( "light", "medium", "width-200px", "height-200px" ),
                                factory.Box().Classes( "gray", "medium", "width-200px", "height-200px" ),
                                factory.Box().Classes( "dark", "medium", "width-200px", "height-200px" ),
                                factory.Box().Classes( "dark2", "medium", "width-200px", "height-200px" )
                            ),
                            factory.RowScope().Children(
                                factory.Box().Classes( "dark2", "medium", "width-200px", "height-200px" ),
                                factory.Box().Classes( "dark", "medium", "width-200px", "height-200px" ),
                                factory.Box().Classes( "gray", "medium", "width-200px", "height-200px" ),
                                factory.Box().Classes( "light", "medium", "width-200px", "height-200px" ),
                                factory.Box().Classes( "light2", "medium", "width-200px", "height-200px" )
                            ),
                            factory.RowScope().Children(
                                factory.Box().Classes( null, "medium", "width-200px", "height-200px" )
                            )
                        );
                    }
                    using (factory.Footer().AsScope()) {
                        VisualElementScope.Add( factory.Submit( "Submit" ), factory.Cancel( "Cancel" ) );
                    }
                }
                return root.VisualElement;
            }
        }
        // Misc
        private static VisualElement Misc(VisualElementFactory factory) {
            using (var root = factory.LargeWidget().AsScope()) {
                using (factory.Card().AsScope()) {
                    using (factory.Header().AsScope()) {
                        VisualElementScope.Add( factory.Label( "Misc" ) );
                    }
                    using (factory.Content().AsScope()) {
                        VisualElementScope.Add(
                            factory.ColumnGroup().Classes( "dark", "medium", "grow-1" ).Children(
                                factory.Label( "Label" ).Classes( "medium" ),
                                factory.Button( "Button" ),
                                factory.RepeatButton( "Repeat Button" ),
                                factory.TextField( "Text Field", "Text", 64, false ).Classes( "label-width-150px", "invalid" ),
                                factory.PopupField( "Popup Field", null, new string[] { } ).Classes( "label-width-150px" ),
                                factory.DropdownField( "Dropdown Field", "Item 1", new string[] { "Item 1", "Item 2", "Item 3", "Item 4", "Item 5", "Item 6", "Item 7", "Item 8", "Item 9", "Item 10", "Item 11", "Item 12", "Item 13", "Item 14", "Item 15", "Item 16", "Item 17", "Item 18", "Item 19", "Item 20" } ).Classes( "label-width-150px" ),
                                factory.SliderField( "Slider Field", 1, 0, 2 ).Classes( "label-width-150px" ),
                                factory.IntSliderField( "Int Slider Field", 1, 0, 2 ).Classes( "label-width-150px" ),
                                factory.ToggleField( "Toggle Field", true ).Classes( "label-width-150px" )
                            )
                        );
                    }
                    using (factory.Footer().AsScope()) {
                        VisualElementScope.Add( factory.Submit( "Submit" ).Classes( "invalid" ), factory.Cancel( "Cancel" ) );
                    }
                }
                return root.VisualElement;
            }
        }

    }
}
