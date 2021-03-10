using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawner : MonoBehaviour
{
    public float cooldown;
    public List<Transform> spawnPoints;
    public List<PowerUp> powerUps;

    void Start()
    {
        EventsManager.SubscribeToEvent(EventType.GAME_STARTED, OnGameStarted);
    }

    void OnGameStarted(object powerup)
    {
        StartCoroutine(Spawner());
    }

    IEnumerator Spawner()
    {
        PowerUp lastSpawned = null;

        while (true)
        {
            yield return new WaitForSeconds(cooldown);

            if (lastSpawned != null)
            {
                Destroy(lastSpawned.gameObject);
            }
            Transform spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Count)];
            PowerUp powerUp = powerUps[Random.Range(0, powerUps.Count)];
            lastSpawned = Instantiate(powerUp, spawnPoint.position, spawnPoint.rotation);
        }
    }
}
