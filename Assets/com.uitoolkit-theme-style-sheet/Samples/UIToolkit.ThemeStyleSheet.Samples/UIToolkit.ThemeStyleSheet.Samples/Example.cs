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

        // Awake
        public void Awake() {
            Document = GetComponent<UIDocument>();
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
                using (var root = VisualElementFactory.Widget().AsScope()) {
                    using (VisualElementFactory.Card().AsScope()) {
                        using (VisualElementFactory.Header().AsScope()) {
                            VisualElementScope.Add( VisualElementFactory.Label( "Widget" ) );
                        }
                        using (VisualElementFactory.Content().AsScope()) {
                            VisualElementScope.Add( VisualElementFactory.Label( "Widget" ) );
                        }
                        using (VisualElementFactory.Footer().AsScope()) {
                            VisualElementScope.Add( VisualElementFactory.Button( "Submit" ), VisualElementFactory.Button( "Cancel" ) );
                        }
                    }
                    Document.rootVisualElement.Clear();
                    Document.rootVisualElement.Add( root.VisualElement );
                }
            }
            if (toolbarIndex == 2 && toolbarIndex != prevToolbarIndex) {
                using (var root = VisualElementFactory.LeftWidget().AsScope()) {
                    using (VisualElementFactory.Card().AsScope()) {
                        using (VisualElementFactory.Header().AsScope()) {
                            VisualElementScope.Add( VisualElementFactory.Label( "Left Widget" ) );
                        }
                        using (VisualElementFactory.Content().AsScope()) {
                            VisualElementScope.Add( VisualElementFactory.Button( "Button 1" ), VisualElementFactory.Button( "Button 2" ), VisualElementFactory.Button( "Button 3" ) );
                        }
                        using (VisualElementFactory.Footer().AsScope()) {
                            VisualElementScope.Add( VisualElementFactory.Button( "Submit" ), VisualElementFactory.Button( "Cancel" ) );
                        }
                    }
                    Document.rootVisualElement.Clear();
                    Document.rootVisualElement.Add( root.VisualElement );
                }
            }
            if (toolbarIndex == 3 && toolbarIndex != prevToolbarIndex) {
                using (var root = VisualElementFactory.SmallWidget().AsScope()) {
                    using (VisualElementFactory.Card().AsScope()) {
                        using (VisualElementFactory.Header().AsScope()) {
                            VisualElementScope.Add( VisualElementFactory.Label( "Small Widget" ) );
                        }
                        using (VisualElementFactory.Content().AsScope()) {
                            VisualElementScope.Add( VisualElementFactory.Label( "Small Widget" ) );
                        }
                        using (VisualElementFactory.Footer().AsScope()) {
                            VisualElementScope.Add( VisualElementFactory.Button( "Submit" ), VisualElementFactory.Button( "Cancel" ) );
                        }
                    }
                    Document.rootVisualElement.Clear();
                    Document.rootVisualElement.Add( root.VisualElement );
                }
            }
            if (toolbarIndex == 4 && toolbarIndex != prevToolbarIndex) {
                using (var root = VisualElementFactory.MediumWidget().AsScope()) {
                    using (VisualElementFactory.Card().AsScope()) {
                        using (VisualElementFactory.Header().AsScope()) {
                            VisualElementScope.Add( VisualElementFactory.Label( "Medium Widget" ) );
                        }
                        using (VisualElementFactory.Content().AsScope()) {
                            VisualElementScope.Add( VisualElementFactory.Label( "Medium Widget" ) );
                        }
                        using (VisualElementFactory.Footer().AsScope()) {
                            VisualElementScope.Add( VisualElementFactory.Button( "Submit" ), VisualElementFactory.Button( "Cancel" ) );
                        }
                    }
                    Document.rootVisualElement.Clear();
                    Document.rootVisualElement.Add( root.VisualElement );
                }
            }
            if (toolbarIndex == 5 && toolbarIndex != prevToolbarIndex) {
                using (var root = VisualElementFactory.LargeWidget().AsScope()) {
                    using (VisualElementFactory.Card().AsScope()) {
                        using (VisualElementFactory.Header().AsScope()) {
                            VisualElementScope.Add( VisualElementFactory.Label( "Large Widget" ) );
                        }
                        using (VisualElementFactory.Content().AsScope()) {
                            VisualElementScope.Add( VisualElementFactory.Label( "Large Widget" ) );
                        }
                        using (VisualElementFactory.Footer().AsScope()) {
                            VisualElementScope.Add( VisualElementFactory.Button( "Submit" ), VisualElementFactory.Button( "Cancel" ) );
                        }
                    }
                    Document.rootVisualElement.Clear();
                    Document.rootVisualElement.Add( root.VisualElement );
                }
            }
            // Widget
            if (toolbarIndex == 6 && toolbarIndex != prevToolbarIndex) {
                using (var root = VisualElementFactory.DialogWidget().AsScope()) {
                    using (VisualElementFactory.DialogCard().AsScope()) {
                        using (VisualElementFactory.Header().AsScope()) {
                            VisualElementScope.Add( VisualElementFactory.Label( "Dialog Widget" ) );
                        }
                        using (VisualElementFactory.Content().AsScope()) {
                            VisualElementScope.Add( VisualElementFactory.Label( "Dialog Widget" ) );
                        }
                        using (VisualElementFactory.Footer().AsScope()) {
                            VisualElementScope.Add( VisualElementFactory.Button( "Submit" ), VisualElementFactory.Button( "Cancel" ) );
                        }
                    }
                    Document.rootVisualElement.Clear();
                    Document.rootVisualElement.Add( root.VisualElement );
                }
            }
            if (toolbarIndex == 7 && toolbarIndex != prevToolbarIndex) {
                using (var root = VisualElementFactory.InfoDialogWidget().AsScope()) {
                    using (VisualElementFactory.InfoDialogCard().AsScope()) {
                        using (VisualElementFactory.Header().AsScope()) {
                            VisualElementScope.Add( VisualElementFactory.Label( "Info Dialog Widget" ) );
                        }
                        using (VisualElementFactory.Content().AsScope()) {
                            VisualElementScope.Add( VisualElementFactory.Label( "Info Dialog Widget" ) );
                        }
                        using (VisualElementFactory.Footer().AsScope()) {
                            VisualElementScope.Add( VisualElementFactory.Button( "Submit" ), VisualElementFactory.Button( "Cancel" ) );
                        }
                    }
                    Document.rootVisualElement.Clear();
                    Document.rootVisualElement.Add( root.VisualElement );
                }
            }
            if (toolbarIndex == 8 && toolbarIndex != prevToolbarIndex) {
                using (var root = VisualElementFactory.WarningDialogWidget().AsScope()) {
                    using (VisualElementFactory.WarningDialogCard().AsScope()) {
                        using (VisualElementFactory.Header().AsScope()) {
                            VisualElementScope.Add( VisualElementFactory.Label( "Warning Dialog Widget" ) );
                        }
                        using (VisualElementFactory.Content().AsScope()) {
                            VisualElementScope.Add( VisualElementFactory.Label( "Warning Dialog Widget" ) );
                        }
                        using (VisualElementFactory.Footer().AsScope()) {
                            VisualElementScope.Add( VisualElementFactory.Button( "Submit" ), VisualElementFactory.Button( "Cancel" ) );
                        }
                    }
                    Document.rootVisualElement.Clear();
                    Document.rootVisualElement.Add( root.VisualElement );
                }
            }
            if (toolbarIndex == 9 && toolbarIndex != prevToolbarIndex) {
                using (var root = VisualElementFactory.ErrorDialogWidget().AsScope()) {
                    using (VisualElementFactory.ErrorDialogCard().AsScope()) {
                        using (VisualElementFactory.Header().AsScope()) {
                            VisualElementScope.Add( VisualElementFactory.Label( "Error Dialog Widget" ) );
                        }
                        using (VisualElementFactory.Content().AsScope()) {
                            VisualElementScope.Add( VisualElementFactory.Label( "Error Dialog Widget" ) );
                        }
                        using (VisualElementFactory.Footer().AsScope()) {
                            VisualElementScope.Add( VisualElementFactory.Button( "Submit" ), VisualElementFactory.Button( "Cancel" ) );
                        }
                    }
                    Document.rootVisualElement.Clear();
                    Document.rootVisualElement.Add( root.VisualElement );
                }
            }
            // TabView
            if (toolbarIndex == 10 && toolbarIndex != prevToolbarIndex) {
                using (var root = VisualElementFactory.LargeWidget().AsScope()) {
                    using (VisualElementFactory.Card().AsScope()) {
                        using (VisualElementFactory.Header().AsScope()) {
                            VisualElementScope.Add( VisualElementFactory.Label( "Tab View" ) );
                        }
                        using (VisualElementFactory.Content().AsScope()) {
                            // TabView
                            VisualElementScope.Add(
                                VisualElementFactory.TabView().Classes( "gray", "medium", "grow-1" ).Children(
                                    VisualElementFactory.Tab( "Tab 1" ).Children(
                                        VisualElementFactory.VisualElement()
                                            .Classes( "color-light", "background-color-dark", "margin-0px", "grow-1", "justify-content-center", "align-items-center" )
                                            .Children( VisualElementFactory.Label( "Tab 1" ) )
                                    ),
                                    VisualElementFactory.Tab( "Tab 2" ).Children(
                                        VisualElementFactory.VisualElement()
                                            .Classes( "color-light", "background-color-dark", "margin-0px", "grow-1", "justify-content-center", "align-items-center" )
                                            .Children( VisualElementFactory.Label( "Tab 2" ) )
                                    ),
                                    VisualElementFactory.Tab( "Tab 3" ).Children(
                                        VisualElementFactory.VisualElement()
                                            .Classes( "color-light", "background-color-dark", "margin-0px", "grow-1", "justify-content-center", "align-items-center" )
                                            .Children( VisualElementFactory.Label( "Tab 3" ) )
                                    )
                                )
                            );
                        }
                        using (VisualElementFactory.Footer().AsScope()) {
                            VisualElementScope.Add( VisualElementFactory.Button( "Submit" ), VisualElementFactory.Button( "Cancel" ) );
                        }
                    }
                    Document.rootVisualElement.Clear();
                    Document.rootVisualElement.Add( root.VisualElement );
                }
            }
            // ScrollView
            if (toolbarIndex == 11 && toolbarIndex != prevToolbarIndex) {
                using (var root = VisualElementFactory.LargeWidget().AsScope()) {
                    using (VisualElementFactory.Card().AsScope()) {
                        using (VisualElementFactory.Header().AsScope()) {
                            VisualElementScope.Add( VisualElementFactory.Label( "Scroll View" ) );
                        }
                        using (VisualElementFactory.Content().AsScope()) {
                            // ScrollView
                            VisualElementScope.Add(
                                VisualElementFactory.ScrollView().Classes( "gray", "medium", "grow-1" ).Children(
                                    VisualElementFactory.VisualElement()
                                        .Classes( "color-light", "background-color-dark", "width-150pc", "height-150pc", "margin-0px", "shrink-0", "justify-content-center", "align-items-center" )
                                        .Children( VisualElementFactory.Label( "Scroll View" ) )
                                )
                            );
                        }
                        using (VisualElementFactory.Footer().AsScope()) {
                            VisualElementScope.Add( VisualElementFactory.Button( "Submit" ), VisualElementFactory.Button( "Cancel" ) );
                        }
                    }
                    Document.rootVisualElement.Clear();
                    Document.rootVisualElement.Add( root.VisualElement );
                }
            }
            // Group
            if (toolbarIndex == 12 && toolbarIndex != prevToolbarIndex) {
                using (var root = VisualElementFactory.LargeWidget().AsScope()) {
                    using (VisualElementFactory.Card().AsScope()) {
                        using (VisualElementFactory.Header().AsScope()) {
                            VisualElementScope.Add( VisualElementFactory.Label( "Group" ) );
                        }
                        using (VisualElementFactory.Content().AsScope()) {
                            VisualElementScope.Add(
                                VisualElementFactory.RowScope().Children(
                                    VisualElementFactory.ColumnGroup().Classes( "dark2", "width-200px", "height-200px" ),
                                    VisualElementFactory.ColumnGroup().Classes( "dark", "width-200px", "height-200px" ),
                                    VisualElementFactory.ColumnGroup().Classes( "gray", "width-200px", "height-200px" ),
                                    VisualElementFactory.ColumnGroup().Classes( "light", "width-200px", "height-200px" ),
                                    VisualElementFactory.ColumnGroup().Classes( "light2", "width-200px", "height-200px" )
                                ),
                                VisualElementFactory.RowScope().Children(
                                    VisualElementFactory.ColumnGroup().Classes( "light2", "width-200px", "height-200px" ),
                                    VisualElementFactory.ColumnGroup().Classes( "light", "width-200px", "height-200px" ),
                                    VisualElementFactory.ColumnGroup().Classes( "gray", "width-200px", "height-200px" ),
                                    VisualElementFactory.ColumnGroup().Classes( "dark", "width-200px", "height-200px" ),
                                    VisualElementFactory.ColumnGroup().Classes( "dark2", "width-200px", "height-200px" )
                                )
                            );
                        }
                        using (VisualElementFactory.Footer().AsScope()) {
                            VisualElementScope.Add( VisualElementFactory.Button( "Submit" ), VisualElementFactory.Button( "Cancel" ) );
                        }
                    }
                    Document.rootVisualElement.Clear();
                    Document.rootVisualElement.Add( root.VisualElement );
                }
            }
            // Box
            if (toolbarIndex == 13 && toolbarIndex != prevToolbarIndex) {
                using (var root = VisualElementFactory.LargeWidget().AsScope()) {
                    using (VisualElementFactory.Card().AsScope()) {
                        using (VisualElementFactory.Header().AsScope()) {
                            VisualElementScope.Add( VisualElementFactory.Label( "Box" ) );
                        }
                        using (VisualElementFactory.Content().AsScope()) {
                            VisualElementScope.Add(
                                VisualElementFactory.RowScope().Children(
                                    VisualElementFactory.Box().Classes( "dark2", "width-200px", "height-200px" ),
                                    VisualElementFactory.Box().Classes( "dark", "width-200px", "height-200px" ),
                                    VisualElementFactory.Box().Classes( "gray", "width-200px", "height-200px" ),
                                    VisualElementFactory.Box().Classes( "light", "width-200px", "height-200px" ),
                                    VisualElementFactory.Box().Classes( "light2", "width-200px", "height-200px" )
                                ),
                                VisualElementFactory.RowScope().Children(
                                    VisualElementFactory.Box().Classes( "light2", "width-200px", "height-200px" ),
                                    VisualElementFactory.Box().Classes( "light", "width-200px", "height-200px" ),
                                    VisualElementFactory.Box().Classes( "gray", "width-200px", "height-200px" ),
                                    VisualElementFactory.Box().Classes( "dark", "width-200px", "height-200px" ),
                                    VisualElementFactory.Box().Classes( "dark2", "width-200px", "height-200px" )
                                )
                            );
                        }
                        using (VisualElementFactory.Footer().AsScope()) {
                            VisualElementScope.Add( VisualElementFactory.Button( "Submit" ), VisualElementFactory.Button( "Cancel" ) );
                        }
                    }
                    Document.rootVisualElement.Clear();
                    Document.rootVisualElement.Add( root.VisualElement );
                }
            }
            // Misc
            if (toolbarIndex == 14 && toolbarIndex != prevToolbarIndex) {
                using (var root = VisualElementFactory.LargeWidget().AsScope()) {
                    using (VisualElementFactory.Card().AsScope()) {
                        using (VisualElementFactory.Header().AsScope()) {
                            VisualElementScope.Add( VisualElementFactory.Label( "Misc" ) );
                        }
                        using (VisualElementFactory.Content().AsScope()) {
                            VisualElementScope.Add(
                                VisualElementFactory.ColumnGroup().Classes( "dark", "medium" ).Children(
                                    VisualElementFactory.Label( "Label" ),
                                    VisualElementFactory.Button( "Button" ),
                                    VisualElementFactory.RepeatButton( "Repeat Button" ),
                                    VisualElementFactory.TextField( "Text Field", "Hello World !!!", 64, false ),
                                    VisualElementFactory.ReadOnlyTextField( "Read Only Text Field", "Hello World !!!", 64, false ).Classes( "invalid" ),
                                    VisualElementFactory.PopupField( "Popup Field", "Item 1", new[] { "Item 1", "Item 2", "Item 3", "Item 4", "Item 5", "Item 6", "Item 7", "Item 8", "Item 9", "Item 10" } ),
                                    VisualElementFactory.DropdownField( "Dropdown Field", "Item 1", new[] { "Item 1", "Item 2", "Item 3", "Item 4", "Item 5", "Item 6", "Item 7", "Item 8", "Item 9", "Item 10", "Item 11", "Item 12", "Item 13", "Item 14", "Item 15", "Item 16", "Item 17", "Item 18", "Item 19", "Item 20" } ),
                                    VisualElementFactory.SliderField( "Slider Field", 1, 0, 2 ),
                                    VisualElementFactory.IntSliderField( "Int Slider Field", 1, 0, 2 ),
                                    VisualElementFactory.ToggleField( "Toggle Field", true )
                                )
                            );
                        }
                        using (VisualElementFactory.Footer().AsScope()) {
                            VisualElementScope.Add( VisualElementFactory.Button( "Submit" ).Classes( "invalid" ), VisualElementFactory.Button( "Cancel" ) );
                        }
                    }
                    Document.rootVisualElement.Clear();
                    Document.rootVisualElement.Add( root.VisualElement );
                }
            }
        }

    }
}
