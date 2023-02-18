using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boid : Kinematic
{
    private GameObject flockMass;

    public Kinematic[] otherBoids;

    private Arrive cohesion;
    private Separation seperation;
    private Align alignment;



    // Start is called before the first frame update
    void Start()
    {
        flockMass = myTarget;

        cohesion = new Arrive();
        cohesion.character = this;
        cohesion.target = flockMass;

        seperation = new Separation();
        seperation.character = this;
        seperation.targets = otherBoids;
    }

    // Update is called once per frame
    void Update()
    {
        steeringUpdate = new SteeringOutput();

        steeringUpdate.linear = cohesion.getSteering().linear;
        steeringUpdate.linear += seperation.getSteering().linear;

        base.Update();
    }
}
