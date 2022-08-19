using UnityEngine;

public class ObstacleDestroyer : MonoBehaviour
{
    [SerializeField]
    private GameObject _destroyer;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == _destroyer.name)
        {
            Destroy(gameObject);
        }
    }

}
