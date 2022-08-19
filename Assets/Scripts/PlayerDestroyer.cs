using UnityEngine;

public class PlayerDestroyer : MonoBehaviour
{
    [SerializeField]
    private GameObject _player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == _player.name)
        {
            
            Destroy(collision.gameObject);
            Time.timeScale = 0f;
            //... Call menu "GaemOver"
        }
    }
}
