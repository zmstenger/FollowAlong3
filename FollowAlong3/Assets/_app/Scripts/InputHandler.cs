using UnityEngine;

namespace _app.Scripts
{
    public class InputHandler : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                DelegateManager.scoreEvent?.Invoke();
                DelegateManager.stringEvent?.Invoke("Hello");
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                DelegateManager.deathEvent?.Invoke();
            }
        }
    }
}