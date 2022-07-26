using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BezierRoute : MonoBehaviour
{
    // Initialize array of control point
    [SerializeField] private Transform[] controlPoints;

    // Initialize variabel for gizmo
    private Vector2 gizmosPosition;

    // Drawing Line for Bezier Curves Path
    private void OnDrawGizmos()
    {
        // Draw Gizmo on each point
        for (float t = 0; t <= 1; t += 0.1f)
        {
            // Calculating the Gizmo position
            gizmosPosition = Mathf.Pow(1 - t, 3) * controlPoints[0].position +
                3 * Mathf.Pow(1 - t, 2) * t * controlPoints[1].position +
                3 * (1 - t) * Mathf.Pow(t, 2) * controlPoints[2].position +
                Mathf.Pow(t, 3) * controlPoints[3].position;

            // Draw the Gizmo as a Sphere on each iteration
            Gizmos.DrawSphere(gizmosPosition, 0.25f);
        }

        // Draw the line for control point 1 and 2
        Gizmos.DrawLine(new Vector2(controlPoints[0].position.x, controlPoints[0].position.y), 
            new Vector2(controlPoints[1].position.x, controlPoints[1].position.y));

        // Draw the line for control point 3 and 4
        Gizmos.DrawLine(new Vector2(controlPoints[2].position.x, controlPoints[2].position.y), 
            new Vector2(controlPoints[3].position.x, controlPoints[3].position.y));
    }
}
