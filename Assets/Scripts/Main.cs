using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Grow {

    public class Main : MonoBehaviour {

        Context ctx;

        void Start() {

            ctx = new Context();

            var factory = ctx.factory;
            
            var role = factory.CreateRoleEntity();
            var roleRepo = ctx.roleRepository;
            roleRepo.SetRole(role);

            var field = factory.CreateFieldEntity();
            var fieldRepo = ctx.fieldRepository;
            fieldRepo.SetField(field);

        }

        void Update() {

        }

    }
}
