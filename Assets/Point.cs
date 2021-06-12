using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{

    Vector3 prepos;

    public float mass;
    public float weight;


    public Bane up;
    public Bane down;

    // Start is called before the first frame update
    void Start()
    {
        this.prepos = this.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        var nowpos = this.transform.position;
        var fdt = nowpos - this.prepos;

        var nextpos = nowpos + fdt;

        if (this.up != null) nextpos += this.up.v;
        if (this.down != null) nextpos -= this.down.v;

        this.transform.position = nextpos;
        this.prepos = nowpos;
    }
}
