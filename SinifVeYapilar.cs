using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SampleCodes.ClassandBuilding
{
    public class SinifVeYapilar : MonoBehaviour
    {

        #region Base Class : Bu sınıftan bir nesne üretilmeyecek ancak kalıtım yoluyla başka sınıflardan türeyecek
        abstract class Chacters
        {
            public string g_ChacterName;
            public int g_ChacterLevel;
            public float g_ChacterHealth;
        }
        #endregion

        #region Interface :  Projede olabildiğince aktif olarak kullnılacak, kod karmaşasını önleyecek şekilde kullanılmalıdır.
        interface IPlayer { }
        interface IEnemy { }
        interface IRigidbody { }
        interface INavmesh { }
        interface INPC { }
        #endregion

        #region Class : Tek sorumluluğu olması gerekir PlayerClass'ı içerisinde hem Movement hem Attack hem Diyalog aynı aynda olmamalıdır.
        public class Movement { }
        public class Attack { }
        public class Dialog { }

        #endregion

    }
}
