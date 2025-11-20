using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    public int currentWave;
    public int antsLeft;
   
    
    public GameObject basicAnt;

    // Delay between spawning individual ants (seconds)
    

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       
        if (antsLeft <= 0)
        {
            currentWave++;
            SpawnWave(currentWave);
        }
        
    }

    void SpawnWave(int wave)
    {
        if (wave == 1)
        {
            antsLeft = 10;
            Debug.Log ("Spawning Wave 1");
            StartCoroutine(SpawnWaveCoroutine(wave));
        }
    }

    public int GetWave()
    {
        return currentWave;
    }

    IEnumerator SpawnWaveCoroutine(int wave)
    {
        if (wave == 1)
        {
            for (int i = 0; i < 10; i++)
            {
                int path = Random.Range(1, 4);
                if (path == 1)
                    Instantiate(basicAnt, new Vector3(-36.7f, 8f, 0), Quaternion.identity);
                else if (path == 2)
                    Instantiate(basicAnt, new Vector3(-36.7f, 7f, 0), Quaternion.identity);
                else
                    Instantiate(basicAnt, new Vector3(-36.7f, 6f, 0), Quaternion.identity);



                yield return new WaitForSeconds(2);
            }
        }

        yield break;
    }
}
