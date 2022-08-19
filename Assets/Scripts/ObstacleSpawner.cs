using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _obstacle;

    private void Start()
    {
        InvokeRepeating("CreatingObstacle", 1f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void CreatingObstacle()
    {
        Instantiate(_obstacle, new Vector3(transform.position.x, Random.Range(-2.5f, 2.5f),0f),Quaternion.identity);
    }
}
