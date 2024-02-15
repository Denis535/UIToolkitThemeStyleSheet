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
                    // Group
                    "Group",
                    // Box
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
                using (var root = Factory.Widget().AsScope()) {
                    using (Factory.Card().AsScope()) {
                        using (Factory.Header().AsScope()) {
                            VisualElementScope.Add( Factory.Label( "Widget" ) );
                        }
                        using (Factory.Content().AsScope()) {
                            VisualElementScope.Add( Factory.Label( "Widget" ) );
                        }
                        using (Factory.Footer().AsScope()) {
                            VisualElementScope.Add( Factory.Submit( "Submit" ), Factory.Cancel( "Cancel" ) );
                        }
                    }
                    Document.rootVisualElement.Clear();
                    Document.rootVisualElement.Add( root.VisualElement );
                }
            }
            if (toolbarIndex == 2 && toolbarIndex != prevToolbarIndex) {
                using (var root = Factory.LeftWidget().AsScope()) {
                    using (Factory.Card().AsScope()) {
                        using (Factory.Header().AsScope()) {
                            VisualElementScope.Add( Factory.Label( "Left Widget" ) );
                        }
                        using (Factory.Content().AsScope()) {
                            VisualElementScope.Add( Factory.Select( "Item 1" ), Factory.Select( "Item 2" ), Factory.Select( "Item 3" ) );
                        }
                        using (Factory.Footer().AsScope()) {
                            VisualElementScope.Add( Factory.Submit( "Submit" ), Factory.Cancel( "Cancel" ) );
                        }
                    }
                    Document.rootVisualElement.Clear();
                    Document.rootVisualElement.Add( root.VisualElement );
                }
            }
            if (toolbarIndex == 3 && toolbarIndex != prevToolbarIndex) {
                using (var root = Factory.SmallWidget().AsScope()) {
                    using (Factory.Card().AsScope()) {
                        using (Factory.Header().AsScope()) {
                            VisualElementScope.Add( Factory.Label( "Small Widget" ) );
                        }
                        using (Factory.Content().AsScope()) {
                            VisualElementScope.Add( Factory.Label( "Small Widget" ) );
                        }
                        using (Factory.Footer().AsScope()) {
                            VisualElementScope.Add( Factory.Submit( "Submit" ), Factory.Cancel( "Cancel" ) );
                        }
                    }
                    Document.rootVisualElement.Clear();
                    Document.rootVisualElement.Add( root.VisualElement );
                }
            }
            if (toolbarIndex == 4 && toolbarIndex != prevToolbarIndex) {
                using (var root = Factory.MediumWidget().AsScope()) {
                    using (Factory.Card().AsScope()) {
                        using (Factory.Header().AsScope()) {
                            VisualElementScope.Add( Factory.Label( "Medium Widget" ) );
                        }
                        using (Factory.Content().AsScope()) {
                            VisualElementScope.Add( Factory.Label( "Medium Widget" ) );
                        }
                        using (Factory.Footer().AsScope()) {
                            VisualElementScope.Add( Factory.Submit( "Submit" ), Factory.Cancel( "Cancel" ) );
                        }
                    }
                    Document.rootVisualElement.Clear();
                    Document.rootVisualElement.Add( root.VisualElement );
                }
            }
            if (toolbarIndex == 5 && toolbarIndex != prevToolbarIndex) {
                using (var root = Factory.LargeWidget().AsScope()) {
                    using (Factory.Card().AsScope()) {
                        using (Factory.Header().AsScope()) {
                            VisualElementScope.Add( Factory.Label( "Large Widget" ) );
                        }
                        using (Factory.Content().AsScope()) {
                            VisualElementScope.Add( Factory.Label( "Large Widget" ) );
                        }
                        using (Factory.Footer().AsScope()) {
                            VisualElementScope.Add( Factory.Submit( "Submit" ), Factory.Cancel( "Cancel" ) );
                        }
                    }
                    Document.rootVisualElement.Clear();
                    Document.rootVisualElement.Add( root.VisualElement );
                }
            }
            // Widget
            if (toolbarIndex == 6 && toolbarIndex != prevToolbarIndex) {
                using (var root = Factory.DialogWidget().AsScope()) {
                    using (Factory.DialogCard().AsScope()) {
                        using (Factory.Header().AsScope()) {
                            VisualElementScope.Add( Factory.Label( "Dialog Widget" ) );
                        }
                        using (Factory.Content().AsScope()) {
                            VisualElementScope.Add(
                                Factory.ColumnGroup()
                                    .Classes( "dark", "medium", "grow-1", "justify-content-center", "align-items-center" )
                                    .Children( Factory.Label( "Dialog Widget" ) )
                            );
                        }
                        using (Factory.Footer().AsScope()) {
                            VisualElementScope.Add( Factory.Submit( "Submit" ), Factory.Cancel( "Cancel" ) );
                        }
                    }
                    Document.rootVisualElement.Clear();
                    Document.rootVisualElement.Add( root.VisualElement );
                }
            }
            if (toolbarIndex == 7 && toolbarIndex != prevToolbarIndex) {
                using (var root = Factory.InfoDialogWidget().AsScope()) {
                    using (Factory.InfoDialogCard().AsScope()) {
                        using (Factory.Header().AsScope()) {
                            VisualElementScope.Add( Factory.Label( "Info Dialog Widget" ) );
                        }
                        using (Factory.Content().AsScope()) {
                            VisualElementScope.Add(
                                Factory.ColumnGroup()
                                    .Classes( "dark", "medium", "grow-1", "justify-content-center", "align-items-center" )
                                    .Children( Factory.Label( "Info Dialog Widget" ) )
                            );
                        }
                        using (Factory.Footer().AsScope()) {
                            VisualElementScope.Add( Factory.Submit( "Submit" ), Factory.Cancel( "Cancel" ) );
                        }
                    }
                    Document.rootVisualElement.Clear();
                    Document.rootVisualElement.Add( root.VisualElement );
                }
            }
            if (toolbarIndex == 8 && toolbarIndex != prevToolbarIndex) {
                using (var root = Factory.WarningDialogWidget().AsScope()) {
                    using (Factory.WarningDialogCard().AsScope()) {
                        using (Factory.Header().AsScope()) {
                            VisualElementScope.Add( Factory.Label( "Warning Dialog Widget" ) );
                        }
                        using (Factory.Content().AsScope()) {
                            VisualElementScope.Add(
                                Factory.ColumnGroup()
                                    .Classes( "dark", "medium", "grow-1", "justify-content-center", "align-items-center" )
                                    .Children( Factory.Label( "Warning Dialog Widget" ) )
                            );
                        }
                        using (Factory.Footer().AsScope()) {
                            VisualElementScope.Add( Factory.Submit( "Submit" ), Factory.Cancel( "Cancel" ) );
                        }
                    }
                    Document.rootVisualElement.Clear();
                    Document.rootVisualElement.Add( root.VisualElement );
                }
            }
            if (toolbarIndex == 9 && toolbarIndex != prevToolbarIndex) {
                using (var root = Factory.ErrorDialogWidget().AsScope()) {
                    using (Factory.ErrorDialogCard().AsScope()) {
                        using (Factory.Header().AsScope()) {
                            VisualElementScope.Add( Factory.Label( "Error Dialog Widget" ) );
                        }
                        using (Factory.Content().AsScope()) {
                            VisualElementScope.Add(
                                Factory.ColumnGroup()
                                    .Classes( "dark", "medium", "grow-1", "justify-content-center", "align-items-center" )
                                    .Children( Factory.Label( "Error Dialog Widget" ) )
                            );
                        }
                        using (Factory.Footer().AsScope()) {
                            VisualElementScope.Add( Factory.Submit( "Submit" ), Factory.Cancel( "Cancel" ) );
                        }
                    }
                    Document.rootVisualElement.Clear();
                    Document.rootVisualElement.Add( root.VisualElement );
                }
            }
            // TabView
            if (toolbarIndex == 10 && toolbarIndex != prevToolbarIndex) {
                using (var root = Factory.LargeWidget().AsScope()) {
                    using (Factory.Card().AsScope()) {
                        using (Factory.Header().AsScope()) {
                            VisualElementScope.Add( Factory.Label( "Tab View" ) );
                        }
                        using (Factory.Content().AsScope()) {
                            VisualElementScope.Add(
                                Factory.TabView().Classes( "gray", "medium", "grow-1" ).Children(
                                    Factory.Tab( "Tab 1" ).Children(
                                        Factory.VisualElement()
                                            .Classes( "color-light", "background-color-dark", "margin-0px", "grow-1", "justify-content-center", "align-items-center" )
                                            .Children( Factory.Label( "Tab 1" ) )
                                    ),
                                    Factory.Tab( "Tab 2" ).Children(
                                        Factory.VisualElement()
                                            .Classes( "color-light", "background-color-dark", "margin-0px", "grow-1", "justify-content-center", "align-items-center" )
                                            .Children( Factory.Label( "Tab 2" ) )
                                    ),
                                    Factory.Tab( "Tab 3" ).Children(
                                        Factory.VisualElement()
                                            .Classes( "color-light", "background-color-dark", "margin-0px", "grow-1", "justify-content-center", "align-items-center" )
                                            .Children( Factory.Label( "Tab 3" ) )
                                    )
                                )
                            );
                        }
                        using (Factory.Footer().AsScope()) {
                            VisualElementScope.Add( Factory.Submit( "Submit" ), Factory.Cancel( "Cancel" ) );
                        }
                    }
                    Document.rootVisualElement.Clear();
                    Document.rootVisualElement.Add( root.VisualElement );
                }
            }
            // ScrollView
            if (toolbarIndex == 11 && toolbarIndex != prevToolbarIndex) {
                using (var root = Factory.LargeWidget().AsScope()) {
                    using (Factory.Card().AsScope()) {
                        using (Factory.Header().AsScope()) {
                            VisualElementScope.Add( Factory.Label( "Scroll View" ) );
                        }
                        using (Factory.Content().AsScope()) {
                            VisualElementScope.Add(
                                Factory.ScrollView().Classes( "gray", "medium", "grow-1" ).Children(
                                    Factory.VisualElement()
                                        .Classes( "color-light", "background-color-dark", "width-150pc", "height-150pc", "margin-0px", "shrink-0", "justify-content-center", "align-items-center" )
                                        .Children( Factory.Label( "Scroll View" ) )
                                )
                            );
                        }
                        using (Factory.Footer().AsScope()) {
                            VisualElementScope.Add( Factory.Submit( "Submit" ), Factory.Cancel( "Cancel" ) );
                        }
                    }
                    Document.rootVisualElement.Clear();
                    Document.rootVisualElement.Add( root.VisualElement );
                }
            }
            // Group
            if (toolbarIndex == 12 && toolbarIndex != prevToolbarIndex) {
                using (var root = Factory.LargeWidget().AsScope()) {
                    using (Factory.Card().AsScope()) {
                        using (Factory.Header().AsScope()) {
                            VisualElementScope.Add( Factory.Label( "Group" ) );
                        }
                        using (Factory.Content().AsScope()) {
                            VisualElementScope.Add(
                                Factory.RowScope().Children(
                                    Factory.ColumnGroup().Classes( "dark2", "width-200px", "height-200px" ),
                                    Factory.ColumnGroup().Classes( "dark", "width-200px", "height-200px" ),
                                    Factory.ColumnGroup().Classes( "gray", "width-200px", "height-200px" ),
                                    Factory.ColumnGroup().Classes( "light", "width-200px", "height-200px" ),
                                    Factory.ColumnGroup().Classes( "light2", "width-200px", "height-200px" )
                                ),
                                Factory.RowScope().Children(
                                    Factory.ColumnGroup().Classes( "light2", "width-200px", "height-200px" ),
                                    Factory.ColumnGroup().Classes( "light", "width-200px", "height-200px" ),
                                    Factory.ColumnGroup().Classes( "gray", "width-200px", "height-200px" ),
                                    Factory.ColumnGroup().Classes( "dark", "width-200px", "height-200px" ),
                                    Factory.ColumnGroup().Classes( "dark2", "width-200px", "height-200px" )
                                )
                            );
                        }
                        using (Factory.Footer().AsScope()) {
                            VisualElementScope.Add( Factory.Submit( "Submit" ), Factory.Cancel( "Cancel" ) );
                        }
                    }
                    Document.rootVisualElement.Clear();
                    Document.rootVisualElement.Add( root.VisualElement );
                }
            }
            // Box
            if (toolbarIndex == 13 && toolbarIndex != prevToolbarIndex) {
                using (var root = Factory.LargeWidget().AsScope()) {
                    using (Factory.Card().AsScope()) {
                        using (Factory.Header().AsScope()) {
                            VisualElementScope.Add( Factory.Label( "Box" ) );
                        }
                        using (Factory.Content().AsScope()) {
                            VisualElementScope.Add(
                                Factory.RowScope().Children(
                                    Factory.Box().Classes( "dark2", "width-200px", "height-200px" ),
                                    Factory.Box().Classes( "dark", "width-200px", "height-200px" ),
                                    Factory.Box().Classes( "gray", "width-200px", "height-200px" ),
                                    Factory.Box().Classes( "light", "width-200px", "height-200px" ),
                                    Factory.Box().Classes( "light2", "width-200px", "height-200px" )
                                ),
                                Factory.RowScope().Children(
                                    Factory.Box().Classes( "light2", "width-200px", "height-200px" ),
                                    Factory.Box().Classes( "light", "width-200px", "height-200px" ),
                                    Factory.Box().Classes( "gray", "width-200px", "height-200px" ),
                                    Factory.Box().Classes( "dark", "width-200px", "height-200px" ),
                                    Factory.Box().Classes( "dark2", "width-200px", "height-200px" )
                                )
                            );
                        }
                        using (Factory.Footer().AsScope()) {
                            VisualElementScope.Add( Factory.Submit( "Submit" ), Factory.Cancel( "Cancel" ) );
                        }
                    }
                    Document.rootVisualElement.Clear();
                    Document.rootVisualElement.Add( root.VisualElement );
                }
            }
            // Misc
            if (toolbarIndex == 14 && toolbarIndex != prevToolbarIndex) {
                using (var root = Factory.LargeWidget().AsScope()) {
                    using (Factory.Card().AsScope()) {
                        using (Factory.Header().AsScope()) {
                            VisualElementScope.Add( Factory.Label( "Misc" ) );
                        }
                        using (Factory.Content().AsScope()) {
                            VisualElementScope.Add(
                                Factory.ColumnGroup().Classes( "dark", "medium", "grow-1" ).Children(
                                    Factory.Label( "Label" ),
                                    Factory.Button( "Button" ),
                                    Factory.RepeatButton( "Repeat Button" ),
                                    Factory.TextField( "Text Field", "Text", 64, false ).Classes( "invalid" ),
                                    //Factory.PopupField( "Popup Field", null, null ),
                                    Factory.PopupField( "Popup Field", "Item 1", new[] { "Item 1", "Item 2", "Item 3", "Item 4", "Item 5", "Item 6", "Item 7", "Item 8", "Item 9", "Item 10" } ),
                                    Factory.DropdownField( "Dropdown Field", "Item 1", new[] { "Item 1", "Item 2", "Item 3", "Item 4", "Item 5", "Item 6", "Item 7", "Item 8", "Item 9", "Item 10", "Item 11", "Item 12", "Item 13", "Item 14", "Item 15", "Item 16", "Item 17", "Item 18", "Item 19", "Item 20" } ),
                                    Factory.SliderField( "Slider Field", 1, 0, 2 ),
                                    Factory.IntSliderField( "Int Slider Field", 1, 0, 2 ),
                                    Factory.ToggleField( "Toggle Field", true )
                                )
                            );
                        }
                        using (Factory.Footer().AsScope()) {
                            VisualElementScope.Add( Factory.Submit( "Submit" ).Classes( "invalid" ), Factory.Cancel( "Cancel" ) );
                        }
                    }
                    Document.rootVisualElement.Clear();
                    Document.rootVisualElement.Add( root.VisualElement );
                }
            }
        }

    }
}
