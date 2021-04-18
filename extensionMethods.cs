using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class extensionMethods
{
    // VECTOR CLAMPING FUNCTIONS
    // two functions for clamping vector2's, one using a vector2 as the clamp variable, and one using a float
    public static Vector2 clamp(this Vector2 vector, Vector2 min_vec, Vector2 max_vec)
    {
        return new Vector2(
            Mathf.Clamp(vector.x, min_vec.x, max_vec.x),
            Mathf.Clamp(vector.y, min_vec.y, max_vec.y)
            );
    }

    public static Vector2 clamp(this Vector2 vector, float min_, float max_)
    {
        return new Vector2(
            Mathf.Clamp(vector.x, min_, max_),
            Mathf.Clamp(vector.y, min_, max_)
            );
    }

    // two functions for clamping vector3's, one using a vector3 as the clamp variable, and one using a float
    public static Vector3 clamp(this Vector3 vector, Vector3 min_vec, Vector3 max_vec)
    {
        // using vector3's as min and max arguments
        return new Vector3(
            Mathf.Clamp(vector.x, min_vec.x, max_vec.x),
            Mathf.Clamp(vector.y, min_vec.y, max_vec.y),
            Mathf.Clamp(vector.z, min_vec.z, max_vec.z)
            );
    }

    public static Vector3 clamp(this Vector3 vector, float min_, float max_)
    {
        // using floats as min and ma arguments
        return new Vector3(
            Mathf.Clamp(vector.x, min_, max_),
            Mathf.Clamp(vector.y, min_, max_),
            Mathf.Clamp(vector.z, min_, max_));
    }
}