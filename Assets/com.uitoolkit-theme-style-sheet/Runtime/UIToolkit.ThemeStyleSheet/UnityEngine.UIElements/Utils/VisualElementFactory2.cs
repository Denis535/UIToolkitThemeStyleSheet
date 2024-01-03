#nullable enable
namespace UnityEngine.UIElements {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public static partial class VisualElementFactory {

        // Widget
        public static View Widget() {
            var result = Create<View>( "widget-view", "widget-view" );
            return result;
        }
        public static View LeftWidget() {
            var result = Create<View>( "left-widget-view", "left-widget-view" );
            return result;
        }
        public static View SmallWidget() {
            var result = Create<View>( "small-widget-view", "small-widget-view" );
            return result;
        }
        public static View MediumWidget() {
            var result = Create<View>( "medium-widget-view", "medium-widget-view" );
            return result;
        }
        public static View LargeWidget() {
            var result = Create<View>( "large-widget-view", "large-widget-view" );
            return result;
        }

        // Widget
        public static View DialogWidget() {
            var result = Create<View>( "dialog-widget-view", "dialog-widget-view" );
            return result;
        }
        public static View InfoDialogWidget() {
            var result = Create<View>( "info-dialog-widget-view", "info-dialog-widget-view" );
            return result;
        }
        public static View WarningDialogWidget() {
            var result = Create<View>( "warning-dialog-widget-view", "warning-dialog-widget-view" );
            return result;
        }
        public static View ErrorDialogWidget() {
            var result = Create<View>( "error-dialog-widget-view", "error-dialog-widget-view" );
            return result;
        }

        // Card
        public static Card Card() {
            var result = Create<Card>( "card" );
            return result;
        }
        public static Header Header() {
            var result = Create<Header>( "header" );
            return result;
        }
        public static Content Content() {
            var result = Create<Content>( "content" );
            return result;
        }
        public static Footer Footer() {
            var result = Create<Footer>( "footer" );
            return result;
        }

        // Card
        public static Card DialogCard() {
            var result = Create<Card>( "dialog-card", "dialog-card" );
            return result;
        }
        public static Card InfoDialogCard() {
            var result = Create<Card>( "info-dialog-card", "info-dialog-card" );
            return result;
        }
        public static Card WarningDialogCard() {
            var result = Create<Card>( "warning-dialog-card", "warning-dialog-card" );
            return result;
        }
        public static Card ErrorDialogCard() {
            var result = Create<Card>( "error-dialog-card", "error-dialog-card" );
            return result;
        }

        // TabView
        public static TabView TabView() {
            var result = Create<TabView>( "tab-view" );
            return result;
        }
        public static Tab Tab(string label) {
            var result = Create<Tab>( "tab" );
            {
                result.label = label;
            }
            return result;
        }

        // ScrollView
        public static ScrollView ScrollView() {
            var result = Create<ScrollView>( "scroll-view" );
            {
                result.horizontalScroller.highButton.BringToFront();
                result.verticalScroller.highButton.BringToFront();
            }
            return result;
        }

        // Slot
        public static Slot Slot() {
            var result = Create<Slot>( "slot" );
            return result;
        }

        // Scope
        public static ColumnScope ColumnScope() {
            var result = Create<ColumnScope>( "scope" );
            return result;
        }
        public static RowScope RowScope() {
            var result = Create<RowScope>( "scope" );
            return result;
        }

        // Group
        public static ColumnGroup ColumnGroup() {
            var result = Create<ColumnGroup>( "group" );
            return result;
        }
        public static RowGroup RowGroup() {
            var result = Create<RowGroup>( "group" );
            return result;
        }

        // Box
        public static Box Box() {
            var result = Create<Box>( "box" );
            return result;
        }

    }
}
