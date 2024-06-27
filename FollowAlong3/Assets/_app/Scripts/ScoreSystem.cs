using UnityEngine;

namespace _app.Scripts
{
    public class ScoreSystem : MonoBehaviour
    {
        private int _score;

        private void OnEnable()
        {
            DelegateManager.scoreEvent += OnScore;
            DelegateManager.deathEvent += OnDeath;
            DelegateManager.stringEvent += OnString;
        }

        private void OnDisable()
        {
            DelegateManager.scoreEvent -= OnScore;
            DelegateManager.deathEvent -= OnDeath;
            DelegateManager.stringEvent -= OnString;
        }

        public void OnScore()
        {
            _score++;
            Debug.Log("Score: " + _score);
        }

        public void OnDeath()
        {
            _score = 0;
            Debug.Log("Game Over, score reset");
        }

        public void OnString(string s)
        {
            Debug.Log(s);
        }
    }
}