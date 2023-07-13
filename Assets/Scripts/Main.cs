using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Grow {

    public class Main : MonoBehaviour {

        RoleEntity role;
        FieldEntity field;

        Factory factory;

        void Start() {

            factory = new Factory();

            role = factory.CreateRoleEntity();
            field = factory.CreateFieldEntity();

        }

        void Update() {
            
        }

    }
}
