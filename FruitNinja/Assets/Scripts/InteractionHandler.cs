using UnityEngine;

public class InteractionHandler : MonoBehaviour
{
    public static bool AreFacingEachOther(GameObject object1, GameObject object2)
    {
        const float facingThreshold = 45f;
        const float distanceThreshold = 1f;
        var distance = Vector3.Distance(object1.transform.position, object2.transform.position);
        if (object1 == null || object2 == null || !(distance < distanceThreshold)) return false;

        var position = object1.transform.position;
        var position1 = object2.transform.position;
        var direction1 = (position1 - position).normalized;
        var direction2 = (position - position1).normalized;

        // Calculate the angle between the forward direction of object1 and the direction to object2
        var angle1 = Vector3.Angle(object1.transform.forward, direction1);

        // Calculate the angle between the forward direction of object2 and the direction to object1
        var angle2 = Vector3.Angle(object2.transform.forward, direction2);

        // Check if both objects are facing each other within the angle threshold
        return angle1 < facingThreshold && angle2 < facingThreshold;
    }

    public static bool AreColliding(GameObject object1, GameObject object2)
    {
        // Check if both objects and their colliders are not null
        if (object1 == null || object2 == null || object1.GetComponent<Collider>() == null ||
            object2.GetComponent<Collider>() == null) return false;

        // Check for collision using the Collider component
        var collider1 = object1.GetComponent<Collider>();
        var collider2 = object2.GetComponent<Collider>();

        // Check if the colliders are overlapping
        return collider1.bounds.Intersects(collider2.bounds);
    }
}