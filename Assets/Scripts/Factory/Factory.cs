using UnityEngine;

namespace Grow {

    public class Factory {

        public RoleEntity CreateRoleEntity() {
            return new GameObject("role").AddComponent<RoleEntity>();
        }

        public FieldEntity CreateFieldEntity() {
            return new GameObject("field").AddComponent<FieldEntity>();
        }

    }

}