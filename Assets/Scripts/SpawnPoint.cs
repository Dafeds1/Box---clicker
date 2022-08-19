using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField]
    private GameObject _upperSpawner;
    [SerializeField]
    private GameObject _lowerSpawner;
    [SerializeField]
    private GameObject _point;

    public bool _isUp = false;

    private void Start()
    {
        Debug.Log(_isUp);
        Spawn();
    }

    private void OnEnable()
    {
        GameEvents.onCollisionWithPoint += Spawn;
    }

    private void OnDisable()
    {
        GameEvents.onCollisionWithPoint -= Spawn;    
    }

    public void Spawn()
    {
        
        switch (_isUp)
        {
            case true:
                Instantiate(_point, new Vector3(Random.Range(-2, 2), _lowerSpawner.transform.position.y, 0), Quaternion.identity);
                Debug.Log(_isUp);
                _isUp = !_isUp;
                break;

            case false:
                Instantiate(_point, new Vector3(Random.Range(-2, 2), _upperSpawner.transform.position.y, 0), Quaternion.identity);
                Debug.Log(_isUp);
                _isUp = !_isUp;
                break;
        }


    }

}
