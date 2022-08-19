using UnityEngine;
using System.Threading.Tasks;

public class TriggerPoint : MonoBehaviour
{
    [SerializeField]
    private GameEvents _gameEvents;

    private void Awake()
    {
       _gameEvents = FindObjectOfType<GameEvents>();
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log(_gameEvents);
            _gameEvents.CollisionWithPoint();
            Destroy(gameObject);
        }
    }

}
