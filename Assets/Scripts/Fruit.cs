using UnityEngine;

public class Fruit : MonoBehaviour
{
    public BoxCollider2D playZone;
    Vector3 tempMaxSpawnPos, tempMinSpawnPos;

    


    private void Start()
    {
        playZone = GetComponent<BoxCollider2D>();
        tempMinSpawnPos = playZone.bounds.min;
        tempMaxSpawnPos = playZone.bounds.max;

      


    }

    public void SpawnFruit()
    {
        
    }
}
