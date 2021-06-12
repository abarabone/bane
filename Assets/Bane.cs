using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bane : MonoBehaviour
{

    //public Vector3 line { get; private set; }
    public Vector3 v;// { get; private set; }

    public float k;
    public float rest;

    public Point p0;
    public Point p1;

    // Start is called before the first frame update
    void Start()
    {
        this.p0.down = this;
        this.p1.up = this;
    }

    // Update is called once per frame
    void Update()
    {
        var line = this.p0.transform.position - this.p1.transform.position;

        var len = line.magnitude;

        var f = (len - this.rest) * this.k;// L‚Ñ‚É’ïR‚µAk‚à‚¤‚Æ‚·‚é—Í‚ªƒvƒ‰ƒX

        this.v = line / len * f * Time.deltaTime;
    }
}
