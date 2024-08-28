using UnityEngine;

public class AnimatedParticles : MonoBehaviour
{
    public ParticleSystem particles;

    public SkinnedMeshRenderer renderr;

    Mesh m;

    void Start()
    {
        m = new Mesh();
    }

    void LateUpdate()
    {
        renderr.BakeMesh(m);

        var sh = particles.shape;
        sh.mesh = m;
    }
}
