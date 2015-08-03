using UnityEngine;
using System.Collections;

public class ParticleGrid : MonoBehaviour {

    public int MAX_PARTICLES = 10;

    ParticleSystem system;
    ParticleSystem.Particle[] particles;



    void Start()
    {
        system = GetComponent<ParticleSystem>();
    }

	void Update () 
    {
        

        particles = new ParticleSystem.Particle[MAX_PARTICLES * MAX_PARTICLES];

        for (int i = 0; i < MAX_PARTICLES * MAX_PARTICLES; i++)
        {
            particles[i] = new ParticleSystem.Particle();
            particles[i].startLifetime = 10;
            particles[i].size = 1;
            particles[i].lifetime = 10;
            particles[i].color = Color.white;
        }


        for (int i = 0; i < MAX_PARTICLES; i++)
        {
            for (int j = 0; j < MAX_PARTICLES; j++)
            {
                float x = i;
                float y = j;

                particles[j * MAX_PARTICLES + i].position = new Vector3(x, 0, y);
                particles[j * MAX_PARTICLES + i].startLifetime = 10;
                Color color = Color.white;

                color.a = Mathf.Lerp(1, 0, Vector3.Distance(particles[j * MAX_PARTICLES + i].position, new Vector3(MAX_PARTICLES * 0.5f, 0, MAX_PARTICLES * 0.5f)) * 0.2f);

                particles[j * MAX_PARTICLES + i].color = color;
            }
        }
        system.SetParticles(particles, MAX_PARTICLES * MAX_PARTICLES);
      

	}
}
