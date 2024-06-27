using UnityEngine;
using UnityEngine.Events;

namespace _app.Scripts
{
    public class DelegateManager : MonoBehaviour
    {
        public delegate void eventDelegate();

        public static eventDelegate scoreEvent;
        public static eventDelegate deathEvent;

        public delegate void StringEvent(string s);

        public static StringEvent stringEvent;

        public UnityEvent OnEndGame;

        public void Update()
        {
            OnEndGame?.Invoke();
        }

        public void DebugGameOver()
        {
            Debug.Log("Game Over");
        }
    }
}