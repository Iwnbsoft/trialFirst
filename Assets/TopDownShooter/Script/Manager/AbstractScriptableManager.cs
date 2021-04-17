using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace topDownShooter
{
public class AbstractScriptableManager<T> : AbstractScriptableManagerBase where T : AbstractScriptableManager<T>
{
    public static T Instance;

    public override void Initialize()
    {
        base.Initialize();
        Instance = this as T;// bunu as t yazmadan scriptableshootmanagerda da yazabilirdik. Burada kullandık as T yazmamızın sebebi, public static olarak belirlediğimiz type instance, bilinmediği ve çevrilmediği için base atadık. Where o yüzden kullandık.
    }

    public override void Destroy()
    {
        base.Destroy();
    }
}
}
