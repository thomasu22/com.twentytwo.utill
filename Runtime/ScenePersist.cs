﻿namespace UtilL2
{
    public class ScenePersist : Singleton<ScenePersist>
    {
        public override void Awake()
        {
            base.Awake();

            DontDestroyOnLoad(gameObject);
        }
    } 
}
