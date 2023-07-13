using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Grow {

    public class Main : MonoBehaviour {

        RoleEntity role;
        FieldEntity field;

        void Start() {

            role = new GameObject("role").AddComponent<RoleEntity>();
            field = new GameObject("field").AddComponent<FieldEntity>();

        }

        void Update() {
            
        }

    }
}
