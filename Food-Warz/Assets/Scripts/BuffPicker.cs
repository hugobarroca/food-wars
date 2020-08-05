using Monobehaviours;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffPicker : MonoBehaviour
{
    public PlayerMovement myPlayerMovement;
    public SetRiceCakeModes setMode;

    // Start is called before the first frame update
    void Start()
    {
        print("BuffPicker is starting!");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        print("METHOD WAS ACTIVATED!!");
        print(other.gameObject.tag);
        if (other.gameObject.CompareTag("Buff"))
        {
            Destroy(other.gameObject);
            myPlayerMovement.buff = true;
            setMode.Set(1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
