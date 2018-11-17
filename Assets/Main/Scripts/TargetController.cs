using UnityEngine;
using UnityEngine.AI;

public class TargetController : MonoBehaviour {

    public Camera camera;

    public NavMeshSurface surface;

    // Update is called once per frame
    void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                this.transform.position = hit.point;
                surface.BuildNavMesh();
            }

        }
    }
}
