using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontroller : MonoBehaviour
{
    // Start is called before the first frame update
    //public List<AnimationClip> Checkpoint;
    [SerializeField] private Animator animator;
    [SerializeField] private int checkpoint = 0;
    public List<enemyTrigger> enemyTrigger;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (checkpoint >= enemyTrigger.Count)
            return;

        if (enemyTrigger[checkpoint].wipeOut)
        {
            checkpoint++;
            move();
        }
    }


    void move()
    {
        animator.SetInteger("move", checkpoint);
    }
}
