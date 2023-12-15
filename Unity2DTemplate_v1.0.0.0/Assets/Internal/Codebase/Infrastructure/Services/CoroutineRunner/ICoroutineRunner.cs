using System.Collections;
using UnityEngine;

namespace Internal.Codebase.Infrastructure.Services.CoroutineRunner
{
    public interface ICoroutineRunner
    {
        public Coroutine StartCoroutine(IEnumerator coroutine);

        public void StopAllCoroutines();

        public void StopCoroutine(IEnumerator coroutine);
    }
}