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
                            VisualElementFactory.Label( "Widget" ).AddToScope();
                        }
                        using (VisualElementFactory.Content().AsScope()) {
                            VisualElementFactory.Label( "Widget" ).AddToScope();
                        }
                        using (VisualElementFactory.Footer().AsScope()) {
                            VisualElementFactory.Button( "Submit" ).AddToScope();
                            VisualElementFactory.Button( "Cancel" ).AddToScope();
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
                            VisualElementFactory.Label( "Left Widget" ).AddToScope();
                        }
                        using (VisualElementFactory.Content().AsScope()) {
                            VisualElementFactory.Label( "Left Widget" ).AddToScope();
                        }
                        using (VisualElementFactory.Footer().AsScope()) {
                            VisualElementFactory.Button( "Submit" ).AddToScope();
                            VisualElementFactory.Button( "Cancel" ).AddToScope();
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
                            VisualElementFactory.Label( "Small Widget" ).AddToScope();
                        }
                        using (VisualElementFactory.Content().AsScope()) {
                            VisualElementFactory.Label( "Small Widget" ).AddToScope();
                        }
                        using (VisualElementFactory.Footer().AsScope()) {
                            VisualElementFactory.Button( "Submit" ).AddToScope();
                            VisualElementFactory.Button( "Cancel" ).AddToScope();
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
                            VisualElementFactory.Label( "Medium Widget" ).AddToScope();
                        }
                        using (VisualElementFactory.Content().AsScope()) {
                            VisualElementFactory.Label( "Medium Widget" ).AddToScope();
                        }
                        using (VisualElementFactory.Footer().AsScope()) {
                            VisualElementFactory.Button( "Submit" ).AddToScope();
                            VisualElementFactory.Button( "Cancel" ).AddToScope();
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
                            VisualElementFactory.Label( "Large Widget" ).AddToScope();
                        }
                        using (VisualElementFactory.Content().AsScope()) {
                            VisualElementFactory.Label( "Large Widget" ).AddToScope();
                        }
                        using (VisualElementFactory.Footer().AsScope()) {
                            VisualElementFactory.Button( "Submit" ).AddToScope();
                            VisualElementFactory.Button( "Cancel" ).AddToScope();
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
                            VisualElementFactory.Label( "Dialog Widget" ).AddToScope();
                        }
                        using (VisualElementFactory.Content().AsScope()) {
                            VisualElementFactory.Label( "Dialog Widget" ).AddToScope();
                        }
                        using (VisualElementFactory.Footer().AsScope()) {
                            VisualElementFactory.Button( "Submit" ).AddToScope();
                            VisualElementFactory.Button( "Cancel" ).AddToScope();
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
                            VisualElementFactory.Label( "Info Dialog Widget" ).AddToScope();
                        }
                        using (VisualElementFactory.Content().AsScope()) {
                            VisualElementFactory.Label( "Info Dialog Widget" ).AddToScope();
                        }
                        using (VisualElementFactory.Footer().AsScope()) {
                            VisualElementFactory.Button( "Submit" ).AddToScope();
                            VisualElementFactory.Button( "Cancel" ).AddToScope();
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
                            VisualElementFactory.Label( "Warning Dialog Widget" ).AddToScope();
                        }
                        using (VisualElementFactory.Content().AsScope()) {
                            VisualElementFactory.Label( "Warning Dialog Widget" ).AddToScope();
                        }
                        using (VisualElementFactory.Footer().AsScope()) {
                            VisualElementFactory.Button( "Submit" ).AddToScope();
                            VisualElementFactory.Button( "Cancel" ).AddToScope();
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
                            VisualElementFactory.Label( "Error Dialog Widget" ).AddToScope();
                        }
                        using (VisualElementFactory.Content().AsScope()) {
                            VisualElementFactory.Label( "Error Dialog Widget" ).AddToScope();
                        }
                        using (VisualElementFactory.Footer().AsScope()) {
                            VisualElementFactory.Button( "Submit" ).AddToScope();
                            VisualElementFactory.Button( "Cancel" ).AddToScope();
                        }
                    }
                    Document.rootVisualElement.Clear();
                    Document.rootVisualElement.Add( root.VisualElement );
                }
            }
            // View
            if (toolbarIndex == 10 && toolbarIndex != prevToolbarIndex) {
                using (var root = VisualElementFactory.LargeWidget().AsScope()) {
                    using (VisualElementFactory.Card().AsScope()) {
                        using (VisualElementFactory.Header().AsScope()) {
                            VisualElementFactory.Label( "Tab View" ).AddToScope();
                        }
                        using (VisualElementFactory.Content().AsScope()) {
                            // TabView
                            VisualElementFactory.TabView().Classes( "gray", "medium", "grow-1" ).Children(
                                VisualElementFactory.Tab( "Tab 1" ).Children(
                                    VisualElementFactory.VisualElement()
                                        .Style( i => i.backgroundColor = Color.red )
                                        .Style( i => i.marginLeft = i.marginRight = i.marginTop = i.marginBottom = new Length( 0, LengthUnit.Pixel ) )
                                        .Style( i => i.flexGrow = 1 )
                                ),
                                VisualElementFactory.Tab( "Tab 2" ).Children(
                                    VisualElementFactory.VisualElement()
                                        .Style( i => i.backgroundColor = Color.green )
                                        .Style( i => i.marginLeft = i.marginRight = i.marginTop = i.marginBottom = new Length( 0, LengthUnit.Pixel ) )
                                        .Style( i => i.flexGrow = 1 )
                                ),
                                VisualElementFactory.Tab( "Tab 3" ).Children(
                                    VisualElementFactory.VisualElement()
                                        .Style( i => i.backgroundColor = Color.blue )
                                        .Style( i => i.marginLeft = i.marginRight = i.marginTop = i.marginBottom = new Length( 0, LengthUnit.Pixel ) )
                                        .Style( i => i.flexGrow = 1 )
                                )
                            ).AddToScope();
                        }
                        using (VisualElementFactory.Footer().AsScope()) {
                            VisualElementFactory.Button( "Submit" ).AddToScope();
                            VisualElementFactory.Button( "Cancel" ).AddToScope();
                        }
                    }
                    Document.rootVisualElement.Clear();
                    Document.rootVisualElement.Add( root.VisualElement );
                }
            }
            if (toolbarIndex == 11 && toolbarIndex != prevToolbarIndex) {
                using (var root = VisualElementFactory.LargeWidget().AsScope()) {
                    using (VisualElementFactory.Card().AsScope()) {
                        using (VisualElementFactory.Header().AsScope()) {
                            VisualElementFactory.Label( "Tab View" ).AddToScope();
                        }
                        using (VisualElementFactory.Content().AsScope()) {
                            // ScrollView
                            VisualElementFactory.ScrollView().Classes( "gray", "medium", "grow-1" ).Children(
                                VisualElementFactory.VisualElement()
                                    .Style( i => i.backgroundColor = Color.red )
                                    .Style( i => i.width = new Length( 1920, LengthUnit.Pixel ) )
                                    .Style( i => i.height = new Length( 1080, LengthUnit.Pixel ) )
                                    .Style( i => i.marginLeft = i.marginRight = i.marginTop = i.marginBottom = new Length( 0, LengthUnit.Pixel ) )
                            ).AddToScope();
                        }
                        using (VisualElementFactory.Footer().AsScope()) {
                            VisualElementFactory.Button( "Submit" ).AddToScope();
                            VisualElementFactory.Button( "Cancel" ).AddToScope();
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
                            VisualElementFactory.Label( "Tab View" ).AddToScope();
                        }
                        using (VisualElementFactory.Content().AsScope()) {
                            VisualElementFactory.RowScope().Children(
                                VisualElementFactory.ColumnGroup().Classes( "dark2", "width-200px", "height-200px" ),
                                VisualElementFactory.ColumnGroup().Classes( "dark", "width-200px", "height-200px" ),
                                VisualElementFactory.ColumnGroup().Classes( "gray", "width-200px", "height-200px" ),
                                VisualElementFactory.ColumnGroup().Classes( "light", "width-200px", "height-200px" ),
                                VisualElementFactory.ColumnGroup().Classes( "light2", "width-200px", "height-200px" )
                            ).AddToScope();
                            VisualElementFactory.RowScope().Children(
                                VisualElementFactory.ColumnGroup().Classes( "light2", "width-200px", "height-200px" ),
                                VisualElementFactory.ColumnGroup().Classes( "light", "width-200px", "height-200px" ),
                                VisualElementFactory.ColumnGroup().Classes( "gray", "width-200px", "height-200px" ),
                                VisualElementFactory.ColumnGroup().Classes( "dark", "width-200px", "height-200px" ),
                                VisualElementFactory.ColumnGroup().Classes( "dark2", "width-200px", "height-200px" )
                            ).AddToScope();
                        }
                        using (VisualElementFactory.Footer().AsScope()) {
                            VisualElementFactory.Button( "Submit" ).AddToScope();
                            VisualElementFactory.Button( "Cancel" ).AddToScope();
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
                            VisualElementFactory.Label( "Tab View" ).AddToScope();
                        }
                        using (VisualElementFactory.Content().AsScope()) {
                            VisualElementFactory.RowScope().Children(
                                VisualElementFactory.Box().Classes( "dark2", "width-200px", "height-200px" ),
                                VisualElementFactory.Box().Classes( "dark", "width-200px", "height-200px" ),
                                VisualElementFactory.Box().Classes( "gray", "width-200px", "height-200px" ),
                                VisualElementFactory.Box().Classes( "light", "width-200px", "height-200px" ),
                                VisualElementFactory.Box().Classes( "light2", "width-200px", "height-200px" )
                            ).AddToScope();
                            VisualElementFactory.RowScope().Children(
                                VisualElementFactory.Box().Classes( "light2", "width-200px", "height-200px" ),
                                VisualElementFactory.Box().Classes( "light", "width-200px", "height-200px" ),
                                VisualElementFactory.Box().Classes( "gray", "width-200px", "height-200px" ),
                                VisualElementFactory.Box().Classes( "dark", "width-200px", "height-200px" ),
                                VisualElementFactory.Box().Classes( "dark2", "width-200px", "height-200px" )
                            ).AddToScope();
                        }
                        using (VisualElementFactory.Footer().AsScope()) {
                            VisualElementFactory.Button( "Submit" ).AddToScope();
                            VisualElementFactory.Button( "Cancel" ).AddToScope();
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
                            VisualElementFactory.Label( "Tab View" ).AddToScope();
                        }
                        using (VisualElementFactory.Content().AsScope()) {
                            VisualElementFactory.ColumnGroup().Children(
                                VisualElementFactory.Label( "Label" ),
                                VisualElementFactory.Button( "Button" ),
                                VisualElementFactory.RepeatButton( "Repeat Button" ),
                                VisualElementFactory.TextField( "Text Field", "Hello World !!!", 64, false ),
                                VisualElementFactory.ReadOnlyTextField( "Read Only Text Field", "Hello World !!!", 64, false ),
                                VisualElementFactory.PopupField( "Popup Field", "Item 1", new[] { "Item 1", "Item 2", "Item 3", "Item 4", "Item 5", "Item 6", "Item 7", "Item 8", "Item 9", "Item 10" } ),
                                VisualElementFactory.DropdownField( "Dropdown Field", "Item 1", new[] { "Item 1", "Item 2", "Item 3", "Item 4", "Item 5", "Item 6", "Item 7", "Item 8", "Item 9", "Item 10", "Item 11", "Item 12", "Item 13", "Item 14", "Item 15", "Item 16", "Item 17", "Item 18", "Item 19", "Item 20" } ),
                                VisualElementFactory.SliderField( "Slider Field", 1, 0, 2 ),
                                VisualElementFactory.IntSliderField( "Int Slider Field", 1, 0, 2 ),
                                VisualElementFactory.ToggleField( "Toggle Field", true )
                            ).AddToScope();
                        }
                        using (VisualElementFactory.Footer().AsScope()) {
                            VisualElementFactory.Button( "Submit" ).AddToScope();
                            VisualElementFactory.Button( "Cancel" ).AddToScope();
                        }
                    }
                    Document.rootVisualElement.Clear();
                    Document.rootVisualElement.Add( root.VisualElement );
                }
            }
        }

    }
}
