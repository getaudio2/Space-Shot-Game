using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Esta script destruye el objeto explosión al acabar la animación
public class AnimationAutoDestroy : MonoBehaviour
{
    public float delay = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length + delay);
    }
}
