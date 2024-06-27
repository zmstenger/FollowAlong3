using UnityEngine;

namespace _app.Scripts
{
    public interface IGameEventListener
    {
        void OnEventRaised();
    }
}