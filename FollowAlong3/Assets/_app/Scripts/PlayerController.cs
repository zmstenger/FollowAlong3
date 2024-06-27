using UnityEngine;
using UnityEngine.InputSystem;

namespace _app.Scripts
{
    public class PlayerController : MonoBehaviour
    {
        private void OnEnable()
        {
            DelegateManager.deathEvent += OnDeath;
        }

        private void OnDisable()
        {
            DelegateManager.deathEvent -= OnDeath;
        }

        public void PlayerMovement(InputAction.CallbackContext context)
        {
            transform.Translate(context.ReadValue<Vector2>() * Time.deltaTime);
            Debug.Log(context.ReadValue<Vector2>().ToString());
        }

        public void OnDeath()
        {
            Destroy(this.gameObject);
            Debug.Log("Player Destroyed");
        }
    }
}