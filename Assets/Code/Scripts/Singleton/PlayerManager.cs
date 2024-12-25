using UnityEngine;

namespace DesignPattern.Singleton
{
    public class PlayerManager : MonoBehaviour
    {
        private GameManager _gameManager;

        private void Start()
        {
           _gameManager = GameManager.Instance;
        }

        private void FixedUpdate()
        {
            float count = _gameManager.Count;
            _gameManager.ChangeCountValue(count + Time.deltaTime);
        }
    }
}
