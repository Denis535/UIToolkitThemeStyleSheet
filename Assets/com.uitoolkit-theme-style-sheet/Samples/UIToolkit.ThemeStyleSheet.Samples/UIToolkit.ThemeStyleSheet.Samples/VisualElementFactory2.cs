#nullable enable
namespace UIToolkit.ThemeStyleSheet.Samples {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.UIElements;
    using UnityEngine.UIElements.Experimental;

    public partial class VisualElementFactory {

        // Helpers
        private void PlayAppearance(AttachToPanelEvent evt) {
            AudioSource.PlayOneShot( appearance );
            PlayAppearance( (VisualElement) evt.target );
        }
        private void PlayInfoAppearance(AttachToPanelEvent evt) {
            AudioSource.PlayOneShot( infoAppearance );
            PlayAppearance( (VisualElement) evt.target );
        }
        private void PlayWarningAppearance(AttachToPanelEvent evt) {
            AudioSource.PlayOneShot( warningAppearance );
            PlayAppearance( (VisualElement) evt.target );
        }
        private void PlayErrorAppearance(AttachToPanelEvent evt) {
            AudioSource.PlayOneShot( errorAppearance );
            PlayAppearance( (VisualElement) evt.target );
        }
        private void PlayAppearance(VisualElement element) {
            var animation = ValueAnimation<float>.Create( element, Mathf.LerpUnclamped );
            animation.valueUpdated = (view, t) => {
                var tx = Easing.OutBack( Easing.InPower( t, 2 ), 4 );
                var ty = Easing.OutBack( Easing.OutPower( t, 2 ), 4 );
                var x = Mathf.LerpUnclamped( 0.8f, 1f, tx );
                var y = Mathf.LerpUnclamped( 0.8f, 1f, ty );
                view.transform.scale = new Vector3( x, y, 1 );
            };
            animation.from = 0;
            animation.to = 1;
            animation.durationMs = 500;
            animation.Start();
        }
        // Helpers
        private void PlayFocus(FocusEvent evt) {
            if (evt.direction != FocusChangeDirection.none && evt.direction != FocusChangeDirection.unspecified) {
                AudioSource.PlayOneShot( focus );
            }
        }
        // Helpers
        private void PlayClick(ClickEvent evt) {
            var target = (VisualElement) evt.target;
            AudioSource.PlayOneShot( target.IsValid() ? click : invalidClick );
        }
        private void PlaySelect(ClickEvent evt) {
            var target = (VisualElement) evt.target;
            AudioSource.PlayOneShot( target.IsValid() ? selectClick : invalidClick );
        }
        private void PlaySubmit(ClickEvent evt) {
            var target = (VisualElement) evt.target;
            AudioSource.PlayOneShot( target.IsValid() ? submitClick : invalidClick );
        }
        private void PlayCancel(ClickEvent evt) {
            var target = (VisualElement) evt.target;
            AudioSource.PlayOneShot( target.IsValid() ? cancelClick : invalidClick );
        }
        // Helpers
        private void PlayChange(ChangeEvent<object> evt) {
            if (evt.newValue != evt.previousValue) {
                AudioSource.PlayOneShot( tik );
            }
        }
        private void PlayChange(ChangeEvent<string> evt) {
            if (evt.newValue != evt.previousValue) {
                AudioSource.PlayOneShot( tik );
            }
        }
        private void PlayChange(ChangeEvent<float> evt) {
            if (Mathf.FloorToInt( evt.newValue * 100 ) != Mathf.FloorToInt( evt.previousValue * 100 )) {
                AudioSource.PlayOneShot( tik );
            }
        }
        private void PlayChange(ChangeEvent<int> evt) {
            if (evt.newValue != evt.previousValue) {
                AudioSource.PlayOneShot( tik );
            }
        }
        private void PlayChange(ChangeEvent<bool> evt) {
            if (evt.newValue != evt.previousValue) {
                AudioSource.PlayOneShot( tik );
            }
        }
        // Helpers
        private static T Create<T>(string? name, string? @class = null) where T : VisualElement, new() {
            var result = new T();
            result.name = name;
            result.AddToClassList( "visual-element" );
            result.AddToClassList( @class );
            return result;
        }

    }
}
