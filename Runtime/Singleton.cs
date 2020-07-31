using UnityEngine;

namespace UtilL2
{
    public class Singleton<T> : MonoBehaviour where T : Singleton<T>
    {
        //The single instance
        public static T Instance { get; protected set; }

        public virtual void Awake()
        {
            T[] objects = FindObjectsOfType<T>();
            if(objects.Length > 1)
            {
                Destroy(gameObject);
            }
            else
            {
                Instance = (T)this;
            }
        }
    } 
}
