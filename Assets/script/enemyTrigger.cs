using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> enemies;
    public bool wipeOut = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemies.RemoveAll(item => item == null);

        if (enemies.Count == 0)
        {
            wipeOut = true;
        }
    }
}
