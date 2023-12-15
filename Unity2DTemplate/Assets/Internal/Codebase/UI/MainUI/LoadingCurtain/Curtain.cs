using System;
using DG.Tweening;
using UnityEngine;

namespace Internal.Codebase.UI.MainUI.LoadingCurtain
{
    [DisallowMultipleComponent]
    public sealed class Curtain : MonoBehaviour
    {
        [SerializeField] private CanvasGroup canvasGroup;
        private float animationDuration = 0.4f;

        public void Constructor(float animationDuration) =>
            this.animationDuration = animationDuration;

        private void Awake() =>
            DontDestroyOnLoad(this);

        public void ShowCurtain(bool isAnimated, Action callback)
        {
            canvasGroup.DOKill();
            gameObject.SetActive(true);

            if (!isAnimated)
            {
                canvasGroup.alpha = 1;
                callback?.Invoke();
                return;
            }

            canvasGroup.alpha = 0;
            canvasGroup
                .DOFade(1, animationDuration)
                .OnComplete(() => callback?.Invoke());
        }

        public void HideCurtain(bool isAnimated, Action callback)
        {
            canvasGroup.DOKill();

            if (!isAnimated)
            {
                gameObject.SetActive(false);
                callback?.Invoke();

                return;
            }

            canvasGroup
                .DOFade(0, animationDuration)
                .OnComplete(() =>
                {
                    gameObject.SetActive(false);
                    callback?.Invoke();
                });
        }

        public void HideCurtain(float startDelay, Action callback)
        {
            canvasGroup
                .DOFade(0, animationDuration)
                .SetDelay(startDelay)
                .OnComplete(() =>
                {
                    gameObject.SetActive(false);
                    callback?.Invoke();
                });
        }
    }
}