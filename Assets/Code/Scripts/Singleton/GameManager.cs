using UnityEngine;

namespace DesignPattern.Singleton
{
    public class GameManager : MonoBehaviour
    {
        [field: SerializeField]
        public float Count { get; private set; } = 0;

        public static GameManager Instance { get; private set; } = null;

        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(Instance);
                return;
            }

            Instance = this;
            DontDestroyOnLoad(gameObject);
        }

        public void ChangeCountValue(float value)
        {
            Count = value;
        }
    }
}
