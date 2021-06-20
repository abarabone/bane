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

    public bool isForcePosition;
    public float Rate;

    // Start is called before the first frame update
    void Start()
    {
        this.prepos = this.transform.position;
    }

    private void Update()
    {
        if (this.isForcePosition) this.transform.position = this.prepos;
        
        var nowpos = this.transform.position;
        var nextpos = nowpos + vt * this.Rate;

        this.transform.position = nextpos;
    }
    void LateUpdate()
    {
        var nowpos = this.transform.position;
        //var nextpos = nowpos + vt * this.Rate;
        var nextpos = this.transform.position;

        if (this.up != null) nextpos += this.up.ftt * this.Rate;
        if (this.down != null) nextpos -= this.down.ftt * this.Rate;

        this.transform.position = nextpos;
        this.prepos = nowpos;
        this.vt = nextpos - nowpos;
    }
}
