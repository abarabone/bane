using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{

    Vector3 prepos;

    public Vector3 vt;// => this.transform.position - this.prepos;
    //public Vector3 v { get; private set; }

    public float mass;
    public float weight;


    [HideInInspector]
    public Bane up;
    [HideInInspector]
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
        var nextpos = nowpos + vt;

        if (this.up != null) nextpos += this.up.ftt;
        if (this.down != null) nextpos -= this.down.ftt;

        this.transform.position = nextpos;
        this.prepos = nowpos;
        this.vt = nextpos - nowpos;
    }
}
